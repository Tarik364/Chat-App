using Chat_App.DataAccesL;
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
using Chat_App.UI;


namespace Chat_App
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }
        DataAccesL.SQL sql = new DataAccesL.SQL();
        List<User> users = new List<User>();
        Chat chat = new Chat();


        private async void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbuser.EditValue != null)
                {

                    //User selectedUser = cmbuser.EditValue as User;
                    string userIdString = cmbuser.EditValue.ToString();
                    string userName = cmbuser.Text;
                    if (int.TryParse(userIdString, out int userId))
                    {
                        // Örneğin, Chat formunu oluştururken bu bilgileri parametre olarak iletebilirsiniz.
                        chat.Getusername(userId, userName);
                        chat.TopMost = true;
                        chat.Show();
                        this.Hide();
                    }
                    else
                    {
                        // userId bir tamsayıya dönüştürülemezse, uygun bir işlem yapabilirsiniz.
                    }
                }
                else
                {
                    // cmbuser.EditValue null ise, uygun bir işlem yapabilirsiniz.
                }
            }
            catch (Exception ex)
            { }
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            users = sql.GetUser();
            cmbuser.Properties.DataSource = users;
            cmbuser.Properties.ValueMember = "UserId";
            cmbuser.Properties.DisplayMember = "UserName";
        }
    }
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }

    }
}