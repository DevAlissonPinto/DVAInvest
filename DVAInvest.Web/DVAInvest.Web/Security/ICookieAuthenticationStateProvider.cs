using Microsoft.AspNetCore.Components.Authorization;

namespace DVAInvest.Web.Security
{
    public interface ICookieAuthenticationStateProvider
    {
        Task<bool> CheckAuthenticatedAsync();
        Task<AuthenticationState> GetAuthenticationStateAsync();
        void NotifyAuthenticationStateChanged();
    }
}
