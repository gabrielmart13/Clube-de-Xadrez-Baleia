using System.ComponentModel.DataAnnotations;
using XadrezBaleia.Application.Exceptions;

namespace Xadrez_Baleia.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionMiddleware> _logger;

        public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                if (context.Response.HasStarted)
                {
                    _logger.LogError(ex, "A resposta já havia começado quando ocorreu uma exceção.");

                    throw;
                }


                await HandleExceptionAsync(context, ex); //Chama o analizador de excessoes
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            int statuscode;
            string message;
            string code;

            switch(ex)
            {
                case XadrezBaleia.Application.Exceptions.ValidationException:
                    statuscode = StatusCodes.Status400BadRequest;
                    message = ex.Message;
                    code = "Validation Error";
                    break;

                case NotFoundException:
                    statuscode = StatusCodes.Status404NotFound;
                    message = ex.Message;
                    code = "Not Found";
                    break;

                case ConflictException:
                    statuscode = StatusCodes.Status409Conflict;
                    message = ex.Message;
                    code = "Conflict Error";
                    break;

                default:
                    statuscode = StatusCodes.Status500InternalServerError;
                    code = "INTERNAL_SERVER_ERROR";
                    message = "Ocorreu um erro interno no servidor.";

                    _logger.LogError(
                        ex,
                        "Erro não tratado durante o processamento da requisição."
                    );
                    break;
            }

            context.Response.Clear();
            context.Response.StatusCode = statuscode;

            var response = new //Forma a resposta
            {
                status = statuscode,
                code,
                message,
                timestamp = DateTime.UtcNow,
                path = context.Request.Path.Value
            };

            await context.Response.WriteAsJsonAsync(response);
        }
    }
}
