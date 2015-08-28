using System;
using System.Threading.Tasks;
using Piofthings.Domain.Models;
using Microsoft.AspNet.Identity;

namespace Piofthings.Domain
{
	public interface IAuthenticationUserService : IDisposable
	{
		Task<IdentityResult> CreateAsync(IdentityUser user);
		Task<IdentityResult> CreateAsync(IdentityUser user, string password);
		Task<IdentityResult> ConfirmEmailAsync (string userId, string code);
		Task<IdentityResult> ResetPasswordAsync (string userId, string confirmationCode, string password);
		Task<IdentityUser> FindByNameAsync(string email);
		Task<string []> GetValidTwoFactorProvidersAsync(IdentityUser user);
		Task<bool> IsEmailConfirmedAsync(string userId);
		Task<IdentityResult> AddLoginAsync (string user, UserLoginInfo login);
	}
}

