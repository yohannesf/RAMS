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
    [System.ComponentModel.DataAnnotations.Schema.Table("StructureConditionSurvey", Schema = "dbo")]
    public partial class StructureConditionSurvey : INotifyPropertyChanged
    {

        public StructureConditionSurvey()
        {
            OnCreated();
        }

        #region Properties

        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "int", Order = 0)]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public virtual int SCSID
        {
            get
            {
                return _SCSID;
            }
            set
            {
                if (_SCSID != value)
                {
                    _SCSID = value;
                    OnPropertyChanged("SCSID");
                }
            }
        }
        private int _SCSID;

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "int", Order = 1)]
        public virtual int StructureID
        {
            get
            {
                return _StructureID;
            }
            set
            {
                if (_StructureID != value)
                {
                    _StructureID = value;
                    OnPropertyChanged("StructureID");
                }
            }
        }
        private int _StructureID;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "int", Order = 2)]
        public virtual int? StructureCondition
        {
            get
            {
                return _StructureCondition;
            }
            set
            {
                if (_StructureCondition != value)
                {
                    _StructureCondition = value;
                    OnPropertyChanged("StructureCondition");
                }
            }
        }
        private int? _StructureCondition;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "int", Order = 3)]
        public virtual int? RoadFurnitureCondition
        {
            get
            {
                return _RoadFurnitureCondition;
            }
            set
            {
                if (_RoadFurnitureCondition != value)
                {
                    _RoadFurnitureCondition = value;
                    OnPropertyChanged("RoadFurnitureCondition");
                }
            }
        }
        private int? _RoadFurnitureCondition;

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "smallint", Order = 4)]
        public virtual short SCSYear
        {
            get
            {
                return _SCSYear;
            }
            set
            {
                if (_SCSYear != value)
                {
                    _SCSYear = value;
                    OnPropertyChanged("SCSYear");
                }
            }
        }
        private short _SCSYear;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "text", Order = 5)]
        public virtual string Comments
        {
            get
            {
                return _Comments;
            }
            set
            {
                if (_Comments != value)
                {
                    _Comments = value;
                    OnPropertyChanged("Comments");
                }
            }
        }
        private string _Comments;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "nvarchar", Order = 6)]
        public virtual string AssessedBy
        {
            get
            {
                return _AssessedBy;
            }
            set
            {
                if (_AssessedBy != value)
                {
                    _AssessedBy = value;
                    OnPropertyChanged("AssessedBy");
                }
            }
        }
        private string _AssessedBy;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "date", Order = 7)]
        public virtual global::System.DateTime? DateOfAssessment
        {
            get
            {
                return _DateOfAssessment;
            }
            set
            {
                if (_DateOfAssessment != value)
                {
                    _DateOfAssessment = value;
                    OnPropertyChanged("DateOfAssessment");
                }
            }
        }
        private global::System.DateTime? _DateOfAssessment;

        #endregion

        #region Navigation Properties

        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("StructureCondition")]
        [System.ComponentModel.DataAnnotations.Schema.InverseProperty("StructureConditionSurveys_StructureCondition")]
        public virtual Condition Condition_StructureCondition
        {
            get
            {
                return _Condition_StructureCondition;
            }
            set
            {
                if (_Condition_StructureCondition != value)
                {
                    _Condition_StructureCondition = value;
                    OnPropertyChanged("Condition_StructureCondition");
                }
            }
        }
        private Condition _Condition_StructureCondition;
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("RoadFurnitureCondition")]
        [System.ComponentModel.DataAnnotations.Schema.InverseProperty("StructureConditionSurveys_RoadFurnitureCondition")]
        public virtual Condition Condition_RoadFurnitureCondition
        {
            get
            {
                return _Condition_RoadFurnitureCondition;
            }
            set
            {
                if (_Condition_RoadFurnitureCondition != value)
                {
                    _Condition_RoadFurnitureCondition = value;
                    OnPropertyChanged("Condition_RoadFurnitureCondition");
                }
            }
        }
        private Condition _Condition_RoadFurnitureCondition;
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("StructureID")]
        [System.ComponentModel.DataAnnotations.Schema.InverseProperty("StructureConditionSurveys")]
        public virtual StructuresInventory StructuresInventory
        {
            get
            {
                return _StructuresInventory;
            }
            set
            {
                if (_StructuresInventory != value)
                {
                    _StructuresInventory = value;
                    OnPropertyChanged("StructuresInventory");
                }
            }
        }
        private StructuresInventory _StructuresInventory;

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
