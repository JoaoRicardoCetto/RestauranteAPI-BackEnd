using RestauranteAPI.Domain.Common;
using RestauranteAPI.Domain.Enums;
using RestauranteAPI.Domain.Validation;
using System.ComponentModel.DataAnnotations.Schema;


  namespace RestauranteAPI.Domain.Entities
    {
    public  class Pedido : BaseEntity {
      public DateTimeOffset Data { get; set; }
      public decimal Valor { get; set; }
      public Guid PedidoClienteId { get; set; }
      //ManyToOne
      public Cliente? Cliente { get; set; }

    public Pedido(DateTimeOffset data,decimal valor, Guid pedidoclienteid, Guid clienteId)
        {

          var validationErrors = PedidoValidation(data,valor,pedidoclienteid, clienteId);
          if (validationErrors.Count > 0)
            {
              throw new DomainValidationException(validationErrors);
            }

          Data = data;
          Valor = valor;
          PedidoClienteId = pedidoclienteid;
          PedidoClienteId = clienteId;
        }

        /*Apenas uma das várias validações. Essas vallidações são necessárias para retornar o erro
            na camada mais "rasa" possível, quanto antes uma exceção for lançada. O intuito não ocorrer
            um erro no Banco de Dados*/
        private List<string>PedidoValidation(DateTimeOffset data,decimal valor, Guid pedidoclienteid, Guid clienteId)
      {
        var errors = new List<string>();

        // Validations

        return errors;
      }
    }
    }
