using CashFlow.Application.UseCases.Expenses.Delete;
using CashFlow.Application.UseCases.Login.DoLogin;
using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace CashFlow.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisteredUserJson), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status401Unauthorized)]

        public async Task<IActionResult> Login(
            [FromServices] IDoLoginUseCase useCase,
            RequestLoginJson request)
        {
            var response = await useCase.Execute(request);

            return Ok(response);
        }


    }
}
   
    

