using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSFEBAPR2022.Win32
{
    public partial class LoginForm : Form
    {
        DSFEBAPR2022.BO.DSFEBABR2022Entities db = new BO.DSFEBABR2022Entities();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DoLogin();
        }

        private void DoLogin()
        {
            var user = db.Usuario.FirstOrDefault(x => x.Usuario1 == txtUsuario.Text.Trim() && x.Clave == txtClave.Text.Trim());
            if (user == null)
            {
                MessageBox.Show("Credenciales Invalidas.");
                return;
            }

            var oMainForm = new MainForm();
            oMainForm.Show();

            this.Hide();
        }
    }
}
