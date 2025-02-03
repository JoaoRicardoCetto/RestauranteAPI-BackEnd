using RestauranteAPI.Domain.Common;
using RestauranteAPI.Domain.Enums;
using RestauranteAPI.Domain.Validation;
using System.ComponentModel.DataAnnotations.Schema;


  namespace RestauranteAPI.Domain.Entities
    {
    public  class Pedido : BaseEntity {
        public DateTimeOffset Data { get; set; }
        public decimal Valor { get; set; }
        public EstadoPedido EstadoPedido { get; set; }
        public Guid PedidoClienteId { get; set; }
        //ManyToOne
        public Cliente? Cliente { get; set; }

        public Pedido()
        {
        }

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
          EstadoPedido = EstadoPedido.FEITO;
        }

        /*Apenas uma das v�rias valida��es. Essas vallida��es s�o necess�rias para retornar o erro
            na camada mais "rasa" poss�vel, quanto antes uma exce��o for lan�ada. O intuito n�o ocorrer
            um erro no Banco de Dados*/
        private List<string>PedidoValidation(DateTimeOffset data,decimal valor, Guid pedidoclienteid, Guid clienteId)
      {
        var errors = new List<string>();
            //Atributos como DateTimeOffSet nunca s�o inicializados como null, por isso a compara��o com default
            if (data == default)
            {
                errors.Add("O campo data do Pedido � obrigat�rio!");
            }
            if (valor < 0)
            {
                errors.Add("O valor do pedido n�o pode ser negativo");
            }
            if (valor == default)
            {
                errors.Add("O campo valor do pedido � obrigat�rio");
            }
            return errors;
      }
    }
    }
