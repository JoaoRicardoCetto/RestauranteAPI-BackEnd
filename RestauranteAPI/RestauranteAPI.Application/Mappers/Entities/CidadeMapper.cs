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
    public class CidadeMapper : Profile
    {
        public CidadeMapper()
        {
            #region Entidade para DTO's
            CreateMap<Cidade, CidadeResponseDTO>().ReverseMap();
            CreateMap<Cidade, CidadeRequestDTO>().ReverseMap();

            #endregion

            #region Entidade para Commads de Caso de Uso
            CreateMap<Cidade, CreateCidadeCommand>().ReverseMap();
            CreateMap<Cidade, UpdateCidadeCommand>().ReverseMap();
            CreateMap<Cidade, GetByIdCidadeCommand>().ReverseMap();
            CreateMap<Cidade, DeleteCidadeCommand>().ReverseMap();
            #endregion

            #region DTO's para Commads de Caso de Uso
            CreateMap<CidadeRequestDTO, CreateCidadeCommand>().ReverseMap() ;
            CreateMap<CidadeRequestDTO, UpdateCidadeCommand>().ReverseMap() ;
            CreateMap<CidadeRequestDTO, DeleteCidadeCommand>().ReverseMap();
            #endregion

            #region Conversão para api response
            CreateMap<ApiResponse, CidadeRequestDTO>().ReverseMap();
            CreateMap<ApiResponse, CreateCidadeCommand>().ReverseMap();
            CreateMap<ApiResponse, UpdateCidadeCommand>().ReverseMap();
            CreateMap<ApiResponse, DeleteCidadeCommand>().ReverseMap();
            #endregion
        }
    }
}