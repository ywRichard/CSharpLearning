﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client2.UserInfoServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserInfoServiceReference.IUserInfoBLL")]
    public interface IUserInfoBLL {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoBLL/Add", ReplyAction="http://tempuri.org/IUserInfoBLL/AddResponse")]
        int Add(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoBLL/Add", ReplyAction="http://tempuri.org/IUserInfoBLL/AddResponse")]
        System.Threading.Tasks.Task<int> AddAsync(int a, int b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserInfoBLLChannel : Client2.UserInfoServiceReference.IUserInfoBLL, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserInfoBLLClient : System.ServiceModel.ClientBase<Client2.UserInfoServiceReference.IUserInfoBLL>, Client2.UserInfoServiceReference.IUserInfoBLL {
        
        public UserInfoBLLClient() {
        }
        
        public UserInfoBLLClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserInfoBLLClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserInfoBLLClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserInfoBLLClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Add(int a, int b) {
            return base.Channel.Add(a, b);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(int a, int b) {
            return base.Channel.AddAsync(a, b);
        }
    }
}