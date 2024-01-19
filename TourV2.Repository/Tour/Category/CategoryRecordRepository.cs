﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourV2.Common.GenericRespository;
using TourV2.Common.UnitOfWork;
using TourV2.Data;
using TourV2.Domain;

namespace TourV2.Repository
{
    public class CategoryRecordRepository: GenericRepository<CategoryRecord, TourContext>,
        ICategoryRecordRepository
    {
        public CategoryRecordRepository(
         IUnitOfWork<TourContext> uow
         ) : base(uow)
        {
        }
    }
}