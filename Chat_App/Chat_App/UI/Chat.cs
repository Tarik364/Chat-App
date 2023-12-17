using Chat_App.DataAccesL;
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
        Login login = new Login();
        public List<Tuple<string, string>> userlist = new List<Tuple<string, string>>();
        Chat_App.DataAccesL.SQL sql = new SQL();
        public Chat()
        {
            InitializeComponent();
            InitializeComponents();
        }
        public async void Chat_Load(object sender, EventArgs e)
        {
            userlist = sql.GetCustomer();
            ListBoxDoldur(userlist);
        }
        private void btnexit2_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Dispose();
            login.Dispose();
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
                    tbcntrlchat.SelectedTabPage = existingTabPage;
                }
                else
                {
                    // Yoksa, yeni bir XtraTabPage oluştur ve ekranı güncelle
                    XtraTabPage newTabPage = new XtraTabPage { Text = selectedName, Name = selectedName };
                    //tbcntrlchat.TabPages.Add(newTabPage);
                    //tbcntrlchat.SelectedTabPage = newTabPage;

                    ChatControl chatControl = new ChatControl();
                    chatControl.Dock = DockStyle.Fill;

                    // ChatControl içindeki MemoEdit'e örnek mesaj ekleyin (istediğiniz gibi düzenleyebilirsiniz)
                    chatControl.AddMessage("User1", "Hello, how are you?");

                    // ChatControl'ü yeni sayfaya ekleyin
                    newTabPage.Controls.Add(chatControl);

                    // TabControl'a yeni sayfayı ekleyin
                    tbcntrlchat.TabPages.Add(newTabPage);

                    // Yeni oluşturulan sayfayı seçin
                    tbcntrlchat.SelectedTabPage = newTabPage;
                }
            }
        }
        private void InitializeComponents()
        {
            //tbcntrlchat = new XtraTabControl();
            //tbcntrlchat.Dock = DockStyle.Fill;
            //this.Controls.Add(tbcntrlchat);
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
public class ChatControl : MemoEdit
{
    private MemoEdit memoEdit;

    public ChatControl()
    {
        InitializeComponents();
    }

    private void InitializeComponents()
    {
        memoEdit = new MemoEdit();
        memoEdit.Dock = DockStyle.Fill;
        this.Controls.Add(memoEdit);
    }

    public void AddMessage(string sender, string message)
    {
        memoEdit.Text += $"[{DateTime.Now:HH:mm:ss}] {sender}: {message}\r\n";

        // İstenirse, en alttaki mesajı görünür yapabilirsiniz
        memoEdit.SelectionStart = memoEdit.Text.Length;
        memoEdit.ScrollToCaret();
    }
}