/*
namespace asp.net.Models {


using System;
using System.Net;
using Newtonsoft.Json.Serialization;
using System.Web.Mvc;  
using System.Collections.Generic;
using System.Text.Json;
using System.Web.Script.Serialization;

using System.Text;



    public class ModelOverview2
    {
        public OrginizationDetails (int orgNumber)
        {
            ApiHelper.InitizalizeClient();

            //https://data.brreg.no/enhetsregisteret/api/enheter?size=1&organisasjonsnummer=995412020


            string URL = "enheter?size=1&organisasjonsnummer=" + orgNumber;
        
        using (HttpResponseMessage client = new HttpResponseMessage())  
            {  
                string json = client.Content.ReadFromJsonAsync(URL);

                RootObject orginizationDetails =  
}   }
}
*/