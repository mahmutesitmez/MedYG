using ClinicApp.Application;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicApp.UI;
public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void loginButton_Click(object sender, EventArgs e)
    {
        DoctorsRepository doctorsRepository = new DoctorsRepository();
        bool isLogin = doctorsRepository.Login(EmailInput.Text, passwordInput.Text);

    }
}
