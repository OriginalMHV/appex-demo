using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

  
namespace asp.net.Models
{  
    public class ModelOverview {

        public async Task GetModelOverview() {
            ApiHelper.InitizalizeClient();

            using(HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync("enhetsregisteret/api/enheter")) {
                if(response.IsSuccessStatusCode) {
                    var result = await response.Content.ReadAsStringAsync();
                    var model = JsonConvert.DeserializeObject<List<ModelOverview>>(result);
                    Console.WriteLine(model);
                }
                else {
                    Console.WriteLine(response.StatusCode);
                }
            }
        }
        
    

        public int OrganizationId { get; set; }  
        public string OrganizationName { get; set; }
        public string OrganizationType { get; set; } 
        public int OrganizationSize { get; set; }   
        public int OrganizationPostalCode { get; set; }  
        public string OrganizationCity { get; set; }  
        public string OrganizationPhoneNumber { get; set; }  
        public string OrganizationEmailAddress { get; set; }  
        public string OrganizationDescription { get; set; }  
        public string OrganizationStartDate { get; set; } 
}
}