using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace SalesforceREST
{
    public class CanvasContext
    {
        /**
         * Provides the context about the current user.
         * 
         * @return The current user context, or null if the oauth scope
         * will not allow.
         */
        [JsonProperty("user")]
        public CanvasUserContext userContext { get; set; }

        /**
         * Provides the context about the current organization.
         * 
         * @return The current organization context, or null if the oauth scope
         * will not allow.
         */
        [JsonProperty("organization")]
        public CanvasOrganizationContext orgContext { get; set; }

        /**
         * Provides the context about the current environment (page, url, etc).
         */
        [JsonProperty("environment")]
        public CanvasEnvironmentContext envContext { get; set; }

        /**
         * Provides links to external resources within sfdc.
         */
        [JsonProperty("links")]
        public CanvasLinkContext linkContext { get; set; }

        public override String ToString()
        {
            return "";
            /*return ("Canvas Context:\n\t" +
                                 "User Context:\n\t\t%s\n\t"+
                                 "Org Context:\n\t\t%s\n\t"+
                                 "Environment Context:\n\t\t%s\n\t"+
                                 "Link Context:\n\t\t%s\n", +
                                 (userContext != null?userContext.toString():"null"),+
                                    orgContext != null?orgContext.toString():"null",+
                                    envContext != null?envContext.toString():"null",+
                                    linkContext != null?linkContext.toString():"null",
                                 );*/
        }
    }
}
