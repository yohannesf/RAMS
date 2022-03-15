﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using the template for generating Repositories and a Unit of Work for Entity Framework model.
// Code is generated on: 3/9/2022 2:28:37 PM
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity;
using RAMSDB.Interface;

namespace RAMSDB.Data
{
    public partial class AnnualRoadExpenditurePlanRepository : EntityFrameworkRepository<RAMSDBModel.AnnualRoadExpenditurePlan>, IAnnualRoadExpenditurePlanRepository
    {
        public AnnualRoadExpenditurePlanRepository(RAMSDBModel.RAMSDBEntities context) : base(context)
        {
        }

        public virtual ICollection<RAMSDBModel.AnnualRoadExpenditurePlan> GetAll()
        {
            return objectSet.ToList();
        }

        public virtual RAMSDBModel.AnnualRoadExpenditurePlan GetByKey(int _AnnualExpID)
        {
            return objectSet.SingleOrDefault(e => e.AnnualExpID == _AnnualExpID);
        }

        public new RAMSDBModel.RAMSDBEntities Context 
        {
            get 
            {
                return (RAMSDBModel.RAMSDBEntities)base.Context;
            }
        }
    }
}
