using RestauranteAPI.Domain.Common;
using RestauranteAPI.Domain.Enums;
using RestauranteAPI.Domain.Validation;
using System.ComponentModel.DataAnnotations.Schema;


  namespace RestauranteAPI.Domain.Entities
    {
    public  class Cliente : BaseEntity {

      public string Nome { get; set; }
      public string Telefone { get; set; }
      public String Identification { get; set; }
      public Guid? ClienteCidadeId { get; set; }
      //OneToMany
      public ICollection<Pedido>? Pedidos { get; set;}
      //ManyToOne
      public Cidade? Cidade { get; set; }

    public Cliente(string nome,string telefone,String identification, Guid clientecidadeid, Guid cidadeId)
        {

          var validationErrors = ClienteValidation(nome,telefone,identification,clientecidadeid, cidadeId);
          if (validationErrors.Count > 0)
            {
              throw new DomainValidationException(validationErrors);
            }
          Nome = nome;
          Telefone = telefone;
          Identification = identification;
          ClienteCidadeId = clientecidadeid;
          ClienteCidadeId = cidadeId;

        }

        /*Apenas uma das várias validações. Essas vallidações são necessárias para retornar o erro
            na camada mais "rasa" possível, quanto antes uma exceção for lançada. O intuito não ocorrer
            um erro no Banco de Dados*/
        private List<string>ClienteValidation(string nome,string telefone,String identification, Guid clientecidadeid, Guid cidadeId)
        {
            var errors = new List<string>();
            if (string.IsNullOrEmpty(nome))
            {
                errors.Add("O campo nome de Cidade é obrigatório!");
            }
            if (string.IsNullOrEmpty(telefone))
            {
                errors.Add("O campo nome de Cidade é obrigatório!");
            }
            if (string.IsNullOrEmpty(identification))
            {
                errors.Add("O campo nome de Cidade é obrigatório!");
            }
            return errors;
        }
    }
  }
