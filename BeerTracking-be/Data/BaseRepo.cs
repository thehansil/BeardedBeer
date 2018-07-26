using System;
using System.Collections.Generic;
using System.Text;
using MongoCrud.Domain;
using MongoDB.Driver;

namespace MongoCrud.Data
{
    public class BaseRepo<TEntityType> where TEntityType : IBaseEntity
    {
        private MongoClient mongoClient;
        private IMongoDatabase mongoDb;
        private IMongoCollection<TEntityType> collection;

        public BaseRepo(string collectionId)
        {
            mongoClient = new MongoClient("mongodb://localhost:27017/");
            mongoDb = mongoClient.GetDatabase("brewery-data");
            collection = mongoDb.GetCollection<TEntityType>(collectionId);
        }

        public void DeleteRecord(TEntityType entity)
        {
            DeleteRecord(entity.Id);
        }

        public void DeleteRecord(Guid id)
        {
            collection.DeleteOne(a => a.Id == id);
        }

        public void UpdateRecord(TEntityType entity)
        {
            collection.FindOneAndReplace(a => a.Id == entity.Id, entity);
        }

        public TEntityType RetrieveRecord(Guid entityId)
        {
            return collection.Find(a => a.Id == entityId).First();
        }

        public void InsertRecord(TEntityType entity)
        {
            collection.InsertOne(entity);
        }
        public List<TEntityType> ListAll()
        {
            return collection.Find(a => true).ToList();

        }
    }
}
