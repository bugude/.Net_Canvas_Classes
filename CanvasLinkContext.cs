using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace SalesforceREST
{
    /**
 * Describes all contextual information around external references, or links to external resources.
 */
//@JsonIgnoreProperties(ignoreUnknown=true)
    public class CanvasLinkContext
    {
        //Provide the url for enterprise-wide external clients.
        [JsonProperty("enterpriseUrl")]
        public String enterpriseUrl { get; set; }
        //Provide the base url for the metadata api to access information about custom objects, apex classes, etc.
        [JsonProperty("metadataUrl")]
        public String metadataUrl { get; set; }
        //Access to the partner api for developing client applications for multiple organizations.
        [JsonProperty("partnerUrl")]
        public String partnerUrl { get; set; }
        //Access to the base url for RESTful services.
        [JsonProperty("restUrl")]
        public String restUrl { get; set; }
        //Access to custom sobject definitions.
        [JsonProperty("sobjectUrl")]
        public String sobjectUrl { get; set; }
        //Access to search api.
        [JsonProperty("searchUrl")]
        public String searchUrl { get; set; }
        //Access to the SOQL query api.
        [JsonProperty("queryUrl")]
        public String queryUrl { get; set; }
        // Access to the recent items feed.
        [JsonProperty("recentItemsUrl")]
        public String recentItemsUrl { get; set; }
        // Retrieve more information about the current user.
        [JsonProperty("userProfileUrl")]
        public String userProfileUrl { get; set; }
        //Access to Chatter Feeds. Note: Requires user profile permissions, otherwise this will be null.
        [JsonProperty("chatterFeedsUrl")]
        public String chatterFeedsUrl { get; set; }
        //Access to Chatter Groups. Note: Requires user profile permissions, otherwise this will be null.
        [JsonProperty("chatterGroupsUrl")]
        public String chatterGroupsUrl { get; set; }
        //Access to Chatter Users. Note: Requires user profile permissions, otherwise this will be null.
        [JsonProperty("chatterUsersUrl")]
        public String chatterUsersUrl { get; set; }
        //Access to individual Chatter Feed items. Note: Requires user profile permissions, otherwise this will be null.
        [JsonProperty("chatterFeedItemsUrl")]
        public String chatterFeedItemsUrl { get; set; }

        public override String ToString()
        {
            return enterpriseUrl + ", " +
                     metadataUrl + ", " +
                     partnerUrl + ", " +
                     restUrl + ", " +
                     sobjectUrl + ", " +
                     searchUrl + ", " +
                     queryUrl + ", " +
                     recentItemsUrl + ", " +
                     userProfileUrl + ", " +
                     chatterFeedsUrl + ", " +
                     chatterGroupsUrl + ", " +
                     chatterUsersUrl + ", " +
                     chatterFeedItemsUrl;
        }
    }
}
