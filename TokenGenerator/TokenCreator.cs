using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Microsoft.Rest;
using System;
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
            UserPasswordCredential creds = new UserPasswordCredential("Vanaja.b@dsiginc.com", "Welcome@123");
            AuthenticationResult authenticationResult = null;
            var authenticationContext = new AuthenticationContext("https://login.windows.net/common/oauth2/token/");

            authenticationResult = await authenticationContext.AcquireTokenAsync("https://analysis.windows.net/powerbi/api", "c565eea1-4938-468e-8d5f-35b74ac5e8e5", creds);// new ClientCredential(Secrets.ClientID,Secrets.ClientSecret));
            return authenticationResult.AccessToken.ToString();

        }
    }
}
