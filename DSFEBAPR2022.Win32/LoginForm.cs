using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSFEBAPR2022.Win32
{
    public partial class LoginForm : Form
    {
        DSFEBAPR2022.BO.DSFEBABR2022Entities db = new BO.DSFEBABR2022Entities();
        private string ExecutePath = string.Empty;

        public LoginForm()
        {
            InitializeComponent();

            ExecutePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            getCredentials();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DoLogin();
        }

        private void DoLogin()
        {
            var pwd = BO.Helpers.Utils.MD5Hash(txtClave.Text);
            var user = db.Usuario.FirstOrDefault(x => x.Usuario1 == txtUsuario.Text.Trim() && x.Clave == pwd);
            if (user == null)
            {
                MessageBox.Show("Credenciales Invalidas.");
                return;
            }

            saveCredentials();

            var oMainForm = new MainForm();
            oMainForm.Show();

            this.Hide();
        }

        private void saveCredentials()
        {
            if (chkRecordar.Checked)
            {
                StreamWriter sw = new StreamWriter(ExecutePath + "\\config.txt");
                sw.WriteLine(txtUsuario.Text);
                sw.WriteLine(BO.Helpers.Utils.MD5Hash(txtClave.Text));
                sw.Close();
            }
            else
            {
                File.Delete(ExecutePath + "\\config.txt");
            }
        }

        private void getCredentials()
        {
            if (File.Exists(ExecutePath + "\\config.txt"))
            {
                chkRecordar.Checked = true;
                String line;
                StreamReader sr = new StreamReader(ExecutePath + "\\config.txt");
                line = sr.ReadLine();

                txtUsuario.Text = line;
                while (line != null)
                {
                    txtClave.Text = line;

                    line = sr.ReadLine();
                }

                sr.Close();
            }
        }
    }
}
