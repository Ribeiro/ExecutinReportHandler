using Enums;

namespace Models
{
    public class ExecutionReport : ICloneable
    {

        public string? ClOrdId { get; set; }

        public string? OrigClOrdId { get; set; }

        public bool? SolicitedFlag { get; set; }

        public char? ExecutionType { get; set; }

        public object Clone()
        {
            var clonedExecutionReport = new ExecutionReport
            {
                ClOrdId = ClOrdId,
                OrigClOrdId = OrigClOrdId,
                SolicitedFlag = SolicitedFlag,
                ExecutionType = ExecutionType
            };
            return clonedExecutionReport;
        }

        public ExecutionReport GetOriginalExecutionReportForCancelFlow()
        {
            var cloned = (ExecutionReport) Clone();
            cloned.ClOrdId = OrigClOrdId!;
            cloned.OrigClOrdId = null;
            cloned.SolicitedFlag = null;

            return cloned;
        }

    }

}