using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcf_chat
{
    [ServiceContract(CallbackContract =typeof(IServerChatCallback))]
    public interface IServiceChat
    {
        [OperationContract]
        int Connect(string name);
        [OperationContract]
        void Disconect(int id);

        [OperationContract(IsOneWay = true)]
        void SendMsg(string msg, int id);
        [OperationContract(IsOneWay = true)]
        void GetServerUsers(string msg);

        [OperationContract(IsOneWay = true)]
        void SendNotification(int sender,int receiver,string msg = "default");
    }

    public interface IServerChatCallback
    {
        [OperationContract(IsOneWay=true)]
        void MsgCallback(string msg);

        [OperationContract(IsOneWay = true)]
        void GetUsersCallback(string msg);

        [OperationContract(IsOneWay = true)]
        void SendNotfCallbakc(string msg, bool isMsg);
    }
}
