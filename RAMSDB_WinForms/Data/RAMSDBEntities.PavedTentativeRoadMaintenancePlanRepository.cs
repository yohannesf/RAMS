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
    public partial class PavedTentativeRoadMaintenancePlanRepository : EntityFrameworkRepository<RAMSDBModel.PavedTentativeRoadMaintenancePlan>, IPavedTentativeRoadMaintenancePlanRepository
    {
        public PavedTentativeRoadMaintenancePlanRepository(RAMSDBModel.RAMSDBEntities context) : base(context)
        {
        }

        public virtual ICollection<RAMSDBModel.PavedTentativeRoadMaintenancePlan> GetAll()
        {
            return objectSet.ToList();
        }

        public virtual RAMSDBModel.PavedTentativeRoadMaintenancePlan GetByKey(int _PavedTentRMaintPlan)
        {
            return objectSet.SingleOrDefault(e => e.PavedTentRMaintPlan == _PavedTentRMaintPlan);
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
