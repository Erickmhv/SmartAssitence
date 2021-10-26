using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using static SmartAssistance.Module.Utils.Util;

namespace SmartAssistance.Module.BusinessObjects.Prueba22
{

    public partial class StudentAssistence
    {
        public StudentAssistence(Session session) : base(session) { }
        public override void AfterConstruction() {base.AfterConstruction();}
        public Assist EnumAssist { get; set; }

    }

}
