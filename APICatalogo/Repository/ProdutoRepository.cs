﻿using APICatalogo.Context;
using APICatalogo.Models;
using APICatalogo.pagination;
using System.Collections.Generic;
using System.Linq;

namespace APICatalogo.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(AppDbContext contexto) : base(contexto)
        {
        }

        public PagedList<Produto> GetProdutos(ProdutosParameters produtosParameters)
        {
            return PagedList<Produto>.ToPageList(Get().OrderBy(on => on.ProdutoId), produtosParameters.PageNumber, produtosParameters.PageSize);
        }

        public IEnumerable<Produto> GetProdutosPorPreco()
        {
            return Get().OrderBy(c => c.Preco).ToList();
        }
    }
}
