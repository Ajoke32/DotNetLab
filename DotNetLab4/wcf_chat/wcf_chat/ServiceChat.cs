using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcf_chat
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ServiceChat : IServiceChat
    {
        public List<ServerUser> users = new List<ServerUser>();
        int nextId = 0;

        public int Connect(string name)
        {
            ServerUser user = new ServerUser()
            {
                Id = nextId,
                Name = name,
                operationContext = OperationContext.Current
            };
            nextId++;
            SendMsg($"{user.Name} connected", 0);
            users.Add(user);
            return user.Id;
        }

        public void Disconect(int id)
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                users.Remove(user);
                SendMsg($"{user.Name} disconected", 0);
            }
        }
        public void SendMsg(string msg, int id)
        {

            foreach (var item in users)
            {
                string answer = $"({DateTime.Now.ToShortTimeString()})";
                string username = String.Empty;
                var user = users.FirstOrDefault(u => u.Id == id);
                if (user != null)
                {
                    answer += $" |{user.Name}| ";
                    username = user.Name;
                }
                answer += $"\n{msg}";
                item.operationContext.GetCallbackChannel<IServerChatCallback>().MsgCallback(answer);
            }

        }

        public void GetServerUsers(string msg)
        {
            string che = String.Empty;
            foreach (var item in users)
            {
                che += $"{item.Name}\n";
            }
            foreach (var item in users)
            {
                item.operationContext.GetCallbackChannel<IServerChatCallback>().GetUsersCallback(che);
            }
        }

        public void SendNotification(int sender, int receiver,string msg ="default")
        {
            string message = String.Empty;
            var rec = users.FirstOrDefault(u => u.Id == receiver);
            var sen = users.FirstOrDefault(u => u.Id == sender);
            if (rec != null && sen != null)
            {
                if (msg!="default")
                {
                    rec.operationContext.GetCallbackChannel<IServerChatCallback>().SendNotfCallbakc(msg, true);
                    sen.operationContext.GetCallbackChannel<IServerChatCallback>().SendNotfCallbakc(msg, true);
                }
                else
                {
                    message = $"Message from {sen.Name}";
                    rec.operationContext.GetCallbackChannel<IServerChatCallback>().SendNotfCallbakc(message, false);
                }

            }
        }
    }
}
