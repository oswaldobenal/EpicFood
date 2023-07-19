using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EpicFood_API.Models.Custom;
using EpicFood_API.Services;
using System.IdentityModel.Tokens.Jwt;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EpicFood_API.Controllers
{
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IAuthotizationService _authotizationService;

        public UserController(IAuthotizationService authotizationService)
        {
            _authotizationService = authotizationService;
        }

        [HttpPost]
        [Route("Autenticar")]
        public async Task<IActionResult> Autenticar([FromBody] RequestAuthorization authorization)
        {
            var authorization_result = await _authotizationService.ReturnToken(authorization);

            if (authorization_result == null)
                return Unauthorized();

            return Ok(authorization_result);
        }

        [HttpPost]
        [Route("ObtenerRefreshToken")]
        public async Task<IActionResult> ObtenerRefreshToken([FromBody] RefreshTokenRequest request)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenExpired = tokenHandler.ReadJwtToken(request.TokenExpirado);

            if (tokenExpired.ValidTo > DateTime.UtcNow)
                return BadRequest(new ResponseAuthorization
                {
                    Result = false,
                    Message = "Token no ha expirado"
                });

            string idUser = tokenExpired.Claims.First(x => x.Type == JwtRegisteredClaimNames.NameId).Value.ToString();

            var authorizationResponse = await _authotizationService.ReturnRefreshToken(request, int.Parse(idUser));

            if (authorizationResponse.Result)
                return Ok(authorizationResponse);
            else
                return BadRequest(authorizationResponse);
        }
    }
}

