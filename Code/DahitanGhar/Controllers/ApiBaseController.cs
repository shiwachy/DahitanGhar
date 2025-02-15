using MediatR;
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
}
