﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Forge.AutoUpdate.Scheduler.DistributionService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DistributionService.IUpdateDistributor")]
    internal interface IUpdateDistributor {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUpdateDistributor/GetAvailableVersions", ReplyAction="http://tempuri.org/IUpdateDistributor/GetAvailableVersionsResponse")]
        System.Version[] GetAvailableVersions(string productName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUpdateDistributor/GetVersion", ReplyAction="http://tempuri.org/IUpdateDistributor/GetVersionResponse")]
        System.IO.Stream GetVersion(string productName, System.Version version);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    internal interface IUpdateDistributorChannel : Forge.AutoUpdate.Scheduler.DistributionService.IUpdateDistributor, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    internal partial class UpdateDistributorClient : System.ServiceModel.ClientBase<Forge.AutoUpdate.Scheduler.DistributionService.IUpdateDistributor>, Forge.AutoUpdate.Scheduler.DistributionService.IUpdateDistributor {
        
        public UpdateDistributorClient() {
        }
        
        public UpdateDistributorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UpdateDistributorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UpdateDistributorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UpdateDistributorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Version[] GetAvailableVersions(string productName) {
            return base.Channel.GetAvailableVersions(productName);
        }
        
        public System.IO.Stream GetVersion(string productName, System.Version version) {
            return base.Channel.GetVersion(productName, version);
        }
    }
}