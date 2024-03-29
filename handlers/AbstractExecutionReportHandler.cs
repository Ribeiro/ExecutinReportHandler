using Models;

namespace handlers
{
    public abstract class AbstractExecutionReportHandler
    {
        public string Logger {get;}
        public string DbConnectionService {get;}

        protected AbstractExecutionReportHandler(string logger, string dbConnectionService)
        {
            Logger = logger;
            DbConnectionService = dbConnectionService;
        }

        public void Handle(ExecutionReportContainer execReportContainer)
        {
            SaveOrUpdateExecutionReport(execReportContainer);
            InsertExecutionReportEvent(execReportContainer);
        }

        public abstract void SaveOrUpdateExecutionReport(ExecutionReportContainer execReportContainer);
        public virtual void InsertExecutionReportEvent(ExecutionReportContainer execReportContainer){
            var reports = execReportContainer.GetAll();
            foreach (var report in reports){
                Console.WriteLine($"Inserting {report} into TB_EXECUTION_REPORT_EVENT");
            }
        }

    }
}