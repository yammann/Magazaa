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
    public partial class UserAditUI : Form
    {
        public UserAditUI()
        {
            InitializeComponent();
            _usersService = new UsersManager(new EfUser());
            _userRuleService=new UserRuleManager(new EfUserRrule());
        }
        private IUsersService _usersService;
        private IUserRuleService _userRuleService;
        ImageMethod imageMethod = new ImageMethod();
        DialogsShow dialog = new DialogsShow();
        public int id;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(id==0)
            {
                pictureEdit1.Image.Save(imageMethod.memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                var user = _usersService.GetUserByName(tbxUserName.Text);
                if(user==null)
                {
                    _usersService.Add(new User
                    {
                        FirstName = tbxFirstName.Text,
                        UserName = tbxUserName.Text,
                        LastName = tbxLastName.Text,
                        Ppassword = tbxPassowrd.Text,
                        Covir = imageMethod.ConvertToByte(),
                        Email=tbxEmail.Text                    
                    });
                    var user2 = _usersService.GetUserByName(tbxUserName.Text);
                    _userRuleService.Add(new UserRrule()
                    {
                        UserId = user2.Id,
                        RuleId=comboBox1.SelectedIndex+1
                    });
                    dialog.DialogShow("User eklandı!", Color.LawnGreen);
                    this.Close();
                }
                else
                {
                    dialog.DialogShow("Bu kulanıcı adı kulanıldı!", Color.Snow);
                }
                

            }
            else if(id==1)
            {

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
