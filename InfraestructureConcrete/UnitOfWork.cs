using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure;
using Domain.Utils.Exceptions;

namespace InfraestructureConcrete
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(DbContext context)
        {
            this.Context = context;
        }

        public DbContext Context { get; private set; }

        public void Commit()
        {
            try
            {
                Context.SaveChanges();
            }
            catch(Exception e)
            {
                throw new InfraestrutureSaveException("Invalid operation", e);
            }
        }

        public void Dispose()
        {
            Context.Dispose();
        }

    }
}
