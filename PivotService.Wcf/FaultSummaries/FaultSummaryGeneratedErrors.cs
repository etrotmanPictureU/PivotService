using Core.FaultHandling;

namespace PivotService.WCF
{
    public class FaultSummaryGeneratedErrors : IFaultSummaryResult
    {
        public string Reason { get; set; }
        public string Code { get { return "0002"; } }
    }
}