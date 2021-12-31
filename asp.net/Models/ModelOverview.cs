using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;


namespace asp.net.Models
{
    public class ModelOverview
    {
        public Task<OrginizationModel> GetModelOverview(int orgNumber)
        {
            ApiHelper.InitizalizeClient();

            //https://data.brreg.no/enhetsregisteret/api/enheter?size=1&organisasjonsnummer=995412020


            string URL = "enheter?size=1&organisasjonsnummer=" + orgNumber;

            // get data from api
            using (HttpResponseMessage response = ApiHelper.ApiClient.GetAsync(URL).Result)
            {
                if (response.IsSuccessStatusCode)
                {
                    OrginizationModel orginizationModel = response.Content.ReadAsAsync<OrginizationModel>().Result;
                    var model = JsonConvert.DeserializeObject<OrginizationModel>(JsonConvert.SerializeObject(orginizationModel));
                    return Task.FromResult(model);
                }
                else
                {
                    Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                    Console.WriteLine(response.StatusCode);
                    return null;
                }
            }
        }
            public Task<OrginizationModel> GetModelOverview(string name)
            {
                ApiHelper.InitizalizeClient();

                string URL = "enheter?size=1&navn=" + name;

                // get data from api
                using (HttpResponseMessage response = ApiHelper.ApiClient.GetAsync(URL).Result)
                {
                    if (response.IsSuccessStatusCode)
                    {
                        OrginizationModel orginizationModel = response.Content.ReadAsAsync<OrginizationModel>().Result;
                        var model = JsonConvert.DeserializeObject<OrginizationModel>(JsonConvert.SerializeObject(orginizationModel));
                        return Task.FromResult(model);
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

// Language: csharp
// Path: asp.net/Models/OrginizationModel.cs


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
