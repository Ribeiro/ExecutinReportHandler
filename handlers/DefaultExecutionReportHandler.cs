
using Enums;
using Models;

namespace handlers
{
    public class DefaultExecutionReportHandler : AbstractExecutionReportHandler
    {
        public override void SaveOrUpdateExecutionReport(ExecutionReportContainer execReportContainer)
        {
            Console.WriteLine("Executing SaveOrUpdateExecutionReport from DefaultExecutionReportHandler...");
            ExecutionReport currentExecReport = execReportContainer.Get(ExecutionReportContainerKey.Current);
            Console.WriteLine($"Retrieving current ExecutionReport from ExecutionReportContainer: {currentExecReport}");
            Console.WriteLine("Executing flow...");
        }
    }

}