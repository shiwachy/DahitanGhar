using DahitanGhar.Application.Auth.Login;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace DahitanGhar.Web.Controllers;
public class AuthController : ApiBaseController
{

    [HttpPost]
    [Route("Login")]
    [ProducesResponseType(typeof(AuthenticationResponseDto), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(ProblemDetails), (int)HttpStatusCode.BadRequest)]
    [ProducesResponseType(typeof(ProblemDetails), (int)HttpStatusCode.InternalServerError)]
    [ProducesResponseType(typeof(ProblemDetails), (int)HttpStatusCode.UnprocessableEntity)]
    [ProducesResponseType(typeof(ProblemDetails), (int)HttpStatusCode.Unauthorized)]

    public async Task<ActionResult<AuthenticationResponseDto>> Login([FromBody]LoginCommand command)
    {
          var result = await Mediator.Send(command);
        return Ok(result);
       
    }



}
