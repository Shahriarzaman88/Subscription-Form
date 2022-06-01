using DataAccess.Data.Repository.IRepository;
using Models;
using Subscription_Form.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Data.Repository
{
    public class SubscriptionRepository : Repository<Subscription>, ISubscriptionRespository
    {
        private readonly ApplicationDbContext _db;

        public SubscriptionRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Subscription subscription)
        {
            var objfromDb = _db.Subscription.FirstOrDefault(s => s.Id == subscription.Id);
            objfromDb.FirstName = subscription.FirstName;
            objfromDb.LastName = subscription.LastName;
            objfromDb.Email = subscription.Email;
            objfromDb.Company = subscription.Company;

            _db.SaveChanges();
        }
        
    }
}
