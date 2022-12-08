﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using wcf_chat;

namespace ChatClient.ServiceChat {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceChat.IServiceChat", CallbackContract=typeof(ChatClient.ServiceChat.IServiceChatCallback))]
    public interface IServiceChat {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceChat/Connect", ReplyAction="http://tempuri.org/IServiceChat/ConnectResponse")]
        int Connect(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceChat/Connect", ReplyAction="http://tempuri.org/IServiceChat/ConnectResponse")]
        System.Threading.Tasks.Task<int> ConnectAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceChat/Disconect", ReplyAction="http://tempuri.org/IServiceChat/DisconectResponse")]
        void Disconect(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceChat/Disconect", ReplyAction="http://tempuri.org/IServiceChat/DisconectResponse")]
        System.Threading.Tasks.Task DisconectAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServiceChat/SendMsg")]
        void SendMsg(string msg, int id);

        [System.ServiceModel.OperationContractAttribute(IsOneWay=true,Action = "http://tempuri.org/IServiceChat/GetServerUsers")]
        void GetServerUsers(string msg);

        [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://tempuri.org/IServiceChat/SendNotification")]
        void SendNotification(int sender, int receiver,string msg="default");

        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action= "http://tempuri.org/IServiceChat/SendMsg")]
        System.Threading.Tasks.Task SendMsgAsync(string msg, int id);

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChatCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServiceChat/MsgCallback")]
        void MsgCallback(string msg);
        [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://tempuri.org/IServiceChat/GetUsersCallback")]
        void GetUsersCallback(string msg);

        [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://tempuri.org/IServiceChat/SendNotfCallbakc")]
        void SendNotfCallbakc(string msg, bool isMsg);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChatChannel : ChatClient.ServiceChat.IServiceChat, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceChatClient : System.ServiceModel.DuplexClientBase<ChatClient.ServiceChat.IServiceChat>, ChatClient.ServiceChat.IServiceChat {
        
        public ServiceChatClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public ServiceChatClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public ServiceChatClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceChatClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceChatClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public int Connect(string name) {
            return base.Channel.Connect(name);
        }
        
        public System.Threading.Tasks.Task<int> ConnectAsync(string name) {
            return base.Channel.ConnectAsync(name);
        }
        
        public void Disconect(int id) {
            base.Channel.Disconect(id);
        }
        
        public System.Threading.Tasks.Task DisconectAsync(int id) {
            return base.Channel.DisconectAsync(id);
        }

        public void GetServerUsers(string msg)
        {
           base.Channel.GetServerUsers(msg);
        }

        public void SendMsg(string msg, int id) {
            base.Channel.SendMsg(msg, id);
        }
 

        public System.Threading.Tasks.Task SendMsgAsync(string msg, int id) {
            return base.Channel.SendMsgAsync(msg, id);
        }

        public void SendNotification(int sender, int receiver,string msg = "default")
        {
            base.Channel.SendNotification(sender, receiver,msg);
        }
    }
}
