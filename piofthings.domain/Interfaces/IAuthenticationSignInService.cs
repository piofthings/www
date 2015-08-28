using System;
using System.Threading.Tasks;
using Piofthings.Domain.Models;

namespace Piofthings.Domain
{
	public interface IAuthenticationSignInService : IDisposable
	{
		Task<SignInStatus> SignInAsync (IdentityUser user, bool isPersistent, bool rememberMe);
		Task<SignInStatus> PasswordSignInAsync(string name, string password, bool rememberMe, bool shouldLockout);
		Task<SignInStatus> TwoFactorSignInAsync(string providerName, string code, bool isPersistent, bool rememberMe);
		Task<bool> HasBeenVerifiedAsync();
		Task<IdentityUser> GetVerifiedUserIdAsync();
		Task<bool> SendTwoFactorCodeAsync(string provider);
		Task<ExternalLoginInfo> GetExternalLoginInfoAsync();
		Task<SignInStatus> ExternalSignInAsync(ExternalLoginInfo loginInfo, bool isPersistent);
	}
}

