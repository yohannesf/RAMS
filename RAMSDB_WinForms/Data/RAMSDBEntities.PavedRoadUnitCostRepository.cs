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
    public partial class PavedRoadUnitCostRepository : EntityFrameworkRepository<RAMSDBModel.PavedRoadUnitCost>, IPavedRoadUnitCostRepository
    {
        public PavedRoadUnitCostRepository(RAMSDBModel.RAMSDBEntities context) : base(context)
        {
        }

        public virtual ICollection<RAMSDBModel.PavedRoadUnitCost> GetAll()
        {
            return objectSet.ToList();
        }

        public virtual RAMSDBModel.PavedRoadUnitCost GetByKey(int _PavedRoadUnitCostID)
        {
            return objectSet.SingleOrDefault(e => e.PavedRoadUnitCostID == _PavedRoadUnitCostID);
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
