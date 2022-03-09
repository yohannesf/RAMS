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
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace RAMSDBModel
{
    [System.ComponentModel.DataAnnotations.Schema.Table("HealthCentersAlongRoad", Schema = "dbo")]
    public partial class HealthCentersAlongRoad : INotifyPropertyChanged
    {

        public HealthCentersAlongRoad()
        {
            this.MultiCriteriaAnalysisDatas = new ObservableListSource<MultiCriteriaAnalysisData>();
            OnCreated();
        }

        #region Properties

        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "int", Order = 0)]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public virtual int HealthCentersAlongRoadID
        {
            get
            {
                return _HealthCentersAlongRoadID;
            }
            set
            {
                if (_HealthCentersAlongRoadID != value)
                {
                    _HealthCentersAlongRoadID = value;
                    OnPropertyChanged("HealthCentersAlongRoadID");
                }
            }
        }
        private int _HealthCentersAlongRoadID;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "varchar", Order = 1)]
        public virtual string HealthCentersAlongRoadDescription
        {
            get
            {
                return _HealthCentersAlongRoadDescription;
            }
            set
            {
                if (_HealthCentersAlongRoadDescription != value)
                {
                    _HealthCentersAlongRoadDescription = value;
                    OnPropertyChanged("HealthCentersAlongRoadDescription");
                }
            }
        }
        private string _HealthCentersAlongRoadDescription;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "numeric", Order = 2)]
        public virtual decimal? CategoryMaxPoints
        {
            get
            {
                return _CategoryMaxPoints;
            }
            set
            {
                if (_CategoryMaxPoints != value)
                {
                    _CategoryMaxPoints = value;
                    OnPropertyChanged("CategoryMaxPoints");
                }
            }
        }
        private decimal? _CategoryMaxPoints;

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "int", Order = 3)]
        public virtual int CriteriaWeightID
        {
            get
            {
                return _CriteriaWeightID;
            }
            set
            {
                if (_CriteriaWeightID != value)
                {
                    _CriteriaWeightID = value;
                    OnPropertyChanged("CriteriaWeightID");
                }
            }
        }
        private int _CriteriaWeightID;

        #endregion

        #region Navigation Properties

        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("CriteriaWeightID")]
        [System.ComponentModel.DataAnnotations.Schema.InverseProperty("HealthCentersAlongRoads")]
        public virtual CriteriaWeight CriteriaWeight
        {
            get
            {
                return _CriteriaWeight;
            }
            set
            {
                if (_CriteriaWeight != value)
                {
                    _CriteriaWeight = value;
                    OnPropertyChanged("CriteriaWeight");
                }
            }
        }
        private CriteriaWeight _CriteriaWeight;
        [System.ComponentModel.DataAnnotations.Schema.InverseProperty("HealthCentersAlongRoad")]
        public virtual ObservableListSource<MultiCriteriaAnalysisData> MultiCriteriaAnalysisDatas { get; set; }

        #endregion

        #region Extensibility Method Definitions

        partial void OnCreated();

        #endregion

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName) {

          if (PropertyChanged != null)
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }

}
