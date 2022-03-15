﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Devart Entity Developer tool using Entity Framework DbContext template.
// Code is generated on: 3/9/2022 2:28:37 PM
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
    [System.ComponentModel.DataAnnotations.Schema.Table("PavedShoulderDeformationScour", Schema = "dbo")]
    public partial class PavedShoulderDeformationScour : INotifyPropertyChanged
    {

        public PavedShoulderDeformationScour()
        {
            this.PavedRoadConditionSurveys_LeftShoulderDeformationScour = new ObservableListSource<PavedRoadConditionSurvey>();
            this.PavedRoadConditionSurveys_RightShoulderDeformationScour = new ObservableListSource<PavedRoadConditionSurvey>();
            OnCreated();
        }

        #region Properties

        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "int", Order = 0)]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public virtual int ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    _ID = value;
                    OnPropertyChanged("ID");
                }
            }
        }
        private int _ID;

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "int", Order = 1)]
        public virtual int ShoulderDeformationScourRate
        {
            get
            {
                return _ShoulderDeformationScourRate;
            }
            set
            {
                if (_ShoulderDeformationScourRate != value)
                {
                    _ShoulderDeformationScourRate = value;
                    OnPropertyChanged("ShoulderDeformationScourRate");
                }
            }
        }
        private int _ShoulderDeformationScourRate;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "text", Order = 2)]
        public virtual string Defect
        {
            get
            {
                return _Defect;
            }
            set
            {
                if (_Defect != value)
                {
                    _Defect = value;
                    OnPropertyChanged("Defect");
                }
            }
        }
        private string _Defect;

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "numeric", Order = 3)]
        public virtual decimal QtyM3
        {
            get
            {
                return _QtyM3;
            }
            set
            {
                if (_QtyM3 != value)
                {
                    _QtyM3 = value;
                    OnPropertyChanged("QtyM3");
                }
            }
        }
        private decimal _QtyM3;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "varchar", Order = 4)]
        public virtual string ActivityCode
        {
            get
            {
                return _ActivityCode;
            }
            set
            {
                if (_ActivityCode != value)
                {
                    _ActivityCode = value;
                    OnPropertyChanged("ActivityCode");
                }
            }
        }
        private string _ActivityCode;

        #endregion

        #region Navigation Properties

        [System.ComponentModel.DataAnnotations.Schema.InverseProperty("PavedShoulderDeformationScour_LeftShoulderDeformationScour")]
        public virtual ObservableListSource<PavedRoadConditionSurvey> PavedRoadConditionSurveys_LeftShoulderDeformationScour { get; set; }
        [System.ComponentModel.DataAnnotations.Schema.InverseProperty("PavedShoulderDeformationScour_RightShoulderDeformationScour")]
        public virtual ObservableListSource<PavedRoadConditionSurvey> PavedRoadConditionSurveys_RightShoulderDeformationScour { get; set; }

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
