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
using System.Collections.Generic;

namespace RAMSDB.Interface
{
    public partial interface IUnpavedTentativeRoadMaintenancePlanRepository : IRepository<RAMSDBModel.UnpavedTentativeRoadMaintenancePlan>
    {
        ICollection<RAMSDBModel.UnpavedTentativeRoadMaintenancePlan> GetAll();
        RAMSDBModel.UnpavedTentativeRoadMaintenancePlan GetByKey(int _TentRMaintPlan);
    }
}
