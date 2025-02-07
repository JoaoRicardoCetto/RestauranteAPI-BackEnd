using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using System;

namespace RestauranteAPI.Application.Shared.Exceptions.Filters
{
    public class DatabaseExceptionFilter : IExceptionFilter
    {
        // Método chamado automaticamente quando ocorre uma exceção durante a execução de uma requisição.
        public void OnException(ExceptionContext context)
        {
            // Verifica se a exceção capturada é do tipo DbUpdateException
            if (context.Exception is DbUpdateException dbUpdateException)
            {
                // Obtém a mensagem de erro da exceção base para fornecer mais detalhes sobre o problema
                var errors = dbUpdateException.GetBaseException().Message;

                // Cria um objeto de resposta contendo a mensagem de erro
                var result = new ObjectResult(new { Errors = errors })
                {
                    StatusCode = 400
                };

                context.Result = result;
                context.ExceptionHandled = true; // Marca a exceção como tratada para que não continue propagando
            }
        }
    }
}