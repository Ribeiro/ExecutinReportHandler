
using Models;

namespace handlers
{
    public class DefaultExecutionReportHandler : AbstractExecutionReportHandler
    {
        public override void InsertExecutionReportEvent(ExecutionReport execReport)
        {
            Console.WriteLine("Executing InsertExecutionReportEvent from DefaultExecutionReportHandler...");
        }

        public override void SaveOrUpdateExecutionReport(ExecutionReport execReport)
        {
            Console.WriteLine("Executing SaveOrUpdateExecutionReport from DefaultExecutionReportHandler...");
        }
    }

}