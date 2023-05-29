using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlyquanan
{
    public partial class FExportBill : Form
    {
        public string ban;
        public string tongtien;
        public FExportBill()
        {
            InitializeComponent();
        }
        public FExportBill(string ban, string tongtien)
        {
            InitializeComponent();
            this.ban = ban;
            this.tongtien = tongtien;
        }
        private void FExportBill_Load(object sender, EventArgs e)
        {
            string today = DateTime.Now.ToString();
            ReportParameter[] parameter = new ReportParameter[3]; // tạo parameter để diền vào textbox trong rdlc
            parameter[0] = new ReportParameter("tenban", this.ban);
            parameter[1] = new ReportParameter("tongtien", this.tongtien);
            parameter[2] = new ReportParameter("thoigian", today);
            
            this.reportViewer1.LocalReport.EnableExternalImages = true;
            this.reportViewer1.LocalReport.SetParameters(parameter);
            /*
            BindingSource bs = new BindingSource();
            bs.DataSource = listBillDetail; // listBillDetail là danh sách các đối tượng BillDetail
            MessageBox.Show(bs.DataSource.ToString());
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", bs));*/
            this.reportViewer1.RefreshReport();
            //this.reportViewer2.RefreshReport();

        }
    }
}
