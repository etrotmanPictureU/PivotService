using Core.FaultHandling;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Configuration;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading.Tasks;

namespace PivotService.WCF
{


    public class GlobalErrorServiceBehavior : IErrorHandler, IServiceBehavior
    {
        private bool _enabled;

            internal GlobalErrorServiceBehavior(bool enabled)
        {
            _enabled = enabled;
        }

        public bool HandleError(Exception error)
        {
            // Log the error here
            EventLog.WriteEntry("DefaultErrorServiceBehavior", error.ToString());

            // Let the other ErrorHandler do their jobs
            return true;
        }

        public void ProvideFault(Exception error, MessageVersion version, ref Message fault)
        {
            if (error is FaultException)
                return;
            ServiceOperationFault serviceOperationFault = new ServiceOperationFault();
            FaultReason fr = new FaultReason(error.ToString());
            FaultCode fc = new FaultCode("0001");
            // Creates the exception we want to send back to the client
            var exception = new FaultException<ServiceOperationFault>(serviceOperationFault, fr);

            // Creates a message fault
            var messageFault = exception.CreateMessageFault();

            // Creates the new message based on the message fault
            fault = Message.CreateMessage(version, messageFault, exception.Action);
        }

        #region IServiceBehavior Members

        public void AddBindingParameters(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints, BindingParameterCollection bindingParameters)
        {
        }

    
        public void ApplyDispatchBehavior(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {

            // Adds a TimeServiceErrorHandler to each ChannelDispatcher
            foreach (var channelDispatcherBase in serviceHostBase.ChannelDispatchers)
            {
                var channelDispatcher = channelDispatcherBase as ChannelDispatcher;
                channelDispatcher.ErrorHandlers.Add(new GlobalErrorServiceBehavior(_enabled));
            }
        }
        public void Validate(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
        }

        #endregion
    }
}
