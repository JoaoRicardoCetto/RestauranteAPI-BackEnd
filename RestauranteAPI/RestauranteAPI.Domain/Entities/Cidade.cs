using Microsoft.AspNetCore.Identity;
using RestauranteAPI.Domain.Common;
using RestauranteAPI.Domain.Enums;
using RestauranteAPI.Domain.Validation;
using System.ComponentModel.DataAnnotations.Schema;


namespace RestauranteAPI.Domain.Entities
{
    public  class Cidade : BaseEntity {
        public string Nome { get; set; }
        //Rela��o de 1 pra N com Cliente
        public ICollection<Cliente>? Clientes { get; set;}

        public Cidade(string nome)
        {
            var validationErrors = CidadeValidation(nome);

            if (validationErrors.Count > 0)
              throw new DomainValidationException(validationErrors);
            
            Nome = nome;
        }

        /*Apenas uma das v�rias valida��es. Essas vallida��es s�o necess�rias para retornar o erro
        na camada mais "rasa" poss�vel, quanto antes uma exce��o for lan�ada. O intuito n�o ocorrer
        um erro no Banco de Dados*/
        private List<string>CidadeValidation(string nome)
        {
            var errors = new List<string>();
            if (string.IsNullOrEmpty(nome))
            {
                errors.Add("O campo nome de Cidade � obrigat�rio!");
            }
            return errors;
        }
    }
}
