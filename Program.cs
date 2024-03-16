// See https://aka.ms/new-console-template for more information

using Enums;
using handlers;
using Models;

AbstractExecutionReportHandler cancelFlowExecutionReportHandler = new CancelFlowExecutionReportHandler();
AbstractExecutionReportHandler defaultExecutionReportHandler = new DefaultExecutionReportHandler();

var executionReportHandlers = new Dictionary<string, AbstractExecutionReportHandler>
{
    { ExecutionType.PendingCancel, cancelFlowExecutionReportHandler },
    { ExecutionType.Cancel, cancelFlowExecutionReportHandler },
    { ExecutionType.Default, defaultExecutionReportHandler }
};

ExecutionReport currentExecReport = new ExecutionReport
{
    ExecutionType = ExecutionType.New,
    ClOrdId = "ABC_456",
    OrigClOrdId = "ABC_123"
};

ExecutionReportContainer execReportContainer = new ExecutionReportContainer(currentExecReport);

AbstractExecutionReportHandler handler;
switch (execReportContainer.Get(ExecutionReportContainerKey.Current).ExecutionType)
{
    case var value when value.Equals(ExecutionType.PendingCancel):
        handler = executionReportHandlers[ExecutionType.PendingCancel];
        handler.Handle(execReportContainer);
        break;
    case var value when value.Equals(ExecutionType.Cancel):
        handler = executionReportHandlers[ExecutionType.Cancel];
        handler.Handle(execReportContainer);
        break;
    default:
        handler = executionReportHandlers[ExecutionType.Default];
        handler.Handle(execReportContainer);
        break;
}
