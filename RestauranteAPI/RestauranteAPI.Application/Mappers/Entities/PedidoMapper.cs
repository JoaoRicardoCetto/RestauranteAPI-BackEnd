using AutoMapper;
using RestauranteAPI.Application.DTOs.Entities.Request;
using RestauranteAPI.Application.DTOs.Entities.Response;
using RestauranteAPI.Application.DTOs.Common;
using RestauranteAPI.Application.UseCase.Entities.PedidoCase.Create;
using RestauranteAPI.Application.UseCase.Entities.PedidoCase.Delete;
using RestauranteAPI.Application.UseCase.Entities.PedidoCase.GetById;
using RestauranteAPI.Application.UseCase.Entities.PedidoCase.Update;
using RestauranteAPI.Domain.Entities;

namespace RestauranteAPI.Application.Mappers.Entities
{
    public class PedidoMapper : Profile
    {
        //Profile é uma entidade do AutoMapper que será responsável pelo auto mapeamento
        public PedidoMapper()
        {
            #region Entidade para DTO's
            /*Mapeando Pedido para PedidoResponse e PedidoRequest
            * O método ReverseMap() garante que o mapeamento
            * seja tanto de entidade para request ou response quando de request ou response para entidade */
            CreateMap<Pedido, PedidoResponseDTO>().ReverseMap();
            CreateMap<Pedido, PedidoRequestDTO>().ReverseMap();

            #endregion

            #region Entidade para Commads de Caso de Uso
            // Mapeia a entidade Pedido para comandos de criação, atualização, obtenção por ID e deleção.
            CreateMap<Pedido, CreatePedidoCommand>().ReverseMap();
            CreateMap<Pedido, UpdatePedidoCommand>().ReverseMap();
            CreateMap<Pedido, GetByIdPedidoCommand>().ReverseMap();
            CreateMap<Pedido, DeletePedidoCommand>().ReverseMap();
            #endregion

            #region DTO's para Commads de Caso de Uso
            // Mapeia DTOs de requisição para comandos correspondentes, garantindo a correta associação de PedidoClienteId
            CreateMap<PedidoRequestDTO, CreatePedidoCommand>().ReverseMap()
                                                                            .ForMember(dest => dest.PedidoClienteId, opt => opt.MapFrom(src => src.ClienteId));
            CreateMap<PedidoRequestDTO, UpdatePedidoCommand>().ReverseMap()
                                                                            .ForMember(dest => dest.PedidoClienteId, opt => opt.MapFrom(src => src.ClienteId));
            CreateMap<PedidoRequestDTO, DeletePedidoCommand>().ReverseMap();
            #endregion

            #region Conversão para api response
            // Mapeia comandos e DTOs para ApiResponse e vice-versa.
            CreateMap<ApiResponse, PedidoRequestDTO>().ReverseMap();
            CreateMap<ApiResponse, CreatePedidoCommand>().ReverseMap();
            CreateMap<ApiResponse, UpdatePedidoCommand>().ReverseMap();
            CreateMap<ApiResponse, DeletePedidoCommand>().ReverseMap();
            #endregion
        }
    }
}