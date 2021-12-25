using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

  
namespace ModelOverview.Models
{  
    public class getOverview {
        private String requestURL = "https://data.brreg.no/enhetsregisteret/api/";

        public String getOrganization(String OrganizationId)
        {
            String url = requestURL + "enheter/" + OrganizationId;
            return url;
        }

        public Object getJSONObject() {
            Object jsonObject;
            try
            {
                using (WebClient client = new WebClient())
                {
                    var content = client.DownloadString(url);
                    jsonContent = JsonConvert.DeserializeObject<RootObject>(content);
                }
            }
            catch (Exception exception)
            {
                return "not found";
            }
            return jsonContent;
        }
        }
        
        

    }
    public class OverviewModel  
    {  
        public int OrganizationId { get; set; }  
        public string OrganizationName { get; set; }
        public string OrganizationType { get; set; } 
        public string OrganizationSize { get; set; }   
        public string OrganizationPostalCode { get; set; }  
        public string OrganizationCity { get; set; }  
        public string OrganizationPhoneNumber { get; set; }  
        public string OrganizationEmailAddress { get; set; }  
        public string OrganizationDescription { get; set; }  
        public string OrganizationStartDate { get; set; }
    } 
