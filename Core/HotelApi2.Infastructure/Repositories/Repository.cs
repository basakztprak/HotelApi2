using HotelApi2.Domain.Entities.Common;
using HotelApi2.Domain.Repositories;
using HotelApi2.Infastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HotelApi2.Infastructure.Repositories
{
    public class Repository<T> : IReadRepository<T>, IWriteRepository<T> where T : BaseEntity
    {
        protected readonly MyDbContext _context;

        public Repository(MyDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();


        public IQueryable<T> GetAll()
        => Table;

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method)
        => Table.Where(method);

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method)
        => await Table.FirstOrDefaultAsync(method);

        public async Task<T> GetByIdAsync(int id)
        => await Table.FirstOrDefaultAsync(data => data.Id == id);

        public async Task<bool> AddAsync(T model)
        {
            await _context.Set<T>().AddAsync(model);
            var saved = await _context.SaveChangesAsync();
            return saved > 0;
        }

        public async Task<bool> AddRangeAsync(List<T> datas)
        {
            await _context.Set<T>().AddRangeAsync(datas);
            var saved = await _context.SaveChangesAsync();
            return saved > 0;
        }

        public bool RemoveRange(List<T> datas)
        {
            _context.Set<T>().RemoveRange(datas);
            var saved = _context.SaveChanges();
            return saved > 0;
        }

        public bool Remove(T model)
        {
            _context.Set<T>().Remove(model);
            var saved = _context.SaveChanges();
            return saved > 0;
        }

        public async Task<bool> RemoveAsync(int id)
        {
            var model = await Table.FirstOrDefaultAsync(data => data.Id == id);
            return Remove(model);
        }
        public bool Update(T model)
        {
            _context.Set<T>().Update(model);
            var saved = _context.SaveChangesAsync();
            return true;
        }

    }
}
