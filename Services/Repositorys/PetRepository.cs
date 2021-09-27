using AdotePet.Mvc.Services.Interfaces;
using APet.App.Data;
using APet.App.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdotePet.Mvc.Services.Repositorys
{
    public class PetRepository : IPet<Pet>, IPetRepository
    {

        protected readonly ApplicationDbContext Db;



        public PetRepository(ApplicationDbContext db)
        {
            Db = db;

        }

        public async Task Adicionar(Pet entity)
        {
            Db.Add(entity);
            await SaveChanges();
        }

        public async Task Atualizar(Pet entity)
        {
            Db.Update(entity);
            await SaveChanges();
        }

        public void Dispose()
        {
            Db?.Dispose();
        }

        public async Task<Pet> MostrarPorId(int id)
        {
            return await Db.Pets.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<List<Pet>> MostrarTodos()
        {
            return await Db.Pets.AsNoTracking().ToListAsync();
        }

        public async Task Remover(int id)
        {
            Db.Remove(new Pet { Id = id });
            await SaveChanges();
        }

        public async Task<int> SaveChanges()
        {
            return await Db.SaveChangesAsync();
        }
    }
}
