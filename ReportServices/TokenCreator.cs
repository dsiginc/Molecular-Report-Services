
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using Microsoft.Extensions.Configuration;

namespace TokenGenerator
{
    public  class TokenCreator
    {
        private readonly IConfiguration _configuration;
        public TokenCreator(IConfiguration configuration)
        {
            _configuration = configuration;
        }



        //UserPasswordCredential creds = new UserPasswordCredential(analyticUserName, analyticPassword);
        //AuthenticationResult authenticationResult = null;
        //var authenticationContext = new AuthenticationContext(authenticationContextUrl);

        //authenticationResult = await authenticationContext.AcquireTokenAsync(tokenUrl, analyticClientId, creds);// new ClientCredential(Secrets.ClientID,Secrets.ClientSecret));
        //return authenticationResult.AccessToken.ToString();







        public  async Task<string> AuthenticateAsync()
        {

            string analyticUserName = _configuration["AnalyticsUserName"].ToString();
            string analyticPassword = _configuration["AnalyticsPassword"].ToString();
            string analyticClientId = _configuration["AnalyticsClientId"].ToString();
            string authenticationContextUrl = _configuration["AuthenticationContextUrl"].ToString();
            string tokenUrl = _configuration["TokenUrl"].ToString();

            var oauthEndpoint = new Uri(authenticationContextUrl);
            using (var client = new HttpClient())
            {
                var result = await client.PostAsync(oauthEndpoint, new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("resource", tokenUrl),
                    new KeyValuePair<string, string>("client_id", analyticClientId),
                    new KeyValuePair<string, string>("grant_type", "password"),
                    new KeyValuePair<string, string>("username", analyticUserName),
                    new KeyValuePair<string, string>("password", analyticPassword),
                    new KeyValuePair<string, string>("scope", "openid"),
                }));

                var content = await result.Content.ReadAsStringAsync();
                var tokenData = JsonConvert.DeserializeObject<OAuthResult>(content);
                return tokenData.AccessToken;
            }
        }

        public class OAuthResult
        {
            [JsonProperty("token_type")]
            public string TokenType { get; set; }
            [JsonProperty("scope")]
            public string Scope { get; set; }
            [JsonProperty("experies_in")]
            public int ExpiresIn { get; set; }
            [JsonProperty("ext_experies_in")]
            public int ExtExpiresIn { get; set; }
            [JsonProperty("experies_on")]
            public int ExpiresOn { get; set; }
            [JsonProperty("not_before")]
            public int NotBefore { get; set; }
            [JsonProperty("resource")]
            public Uri Resource { get; set; }
            [JsonProperty("access_token")]
            public string AccessToken { get; set; }
            [JsonProperty("refresh_token")]
            public string RefreshToken { get; set; }
        }
    }
}



