using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.ExpressApp.DC;

namespace SmartAssistance.Module.BusinessObjects.Prueba22
{
    [XafDefaultProperty(nameof(Name))]
    public partial class Module
    {
        public Module(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
