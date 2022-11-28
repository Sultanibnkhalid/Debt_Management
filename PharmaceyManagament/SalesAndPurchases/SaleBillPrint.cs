using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaceyManagament.SalesAndPurchases
{
    public partial class SaleBillPrint : Form
    {
        public SaleBillPrint()
        {
            InitializeComponent();
        }

        private void SaleBillPrint_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyADataSet1.SalProcedureForREport' table. You can move, or remove it, as needed.
         
            // TODO: This line of code loads data into the 'pharmacyADataSet.Drugs' table. You can move, or remove it, as needed.
            //this.drugsTableAdapter.Fill(this.pharmacyADataSet.Drugs);

            this.reportViewer1.RefreshReport();
        }

    }
}
