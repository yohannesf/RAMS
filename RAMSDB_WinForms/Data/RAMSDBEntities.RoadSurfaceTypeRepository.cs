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
    public partial class RoadSurfaceTypeRepository : EntityFrameworkRepository<RAMSDBModel.RoadSurfaceType>, IRoadSurfaceTypeRepository
    {
        public RoadSurfaceTypeRepository(RAMSDBModel.RAMSDBEntities context) : base(context)
        {
        }

        public virtual ICollection<RAMSDBModel.RoadSurfaceType> GetAll()
        {
            return objectSet.ToList();
        }

        public virtual RAMSDBModel.RoadSurfaceType GetByKey(int _SurfaceTypeID)
        {
            return objectSet.SingleOrDefault(e => e.SurfaceTypeID == _SurfaceTypeID);
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
