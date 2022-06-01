using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Data.Repository.IRepository
{
    public interface ISubscriptionRespository : IRepository<Subscription>
    {
        void Update (Subscription subscription);

    }
}
