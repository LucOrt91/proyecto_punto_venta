using punto_venta.Infrastructure.Persistence.Contexts;
using punto_venta.Infrastructure.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_venta.Infrastructure.Persistence.Repositories
{
   
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbPuntoVentaContext _context;
        public ICategoryRepository Category { get; private set; }
        public UnitOfWork(DbPuntoVentaContext context)
        {
            _context = context;
            Category = new CategoryRepository(_context);
        }
        public void Dispose()
        {
            _context.Dispose();
        }

        public void SaveChances()
        {
            _context.SaveChanges();
        }

        public async Task SaveChancesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
