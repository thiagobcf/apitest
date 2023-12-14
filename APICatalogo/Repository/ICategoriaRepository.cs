using APICatalogo.Models;
using APICatalogo.pagination;
using System.Collections.Generic;

namespace APICatalogo.Repository
{
    public interface ICategoriaRepository : IRepository<Categoria>
    {
        PagedList<Categoria> GetCategorias(CategoriasParameters categoriasParameters);
        IEnumerable<Categoria> GetCategoriasProdutos();
    }
}
