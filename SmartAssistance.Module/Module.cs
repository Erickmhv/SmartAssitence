using System;
using System.Text;
using System.Linq;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using System.Collections.Generic;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.BaseImpl.PermissionPolicy;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Updating;
using DevExpress.ExpressApp.Model.Core;
using DevExpress.ExpressApp.Model.DomainLogics;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.Xpo;
using DevExpress.ExpressApp.ReportsV2;
using SmartAssistance.Module.BusinessObjects.Prueba22;

namespace SmartAssistance.Module {
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppModuleBasetopic.aspx.
    public sealed partial class SmartAssistanceModule : ModuleBase {
        public SmartAssistanceModule() {
            InitializeComponent();
			BaseObject.OidInitializationMode = OidInitializationMode.AfterConstruction;
        }
        public override IEnumerable<ModuleUpdater> GetModuleUpdaters(IObjectSpace objectSpace, Version versionFromDB)
        {
            ModuleUpdater updater = new DatabaseUpdate.Updater(objectSpace, versionFromDB);

            // Agregar los reportes creados por codigo a la lista diponible al runtime
            PredefinedReportsUpdater predefinedReportsUpdater = new PredefinedReportsUpdater(Application, objectSpace, versionFromDB);

            predefinedReportsUpdater.AddPredefinedReport<Reports.HistoricoAssistencia>("Historic Assistence", typeof(StudentAssistence), true);
            predefinedReportsUpdater.AddPredefinedReport<Reports.HistoricoAssistenciaPorEstudiante>("Historic Student Assistence", typeof(StudentAssistence), false);
            predefinedReportsUpdater.AddPredefinedReport<Reports.HistoricoAssistenciaPorProfesor>("Historic Teacher Assistence", typeof(StudentAssistence), false);
            predefinedReportsUpdater.AddPredefinedReport<Reports.HistoricoGeneralAusencia>("Historic Absent", typeof(StudentAssistence), false);
            predefinedReportsUpdater.AddPredefinedReport<Reports.HistoricoWarnings>("Historic Warnings", typeof(Warning), false);
            return new ModuleUpdater[] { updater, predefinedReportsUpdater };
        }
        public override void Setup(XafApplication application) {
            base.Setup(application);
            // Manage various aspects of the application UI and behavior at the module level.
        }
        public override void CustomizeTypesInfo(ITypesInfo typesInfo) {
            base.CustomizeTypesInfo(typesInfo);
            CalculatedPersistentAliasHelper.CustomizeTypesInfo(typesInfo);
        }
    }
}
