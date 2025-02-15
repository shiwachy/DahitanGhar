using DahitanGhar.Domain.Common;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DahitanGhar.Application.Auth.Login;

public class LoginCommand : IRequest<OperationResult<AuthenticationResponseDto>>
{
    public string UserName { get; set; }
    public string Password { get; set; }
}


public class LoginCommandHandler : IRequestHandler<LoginCommand, OperationResult<AuthenticationResponseDto>>
{
    public async Task<OperationResult<AuthenticationResponseDto>> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        var res = new AuthenticationResponseDto
        {
            Success = true,
            AccessToken = "This is access token",
            RefreshToken = "This is refresh token",
            ErrorMessage = "This is error message"
        };

        var ressult1 = OperationResult.Success();
        var result = OperationResult.Failure<AuthenticationResponseDto>("Wrong Credentials");
        return result;
    }
}