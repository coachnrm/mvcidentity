using static Yt_Dot6Identity.Models.DTO.ChangePasswordModel;
using Yt_Dot6Identity.Models.DTO;

namespace Yt_Dot6Identity.Repositories.Abstract
{
    public interface IUserAuthenticationService
    {
        Task<Status> LoginAsync(LoginModel model);
        Task LogoutAsync();
        Task<Status> RegisterAsync(RegistrationModel model);
        Task<Status> ChangePasswordAsync(ChangePasswordModel model, string username);
    }
}
