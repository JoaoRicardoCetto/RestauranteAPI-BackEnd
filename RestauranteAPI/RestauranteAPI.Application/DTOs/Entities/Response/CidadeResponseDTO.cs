using RestauranteAPI.Application.DTOs.Common;
using RestauranteAPI.Domain.Enums;

namespace RestauranteAPI.Application.DTOs.Entities.Response
{
    //O front pode se basear nesses atributos
    //S�o os dados de Cidade que s�o enviados de volta para o front
    public class CidadeResponseDTO : BaseDTO
    {
        public string Nome { get; set; }



    }
}
