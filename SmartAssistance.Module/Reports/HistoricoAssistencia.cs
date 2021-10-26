using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace SmartAssistance.Module.Reports
{
    public partial class HistoricoAssistencia : DevExpress.XtraReports.UI.XtraReport
    {
        public HistoricoAssistencia()
        {
            InitializeComponent();
        }

        private void HistoricoAssistencia_ParametersRequestBeforeShow(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            var firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

            DateF.Value = firstDayOfMonth;
            DateU.Value = firstDayOfMonth.AddMonths(1).AddDays(-1);
        }
    }
}
