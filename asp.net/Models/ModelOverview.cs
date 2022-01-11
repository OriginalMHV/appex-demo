using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.Json;
using asp.net.Models;


namespace asp.net.Models
{
    public class ModelOverview
    {
        public async Task<RootObjectResults> GetModelOverview(int orgNumber)
        {
            ApiHelper.InitizalizeClient();
            string URL = "enheter?size=1&organisasjonsnummer=" + orgNumber;
           
            using (HttpResponseMessage response = ApiHelper.ApiClient.GetAsync(URL).Result)
            {
                if (response.IsSuccessStatusCode)
                {
                    RootObjectResults rootObject = await response.Content.ReadAsAsync<RootObjectResults>();
                    return rootObject;
                }
                else
                {
                    Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                    return null;
                }
            }
        }
        public async Task<RootObjectModel> GetModelOverview(string name)
        {
            ApiHelper.InitizalizeClient();
            string URL = "enheter?size=1&navn=" + name;

            using (HttpResponseMessage response = ApiHelper.ApiClient.GetAsync(URL).Result)
            {
                if (response.IsSuccessStatusCode)
                {
                    RootObjectModel rootObject = await response.Content.ReadAsAsync<RootObjectModel>();
                    return rootObject;
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
 //https://data.brreg.no/enhetsregisteret/api/enheter?size=1&organisasjonsnummer=995412020

// Language: csharp
// Path: asp.net/Models/OrginizationModel.cs


/*
                    var resultFromResponse = response.Content.ReadAsAsync<OrginizationModel>().Result;
                    var jsonString = response.Content.ReadAsStringAsync();
                    jsonString.Wait();
                    var jsonResult = JsonSerializer.Deserialize<OrginizationModel>(jsonString.Result);
                    System.Console.WriteLine(jsonResult);
                    return Task.FromResult(jsonResult);
                    */
                    //var resultFromResponse = response.Content.ReadAsAsync<OrginizationModel>().Result;
                    //var jsonString = JsonSerializer.Deserialize<OrginizationModel>(resultFromResponse.ToString());
                    // Deserialize the Object from OrginizationModel
                    //return Task.FromResult(jsonString);

/*
public async Task<OrginizationModel> GetModelOverview()
        {
            ApiHelper.InitizalizeClient();

            string URL = "";

            // https://data.brreg.no/enhetsregisteret/api/enheter?size=1&navn=Appex
            // https://data.brreg.no/enhetsregisteret/api/enheter?size=1&organisasjonsnummer=995412020


            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(URL))
            {
                if (response.IsSuccessStatusCode)
                {
                    OrginizationModel orginizationModel = await response.Content.ReadAsAsync<OrginizationModel>();
                    var model = JsonConvert.DeserializeObject<OrginizationModel>(JsonConvert.SerializeObject(orginizationModel));
                    return Task.FromResult(model).Result;
                }
                else
                {
                    Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                    Console.WriteLine(response.StatusCode);
                    return null;
                }
            }

        }*/

/*var result = await response.Content.ReadAsStringAsync();
                    var model = JsonConvert.DeserializeObject<OrginizationModel>(URL);
                    Console.WriteLine(result);
                    */
