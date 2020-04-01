using EntrevistaFuncaoInformatica.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Security.Claims;

namespace EntrevistaFuncaoInformatica.CrossCutting.Models
{
    public class AspNetUser : IUser
    {
        private readonly IHttpContextAccessor contextAccessor;

        public AspNetUser(IHttpContextAccessor contextAccessor)
        {
            this.contextAccessor = contextAccessor;
        }

        public string Chave { get => contextAccessor.HttpContext.User.Identity.Name; }

        public IEnumerable<Claim> GetClaimsIdentity()
        {
            return contextAccessor.HttpContext.User.Claims;
        }

        public bool IsAuthenticated()
        {
            return contextAccessor.HttpContext.User.Identity.IsAuthenticated;
        }
        
        public bool HasClaim(string claimType, string claimValue)
        {
            return contextAccessor.HttpContext.User.HasClaim(claimType, claimValue);
        }
    }
}
