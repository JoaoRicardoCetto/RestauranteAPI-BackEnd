﻿using RestauranteAPI.Domain.Entities;
using RestauranteAPI.Domain.Enums;
using RestauranteAPI.Domain.Interfaces.Entities;
using RestauranteAPI.Infrastructure.Context;
using RestauranteAPI.Infrastructure.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace RestauranteAPI.Infrastructure.Repositories.Entities
{
    // Repositório responsável por operações relacionadas à entidade Cidade.
    public class CidadeRepository : BaseRepository<Cidade>, ICidadeRepository
    {
        public CidadeRepository(AppDbContext context) : base(context) { }

    }
}
