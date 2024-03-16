using Models;

namespace handlers
{
    public abstract class AbstractExecutionReportHandler
    {
        public void Handle(ExecutionReportContainer execReportContainer)
        {
            SaveOrUpdateExecutionReport(execReportContainer);
            InsertExecutionReportEvent(execReportContainer);
        }

        public abstract void SaveOrUpdateExecutionReport(ExecutionReportContainer execReportContainer);
        public abstract void InsertExecutionReportEvent(ExecutionReportContainer execReportContainer);

    }
}