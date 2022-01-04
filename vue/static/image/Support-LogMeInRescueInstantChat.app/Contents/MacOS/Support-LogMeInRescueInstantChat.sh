#!/bin/bash
#
# Support LogMeIn Rescue - init script
#
# Copyright (c) 2012-2020 LogMeIn, Inc. All rights reserved.
# ===========================================================================

# ===========================================================================
function PrepareIcon
{
    local Folder FileSign

    Folder="$(dirname "$1")"

    cp "$1/Contents/Resources/Rescue.icns" "${Folder}/Rescue.icns"

    if [ ! -f "${Folder}/Rescue.ico" ]; then
        if [ -f "$1/Contents/Resources/Rescue.ico" ]; then
            cp "$1/Contents/Resources/Rescue.ico" "${Folder}/Rescue.ico"
        fi
    fi

    if [ -f "${Folder}/Rescue.ico" ]; then
        FileSign="$(hexdump "${Folder}/Rescue.ico" |head -1)"

        if [ "${FileSign::19}" != "0000000 69 63 6e 73" ]; then
            rm "${Folder}/Rescue.icns"
            "$1/Contents/MacOS/ConvertWinIcoToIcns" "${Folder}/Rescue.ico" "${Folder}/Rescue.icns"
        fi
    fi

    [ -f "${Folder}/Rescue.icns" ] && sips -Z 32 -s format icns "${Folder}/Rescue.icns" --out "${Folder}/Rescue32.icns"
}

# ===========================================================================
function GetQuotedParam
{
    sed -e "/$1/!d;s|.*[[:space:]]*$1[[:space:]]|$1 |;s/^$1 \"\([^\"]*\)\".*/\1/" "$2"
}

# ===========================================================================
function GetParam
{
    sed -e "/$1/!d;s|[[:space:]][[:space:]]*| |g;s/.* *$1 \([^ ]*\).*/\1/" "$2"
}

# ===========================================================================
function PrepareParams
{
    local Folder

    Folder="$(dirname "$1")"

    xattr "$1" |grep com.logmein.rescue.params > /dev/null
    if [ $? == 0 ]; then
        xattr -p com.logmein.rescue.params "$1" > "${Folder}/params.txt"
    fi

    xattr "$1" |grep com.logmein.rescue.eula > /dev/null
    if [ $? == 0 ]; then
        eula=$(xattr -p com.logmein.rescue.eula   "$1")
        printf '%s' "${eula}" > "${Folder}/eula.txt"
    fi

    local rscID="$(tr "\t\r\n" " " < "${Folder}/params.txt" |sed "s/ *$//;s/.* //")"

    if [ "${rscID:0:1}" == "-" ]; then
        return 0
    fi

    local rscLock="$(dirname "${Folder}")/.rescue.session.lock.${rscID}.tmp"

    if [ -f "${rscLock}" ]; then
        return 1
    fi
    echo "rscID=${rscID}" > "${rscLock}"
}

# ===========================================================================
function DownloadCustomization
{
    local Folder website logoid logotype iconid icontype

    Folder="$1"
    
    if [ ! -f "${Folder}/params.txt" ]; then
        return 0
    fi

    website=$(GetQuotedParam "-s" "${Folder}/params.txt")

    logoid=$(GetParam "-logoid" "${Folder}/params.txt")
    logotype=$(GetParam "-logotype" "${Folder}/params.txt")

    iconid=$(GetParam "-iconid" "${Folder}/params.txt")
    icontype=$(GetParam "-icontype" "${Folder}/params.txt")

    curl -s -o "${Folder}/CustomLogo.bmp" "https://${website}/CallingCard/imageFromDB.aspx?imageid=${logoid}&imagetype=${logotype}"
    curl -s -o "${Folder}/Rescue.ico"     "https://${website}/CallingCard/imageFromDB.aspx?imageid=${iconid}&imagetype=${icontype}"

    [ `wc -c < "${Folder}/CustomLogo.bmp"` -eq 0 ] && rm "${Folder}/CustomLogo.bmp"
    [ `wc -c < "${Folder}/Rescue.ico"`     -eq 0 ] && rm "${Folder}/Rescue.ico"
}

# ===========================================================================

    Init="$(cd "$(dirname "${0}")"; pwd -P)" # "
    Src="$(cd "${Init}/../.."; pwd -P)"

    if [[ "${Init}" == /*var/tmp* ]]; then
        "${Init}/Support-LogMeInRescueInstantChat" --launch-- $@ &
        exit 0
    fi

    if [ -f "$1/Support-LogMeInRescueInstantChat.app/Contents/MacOS/Support-LogMeInRescueInstantChat" ]; then
        "$1/Support-LogMeInRescueInstantChat.app/Contents/MacOS/Support-LogMeInRescueInstantChat" --launch-- $@ &
        exit 0
    fi

    InstDir=`printf "/var/tmp/LogMeIn Rescue - %04X" ${RANDOM}`
    while [ -d "${InstDir}" ]; do
        InstDir=`printf "/var/tmp/LogMeIn Rescue - %04X" ${RANDOM}`
    done

    rm -rf     "${InstDir}"
    mkdir -p   "${InstDir}"
    chmod 0777 "${InstDir}"

    cp -R "${Src}" "${InstDir}/Support-LogMeInRescueInstantChat.app"

    xattr -d "com.apple.quarantine" "${InstDir}/Support-LogMeInRescueInstantChat.app"

    PrepareParams "${InstDir}/Support-LogMeInRescueInstantChat.app"
    if [ $? -ne 0 ]; then
        rm -rf "${InstDir}"
        exit 1
    fi

    DownloadCustomization "${InstDir}"
    PrepareIcon "${InstDir}/Support-LogMeInRescueInstantChat.app"

    "${InstDir}/Support-LogMeInRescueInstantChat.app/Contents/MacOS/Support-LogMeInRescueInstantChat" --args "${InstDir}"

# ===========================================================================
