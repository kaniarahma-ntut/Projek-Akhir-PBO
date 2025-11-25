using Project_Akhir.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Akhir
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbUsernameLogin.Text == "Username" && tbPasswordLogin.Text == "Password")
            {
                this.DialogResult = DialogResult.OK;

                this.Close();
            }
            else
                {
                MessageBox.Show("Username atau Password salah!");
                }
        }

        private void linkLabelDaftar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // 1. Buat instance (objek) dari FormRegister
            FormRegister formReg = new FormRegister();
            this.Hide();
            formReg.ShowDialog();

        }
    }
}
