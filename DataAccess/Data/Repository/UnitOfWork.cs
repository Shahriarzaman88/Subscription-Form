using DataAccess.Data.Repository.IRepository;
using Subscription_Form.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Data.Repository
{
    public class UnitOfWork : IUnitofWork
    {
        private readonly ApplicationDbContext _db;

        public UnitOfWork (ApplicationDbContext db)
        {
            _db = db;
            Subscription = new SubscriptionRepository(_db);
        }
        public ISubscriptionRespository Subscription { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
