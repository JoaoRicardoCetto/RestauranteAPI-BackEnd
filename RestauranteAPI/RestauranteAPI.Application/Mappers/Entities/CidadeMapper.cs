using AutoMapper;
using RestauranteAPI.Application.DTOs.Entities.Request;
using RestauranteAPI.Application.DTOs.Entities.Response;
using RestauranteAPI.Application.DTOs.Common;
using RestauranteAPI.Application.UseCase.Entities.CidadeCase.Create;
using RestauranteAPI.Application.UseCase.Entities.CidadeCase.Delete;
using RestauranteAPI.Application.UseCase.Entities.CidadeCase.GetById;
using RestauranteAPI.Application.UseCase.Entities.CidadeCase.Update;
using RestauranteAPI.Domain.Entities;

namespace RestauranteAPI.Application.Mappers.Entities
{
    //Profile é uma entidade do AutoMapper que será responsável pelo auto mapeamento
    public class CidadeMapper : Profile
    {
        public CidadeMapper()
        {
            #region Entidade para DTO's
            /*Mapeando Cidade Para CidadeRequest e CidadeResponse
            * O método ReverseMap() garante que o mapeamento
            * seja tanto de entidade para request ou response quando de request ou response para entidade */
            CreateMap<Cidade, CidadeResponseDTO>().ReverseMap(); 
            CreateMap<Cidade, CidadeRequestDTO>().ReverseMap();

            #endregion

            #region Entidade para Commads de Caso de Uso
            // Mapeia a entidade Cidade para comandos de criação, atualização, obtenção por ID e deleção.
            CreateMap<Cidade, CreateCidadeCommand>().ReverseMap();
            CreateMap<Cidade, UpdateCidadeCommand>().ReverseMap();
            CreateMap<Cidade, GetByIdCidadeCommand>().ReverseMap();
            CreateMap<Cidade, DeleteCidadeCommand>().ReverseMap();
            #endregion

            #region DTO's para Commads de Caso de Uso
            // Mapeia DTOs de requisição para comandos correspondentes.
            CreateMap<CidadeRequestDTO, CreateCidadeCommand>().ReverseMap() ;
            CreateMap<CidadeRequestDTO, UpdateCidadeCommand>().ReverseMap() ;
            CreateMap<CidadeRequestDTO, DeleteCidadeCommand>().ReverseMap();
            #endregion

            #region Conversão para api response
            // Mapeia comandos e DTOs para ApiResponse e vice-versa.
            CreateMap<ApiResponse, CidadeRequestDTO>().ReverseMap();
            CreateMap<ApiResponse, CreateCidadeCommand>().ReverseMap();
            CreateMap<ApiResponse, UpdateCidadeCommand>().ReverseMap();
            CreateMap<ApiResponse, DeleteCidadeCommand>().ReverseMap();
            #endregion
        }
    }
}