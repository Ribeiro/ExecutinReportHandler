using Models;

namespace handlers
{
    public abstract class AbstractExecutionReportHandler
    {
        public void Handle(ExecutionReport execReport)
        {
            SaveOrUpdateExecutionReport(execReport);
            InsertExecutionReportEvent(execReport);
        }

        public abstract void SaveOrUpdateExecutionReport(ExecutionReport execReport);
        public abstract void InsertExecutionReportEvent(ExecutionReport execReport);

    }
}