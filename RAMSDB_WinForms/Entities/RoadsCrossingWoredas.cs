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
    [System.ComponentModel.DataAnnotations.Schema.Table("RoadsCrossingWoredas", Schema = "dbo")]
    public partial class RoadsCrossingWoredas : INotifyPropertyChanged
    {

        public RoadsCrossingWoredas()
        {
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

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "int", Order = 1)]
        public virtual int? RoadID
        {
            get
            {
                return _RoadID;
            }
            set
            {
                if (_RoadID != value)
                {
                    _RoadID = value;
                    OnPropertyChanged("RoadID");
                }
            }
        }
        private int? _RoadID;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "int", Order = 2)]
        public virtual int? AdminID
        {
            get
            {
                return _AdminID;
            }
            set
            {
                if (_AdminID != value)
                {
                    _AdminID = value;
                    OnPropertyChanged("AdminID");
                }
            }
        }
        private int? _AdminID;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "numeric", Order = 3)]
        public virtual decimal? RoadLengthInKm
        {
            get
            {
                return _RoadLengthInKm;
            }
            set
            {
                if (_RoadLengthInKm != value)
                {
                    _RoadLengthInKm = value;
                    OnPropertyChanged("RoadLengthInKm");
                }
            }
        }
        private decimal? _RoadLengthInKm;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "nvarchar", Order = 4)]
        public virtual string RoadIdentifier
        {
            get
            {
                return _RoadIdentifier;
            }
            set
            {
                if (_RoadIdentifier != value)
                {
                    _RoadIdentifier = value;
                    OnPropertyChanged("RoadIdentifier");
                }
            }
        }
        private string _RoadIdentifier;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "nvarchar", Order = 5)]
        public virtual string RoadOriginDestination
        {
            get
            {
                return _RoadOriginDestination;
            }
            set
            {
                if (_RoadOriginDestination != value)
                {
                    _RoadOriginDestination = value;
                    OnPropertyChanged("RoadOriginDestination");
                }
            }
        }
        private string _RoadOriginDestination;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "nvarchar", Order = 6)]
        public virtual string RoadClassificationDescription
        {
            get
            {
                return _RoadClassificationDescription;
            }
            set
            {
                if (_RoadClassificationDescription != value)
                {
                    _RoadClassificationDescription = value;
                    OnPropertyChanged("RoadClassificationDescription");
                }
            }
        }
        private string _RoadClassificationDescription;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "varchar", Order = 7)]
        public virtual string RoadType
        {
            get
            {
                return _RoadType;
            }
            set
            {
                if (_RoadType != value)
                {
                    _RoadType = value;
                    OnPropertyChanged("RoadType");
                }
            }
        }
        private string _RoadType;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "varchar", Order = 8)]
        public virtual string SurfaceTypeName
        {
            get
            {
                return _SurfaceTypeName;
            }
            set
            {
                if (_SurfaceTypeName != value)
                {
                    _SurfaceTypeName = value;
                    OnPropertyChanged("SurfaceTypeName");
                }
            }
        }
        private string _SurfaceTypeName;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "varchar", Order = 9)]
        public virtual string ZoneName
        {
            get
            {
                return _ZoneName;
            }
            set
            {
                if (_ZoneName != value)
                {
                    _ZoneName = value;
                    OnPropertyChanged("ZoneName");
                }
            }
        }
        private string _ZoneName;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "varchar", Order = 10)]
        public virtual string ZoneCode
        {
            get
            {
                return _ZoneCode;
            }
            set
            {
                if (_ZoneCode != value)
                {
                    _ZoneCode = value;
                    OnPropertyChanged("ZoneCode");
                }
            }
        }
        private string _ZoneCode;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "varchar", Order = 11)]
        public virtual string WoredaName
        {
            get
            {
                return _WoredaName;
            }
            set
            {
                if (_WoredaName != value)
                {
                    _WoredaName = value;
                    OnPropertyChanged("WoredaName");
                }
            }
        }
        private string _WoredaName;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "varchar", Order = 12)]
        public virtual string WoredaCode
        {
            get
            {
                return _WoredaCode;
            }
            set
            {
                if (_WoredaCode != value)
                {
                    _WoredaCode = value;
                    OnPropertyChanged("WoredaCode");
                }
            }
        }
        private string _WoredaCode;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "varchar", Order = 13)]
        public virtual string RegionName
        {
            get
            {
                return _RegionName;
            }
            set
            {
                if (_RegionName != value)
                {
                    _RegionName = value;
                    OnPropertyChanged("RegionName");
                }
            }
        }
        private string _RegionName;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "varchar", Order = 14)]
        public virtual string RegionCode
        {
            get
            {
                return _RegionCode;
            }
            set
            {
                if (_RegionCode != value)
                {
                    _RegionCode = value;
                    OnPropertyChanged("RegionCode");
                }
            }
        }
        private string _RegionCode;

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
