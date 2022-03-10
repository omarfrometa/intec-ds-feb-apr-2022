using DSFEBAPR2022.BO;
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
    public partial class UserForm : Form
    {
        DSFEBAPR2022.BO.DSFEBABR2022Entities db = new BO.DSFEBABR2022Entities();
        public bool Adding { get; set; }
        public UserForm()
        {
            InitializeComponent();

            Adding = false;

            getRecords();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            gbDatos.Enabled = true;
            btnSave.Enabled = true;
            btnAdd.Enabled = false;
            Adding = true;

            txtID.Text = Guid.NewGuid().ToString();
            txtCreatedDate.Text = DateTime.Now.ToString("MMM dd, yyyy");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            save();
        }

        private void save()
        {
            var user = new Usuario
            {
                Id = txtID.Text,
                Usuario1 = txtUsername.Text,
                Clave = txtPassword.Text,
                CorreoElectronico = txtEmail.Text,
                Estado = chkEnabled.Checked,
                FechaCreacion = DateTime.Now
            };

            using (var ctx = new DSFEBABR2022Entities())
            {
                ctx.Entry(user).State = Adding ? System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;

                ctx.SaveChanges();

                getRecords();
                clearFields();

                btnAdd.Enabled = true;
                gbDatos.Enabled = false;
                btnSave.Enabled = false;

                MessageBox.Show($"Usuario {(Adding ? "Agregado" : "Actualizado")}", "DESARROLLO DE SOFTWARE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void clearFields()
        {
            txtID.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtPasswordConfirm.Text = string.Empty;
            txtEmail.Text = string.Empty;
            chkEnabled.Checked = false;
            txtCreatedDate.Text = string.Empty;
        }

        private void getRecords(string searchText = "")
        {
            var users = db.Usuario.ToList();

            if (!string.IsNullOrEmpty(searchText))
            {
                users = db.Usuario.Where(x=> x.Usuario1.Contains(searchText) || x.CorreoElectronico.Contains(searchText)).ToList();
            }

            dgvRecords.DataSource = users.ToList();
            dgvRecords.Columns[1].HeaderText = "Usuario";
            dgvRecords.Columns[3].HeaderText = "Correo Electronico";
            dgvRecords.Columns[6].Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            getRecords(txtSearch.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            getRecords();
            clearFields();
        }

        private void gerRecordById(string Id)
        {
            var user = db.Usuario.FirstOrDefault(x => x.Id == Id);
            if (user != null)
            {
                Adding = false;
                txtID.Text = user.Id;
                txtUsername.Text = user.Usuario1;
                txtPassword.Text = user.Clave;
                txtPasswordConfirm.Text = user.Clave;
                txtEmail.Text = user.CorreoElectronico;
                chkEnabled.Checked = user.Estado;
                txtCreatedDate.Text = user.FechaCreacion.ToString("MMM dd, yyyy - hh:mm:ss tt");

                gbDatos.Enabled = true;
                btnAdd.Enabled = false;
                btnSave.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void dgvRecords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvRecords.Rows[e.RowIndex];
            var ID = row.Cells[0].Value.ToString();

            gerRecordById(ID);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Estas seguro que deseas eliminar este registro.", "DESARROLLO DE SOFTWARE", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (dr == DialogResult.Yes)
            {
                var user = db.Usuario.FirstOrDefault(x => x.Id == txtID.Text);
                if (user != null)
                {
                    db.Usuario.Remove(user);

                    var rUser = db.SaveChanges() > 0;
                    if (rUser)
                    {
                        getRecords();
                        clearFields();

                        btnAdd.Enabled = true;
                        gbDatos.Enabled = false;
                        btnSave.Enabled = false;
                        btnDelete.Enabled = false;
                        Adding = false;
                    }
                }
            }
        }
    }
}
