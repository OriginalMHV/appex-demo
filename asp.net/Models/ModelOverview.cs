using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;


namespace asp.net.Models
{
    public class ModelOverview
    {
        public async Task<OrginizationModel> GetModelOverview()
        {
            ApiHelper.InitizalizeClient();

            string URL= "https://data.brreg.no/enhetsregisteret/api/enheter?size=1&navn=Appex";

            // https://data.brreg.no/enhetsregisteret/api/enheter?size=1&navn=Appex
            // https://data.brreg.no/enhetsregisteret/api/enheter?size=1&organisasjonsnummer=995412020
            

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(URL))
            {
                if (response.IsSuccessStatusCode)
                {
                    OrginizationModel orginizationModel = await response.Content.ReadAsAsync<OrginizationModel>();
                    var model = JsonConvert.DeserializeObject<OrginizationModel>(JsonConvert.SerializeObject(orginizationModel));
                    return orginizationModel;
                    /*var result = await response.Content.ReadAsStringAsync();
                    var model = JsonConvert.DeserializeObject<OrginizationModel>(URL);
                    Console.WriteLine(result);
                    */
                }
                else
                {
                    Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                    Console.WriteLine(response.StatusCode);
                    return null;
                }
            }
        }

    }
}
