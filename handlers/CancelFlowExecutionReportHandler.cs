using Models;

namespace handlers
{
    public class CancelFlowExecutionReportHandler : AbstractExecutionReportHandler
    {
        public override void InsertExecutionReportEvent(ExecutionReport execReport)
        {
            Console.WriteLine("Recreating original ExecutionReport instance...");
            ExecutionReport originalExecutionReport = execReport.GetOriginalExecutionReportForCancelFlow();
            Console.WriteLine("Executing InsertExecutionReportEvent from CancelFlowExecutionReportHandler...");
            //throw new NotImplementedException();
        }

        public override void SaveOrUpdateExecutionReport(ExecutionReport execReport)
        {
            Console.WriteLine("Recreating original ExecutionReport instance...");
            ExecutionReport originalExecutionReport = execReport.GetOriginalExecutionReportForCancelFlow();
            Console.WriteLine("Executing SaveOrUpdateExecutionReport from CancelFlowExecutionReportHandler...");
        }
    }

}