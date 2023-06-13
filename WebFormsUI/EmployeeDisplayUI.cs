using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Business.Methods;
using Entities.Concreate;
using Business.Abstract;
using Business.Concreate;
using DataAccess.Concreate.EntityFrameWork;

namespace WebFormsUI
{
    public partial class EmployeeDisplayUI : Form
    {
        public EmployeeDisplayUI()
        {
            InitializeComponent();
            _employeeService = new EmployeeManager(new EfEmployee());
        }
        IEmployeeService _employeeService;
        ImageMethod imageMethod = new ImageMethod();
        DialogsShow dialogsShow = new DialogsShow();

        private void btnEditAdd_Click(object sender, EventArgs e)
        {
            EmployeeAditUI employeeAdit = new EmployeeAditUI();

            employeeAdit.id=0;
            employeeAdit.Show();
            employeeAdit.btnAdd.Text = "Ekle";
            employeeAdit.btnAdd.ForeColor = Color.LawnGreen;
        }

        private void btnAditUpdate_Click(object sender, EventArgs e)
        {
            EmployeeAditUI employeeAdit = new EmployeeAditUI();

            employeeAdit.id = Convert.ToInt32(tileView1.GetFocusedRowCellValue("EmployeeId"));
            employeeAdit.Show();
            employeeAdit.btnAdd.Text = "Günceleme";
            employeeAdit.btnAdd.ForeColor = Color.Tomato;
            employeeAdit.tbxName.Text = tileView1.GetFocusedRowCellValue("EmployeeName").ToString();
            employeeAdit.tbxAdres.Text = tileView1.GetFocusedRowCellValue("Adress").ToString();
            employeeAdit.tbxMail.Text = tileView1.GetFocusedRowCellValue("Email").ToString();
            imageMethod.by = (byte[])tileView1.GetFocusedRowCellValue("Employeeİmage");
            employeeAdit.pictureEdit1.Image = Image.FromStream(imageMethod.ConvertToImage());
            employeeAdit.tbxPhone.Text = tileView1.GetFocusedRowCellValue("Phone").ToString();
            employeeAdit.tbxSalary.Text = tileView1.GetFocusedRowCellValue("Salary").ToString();
            employeeAdit.tbxStartDate.Text = tileView1.GetFocusedRowCellValue("StartDate").ToString();
            employeeAdit.cmpState.Text = tileView1.GetFocusedRowCellValue("EmployeeState").ToString();
        }

        private void btnAditDelet_Click(object sender, EventArgs e)
        {
            EmployeeAditUI employeeAdit = new EmployeeAditUI();

            employeeAdit.id = Convert.ToInt32(tileView1.GetFocusedRowCellValue("Id"));
            var result = MessageBox.Show("Bu ürün silmek istediğni emin misin?", "Silme işlem", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                employeeAdit.id =Convert.ToInt32(tileView1.GetFocusedRowCellValue("EmployeeId"));
                employeeAdit._employeeService.Delete(new Employee { EmployeeId = employeeAdit.id });
                gridControl1.DataSource = employeeAdit._employeeService.GetAll();
                dialogsShow.DialogShow("Ürürn Silindi!",Color.Tomato);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EmployeeAditUI employeeAditUI=new EmployeeAditUI();
            gridControl1.DataSource=_employeeService.GetAll();
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbxSearch.Text.Length == 0)
            {
                gridControl1.DataSource = _employeeService.GetAll();
            }
            else
            {
                gridControl1.DataSource = _employeeService.GetEmployeebyEmployeeName(tbxSearch.Text);

            }
        }
    }
}
