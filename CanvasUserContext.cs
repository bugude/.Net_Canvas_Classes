using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace SalesforceREST
{
   /**
    * Describes contextual information about the current user.
    */
    public class CanvasUserContext{
        //The Salesforce user identifier.
        [JsonProperty("userId")]
        public String userId { get; set; }
        //The Salesforce username.
        [JsonProperty("userName")]
        public String userName { get; set; }
        // User's first name.
        [JsonProperty("firstName")]
        public String firstName { get; set; }
        //User's last name.
        [JsonProperty("lastName")]
        public String lastName { get; set; }
        //Indicates whether user interface modifications for the visually impaired are on (true) or off (false).
        [JsonProperty("accessibilityModeEnabled")]
        public bool accessibilityMode { get; set; }
        //The user's email address.
        [JsonProperty("email")]
        public String email { get; set; }
        //User's full name.
        [JsonProperty("fullName")]
        public String fullName { get; set; }
        //User\u2019s locale, which controls the formatting of dates and choice of symbols for currency.
        [JsonProperty("locale")]
        public String locale { get; set; }
        //User's language, which controls the language for labels displayed in an application.
        [JsonProperty("language")]
        public String language { get; set; }
        //The user's configured timezone.
        [JsonProperty("timeZone")]
        public String timeZone { get; set; }
        //Information about the user's profile identifier.
        [JsonProperty("profileId")]
        public String profileId { get; set; }
        //Role ID of the role currently assigned to the user.
        [JsonProperty("roleId")]
        public String roleId { get; set; }
        //Current user's license type in label form.
        [JsonProperty("userType")]
        public String userType { get; set; }
        //Current user's default currency ISO code (applies only if multi-currency is enabled for the org).
        [JsonProperty("currencyISOCode")]
        public String currencyISOCode { get; set; }
        //Returns the full profile photo of the current user.
        [JsonProperty("profilePhotoUrl")]
        public String profilePhotoUrl { get; set; }
        //Returns the thumbnail photo of the current user.
        [JsonProperty("profileThumbnailUrl")]
        public String profileThumbnailUrl { get; set; }

        public override String ToString()
        {
            return userId+ ","+
                   userName+ ","+
                   firstName+","+
                   lastName+ ","+
                   email+ ","+
                   fullName+ ","+
                   locale+ ","+
                   language+ ","+
                   timeZone+ ","+
                   profileId+ ","+
                   roleId+ ","+
                   userType+ ","+
                   currencyISOCode+ ","+
                   accessibilityMode+ ","+
                   profilePhotoUrl+","+
                   profileThumbnailUrl;

        }
    }
}
