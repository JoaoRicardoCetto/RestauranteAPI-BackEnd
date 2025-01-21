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
        public PedidoMapper()
        {
            #region Entidade para DTO's
            CreateMap<Pedido, PedidoResponseDTO>().ReverseMap();
            CreateMap<Pedido, PedidoRequestDTO>().ReverseMap();

            #endregion

            #region Entidade para Commads de Caso de Uso
            CreateMap<Pedido, CreatePedidoCommand>().ReverseMap();
            CreateMap<Pedido, UpdatePedidoCommand>().ReverseMap();
            CreateMap<Pedido, GetByIdPedidoCommand>().ReverseMap();
            CreateMap<Pedido, DeletePedidoCommand>().ReverseMap();
            #endregion

            #region DTO's para Commads de Caso de Uso
            CreateMap<PedidoRequestDTO, CreatePedidoCommand>().ReverseMap()
                                                                            .ForMember(dest => dest.PedidoClienteId, opt => opt.MapFrom(src => src.ClienteId));
            CreateMap<PedidoRequestDTO, UpdatePedidoCommand>().ReverseMap()
                                                                            .ForMember(dest => dest.PedidoClienteId, opt => opt.MapFrom(src => src.ClienteId));
            CreateMap<PedidoRequestDTO, DeletePedidoCommand>().ReverseMap();
            #endregion

            #region Conversão para api response
            CreateMap<ApiResponse, PedidoRequestDTO>().ReverseMap();
            CreateMap<ApiResponse, CreatePedidoCommand>().ReverseMap();
            CreateMap<ApiResponse, UpdatePedidoCommand>().ReverseMap();
            CreateMap<ApiResponse, DeletePedidoCommand>().ReverseMap();
            #endregion
        }
    }
}