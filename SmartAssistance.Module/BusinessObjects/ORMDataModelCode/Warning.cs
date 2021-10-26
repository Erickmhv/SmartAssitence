using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using static SmartAssistance.Module.Utils.Util;
using DevExpress.ExpressApp.DC;

namespace SmartAssistance.Module.BusinessObjects.Prueba22
{
    [XafDefaultProperty(nameof(Oid))]
    public partial class Warning
    {
        public Warning(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        public Shift EnumShift { get; set; }
        public TipoWarning EnumTipoWarning { get; set; }
        public RazonWarning EnumRazonWarning { get; set; }
    }
}
