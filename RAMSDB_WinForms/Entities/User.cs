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
    [System.ComponentModel.DataAnnotations.Schema.Table("User", Schema = "dbo")]
    public partial class User : INotifyPropertyChanged
    {

        public User()
        {
            this.PavedRoadConditionSurveys = new ObservableListSource<PavedRoadConditionSurvey>();
            this.RoadsPerUsers = new ObservableListSource<RoadsPerUser>();
            this.UserRoles = new ObservableListSource<UserRole>();
            OnCreated();
        }

        #region Properties

        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "uniqueidentifier", Order = 0)]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
        public virtual global::System.Guid UserID
        {
            get
            {
                return _UserID;
            }
            set
            {
                if (_UserID != value)
                {
                    _UserID = value;
                    OnPropertyChanged("UserID");
                }
            }
        }
        private global::System.Guid _UserID;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "varchar", Order = 1)]
        public virtual string FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                if (_FirstName != value)
                {
                    _FirstName = value;
                    OnPropertyChanged("FirstName");
                }
            }
        }
        private string _FirstName;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "varchar", Order = 2)]
        public virtual string LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                if (_LastName != value)
                {
                    _LastName = value;
                    OnPropertyChanged("LastName");
                }
            }
        }
        private string _LastName;

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "varchar", Order = 3)]
        public virtual string UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                if (_UserName != value)
                {
                    _UserName = value;
                    OnPropertyChanged("UserName");
                }
            }
        }
        private string _UserName;

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "varchar", Order = 4)]
        public virtual string Password
        {
            get
            {
                return _Password;
            }
            set
            {
                if (_Password != value)
                {
                    _Password = value;
                    OnPropertyChanged("Password");
                }
            }
        }
        private string _Password;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "varchar", Order = 5)]
        public virtual string PhoneNumber
        {
            get
            {
                return _PhoneNumber;
            }
            set
            {
                if (_PhoneNumber != value)
                {
                    _PhoneNumber = value;
                    OnPropertyChanged("PhoneNumber");
                }
            }
        }
        private string _PhoneNumber;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "varchar", Order = 6)]
        public virtual string EmailAddress
        {
            get
            {
                return _EmailAddress;
            }
            set
            {
                if (_EmailAddress != value)
                {
                    _EmailAddress = value;
                    OnPropertyChanged("EmailAddress");
                }
            }
        }
        private string _EmailAddress;

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "bit", Order = 7)]
        public virtual bool IsActive
        {
            get
            {
                return _IsActive;
            }
            set
            {
                if (_IsActive != value)
                {
                    _IsActive = value;
                    OnPropertyChanged("IsActive");
                }
            }
        }
        private bool _IsActive;

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "datetime", Order = 8)]
        public virtual global::System.DateTime CreatedDate
        {
            get
            {
                return _CreatedDate;
            }
            set
            {
                if (_CreatedDate != value)
                {
                    _CreatedDate = value;
                    OnPropertyChanged("CreatedDate");
                }
            }
        }
        private global::System.DateTime _CreatedDate;

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "datetime", Order = 9)]
        public virtual global::System.DateTime ModifiedDate
        {
            get
            {
                return _ModifiedDate;
            }
            set
            {
                if (_ModifiedDate != value)
                {
                    _ModifiedDate = value;
                    OnPropertyChanged("ModifiedDate");
                }
            }
        }
        private global::System.DateTime _ModifiedDate;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "varchar", Order = 10)]
        public virtual string ModifiedBy
        {
            get
            {
                return _ModifiedBy;
            }
            set
            {
                if (_ModifiedBy != value)
                {
                    _ModifiedBy = value;
                    OnPropertyChanged("ModifiedBy");
                }
            }
        }
        private string _ModifiedBy;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "int", Order = 11)]
        public virtual int? RoleID
        {
            get
            {
                return _RoleID;
            }
            set
            {
                if (_RoleID != value)
                {
                    _RoleID = value;
                    OnPropertyChanged("RoleID");
                }
            }
        }
        private int? _RoleID;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "varchar", Order = 12)]
        public virtual string Region
        {
            get
            {
                return _Region;
            }
            set
            {
                if (_Region != value)
                {
                    _Region = value;
                    OnPropertyChanged("Region");
                }
            }
        }
        private string _Region;

       // [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "varchar", Order = 13)]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed)]
        public virtual string FullName
        {
            get
            {
                return _FullName;
            }
            set
            {
                if (_FullName != value)
                {
                    _FullName = value;
                    OnPropertyChanged("FullName");
                }
            }
        }
        private string _FullName;

        #endregion

        #region Navigation Properties

        [System.ComponentModel.DataAnnotations.Schema.InverseProperty("User")]
        public virtual ObservableListSource<PavedRoadConditionSurvey> PavedRoadConditionSurveys { get; set; }
        [System.ComponentModel.DataAnnotations.Schema.InverseProperty("User")]
        public virtual ObservableListSource<RoadsPerUser> RoadsPerUsers { get; set; }
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("RoleID")]
        [System.ComponentModel.DataAnnotations.Schema.InverseProperty("Users")]
        public virtual Role Role
        {
            get
            {
                return _Role;
            }
            set
            {
                if (_Role != value)
                {
                    _Role = value;
                    OnPropertyChanged("Role");
                }
            }
        }
        private Role _Role;
        [System.ComponentModel.DataAnnotations.Schema.InverseProperty("User")]
        public virtual ObservableListSource<UserRole> UserRoles { get; set; }

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
