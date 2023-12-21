using Chat_App.DataAccesL;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Chat_App.UI
{
    public class ChatControl : XtraUserControl
    {
        private MemoEdit memoEdit;
        private TextBox textBox;
        private Button btnSend;
        public int userid;
        public string username;
        public int CustomerID;
        SQL sql = new SQL();

        public ChatControl()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            memoEdit = new MemoEdit();
            memoEdit.Dock = DockStyle.Fill;
            this.Controls.Add(memoEdit);

            textBox = new TextBox();
            textBox.Dock = DockStyle.Bottom;
            this.Controls.Add(textBox);

            btnSend = new Button();
            btnSend.Text = "Gönder";
            btnSend.Dock = DockStyle.Bottom;
            btnSend.Click += BtnSend_Click;
            this.Controls.Add(btnSend);
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            try
            {
                string messageText = textBox.Text;
                AddMessage(DateTime.Now, username, messageText);
                sql.InsertMessage(CustomerID, username, messageText);
                // Mesaj gönderildikten sonra TextBox'u temizle
                textBox.Text = "";

            }
            catch (Exception)
            {

                throw;
            }
            // TextBox içindeki metni al ve mesaj olarak ekle

        }
        public void AddMessage(DateTime messageTime, string sender, string messageText)
        {
            memoEdit.Text += $"[{messageTime:HH:mm:ss}] {sender}: {messageText}\r\n";

            // İstenirse, en alttaki mesajı görünür yapabilirsiniz
            memoEdit.SelectionStart = memoEdit.Text.Length;
            memoEdit.ScrollToCaret();
        }
        public void AddMessageUsers(DateTime messageTime, string sender, string messageText)
        {
            memoEdit.Text += $"[{messageTime:HH:mm:ss}] {sender}: {messageText}\r\n";
            try
            {
                
            }
            catch (Exception ex)
            {}

            // İstenirse, en alttaki mesajı görünür yapabilirsiniz
            memoEdit.SelectionStart = memoEdit.Text.Length;
            memoEdit.ScrollToCaret();
        }
        public void Getusername(int CustomerID,int userid, string usernameparam)
        {
            this.CustomerID = CustomerID;
            username = usernameparam.Trim();
            this.userid = userid;

        }
    }
}
