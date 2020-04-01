using EntrevistaFuncaoInformatica.Domain.Enums;
using System.Collections.Generic;
using System.Security.Claims;

namespace EntrevistaFuncaoInformatica.Core.Interfaces
{
    public interface IUser
    {
        string Chave { get; }
        bool IsAuthenticated();
        IEnumerable<Claim> GetClaimsIdentity();
        bool HasClaim(string claimType, string claimValue);

    }
}
