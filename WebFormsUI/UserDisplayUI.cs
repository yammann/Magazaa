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
using Business.Abstract;
using Business.Concreate;
using DataAccess.Concreate.EntityFrameWork;
using Entities.Concreate;
using Business.Methods;

namespace WebFormsUI
{
    public partial class UserDisplayUI : Form
    {
        public UserDisplayUI()
        {
            InitializeComponent();

            _usersService = new UsersManager(new EfUser());
          
        }
        private IUsersService _usersService;
        DialogsShow dialog= new DialogsShow();
        ImageMethod imageMethod= new ImageMethod();
        int userId;
        private void btnEditAdd_Click(object sender, EventArgs e)
        {
            UserAditUI userAditUI=new UserAditUI();
            userAditUI.btnAdd.Text = "Ekle";
            userAditUI.btnAdd.ForeColor = Color.LawnGreen;
            userAditUI.Show();
            userAditUI.id = 0;
        }

        private void btnAditDelet_Click(object sender, EventArgs e)
        {
            if(userId==0)
            {
                dialog.DialogShow("Bir kulanıcı seçiniz!",Color.Red);
            }
            else
            {
                var result=MessageBox.Show("Bu kulanıcı silmek istedinizdan emin misiniz?", "Uyar", MessageBoxButtons.YesNo);
                if(result==DialogResult.Yes)
                {
                    _usersService.Delete(new User { Id=userId });
                }
                gridControl1.DataSource = _usersService.GetAll();
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            userId = Convert.ToInt32(cardView1.GetFocusedRowCellValue("Id"));
        }

        private void btnAditUpdate_Click(object sender, EventArgs e)
        {
            UserAditUI userAditUI = new UserAditUI();
            userAditUI.btnAdd.Text = "Gunceleme";
            userAditUI.btnAdd.ForeColor = Color.Tomato;
            userAditUI.Show();
            userAditUI.id=1;
            
            var user=_usersService.GetUser(userId);
            if (user != null)
            {
                userAditUI.tbxUserName.Text = user.UserName;
                userAditUI.tbxFirstName.Text = user.FirstName;
                userAditUI.tbxLastName.Text = user.LastName;
                userAditUI.tbxEmail.Text = user.Email;
                userAditUI.tbxPassowrd.Text = user.Ppassword;
                imageMethod.by = user.Covir;
                userAditUI.pictureEdit1.Image = Image.FromStream(imageMethod.ConvertToImage());
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = _usersService.GetAll();
        }
    }
}
