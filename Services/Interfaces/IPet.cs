using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdotePet.Mvc.Services.Interfaces
{
    public interface IPet<T> : IDisposable
    {
        Task<List<T>> MostrarTodos();

        Task<T> MostrarPorId(int id);

        Task Adicionar(T entity);

        Task Atualizar(T entity);

        Task Remover(int id);

        Task<int> SaveChanges();
    }
}
