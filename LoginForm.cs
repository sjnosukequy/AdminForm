using AdminForm;
using AdminForm.DLayers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public partial class LoginForm : Form
{
    Login login = new Login();
    public LoginForm()
    {
        InitializeComponent();
    }

    private void Login_btn_Click(object sender, EventArgs e)
    {
        if (login.Check(UserID_tb.Text, Password_tb.Text))
        {
            this.Hide();
            Main main = new Main();
            main.ShowDialog();
            this.Dispose();
        }
        else
            MessageBox.Show("Wrong!!");
    }
}
