﻿using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace TourV2.Common.UnitOfWork
{
    public interface IUnitOfWork<TContext>
        where TContext : DbContext
    {
        int Save();
        Task<int> SaveAsync();
        TContext Context { get; }
    }
}
