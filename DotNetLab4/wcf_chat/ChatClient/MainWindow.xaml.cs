using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ChatClient.ServiceChat;

namespace ChatClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IServiceChatCallback
    {
        bool isConnected = false;
        ServiceChatClient client;
        bool isGlobalChat = true;
        bool isFrom = false;
        int Id;
        public MainWindow()
        {
            InitializeComponent();
        }
        public void ConnectUser()
        {
            if (!isConnected)
            {
                client = new ServiceChatClient(new System.ServiceModel.InstanceContext(this));
                Id = client.Connect(tbUserName.Text);
                client.GetServerUsers(tbUserName.Text);
                tbUserName.IsEnabled = false;
                bthConOrDis.Content = "Disconnect";
                isConnected = true;
            }
        }

        public void DisconectUser()
        {
            if (isConnected)
            {
                client.Disconect(Id);

                tbUserName.IsEnabled = true;
                bthConOrDis.Content = "Connect";
                isConnected = false;
                client = null;
            }
        }

        public void MsgCallback(string msg)
        {
            tbChat.Items.Add(msg);
            tbChat.ScrollIntoView(tbChat.Items[tbChat.Items.Count - 1]);

        }
        public void GetUsersCallback(string msg)
        {
            OnlineList.Items.Clear();
            string[] arr = msg.Split('\n');
            foreach (var i in arr)
            {
                OnlineList.Items.Add(i);
            }
        }
        public void SendNotfCallbakc(string msg,bool isMsg)
        {
            if (isMsg)
            {
                PersChat.Items.Add(msg);
            }
            else
            {
                NotList.Items.Add(msg);
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (isConnected)
            {
                DisconectUser();
            }
            else
            {
                ConnectUser();
            }
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Grid_ContextMenuClosing(object sender, ContextMenuEventArgs e)
        {
            DisconectUser();
        }

        private void tbMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (client != null)
                {
                    if (isGlobalChat)
                    {
                        client.SendMsg(tbMessage.Text, Id);
                        tbMessage.Text = String.Empty;
                    }
                    else
                    {
                        if (Id != OnlineList.SelectedIndex&&OnlineList.SelectedIndex!=-1)
                        {
                            client.SendNotification(Id, OnlineList.SelectedIndex, tbMessage.Text);
                            client.SendNotification(Id, OnlineList.SelectedIndex);
                        }
                        else
                        {
                            MessageBox.Show("Not selected or its you");
                        }
                    }
                }
            }
        }

        private void OnlineList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SendMsg.IsEnabled = true;
            SendMsg.Content = $"send message to {OnlineList.SelectedItem}";
        }

        private void SendMsg_Click(object sender, RoutedEventArgs e)
        {
            tbChat.Visibility = Visibility.Hidden;
            PersChat.Visibility = Visibility.Visible;
            GlobCh.Content = $"Chat with {OnlineList.SelectedItem}";
            SendMsg.IsEnabled = false;
            isGlobalChat = false;
        }

      

        private void NotList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tbChat.Visibility = Visibility.Hidden;
            GlobCh.Content = $"Private chat";
            PersChat.Visibility = Visibility.Visible;
            isGlobalChat = false;
            isFrom = true;
        }
    }
}
