using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using MongoCrud.Data;
using MongoCrud.Domain;

namespace BeerTracking_be.Application
{
    public class BaseManager<TType> where TType : IBaseEntity
    {
        private readonly BaseRepo<TType> repo;

        public BaseManager(BaseRepo<TType> repo)
        {
            this.repo = repo;
        }

        public void Delete(Guid id)
        {
            repo.DeleteRecord(id);
        }

        public void Update(TType entity)
        {
            repo.UpdateRecord(entity);
        }

        public TType Get(Guid entityId)
        {
            return repo.RetrieveRecord(entityId);
        }

        public void Create(TType entity)
        {
            repo.InsertRecord(entity);
        }
    }
}
