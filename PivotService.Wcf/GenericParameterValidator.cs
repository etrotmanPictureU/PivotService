using Core.FaultHandling;
using Core.Services;
using Core.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PivotService.WCF
{
    public abstract class GenericParameterValidator : BaseParameterValidator
    {
        private readonly CoreValidator _CoreValidator = null;
        private readonly FaultSummaryUtility _fsu = null;

        internal GenericParameterValidator(object[] inputs)
        {
            this.inputs = inputs;

            _CoreValidator = new CoreValidator();
            _fsu = new FaultSummaryUtility();

        }
        public FaultReturn NullValidate<SERVICE_POCO, VALIDATION_POCO>()
            where SERVICE_POCO : class
            where VALIDATION_POCO : class
        {
            FaultReturn faultReturn = null;
            for (int i = 0; i < inputs.Length; i++)
            {
                if (inputs[i] == null)
                {
                    if (BaseParameterInspector.RejectNullValue(i) == true)
                    {
                        faultReturn = _fsu.GetFaultSummary(new FaultSummaryNullObject(), this.Action);
                        return faultReturn;
                    }
                }
                object input = inputs[i];
                faultReturn = CheckInputs<SERVICE_POCO, VALIDATION_POCO>(input);
            }

            return faultReturn;
        }



        protected abstract FaultReturn Check<SERVICE_POCO, VALIDATION_POCO>(object input, string action)
            where SERVICE_POCO : class
            where VALIDATION_POCO : class;
        protected abstract FaultReturn CheckInputs<SERVICE_POCO, VALIDATION_POCO>(object input)
            where SERVICE_POCO : class
            where VALIDATION_POCO : class;


        public override FaultReturn NullValidate()
        {
            throw new NotImplementedException();
        }
    }

  
}
