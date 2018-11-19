using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Microsoft.Rest;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokenGenerator
{
    public class TokenCreator
    {
        public async Task<string> GetAccessToken()
        {
            string analyticUserName = System.Configuration.ConfigurationManager.AppSettings["AnalyticsUserName"].ToString();
            string analyticPassword = System.Configuration.ConfigurationManager.AppSettings["AnalyticsPassword"].ToString();
            string analyticClientId = System.Configuration.ConfigurationManager.AppSettings["AnalyticsClientId"].ToString();
            string authenticationContextUrl = System.Configuration.ConfigurationManager.AppSettings["AuthenticationContextUrl"].ToString();
            string tokenUrl = System.Configuration.ConfigurationManager.AppSettings["TokenUrl"].ToString();


            UserPasswordCredential creds = new UserPasswordCredential(analyticUserName, analyticPassword);
            AuthenticationResult authenticationResult = null;
            var authenticationContext = new AuthenticationContext(authenticationContextUrl);

            authenticationResult = await authenticationContext.AcquireTokenAsync(tokenUrl, analyticClientId, creds);// new ClientCredential(Secrets.ClientID,Secrets.ClientSecret));
            return authenticationResult.AccessToken.ToString();

        }
    }
}
