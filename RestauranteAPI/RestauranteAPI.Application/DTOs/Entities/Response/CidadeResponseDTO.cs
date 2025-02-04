using RestauranteAPI.Application.DTOs.Common;
using RestauranteAPI.Domain.Enums;

namespace RestauranteAPI.Application.DTOs.Entities.Response
{
    //O front pode se basear nesses atributos
    //São os dados de Cidade que são enviados de volta para o front
    public class CidadeResponseDTO : BaseDTO
    {
        public string Nome { get; set; }



    }
}
