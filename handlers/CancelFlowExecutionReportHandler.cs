using Enums;
using Models;

namespace handlers
{
    public class CancelFlowExecutionReportHandler : AbstractExecutionReportHandler
    {
        public override void SaveOrUpdateExecutionReport(ExecutionReportContainer execReportContainer)
        {
            Console.WriteLine("Executing SaveOrUpdateExecutionReport from CancelFlowExecutionReportHandler...");

            ExecutionReport currentExecReport = execReportContainer.Get(ExecutionReportContainerKey.Current);
            Console.WriteLine($"Retrieving current ExecutionReport from ExecutionReportContainer: {currentExecReport}");

            ExecutionReport originalExecReport = currentExecReport.GetOriginalExecutionReportForCancelFlow();
            Console.WriteLine($"Recreating original ExecutionReport instance and adding it to ExecutionReportContainer: {originalExecReport}");
            //execReportContainer.Add(ExecutionReportContainerKey.Original, originalExecReport);
            execReportContainer.Add("WTF", originalExecReport);

            Console.WriteLine("Executing flow...");
        }
    }
}