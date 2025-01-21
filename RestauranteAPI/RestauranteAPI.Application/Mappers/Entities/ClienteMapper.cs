using AutoMapper;
using RestauranteAPI.Application.DTOs.Entities.Request;
using RestauranteAPI.Application.DTOs.Entities.Response;
using RestauranteAPI.Application.DTOs.Common;
using RestauranteAPI.Application.UseCase.Entities.ClienteCase.Create;
using RestauranteAPI.Application.UseCase.Entities.ClienteCase.Delete;
using RestauranteAPI.Application.UseCase.Entities.ClienteCase.GetById;
using RestauranteAPI.Application.UseCase.Entities.ClienteCase.Update;
using RestauranteAPI.Domain.Entities;

namespace RestauranteAPI.Application.Mappers.Entities
{
    public class ClienteMapper : Profile
    {
        public ClienteMapper()
        {
            #region Entidade para DTO's
            CreateMap<Cliente, ClienteResponseDTO>().ReverseMap();
            CreateMap<Cliente, ClienteRequestDTO>().ReverseMap();

            #endregion

            #region Entidade para Commads de Caso de Uso
            CreateMap<Cliente, CreateClienteCommand>().ReverseMap();
            CreateMap<Cliente, UpdateClienteCommand>().ReverseMap();
            CreateMap<Cliente, GetByIdClienteCommand>().ReverseMap();
            CreateMap<Cliente, DeleteClienteCommand>().ReverseMap();
            #endregion

            #region DTO's para Commads de Caso de Uso
            CreateMap<ClienteRequestDTO, CreateClienteCommand>().ReverseMap()
                                                                              .ForMember(dest => dest.ClienteCidadeId, opt => opt.MapFrom(src => src.CidadeId));
            CreateMap<ClienteRequestDTO, UpdateClienteCommand>().ReverseMap()
                                                                              .ForMember(dest => dest.ClienteCidadeId, opt => opt.MapFrom(src => src.CidadeId));
            CreateMap<ClienteRequestDTO, DeleteClienteCommand>().ReverseMap();
            #endregion

            #region Conversão para api response
            CreateMap<ApiResponse, ClienteRequestDTO>().ReverseMap();
            CreateMap<ApiResponse, CreateClienteCommand>().ReverseMap();
            CreateMap<ApiResponse, UpdateClienteCommand>().ReverseMap();
            CreateMap<ApiResponse, DeleteClienteCommand>().ReverseMap();
            #endregion
        }
    }
}