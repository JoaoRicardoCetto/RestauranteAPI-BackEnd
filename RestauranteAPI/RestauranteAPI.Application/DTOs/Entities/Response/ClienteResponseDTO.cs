using RestauranteAPI.Application.DTOs.Common;
using RestauranteAPI.Domain.Enums;

namespace RestauranteAPI.Application.DTOs.Entities.Response
{
    //S�o os dados de Cliente que s�o enviados de volta para o front
    public class ClienteResponseDTO : BaseDTO
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public String Identification { get; set; }
        public Guid ClienteCidadeId { get; set; }
        public virtual CidadeResponseDTO Cidade { get; set; }

    }
}
