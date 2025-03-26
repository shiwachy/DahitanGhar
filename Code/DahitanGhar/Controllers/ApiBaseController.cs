using DahitanGhar.Domain.Common;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace DahitanGhar.Web.Controllers;

public class ApiBaseController : Controller
{
    private ISender? _mediator;

    protected ISender Mediator
    {
        get
        {
            if (_mediator == null)
            {
                _mediator = HttpContext.RequestServices.GetService<ISender>();
            }
            return _mediator ?? throw new NullReferenceException(nameof(_mediator));
        }
    }


    public ActionResult HandleResult<T>(OperationResult<T> result)
    {
        if (result.IsSuccess)
            return Ok(result.Data);
        
        //If result is failed return error message.
        return BadRequest(result.Message);
        
    }

    public ActionResult HandleResult(OperationResult result)
    {
        if (result.IsSuccess)
            return Ok(result);

        //If result is failed return error message.
        return BadRequest(result.Message);

    }
}
