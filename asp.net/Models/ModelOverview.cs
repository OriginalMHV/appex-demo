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

            string URL = "navn=Appex";

            // https://data.brreg.no/enhetsregisteret/api/enheter?size=1&navn=Appex
            // https://data.brreg.no/enhetsregisteret/api/enheter?size=1&organisasjonsnummer=995412020
            

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(URL))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadFromJsonAsync<OrginizationModel>();
                    var model = JsonConvert.DeserializeObject<OrginizationModel>(result.ToString());
                    Console.WriteLine(result);
                    return result;
                }
                else
                {
                    Console.WriteLine(response.StatusCode);
                    return null;
                }
            }
        }

    }
}
