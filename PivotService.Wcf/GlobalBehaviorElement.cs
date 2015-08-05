using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceModel.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace PivotService.WCF
{
    public class GlobalErrorBehaviorElement : BehaviorExtensionElement
    {
        private const string EnabledAttributeName = "enabled";

        [ConfigurationProperty(EnabledAttributeName, DefaultValue = true, IsRequired = false)]
        public bool Enabled
        {
            get { return (bool)base[EnabledAttributeName]; }
            set { base[EnabledAttributeName] = value; }
        }

        public override Type BehaviorType
        {
            get { return typeof(GlobalErrorServiceBehavior); }
        }

        protected override object CreateBehavior()
        {
            return new GlobalErrorServiceBehavior(this.Enabled);
        }
    }
}
