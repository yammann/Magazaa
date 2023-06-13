using Business.Report;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebFormsUI
{
    public partial class ReportUI : Form
    {
        public ReportUI()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            OrderRepo orderRepo = new OrderRepo();
            DateTime startDate = dateEdit1.DateTime;
            DateTime endDate = dateEdit2.DateTime;
            string filter = string.Format("OrderDate >= '{0}' AND OrderDate <= '{1}'", startDate, endDate);
            orderRepo.FilterString = filter;

            orderRepo.ShowPreview();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            EmployeeRepo employeeRepo = new EmployeeRepo();
            employeeRepo.ShowPreview();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            DepoRepo depoRepo = new DepoRepo();
            DateTime startDate = dateEdit1.DateTime;
            DateTime endDate = dateEdit2.DateTime;
            string filter = string.Format("OrderDate >= '{0}' AND OrderDate <= '{1}'", startDate, endDate);
            depoRepo.FilterString = filter; 
            depoRepo.ShowPreview();

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            StoreExpesesRepo storeExpeses=new StoreExpesesRepo();
            DateTime startDate = dateEdit1.DateTime;
            DateTime endDate = dateEdit2.DateTime;
            string filter = string.Format("ExpensesDate >= '{0}' AND ExpensesDate <= '{1}'", startDate, endDate);
            storeExpeses.FilterString = filter;
            storeExpeses.ShowPreview();
        }
    }
}
