using Chat_App.DataAccesL;
using Chat_App.UI;
using DevExpress.Data.ExpressionEditor;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chat_App
{
    public partial class Chat : DevExpress.XtraEditors.XtraForm
    {
        private Point lastPoint;
        public List<Tuple<string, string>> userlist = new List<Tuple<string, string>>();
        Chat_App.DataAccesL.SQL sql = new SQL();
        public string username;
        public int userid;
        public Chat()
        {
            InitializeComponent();
        }
        public async void Getusername(int userid,string usernameparam)
        {
            this.userid = userid;
            username = usernameparam.Trim();
        }
        public async void Chat_Load(object sender, EventArgs e)
        {
            userlist = sql.GetCustomer();
            ListBoxDoldur(userlist);
        }
        private void btnexit2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private async void ListBoxDoldur(List<Tuple<string, string>> alist)
        {
            lstcontrolcustomer.Items.Clear();
            foreach (var item in userlist)
            {
                lstcontrolcustomer.Items.Add($"{item.Item1} - {item.Item2}");
            }
        }
        private void lstcontrolcustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Int16 selectedValue = (short)lstcontrolcustomer.SelectedIndex;
            selectedValue++;

            string selectedName = lstcontrolcustomer.SelectedItem.ToString();
            if (selectedName != null && selectedValue >= 0)
            {
                // Eğer belirtilen isme sahip bir XtraTabPage zaten varsa, onu seç
                XtraTabPage existingTabPage = tbcntrlchat.TabPages.FirstOrDefault(tab => tab.Name == selectedName);

                if (existingTabPage != null)
                {
                    existingTabPage.Controls.Clear();
                    //tbcntrlchat.SelectedTabPage = existingTabPage;
                    ChatDoldur(selectedName, selectedValue);
                }
                else
                {
                    ChatDoldur(selectedName, selectedValue);
                }
            }
        }
        private void ChatDoldur(string selectedName, int selectedValue)
        {
            // Yoksa, yeni bir XtraTabPage oluştur ve ekranı güncelle
            XtraTabPage newTabPage = new XtraTabPage { Text = selectedName, Name = selectedName };


            ChatControl chatControl = new ChatControl();
            chatControl.Dock = DockStyle.Fill;

            //Chat de bulunan mesajları aldık..
            List<ChatMessages> messages = sql.GetMessages(selectedValue);
            foreach (ChatMessages message in messages)
            {
                chatControl.AddMessage(message.MessageTime, message.MessageClient, message.MessageText);
            }
            //gerekli kullanacağı bilgiler sınıfa verildi..
            chatControl.Getusername(selectedValue, userid, username);
            // ChatControl'ü yeni sayfaya ekleyin
            newTabPage.Controls.Add(chatControl);

            // TabControl'a yeni sayfayı ekleyin
            tbcntrlchat.TabPages.Add(newTabPage);

            // Yeni oluşturulan sayfayı seçin
            tbcntrlchat.SelectedTabPage = newTabPage;
        }
        private void titpanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void titpanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
