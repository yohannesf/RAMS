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
using System.Collections.Generic;

namespace RAMSDB.Interface
{
    public partial interface IRoadAccessoriesFurnituresRepository : IRepository<RAMSDBModel.RoadAccessoriesFurnitures>
    {
        ICollection<RAMSDBModel.RoadAccessoriesFurnitures> GetAll();
        RAMSDBModel.RoadAccessoriesFurnitures GetByKey(int _ID);
    }
}
