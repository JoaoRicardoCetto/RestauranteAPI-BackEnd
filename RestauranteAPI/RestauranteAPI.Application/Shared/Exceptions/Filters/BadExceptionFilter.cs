using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using RestauranteAPI.Domain.Validation;
using System.Linq;

namespace RestauranteAPI.Application.Shared.Exceptions.Filters
{
    public class BadRequestExceptionFilter : IExceptionFilter
    {
        public BadRequestExceptionFilter() { }
        // Método que é chamado automaticamente quando uma exceção ocorre durante a execução de uma requisição.
        public void OnException(ExceptionContext context)
        {
            // Se a exceção capturada for do tipo ValidationException (FluentValidation)
            if (context.Exception is ValidationException validationException)
            {
                var errors = validationException.Errors.Select(e => new { e.PropertyName, e.ErrorMessage });
                
                // Cria um objeto de resposta contendo os erros
                var result = new ObjectResult(new { Errors = errors })
                {
                    StatusCode = 400
                };
                context.Result = result;
                context.ExceptionHandled = true; // Marca a exceção como tratada para que não continue propagando
            }
            else if (context.Exception is DomainValidationException domainValidationException)
            {
                var errors = domainValidationException.Message;
                var result = new ObjectResult(new { Errors = errors })
                {
                    StatusCode = 400
                };
                context.Result = result;
                context.ExceptionHandled = true;
            }
        }
    }
}
