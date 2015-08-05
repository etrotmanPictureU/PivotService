using Core.FaultHandling;

namespace PivotService.WCF
{
    public class FaultSummaryInvalidNumeric : IFaultSummaryResult
    {
        public string Reason { get { return "Invalid Numeric value"; } }
        public string Code { get { return "0002"; } }
    }
}