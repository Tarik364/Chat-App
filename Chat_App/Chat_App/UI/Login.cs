using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat_App
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }
        public string user = "1";
        public string pass = "1";
        private async void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtuser.Text == user)
                {
                    Chat chat = new Chat();
                    chat.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {}
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}