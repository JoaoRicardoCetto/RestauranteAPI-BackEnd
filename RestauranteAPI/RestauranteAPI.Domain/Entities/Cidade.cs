using Microsoft.AspNetCore.Identity;
using RestauranteAPI.Domain.Common;
using RestauranteAPI.Domain.Enums;
using RestauranteAPI.Domain.Validation;
using System.ComponentModel.DataAnnotations.Schema;


namespace RestauranteAPI.Domain.Entities
{
    public  class Cidade : BaseEntity {
        public string Nome { get; set; }
        //Relação de 1 pra N com Cliente
        public ICollection<Cliente>? Clientes { get; set;}

        public Cidade(string nome)
        {
            var validationErrors = CidadeValidation(nome);

            if (validationErrors.Count > 0)
              throw new DomainValidationException(validationErrors);
            
            Nome = nome;
        }

        /*Apenas uma das várias validações. Essas vallidações são necessárias para retornar o erro
        na camada mais "rasa" possível, quanto antes uma exceção for lançada. O intuito não ocorrer
        um erro no Banco de Dados*/
        private List<string>CidadeValidation(string nome)
        {
            var errors = new List<string>();
            if (string.IsNullOrEmpty(nome))
            {
                errors.Add("O campo nome de Cidade é obrigatório!");
            }
            return errors;
        }
    }
}
