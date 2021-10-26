using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Security.Strategy;
using static SmartAssistance.Module.Utils.Util;

namespace SmartAssistance.Module.BusinessObjects.Prueba22
{
    [XafDefaultProperty(nameof(FullName))]
    public partial class Student
    {
        public string FullName => FirstName +" "+LastName;
        public Student(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        public Shift EnumShift { get; set; }
        public SecuritySystemUser Teacher { get; set; }
    }

}
