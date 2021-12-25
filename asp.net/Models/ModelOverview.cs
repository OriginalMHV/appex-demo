using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Web;  
  
namespace Models
{  
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
}  