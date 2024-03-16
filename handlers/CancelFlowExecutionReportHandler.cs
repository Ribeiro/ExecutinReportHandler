using Enums;
using Models;

namespace handlers
{
    public class CancelFlowExecutionReportHandler : AbstractExecutionReportHandler
    {
        public override void InsertExecutionReportEvent(ExecutionReportContainer execReportContainer)
        {
            Console.WriteLine("Executing InsertExecutionReportEvent from CancelFlowExecutionReportHandler...");

            ExecutionReport currentExecReport = execReportContainer.Get(ExecutionReportContainerKey.Current);
            Console.WriteLine($"Retrieving current ExecutionReport from ExecutionReportContainer: {currentExecReport}");

            ExecutionReport originalExecReport = execReportContainer.Get(ExecutionReportContainerKey.Original);
            Console.WriteLine($"Retrieving original ExecutionReport from ExecutionReportContainer: {originalExecReport}");

            Console.WriteLine("Executing flow...");
        }

        public override void SaveOrUpdateExecutionReport(ExecutionReportContainer execReportContainer)
        {
            Console.WriteLine("Executing SaveOrUpdateExecutionReport from CancelFlowExecutionReportHandler...");

            ExecutionReport currentExecReport = execReportContainer.Get(ExecutionReportContainerKey.Current);
            Console.WriteLine($"Retrieving current ExecutionReport from ExecutionReportContainer: {currentExecReport}");

            ExecutionReport originalExecReport = currentExecReport.GetOriginalExecutionReportForCancelFlow();
            Console.WriteLine($"Recreating original ExecutionReport instance and adding it to ExecutionReportContainer: {originalExecReport}");
            execReportContainer.Add(ExecutionReportContainerKey.Original, originalExecReport);

            Console.WriteLine("Executing flow...");
        }
    }
}