using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.ExpressApp.DC;
using static SmartAssistance.Module.Utils.Util;
using DevExpress.ExpressApp.Security.Strategy;
using DevExpress.ExpressApp;
using System.Linq;

namespace SmartAssistance.Module.BusinessObjects.Prueba22
{
    [XafDefaultProperty(nameof(Oid))]
    public partial class Assistence
    {
        public Shift EnumShift { get; set; }
        public SecuritySystemUser Teacher { get; set; }

        public Assistence(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();

            var CurrentUser = Session.GetObjectByKey<SecuritySystemUser>(SecuritySystem.CurrentUserId);

            if (CurrentUser != null)
                Teacher = CurrentUser;

            Date = DateTime.Now;

            var Modulo = new XPQuery<Module>(Session).OrderBy(x => x.Oid).FirstOrDefault();

            if (Modulo != null)
                Module = Modulo;

            EnumShift = Shift.Morning;
        }

        protected override void OnChanged(string propertyName, object oldValue, object newValue)
        {
            if (propertyName == "Module")
            {
                Limpiar();
            }

            if (propertyName == "EnumShift")
            {
                Limpiar();
            }

            base.OnChanged(propertyName, oldValue, newValue);
        }

        protected override void OnSaved()
        {
            LastModifiedDate = DateTime.Now;
            base.OnSaved();
        }

        public void Limpiar()
        {
            Session.Delete(StudentAssistences);

            var Estudiantes = new XPQuery<Student>(Session).Where(x => x.Module == Module && x.Teacher == Teacher && x.EnumShift == EnumShift).ToList();

            foreach (var e in Estudiantes)
            {
                StudentAssistences.Add(new StudentAssistence(Session) { Student = e, Assistence = this });
            }
        }
    }
}