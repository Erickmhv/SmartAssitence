﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace SmartAssistance.Module.BusinessObjects.Prueba22
{

    public partial class Student : XPObject
    {
        string fFirstName;
        public string FirstName
        {
            get { return fFirstName; }
            set { SetPropertyValue<string>(nameof(FirstName), ref fFirstName, value); }
        }
        string fLastName;
        public string LastName
        {
            get { return fLastName; }
            set { SetPropertyValue<string>(nameof(LastName), ref fLastName, value); }
        }
        string fID;
        public string ID
        {
            get { return fID; }
            set { SetPropertyValue<string>(nameof(ID), ref fID, value); }
        }
        Campus fCampus;
        public Campus Campus
        {
            get { return fCampus; }
            set { SetPropertyValue<Campus>(nameof(Campus), ref fCampus, value); }
        }
        Module fModule;
        public Module Module
        {
            get { return fModule; }
            set { SetPropertyValue<Module>(nameof(Module), ref fModule, value); }
        }
    }

}
