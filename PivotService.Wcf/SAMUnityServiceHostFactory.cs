using System;
using System.ServiceModel;

using System.Reflection;
using Core.Services;
using Core.IoC;
using Core.Utilities;
using Core.Data.DbContext.Orm;
using PivotData.Repository;
using PivotData.DataModel;
using PivotBusiness;

namespace PivotService.WCF
{
    public class PivotUnityServiceHostFactory : UnityContainerServiceHostFactory
    {
        protected override ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses)
        {
            ReflectionHelper reflectionHelper = new ReflectionHelper();

            Assembly businessAssembly = reflectionHelper.GetAssemblyFromType(typeof(IoCBusiness));
            Assembly dataAssembly = reflectionHelper.GetAssemblyFromType(typeof(IIoCRepository<>));
          

            //Data Registration
            IContextRegistration<PivotEntities> contextRegistration = new PivotContextRegistration<PivotEntities>();
            contextRegistration.RegisterContext();


            //Non UnityIoCFactory Registration
            UnityIoCFactory.Instance.RegisterByConvention(businessAssembly, "Business");
            UnityIoCFactory.Instance.RegisterGenericByConvention(dataAssembly, "Repository");
            

            return base.CreateServiceHost(serviceType, baseAddresses);
        }
    }
}