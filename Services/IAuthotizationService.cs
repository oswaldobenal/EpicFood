using System;
using EpicFood_API.Models.Custom;

namespace EpicFood_API.Services
{
    public interface IAuthotizationService
    {
        Task<ResponseAuthorization> ReturnToken(RequestAuthorization authorization);
        Task<ResponseAuthorization> ReturnRefreshToken(RefreshTokenRequest refreshTokenRequest, int userId);
    }
}

