using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using System;

namespace RestauranteAPI.Application.Shared.Exceptions.Filters
{
    public class DatabaseExceptionFilter : IExceptionFilter
    {
        // M�todo chamado automaticamente quando ocorre uma exce��o durante a execu��o de uma requisi��o.
        public void OnException(ExceptionContext context)
        {
            // Verifica se a exce��o capturada � do tipo DbUpdateException
            if (context.Exception is DbUpdateException dbUpdateException)
            {
                // Obt�m a mensagem de erro da exce��o base para fornecer mais detalhes sobre o problema
                var errors = dbUpdateException.GetBaseException().Message;

                // Cria um objeto de resposta contendo a mensagem de erro
                var result = new ObjectResult(new { Errors = errors })
                {
                    StatusCode = 400
                };

                context.Result = result;
                context.ExceptionHandled = true; // Marca a exce��o como tratada para que n�o continue propagando
            }
        }
    }
}