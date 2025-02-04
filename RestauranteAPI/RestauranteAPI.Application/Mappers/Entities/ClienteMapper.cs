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
    //Profile é uma entidade do AutoMapper que será responsável pelo auto mapeamento
    public class ClienteMapper : Profile
    {
        public ClienteMapper()
        {
            #region Entidade para DTO's
            /*Mapeando Cliente Para ClienteRequest e ClienteResponse
            * O método ReverseMap() garante que o mapeamento
            * seja tanto de entidade para request ou response quando de request ou response para entidade */
            CreateMap<Cliente, ClienteResponseDTO>().ReverseMap();
            CreateMap<Cliente, ClienteRequestDTO>().ReverseMap();

            #endregion

            #region Entidade para Commads de Caso de Uso
            // Mapeia a entidade Cliente para comandos de criação, atualização, obtenção por ID e deleção.
            CreateMap<Cliente, CreateClienteCommand>().ReverseMap();
            CreateMap<Cliente, UpdateClienteCommand>().ReverseMap();
            CreateMap<Cliente, GetByIdClienteCommand>().ReverseMap();
            CreateMap<Cliente, DeleteClienteCommand>().ReverseMap();
            #endregion

            #region DTO's para Commads de Caso de Uso
            // Mapeia DTOs de requisição para comandos correspondentes, garantindo a correta associação de ClienteCidadeId
            CreateMap<ClienteRequestDTO, CreateClienteCommand>().ReverseMap()
                                                                              .ForMember(dest => dest.ClienteCidadeId, opt => opt.MapFrom(src => src.CidadeId));
            CreateMap<ClienteRequestDTO, UpdateClienteCommand>().ReverseMap()
                                                                              .ForMember(dest => dest.ClienteCidadeId, opt => opt.MapFrom(src => src.CidadeId));
            CreateMap<ClienteRequestDTO, DeleteClienteCommand>().ReverseMap();
            #endregion

            #region Conversão para api response
            // Mapeia comandos e DTOs para ApiResponse e vice-versa.
            CreateMap<ApiResponse, ClienteRequestDTO>().ReverseMap();
            CreateMap<ApiResponse, CreateClienteCommand>().ReverseMap();
            CreateMap<ApiResponse, UpdateClienteCommand>().ReverseMap();
            CreateMap<ApiResponse, DeleteClienteCommand>().ReverseMap();
            #endregion
        }
    }
}