using DVAInvest.Domain.Entities;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace DVAInvest.Web.Security
{
    public class CookieAuthenticationStateProvider(IHttpClientFactory clientFactory) :
    AuthenticationStateProvider,
    ICookieAuthenticationStateProvider
    {
        private bool _isAuthenticated = false;
        private readonly HttpClient _client = clientFactory.CreateClient("DVAInvest");

        public async Task<bool> CheckAuthenticatedAsync()
        {
            await GetAuthenticationStateAsync();
            return _isAuthenticated;
        }

        public void NotifyAuthenticationStateChanged()
            => NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            _isAuthenticated = false;
            var user = new ClaimsPrincipal(new ClaimsIdentity());

            var userInfo = await GetUser();
            if (userInfo is null)
                return new AuthenticationState(user);

            var claims = await GetClaims(userInfo);

            var id = new ClaimsIdentity(claims, nameof(CookieAuthenticationStateProvider));
            user = new ClaimsPrincipal(id);

            _isAuthenticated = true;
            return new AuthenticationState(user);
        }

        private async Task<UserInfo?> GetUser()
        {
            try
            {
                return await _client.GetFromJsonAsync<UserInfo?>("v1/identity/manage/info");
            }
            catch
            {
                return null;
            }
        }

        private async Task<List<Claim>> GetClaims(UserInfo user)
        {
            var claims = new List<Claim>
        {
            new(ClaimTypes.Name, user.Email),
            new(ClaimTypes.Email, user.Email)
        };

            claims.AddRange(
                user.Claims.Where(x =>
                        x.Key != ClaimTypes.Name &&
                        x.Key != ClaimTypes.Email)
                    .Select(x
                        => new Claim(x.Key, x.Value))
            );

            RoleClaim[]? roles;
            try
            {
                roles = await _client.GetFromJsonAsync<RoleClaim[]>("v1/identity/roles");
            }
            catch
            {
                return claims;
            }

            foreach (var role in roles ?? [])
                if (!string.IsNullOrEmpty(role.Type) && !string.IsNullOrEmpty(role.Value))
                    claims.Add(new Claim(role.Type, role.Value, role.ValueType, role.Issuer, role.OriginalIssuer));

            return claims;
        }
    }
}
