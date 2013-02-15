using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace SalesforceREST
{
    public class CanvasClient
    {
        //The scoped OAuth token to be used to subsequent REST calls    
        [JsonProperty("oauthToken")]
        public String OAuthToken { get; set; } 
        
        [JsonProperty("clientId")]
        public String clientId {get;set;} 

         /**
         * Unique identifier for this canvas app. This value will be different for each instance of a canvas app, even if
         * the same canvas app is placed on a page more than once.
         * @return Unique identifier for this canvas app
         */
        [JsonProperty("instanceId")]
        public String instanceId {get;set;} //

        //@returns the origin (http://somesalesforcedomain:port) of the parent to the canvas app. 
        //This is used so the in browser proxy knows where to post the request to.
        [JsonProperty("targetOrigin")]
        public String targetOrigin { get; set; }

        //The base url for all subsequent REST call, this has the correct Salesforce instance this organization is pinned to.                                         
        [JsonProperty("instanceUrl")]
        public String instanceUrl { get; set; } 

    }
}
