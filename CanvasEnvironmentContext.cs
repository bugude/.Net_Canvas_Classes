using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace SalesforceREST
{
    public class CanvasEnvironmentContext
    {
        [JsonProperty("locationUrl")]
        public String locationUrl { get; set; }
        /**
         * Returns the value Theme2 if the user is using the newer user interface theme of the online application, labeled
         * \u201cSalesforce.\u201d Returns Theme1 if the user is using the older user interface theme, labeled
         * \u201cSalesforce Classic.\u201d
         */
        [JsonProperty("uiTheme")]
        public String uiTheme { get; set; }
        [JsonProperty("dimensions")]
        public Dimensions dimensions { get; set; }
        [JsonProperty("version")]
        public SystemVersion version { get; set; }

        public override String ToString()
        {
            return locationUrl + ", " +
                   uiTheme + "," +
                   dimensions.ToString() + "," +
                   version.ToString();
        }

        public class Dimensions{
            /**
             * The width of the iframe
             */
            [JsonProperty("width")]            
            public String width  { get; set; }       
            /**
             * The height of the iframe.
             */
            [JsonProperty("height")]
            public String height { get; set; }

            public override String ToString()
            {
                return String.Format("(w:{0},h:{1}",width,height);
            }
        }

        public class SystemVersion{
            [JsonProperty("api")]
            public String api { get; set; }
            [JsonProperty("season")]
            public String season { get; set; }

            public override String ToString()
            {
                return String.Format("{0} - {1}", api, season);
            }
        }
    }
}
