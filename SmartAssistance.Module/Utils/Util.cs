using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartAssistance.Module.Utils
{
    public class Util
    {
        public enum Shift
        {
            Morning,Afternoon,Night
        };

        public enum Assist
        {
            Empty, Present, Excuse , Late
        };

        public enum TipoWarning
        {
            Verbal,Oral
        };

        public enum RazonWarning
        {
            Late,Absent,Discipline,Spanish
        };
    }
}
