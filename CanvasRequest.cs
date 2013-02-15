using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.ComponentModel;

namespace SalesforceREST
{    
    public class CanvasRequest {
        //The algorithm used to sign the request. typically HMAC-SHA256  
        //@see platform.connect.service.SignRequestService.ALGORITHM
        [JsonProperty("algorithm")]
        public String algorithm { get; set; }
        //The unix time this request was issued at.
        [JsonProperty("issuedAt", NullValueHandling = NullValueHandling.Ignore)]
        [DefaultValue(0)]
        public int issuedAt { get; set; }
        //The Salesforce unique id for this user.
        [JsonProperty("userId")]
        public String userId { get; set; }
        /*Context information about the user, org and environment.
        Client instance information required while using the Sfdc.canvas.client JavaScript API.*/
        [JsonProperty("context")]
        public CanvasContext context { get; set; }
        /*Unique information about this client (including oauth token). This information (in JSON) format needs to be
        included on all client side SDK calls.*/
        [JsonProperty("client")]
        public CanvasClient client { get; set; }   
    }
}
