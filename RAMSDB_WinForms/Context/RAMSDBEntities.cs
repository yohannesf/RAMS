﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Devart Entity Developer tool using Entity Framework DbContext template.
// Code is generated on: 3/7/2022 4:13:26 PM
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Core;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace RAMSDBModel
{
    public partial class RAMSDBEntities : DbContext
    {
        #region Constructors

        /// <summary>
        /// Initialize a new RAMSDBEntities object.
        /// </summary>
        public RAMSDBEntities() :
                base(@"name=RAMSDBEntitiesConnectionString")
        {
            Configure();
        }

        /// <summary>
        /// Initializes a new RAMSDBEntities object using the connection string found in the 'RAMSDBEntities' section of the application configuration file.
        /// </summary>
        public RAMSDBEntities(string nameOrConnectionString) :
                base(nameOrConnectionString)
        {
            Configure();
        }

        /// <summary>
        /// Initialize a new RAMSDBEntities object.
        /// </summary>
        public RAMSDBEntities(DbConnection existingConnection, bool contextOwnsConnection) :
                base(existingConnection, contextOwnsConnection)
        {
            Configure();
        }

        /// <summary>
        /// Initialize a new RAMSDBEntities object.
        /// </summary>
        public RAMSDBEntities(ObjectContext objectContext, bool dbContextOwnsObjectContext) :
                base(objectContext, dbContextOwnsObjectContext)
        {
            Configure();
        }

        /// <summary>
        /// Initialize a new RAMSDBEntities object.
        /// </summary>
        public RAMSDBEntities(string nameOrConnectionString, DbCompiledModel model) :
                base(nameOrConnectionString, model)
        {
            Configure();
        }

        /// <summary>
        /// Initialize a new RAMSDBEntities object.
        /// </summary>
        public RAMSDBEntities(DbConnection existingConnection, DbCompiledModel model, bool contextOwnsConnection) :
                base(existingConnection, model, contextOwnsConnection)
        {
            Configure();
        }

        private void Configure()
        {
            this.Configuration.AutoDetectChangesEnabled = true;
            this.Configuration.LazyLoadingEnabled = true;
            this.Configuration.ProxyCreationEnabled = true;
            this.Configuration.ValidateOnSaveEnabled = true;
        }


        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminBoundary>()
                .Property(p => p.ObjectID)
                    .HasPrecision(10, 0);
            modelBuilder.Entity<AdminBoundary>()
                .Property(p => p.ShapeLength)
                    .HasPrecision(19, 11);
            modelBuilder.Entity<AdminBoundary>()
                .Property(p => p.ShapeAreaSqKm)
                    .HasPrecision(19, 11);
            modelBuilder.Entity<AdminBoundary>()
                .Property(p => p.Population)
                    .HasPrecision(19, 11);
            modelBuilder.Entity<AdminBoundary>()
                .Property(p => p.RoadDensity)
                    .HasPrecision(19, 11);
            modelBuilder.Entity<AnnualRoadExpenditurePlan>()
                .Property(p => p.SectionLength)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<AnnualRoadExpenditurePlan>()
                .Property(p => p.RoutineMaintenance)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<AnnualRoadExpenditurePlan>()
                .Property(p => p.PeriodicMaintenance)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<AnnualRoadExpenditurePlan>()
                .Property(p => p.Rehabilitation)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<AnnualRoadExpenditurePlan>()
                .Property(p => p.RoadBottleneck)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<AnnualRoadExpenditurePlan>()
                .Property(p => p.StructuralBottleneck)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<AnnualRoadExpenditurePlan>()
                .Property(p => p.Qtr1Plan)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<AnnualRoadExpenditurePlan>()
                .Property(p => p.Qtr1Achievement)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<AnnualRoadExpenditurePlan>()
                .Property(p => p.Qtr2Plan)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<AnnualRoadExpenditurePlan>()
                .Property(p => p.Qtr2Achievement)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<AnnualRoadExpenditurePlan>()
                .Property(p => p.Qtr3Plan)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<AnnualRoadExpenditurePlan>()
                .Property(p => p.Qtr3Achievement)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<AnnualRoadExpenditurePlan>()
                .Property(p => p.Qtr4Plan)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<AnnualRoadExpenditurePlan>()
                .Property(p => p.Qtr4Achievement)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<AnnualRoadWorkPlan>()
                .Property(p => p.SectionLength)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<AnnualRoadWorkPlan>()
                .Property(p => p.RoutineMaintenance)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<AnnualRoadWorkPlan>()
                .Property(p => p.PeriodicMaintenance)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<AnnualRoadWorkPlan>()
                .Property(p => p.Rehabilitation)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<AnnualRoadWorkPlan>()
                .Property(p => p.RoadBottleneck)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<AnnualRoadWorkPlan>()
                .Property(p => p.StructuralBottleneck)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<AnnualRoadWorkPlan>()
                .Property(p => p.Qtr1Plan)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<AnnualRoadWorkPlan>()
                .Property(p => p.Qtr1Achievement)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<AnnualRoadWorkPlan>()
                .Property(p => p.Qtr2Plan)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<AnnualRoadWorkPlan>()
                .Property(p => p.Qtr2Achievement)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<AnnualRoadWorkPlan>()
                .Property(p => p.Qtr3Plan)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<AnnualRoadWorkPlan>()
                .Property(p => p.Qtr3Achievement)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<AnnualRoadWorkPlan>()
                .Property(p => p.Qtr4Plan)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<AnnualRoadWorkPlan>()
                .Property(p => p.Qtr4Achievement)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<ContractPeformancePeriodiMSpotRRehab>()
                .Property(p => p.TotalPaymentToDate)
                    .HasPrecision(8, 2);
            modelBuilder.Entity<ContractPeformanceRoutineMaintenance>()
                .Property(p => p.TimeWorkedMonths)
                    .HasPrecision(8, 2);
            modelBuilder.Entity<ContractPeformanceRoutineMaintenance>()
                .Property(p => p.ToDateWorkerDays)
                    .HasPrecision(8, 2);
            modelBuilder.Entity<ContractPeformanceRoutineMaintenance>()
                .Property(p => p.TotalPaymentToDate)
                    .HasPrecision(8, 2);
            modelBuilder.Entity<ContractPeriodiMSpotRRehab>()
                .Property(p => p.ContractingEngEstimate)
                    .HasPrecision(8, 2);
            modelBuilder.Entity<ContractPeriodiMSpotRRehab>()
                .Property(p => p.ContractPrice)
                    .HasPrecision(8, 2);
            modelBuilder.Entity<ContractPeriodiMSpotRRehab>()
                .Property(p => p.ContractPeriodWeeks)
                    .HasPrecision(8, 2);
            modelBuilder.Entity<ContractRoutineMaintenance>()
                .Property(p => p.SectionLength)
                    .HasPrecision(8, 2);
            modelBuilder.Entity<ContractRoutineMaintenance>()
                .Property(p => p.ContractingEngEstimate)
                    .HasPrecision(8, 2);
            modelBuilder.Entity<ContractRoutineMaintenance>()
                .Property(p => p.ContractPrice)
                    .HasPrecision(8, 2);
            modelBuilder.Entity<ContractRoutineMaintenance>()
                .Property(p => p.AnnualWorkDays)
                    .HasPrecision(8, 2);
            modelBuilder.Entity<ContractRoutineMaintenance>()
                .Property(p => p.RatePerWorkDays)
                    .HasPrecision(8, 2);
            modelBuilder.Entity<CooperativeCentersAlongRoad>()
                .Property(p => p.CategoryMaxPoints)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<CriteriaWeight>()
                .Property(p => p.CriteriaWeightScore)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<EducationCentersAlongRoad>()
                .Property(p => p.CategoryMaxPoints)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<HealthCentersAlongRoad>()
                .Property(p => p.CategoryMaxPoints)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<KebelesVillagesCommunitiesConnected>()
                .Property(p => p.CategoryMaxPoints)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<MarketsConnectByRoad>()
                .Property(p => p.CategoryMaxPoints)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<OfficeSupplyAdminCost>()
                .Property(p => p.UnitPrice)
                    .HasPrecision(8, 2);
            modelBuilder.Entity<OfficeSupplyAdminCost>()
                .Property(p => p.TotalCost)
                    .HasPrecision(8, 2);
            modelBuilder.Entity<OfficeSupplyAdminCost>()
                .Property(p => p.SepMothlyExpense)
                    .HasPrecision(8, 2);
            modelBuilder.Entity<OfficeSupplyAdminCost>()
                .Property(p => p.OctMothlyExpense)
                    .HasPrecision(8, 2);
            modelBuilder.Entity<OfficeSupplyAdminCost>()
                .Property(p => p.NovMothlyExpense)
                    .HasPrecision(8, 2);
            modelBuilder.Entity<OfficeSupplyAdminCost>()
                .Property(p => p.DecMothlyExpense)
                    .HasPrecision(8, 2);
            modelBuilder.Entity<OfficeSupplyAdminCost>()
                .Property(p => p.JanMothlyExpense)
                    .HasPrecision(8, 2);
            modelBuilder.Entity<OfficeSupplyAdminCost>()
                .Property(p => p.FebMothlyExpense)
                    .HasPrecision(8, 2);
            modelBuilder.Entity<OfficeSupplyAdminCost>()
                .Property(p => p.MarMothlyExpense)
                    .HasPrecision(8, 2);
            modelBuilder.Entity<OfficeSupplyAdminCost>()
                .Property(p => p.AprMothlyExpense)
                    .HasPrecision(8, 2);
            modelBuilder.Entity<OfficeSupplyAdminCost>()
                .Property(p => p.MayMothlyExpense)
                    .HasPrecision(8, 2);
            modelBuilder.Entity<OfficeSupplyAdminCost>()
                .Property(p => p.JunMothlyExpense)
                    .HasPrecision(8, 2);
            modelBuilder.Entity<OfficeSupplyAdminCost>()
                .Property(p => p.JulMothlyExpense)
                    .HasPrecision(8, 2);
            modelBuilder.Entity<OfficeSupplyAdminCost>()
                .Property(p => p.AugMothlyExpense)
                    .HasPrecision(8, 2);
            modelBuilder.Entity<OtherProjectsAlongRoad>()
                .Property(p => p.CategoryMaxPoints)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<PavedCarriagewayCracking>()
                .Property(p => p.QtyM2)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<PavedCarriagewayFailure>()
                .Property(p => p.QtyM3)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<PavedCarriagewayPotholes>()
                .Property(p => p.QtyM3)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<PavedCarriagewayRavellingBleeding>()
                .Property(p => p.QtyM2)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<PavedCarriagewayRutting>()
                .Property(p => p.QtyMM)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<PavedRoadConditionSurvey>()
                .Property(p => p.SectionStartM)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<PavedRoadConditionSurvey>()
                .Property(p => p.SectionEndM)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<PavedRoadConditionSurvey>()
                .Property(p => p.SectionLengthM)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<PavedRoadConditionSurvey>()
                .Property(p => p.XBegin)
                    .HasPrecision(18, 8);
            modelBuilder.Entity<PavedRoadConditionSurvey>()
                .Property(p => p.YBegin)
                    .HasPrecision(18, 8);
            modelBuilder.Entity<PavedRoadConditionSurvey>()
                .Property(p => p.XEnd)
                    .HasPrecision(18, 8);
            modelBuilder.Entity<PavedRoadConditionSurvey>()
                .Property(p => p.YEnd)
                    .HasPrecision(18, 8);
            modelBuilder.Entity<PavedRoadSurfaceType>()
                .Property(p => p.Factor)
                    .HasPrecision(5, 2);
            modelBuilder.Entity<PavedRoadUnitCost>()
                .Property(p => p.PavedUnitCost)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<PavedShoulderDeformationScour>()
                .Property(p => p.QtyM3)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<PavedShoulderEdgeDamage>()
                .Property(p => p.QtyM3)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<PavedShoulderEdgeStep>()
                .Property(p => p.QtyM2)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<PavedSideDrainScour>()
                .Property(p => p.QtyM3)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<PavedSideDrainSilt>()
                .Property(p => p.QtyM3)
                    .HasPrecision(18, 4);
            modelBuilder.Entity<PavedTentativeRoadMaintenancePlan>()
                .Property(p => p.Quantity)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<PavedVegetationControl>()
                .Property(p => p.QtyM2)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<RoadAccessoriesFurnitures>()
                .Property(p => p.XCoordinate)
                    .HasPrecision(18, 6);
            modelBuilder.Entity<RoadAccessoriesFurnitures>()
                .Property(p => p.YCoordinate)
                    .HasPrecision(18, 6);
            modelBuilder.Entity<RoadClassification>()
                .Property(p => p.CategoryMaxPoint)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<RoadsCrossingWoredas>()
                .Property(p => p.RoadLengthInKm)
                    .HasPrecision(38, 8);
            modelBuilder.Entity<RoadsGISData>()
                .Property(p => p.RoadLengthInKm)
                    .HasPrecision(38, 8);
            modelBuilder.Entity<RoadsGISData>()
                .Property(p => p.GravelThickness)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<RoadsGISData>()
                .Property(p => p.CarriagewayWidth)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<RoadSurfaceType>()
                .Property(p => p.Factor)
                    .HasPrecision(3, 1);
            modelBuilder.Entity<RoadTraversesFarmland>()
                .Property(p => p.CategoryMaxPoints)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<RoadWorkFunding>()
                .Property(p => p.RoadLength)
                    .HasPrecision(8, 2);
            modelBuilder.Entity<RoadWorkFunding>()
                .Property(p => p.InterventionCostRM)
                    .HasPrecision(8, 2);
            modelBuilder.Entity<RoadWorkFunding>()
                .Property(p => p.InterventionCostPM)
                    .HasPrecision(8, 2);
            modelBuilder.Entity<RoadWorkFunding>()
                .Property(p => p.InterventionCostRehabilitation)
                    .HasPrecision(8, 2);
            modelBuilder.Entity<RoadWorkFunding>()
                .Property(p => p.InterventionCostRoadBottleneck)
                    .HasPrecision(8, 2);
            modelBuilder.Entity<RoadWorkFunding>()
                .Property(p => p.InterventionCostStructureBottleneck)
                    .HasPrecision(8, 2);
            modelBuilder.Entity<RoadWorkFunding>()
                .Property(p => p.YearCost)
                    .HasPrecision(8, 2);
            modelBuilder.Entity<StructuresInventory>()
                .Property(p => p.WidthInMeters)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<StructuresInventory>()
                .Property(p => p.LengthInMeters)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<TradingCentersAlongRoad>()
                .Property(p => p.CateogryMaxPoints)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<TrafficPerDayPoints>()
                .Property(p => p.CateogryMaxPoints)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<TrafficSurvey>()
                .Property(p => p.TrafficCount)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<UnpavedRoadConditionSurvey>()
                .Property(p => p.SectionChainageStartKM)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<UnpavedRoadConditionSurvey>()
                .Property(p => p.SectionChainageEndKM)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<UnpavedRoadConditionSurvey>()
                .Property(p => p.SectionLengthKM)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<UnpavedRoadConditionSurvey>()
                .Property(p => p.XBegin)
                    .HasPrecision(18, 0);
            modelBuilder.Entity<UnpavedRoadConditionSurvey>()
                .Property(p => p.YBegin)
                    .HasPrecision(18, 0);
            modelBuilder.Entity<UnpavedRoadConditionSurvey>()
                .Property(p => p.XEnd)
                    .HasPrecision(18, 0);
            modelBuilder.Entity<UnpavedRoadConditionSurvey>()
                .Property(p => p.YEnd)
                    .HasPrecision(18, 0);
            modelBuilder.Entity<UnpavedRoadConditionSurvey>()
                .Property(p => p.BottleneckSize)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<UnpavedRoadUnitCost>()
                .Property(p => p.UnpavedUnitCost)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<UnpavedTentativeRoadMaintenancePlan>()
                .Property(p => p.Length)
                    .HasPrecision(18, 2);

            CustomizeMapping(modelBuilder);
        }

        partial void CustomizeMapping(DbModelBuilder modelBuilder);

        public virtual DbSet<AdminBoundary> AdminBoundary { get; set; }
        public virtual DbSet<AnnualRoadExpenditurePlan> AnnualRoadExpenditurePlan { get; set; }
        public virtual DbSet<AnnualRoadWorkPlan> AnnualRoadWorkPlan { get; set; }
        public virtual DbSet<Condition> Condition { get; set; }
        public virtual DbSet<ContractPeformancePeriodiMSpotRRehab> ContractPeformancePeriodiMSpotRRehab { get; set; }
        public virtual DbSet<ContractPeformanceRoutineMaintenance> ContractPeformanceRoutineMaintenance { get; set; }
        public virtual DbSet<ContractPeriodiMSpotRRehab> ContractPeriodiMSpotRRehab { get; set; }
        public virtual DbSet<ContractRoutineMaintenance> ContractRoutineMaintenance { get; set; }
        public virtual DbSet<CooperativeCentersAlongRoad> CooperativeCentersAlongRoad { get; set; }
        public virtual DbSet<CriteriaWeight> CriteriaWeight { get; set; }
        public virtual DbSet<EducationCentersAlongRoad> EducationCentersAlongRoad { get; set; }
        public virtual DbSet<HealthCentersAlongRoad> HealthCentersAlongRoad { get; set; }
        public virtual DbSet<KebelesVillagesCommunitiesConnected> KebelesVillagesCommunitiesConnected { get; set; }
        public virtual DbSet<MaintenanceBranch> MaintenanceBranch { get; set; }
        public virtual DbSet<MarketsConnectByRoad> MarketsConnectByRoad { get; set; }
        public virtual DbSet<MultiCriteriaAnalysisData> MultiCriteriaAnalysisData { get; set; }
        public virtual DbSet<OfficeSupplyAdminCost> OfficeSupplyAdminCost { get; set; }
        public virtual DbSet<OtherProjectsAlongRoad> OtherProjectsAlongRoad { get; set; }
        public virtual DbSet<PavedCarriagewayCracking> PavedCarriagewayCracking { get; set; }
        public virtual DbSet<PavedCarriagewayFailure> PavedCarriagewayFailure { get; set; }
        public virtual DbSet<PavedCarriagewayPotholes> PavedCarriagewayPotholes { get; set; }
        public virtual DbSet<PavedCarriagewayRavellingBleeding> PavedCarriagewayRavellingBleeding { get; set; }
        public virtual DbSet<PavedCarriagewayRutting> PavedCarriagewayRutting { get; set; }
        public virtual DbSet<PavedCategoryofWork> PavedCategoryofWork { get; set; }
        public virtual DbSet<PavedOverallCondition> PavedOverallCondition { get; set; }
        public virtual DbSet<PavedRoadConditionSurvey> PavedRoadConditionSurvey { get; set; }
        public virtual DbSet<PavedRoadSurfaceType> PavedRoadSurfaceType { get; set; }
        public virtual DbSet<PavedRoadUnitCost> PavedRoadUnitCost { get; set; }
        public virtual DbSet<PavedShoulderDeformationScour> PavedShoulderDeformationScour { get; set; }
        public virtual DbSet<PavedShoulderEdgeDamage> PavedShoulderEdgeDamage { get; set; }
        public virtual DbSet<PavedShoulderEdgeStep> PavedShoulderEdgeStep { get; set; }
        public virtual DbSet<PavedSideDrainScour> PavedSideDrainScour { get; set; }
        public virtual DbSet<PavedSideDrainSilt> PavedSideDrainSilt { get; set; }
        public virtual DbSet<PavedTentativeRoadMaintenancePlan> PavedTentativeRoadMaintenancePlan { get; set; }
        public virtual DbSet<PavedVegetationControl> PavedVegetationControl { get; set; }
        public virtual DbSet<PrioritizedRoads> PrioritizedRoads { get; set; }
        public virtual DbSet<RoadAccessoriesFurnitures> RoadAccessoriesFurnitures { get; set; }
        public virtual DbSet<RoadClassification> RoadClassification { get; set; }
        public virtual DbSet<RoadsCrossingWoredas> RoadsCrossingWoredas { get; set; }
        public virtual DbSet<RoadsGISData> RoadsGISData { get; set; }
        public virtual DbSet<RoadsPerUser> RoadsPerUser { get; set; }
        public virtual DbSet<RoadSurfaceType> RoadSurfaceType { get; set; }
        public virtual DbSet<RoadTraversesFarmland> RoadTraversesFarmland { get; set; }
        public virtual DbSet<RoadTypePavedUnpaved> RoadTypePavedUnpaved { get; set; }
        public virtual DbSet<RoadWorkFunding> RoadWorkFunding { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<ShapesCollection> ShapesCollection { get; set; }
        public virtual DbSet<StructureConditionSurvey> StructureConditionSurvey { get; set; }
        public virtual DbSet<StructuresInventory> StructuresInventory { get; set; }
        public virtual DbSet<TradingCentersAlongRoad> TradingCentersAlongRoad { get; set; }
        public virtual DbSet<TrafficCountHour> TrafficCountHour { get; set; }
        public virtual DbSet<TrafficPerDayPoints> TrafficPerDayPoints { get; set; }
        public virtual DbSet<TrafficSurvey> TrafficSurvey { get; set; }
        public virtual DbSet<UnpavedCategoryofWork> UnpavedCategoryofWork { get; set; }
        public virtual DbSet<UnpavedRoadConditionSurvey> UnpavedRoadConditionSurvey { get; set; }
        public virtual DbSet<UnpavedRoadUnitCost> UnpavedRoadUnitCost { get; set; }
        public virtual DbSet<UnpavedTentativeRoadMaintenancePlan> UnpavedTentativeRoadMaintenancePlan { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<VehicleType> VehicleType { get; set; }
        public virtual DbSet<YearConditionSurveyConducted> YearConditionSurveyConducted { get; set; }
    }
}
