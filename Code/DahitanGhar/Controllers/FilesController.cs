using DahitanGhar.Application.Fiiles.Command;
using DahitanGhar.Domain.Common;
using DahitanGhar.Web.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace DahitanGhar.Web.Controllersp;

public class FilesController : ApiBaseController
{
    [HttpPost]
    [Route("UploadImage")]
    public async Task<ActionResult> UploadImage(UploadImageCommand command)
    {
        var result = await Mediator.Send(command);

        return HandleResult(result);
    }
}
