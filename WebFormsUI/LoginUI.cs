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
    public partial class LoginUI : Form
    {
        public LoginUI()
        {
            InitializeComponent();
            _usersService = new UsersManager(new EfUser());
            _userRuleService = new UserRuleManager(new EfUserRrule());
        }
        IUsersService _usersService;
        IUserRuleService _userRuleService;
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (tbxUserName.Text != "" && tbxPassowrd.Text != "") 
            {
                string userName=tbxUserName.Text;
                string password=tbxPassowrd.Text;
                var user=_usersService.GetUserByName(userName);
                if (user != null)
                {
                    if(user.Ppassword == password)
                    {
                        var rule = _userRuleService.GetUser(user.Id);
                        if(rule.RuleId==1)
                        {
                            BaseForm baseForm = new BaseForm();
                            ImageMethod imageMethod = new ImageMethod();
                            imageMethod.by = user.Covir;

                            baseForm.btnEmployee.Hide();
                            baseForm.btnOrder.Hide();
                            baseForm.btnReport.Hide();
                            baseForm.btnStore.Hide();
                            baseForm.btnUsers.Hide();

                            baseForm.lblEmployeeName.Text = user.FirstName + " " + user.LastName;
                            baseForm.lblEmployeeRole.Text = "Çalışan";
                            baseForm.picEmployee.Image = Image.FromStream(imageMethod.ConvertToImage());

                            baseForm.Show();
                        }
                        else if(rule.RuleId==2)
                        {
                            BaseForm baseForm = new BaseForm();
                            ImageMethod imageMethod = new ImageMethod();

                            imageMethod.by = user.Covir;
                            baseForm.btnEmployee.Hide();
                            baseForm.btnOrder.Show();
                            baseForm.btnReport.Show();
                            baseForm.btnStore.Show();
                            baseForm.btnUsers.Hide();
                    
                            baseForm.lblEmployeeName.Text = user.FirstName + " " + user.LastName;
                            baseForm.lblEmployeeRole.Text = "Yönetici";
                            baseForm.picEmployee.Image = Image.FromStream(imageMethod.ConvertToImage());

                            baseForm.ShowDialog();
                        }
                        else if(rule.RuleId==3)
                        {
                            BaseForm baseForm = new BaseForm();
                            ImageMethod imageMethod = new ImageMethod();
                            imageMethod.by = user.Covir;

                            baseForm.btnEmployee.Show();
                            baseForm.btnOrder.Show();
                            baseForm.btnReport.Show();
                            baseForm.btnStore.Show();
                            baseForm.btnUsers.Show();

                            baseForm.lblEmployeeName.Text = user.FirstName + " " + user.LastName;
                            baseForm.lblEmployeeRole.Text = "Müdür";
                            baseForm.picEmployee.Image = Image.FromStream(imageMethod.ConvertToImage());
                            baseForm.Show();
                        }
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
