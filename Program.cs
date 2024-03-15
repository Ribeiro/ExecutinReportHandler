// See https://aka.ms/new-console-template for more information


using Enums;
using handlers;
using Models;

ExecutionReport executionReport = new ExecutionReport();
executionReport.ExecutionStatus = ExecutionStatus.PendingCancel;
executionReport.ClOrdId = "BTG_456";
executionReport.OrigClOrdId = "BTG_123";


AbstractExecutionReportHandler cancelFlowExecutionReportHandler = new CancelFlowExecutionReportHandler();
AbstractExecutionReportHandler defaultExecutionReportHandler = new DefaultExecutionReportHandler();

var executionReportHandlers = new Dictionary<ExecutionStatus, AbstractExecutionReportHandler>();
executionReportHandlers.Add(ExecutionStatus.PendingCancel, cancelFlowExecutionReportHandler);
executionReportHandlers.Add(ExecutionStatus.Cancel, cancelFlowExecutionReportHandler);
executionReportHandlers.Add(ExecutionStatus.New, defaultExecutionReportHandler);


AbstractExecutionReportHandler handler;

switch (executionReport.ExecutionStatus)
{

    case ExecutionStatus.PendingCancel:
        handler = executionReportHandlers[ExecutionStatus.PendingCancel];
        handler.Handle(executionReport);
        break;
    case ExecutionStatus.Cancel:
        handler = executionReportHandlers[ExecutionStatus.Cancel];
        handler.Handle(executionReport);
        break;
    case ExecutionStatus.New:
        handler = executionReportHandlers[ExecutionStatus.New];
        handler.Handle(executionReport);
        break;
    default:
        break;
}
