using Business.Abstract;
using Business.Concreate;
using Business.Methods;
using DataAccess.Concreate.EntityFrameWork;
using Entities.Concreate;
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
    public partial class EmployeeAditUI : Form
    {
        public EmployeeAditUI()
        {
            InitializeComponent();
            _employeeService = new EmployeeManager(new EfEmployee());
        }
        public IEmployeeService _employeeService;
        ImageMethod imageMethod = new ImageMethod(); 
        DialogsShow dialogsShow = new DialogsShow();
        public int id;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                pictureEdit1.Image.Save(imageMethod.memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                _employeeService.Add(new Employee
                {
                    EmployeeName = tbxName.Text,
                    Email = tbxMail.Text,
                    Adress = tbxAdres.Text,
                    Salary=Convert.ToDecimal(tbxSalary.Text),
                    Phone=tbxPhone.Text,  
                    StartDate=Convert.ToDateTime(tbxStartDate.Text),
                    EmployeeState=Convert.ToBoolean(cmpState.Text),
                    Employeeİmage = imageMethod.ConvertToByte()
                });
                dialogsShow.DialogShow("Ürürn Eklendi!",Color.LawnGreen);
                this.Close();
            }
            else
            {
                pictureEdit1.Image.Save(imageMethod.memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                _employeeService.Update(new Employee
                {
                    EmployeeId= id,
                    EmployeeName = tbxName.Text,
                    Email = tbxMail.Text,
                    Adress = tbxAdres.Text,
                    Salary = Convert.ToDecimal(tbxSalary.Text),
                    Phone = tbxPhone.Text,
                    StartDate = Convert.ToDateTime(tbxStartDate.Text),
                    EmployeeState = Convert.ToBoolean(cmpState.Text),
                    Employeeİmage = imageMethod.ConvertToByte()
                });
                dialogsShow.DialogShow("Ürürn Güncelendi!",Color.Thistle);
                this.Close();
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
