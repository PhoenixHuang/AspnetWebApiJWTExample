using Microsoft.Owin.Security;
using System;
using Thinktecture.IdentityModel.Tokens;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens;

namespace WebApplication6
{
    public class CustomJwtFormat : ISecureDataFormat<AuthenticationTicket>
    {
        private string issuer;
        private byte[] secret;

        public CustomJwtFormat(string issuer, byte[] secret)
        {
            this.issuer = issuer;
            this.secret = secret;
        }
        public string Protect(AuthenticationTicket data)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }
            
            var signingKey =  new HmacSigningCredentials(secret); 
            var issued = data.Properties.IssuedUtc;
            var expires = data.Properties.ExpiresUtc;

            return new JwtSecurityTokenHandler().WriteToken(new JwtSecurityToken(issuer, "Any", data.Identity.Claims, issued.Value.UtcDateTime, expires.Value.UtcDateTime, signingKey));
        }

        public AuthenticationTicket Unprotect(string protectedText)
        {
            throw new NotImplementedException();
        }
    }
}
