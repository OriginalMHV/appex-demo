#!/bin/bash
#
# create_pkg.sh
#
# Copyright (c) 2020 LogMeIn, Inc. All rights reserved.
# ===========================================================================


    UABundle=$(cd "$(dirname "${0}")/../.."; pwd -P) # "
    UABundleVer=7.14.432.454
#   printf "Bundle location: [%s]\n" "${UABundle}"

    UAParams=$(xattr -p com.logmein.rescue.params "${UABundle}" |tr "\n" " ")
    if [ ${#UAParams} == 0 ]; then
        printf "error : Can not locate parameters for the Unattended application\n"
        exit 1
    fi

    UAScripts=$(mktemp -d /tmp/UA-pkg-XXXXXXXXXX)
    UAScriptSrc=${UABundle}/Contents/MacOS

    sed "s@\${UNATTENDED_PARAMETERS}@\"${UAParams}\"@" "${UAScriptSrc}/postinstall" > "${UAScripts}/postinstall"
    chmod 755 "${UAScripts}/postinstall"

    UAPackage=$(dirname "${UABundle}")/unattended-${UABundleVer}.pkg

    params=(--identifier com.logmein.rescue.unattended --version ${UABundleVer})
    params=(${params[@]} --install-location "/tmp")
    params=(${params[@]} --scripts "${UAScripts}")

    pkgbuild --component "${UABundle}" ${params[@]} "${UAPackage}"
    rm -R "${UAScripts}"

# ===========================================================================
