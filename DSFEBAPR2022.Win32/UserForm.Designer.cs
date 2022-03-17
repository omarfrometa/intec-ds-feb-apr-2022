
namespace DSFEBAPR2022.Win32
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.txtPasswordConfirm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCreatedDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkEnabled = new System.Windows.Forms.CheckBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvRecords = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbDatos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.txtPasswordConfirm);
            this.gbDatos.Controls.Add(this.label7);
            this.gbDatos.Controls.Add(this.txtID);
            this.gbDatos.Controls.Add(this.label6);
            this.gbDatos.Controls.Add(this.txtCreatedDate);
            this.gbDatos.Controls.Add(this.label5);
            this.gbDatos.Controls.Add(this.chkEnabled);
            this.gbDatos.Controls.Add(this.txtEmail);
            this.gbDatos.Controls.Add(this.label4);
            this.gbDatos.Controls.Add(this.txtPassword);
            this.gbDatos.Controls.Add(this.label3);
            this.gbDatos.Controls.Add(this.txtUsername);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Enabled = false;
            this.gbDatos.Location = new System.Drawing.Point(12, 50);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(362, 274);
            this.gbDatos.TabIndex = 0;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // txtPasswordConfirm
            // 
            this.txtPasswordConfirm.Location = new System.Drawing.Point(139, 127);
            this.txtPasswordConfirm.Name = "txtPasswordConfirm";
            this.txtPasswordConfirm.Size = new System.Drawing.Size(206, 22);
            this.txtPasswordConfirm.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Confirmar Clave:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(139, 25);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(206, 22);
            this.txtID.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "ID:";
            // 
            // txtCreatedDate
            // 
            this.txtCreatedDate.Enabled = false;
            this.txtCreatedDate.Location = new System.Drawing.Point(139, 227);
            this.txtCreatedDate.Name = "txtCreatedDate";
            this.txtCreatedDate.ReadOnly = true;
            this.txtCreatedDate.Size = new System.Drawing.Size(206, 22);
            this.txtCreatedDate.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fecha Creacion:";
            // 
            // chkEnabled
            // 
            this.chkEnabled.AutoSize = true;
            this.chkEnabled.Location = new System.Drawing.Point(139, 197);
            this.chkEnabled.Name = "chkEnabled";
            this.chkEnabled.Size = new System.Drawing.Size(78, 21);
            this.chkEnabled.TabIndex = 6;
            this.chkEnabled.Text = "Inactivo";
            this.chkEnabled.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(139, 165);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(206, 22);
            this.txtEmail.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(139, 90);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(206, 22);
            this.txtPassword.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Clave:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(139, 53);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(206, 22);
            this.txtUsername.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usuario:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(11, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 32);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(120, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 32);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(229, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 32);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvRecords);
            this.groupBox2.Location = new System.Drawing.Point(391, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(858, 563);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registros";
            // 
            // dgvRecords
            // 
            this.dgvRecords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecords.Location = new System.Drawing.Point(3, 18);
            this.dgvRecords.Name = "dgvRecords";
            this.dgvRecords.RowHeadersWidth = 51;
            this.dgvRecords.RowTemplate.Height = 24;
            this.dgvRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecords.Size = new System.Drawing.Size(849, 539);
            this.dgvRecords.TabIndex = 0;
            this.dgvRecords.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecords_CellClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(699, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(103, 32);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(391, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(302, 22);
            this.txtSearch.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Filtar Usuarios:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(808, 17);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 32);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 625);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbDatos);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkEnabled;
        private System.Windows.Forms.TextBox txtCreatedDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPasswordConfirm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvRecords;
    }
}