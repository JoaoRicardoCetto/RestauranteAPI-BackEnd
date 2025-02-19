﻿using RestauranteAPI.Domain.Entities;
using RestauranteAPI.Domain.Enums;
using RestauranteAPI.Domain.Interfaces.Entities;
using RestauranteAPI.Infrastructure.Context;
using RestauranteAPI.Infrastructure.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace RestauranteAPI.Infrastructure.Repositories.Entities
{
    // Repositório responsável por operações relacionadas à entidade Pedido.
    public class PedidoRepository : BaseRepository<Pedido>, IPedidoRepository
    {   
        public PedidoRepository(AppDbContext context) : base(context) { }

    }
}
