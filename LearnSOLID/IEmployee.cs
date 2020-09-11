using System;
using System.Collections.Generic;
using System.Text;

namespace LearnSOLID
{
    public interface IEmployeeReportBAL
    {
        void GeneratePFReport();
        void GenerateESICReport();
    }
    public interface IManagerReportBAL : IEmployeeReportBAL
    {
        void GenerateResourcePerformanceReport();
        void GenerateProjectSchedule();
    }
    public interface IAdminReportBAL : IManagerReportBAL
    {
        void GenerateProfitReport();
    }
    public class ReportBAL : IAdminReportBAL
    {
        public void GeneratePFReport()
        {/*...............*/}

        public void GenerateESICReport()
        {/*...............*/}

        public void GenerateResourcePerformanceReport()
        {/*...............*/}

        public void GenerateProjectSchedule()
        {/*...............*/}

        public void GenerateProfitReport()
        {/*...............*/}
    }
}
