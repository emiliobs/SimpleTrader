using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SimpleTrade.Domain.Models;
using SimpleTrade.Domain.Services;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace SimpleTrader.EntityFramework.Services
{
    public class GenericDataService<T> : IDataService<T> where T : DomainObject
    {
        private readonly SimpleTraderDbContexfactory _contexfactory;
       
        public GenericDataService(SimpleTraderDbContexfactory contexfactory)
        {
            _contexfactory = contexfactory;
            
        }

        public async Task<T> Create(T entity)
        {
            var context = _contexfactory.CreateDbContext();
            var createEntity = await context.Set<T>().AddAsync(entity);
            await context.SaveChangesAsync();
            return createEntity.Entity;
        }
        //public async Task<T> Create(T entity)
        //{
        //    using (SimpleTraderDbContext context = _contexfactory.CreateDbContext())
        //    {
        //        EntityEntry<T> createdEntity = await context.Set<T>().AddAsync(entity);
        //        await context.SaveChangesAsync();

        //        return createdEntity.Entity;
        //    }
        //}

        public async Task<bool> Delete(int id)
        {
            using SimpleTraderDbContext context = _contexfactory.CreateDbContext();
            T deleteEntity = await context.Set<T>().FirstOrDefaultAsync((e) => e.Id == id);
            context.Set<T>().Remove(deleteEntity);
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            using (SimpleTraderDbContext context = _contexfactory.CreateDbContext())
            {
                return await context.Set<T>().ToListAsync();

            }
        }

        public async Task<T> GetById(int id)
        {
            using (SimpleTraderDbContext context = _contexfactory.CreateDbContext())
            {
                return await context.Set<T>().FirstOrDefaultAsync((e) => e.Id == id);

            }
        }

        public async Task<T> Update(int id, T entity)
        {
            using (SimpleTraderDbContext context = _contexfactory.CreateDbContext())
            {
                entity.Id = id;
                context.Set<T>().Update(entity);
                await context.SaveChangesAsync();
                return entity;
            }
        }

       
    }
}
