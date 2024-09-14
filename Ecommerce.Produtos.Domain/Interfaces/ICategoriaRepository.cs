﻿using Ecommerce.Produtos.Domain.Entities;

namespace Ecommerce.Produtos.Domain.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<CategoriaEntity> ObterTodos();
        CategoriaEntity? ObterPorId(int id);
        CategoriaEntity? SalvarDados(CategoriaEntity entity);
        CategoriaEntity? EditarDados(CategoriaEntity entity);
        CategoriaEntity? DeletarDados(int id);
    }
}