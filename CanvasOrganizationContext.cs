using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace SalesforceREST
{
    public class CanvasOrganizationContext
    {
        // The organization id of the organization.
        [JsonProperty("organizationId")]
        public String organizationId { get; set; }
        //The name of the company or organization.
        [JsonProperty("name")]
        public String name { get; set; }
        //Indicates whether the user\u2019s organization uses multiple currencies (true) or not (false).
        [JsonProperty("multicurrencyEnabled")]
        public bool multicurrencyEnabled { get; set; }
        //Current company's default currency ISO code (applies only if multi-currency is disabled for the org).
        [JsonProperty("currencyIsoCode")]
        public String currencyISOCode { get; set; }

        public override String ToString()
        {
            return organizationId + ","+
                   name + ","+
                   multicurrencyEnabled + ","+
                   currencyISOCode;
        }

    }
}
