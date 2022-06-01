using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Data.Repository.IRepository
{
    public interface IUnitofWork : IDisposable
    {
        ISubscriptionRespository Subscription { get; }

        void Save();
    }
}
