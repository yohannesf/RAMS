﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using the template for generating Repositories and a Unit of Work for Entity Framework model.
// Code is generated on: 3/7/2022 4:13:27 PM
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
    public partial class HealthCentersAlongRoadRepository : EntityFrameworkRepository<RAMSDBModel.HealthCentersAlongRoad>, IHealthCentersAlongRoadRepository
    {
        public HealthCentersAlongRoadRepository(RAMSDBModel.RAMSDBEntities context) : base(context)
        {
        }

        public virtual ICollection<RAMSDBModel.HealthCentersAlongRoad> GetAll()
        {
            return objectSet.ToList();
        }

        public virtual RAMSDBModel.HealthCentersAlongRoad GetByKey(int _HealthCentersAlongRoadID)
        {
            return objectSet.SingleOrDefault(e => e.HealthCentersAlongRoadID == _HealthCentersAlongRoadID);
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
