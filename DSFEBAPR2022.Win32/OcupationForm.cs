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
    public partial class OcupationForm : Form
    {
        BO.DSFEBABR2022Entities db = new BO.DSFEBABR2022Entities();
        public OcupationForm()
        {
            InitializeComponent();

            getrecords();
        }

        private void getrecords()
        {
            var ocupations = db.Ocupacion;
            dataGridView1.DataSource = ocupations.ToList();
        }
    }
}
