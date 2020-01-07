using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TweetBook_NetCore_REST_API.Domain;

namespace TweetBook_NetCore_REST_API.Services
{
    public interface IIdentityService
    {
        Task<AuthenticationResult> RegisterAsync(string email, string password);
        Task<AuthenticationResult> LoginAsync(string email, string password);
        Task<AuthenticationResult> RefreshTokenAsync(string jwtToken, string refreshToken);

    }
}
