﻿using ProcessProject.DB_Access;
using ProcessProject.OtherClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessProject.OtherForm
{
    public partial class EditStudent : Form
    {
        public EditStudent()
        {
            InitializeComponent();
        }

        public EditStudent(int ID)
        {
            InitializeComponent();
            _Load(ID); ;
        }

        private void _Load(int ID)
        {
            StudenAccess acs = new StudenAccess();
            student std = acs.getStuden(ID);
            txtID.Text = std.C01_id.ToString().Trim();
            txtFirstName.Text = std.C02_firtsname.ToString().Trim();
            txtLastName.Text = std.C03_lastname.ToString().Trim();
            timeBirthday.Text = std.C04_birthday.ToString().Trim();
            if (std.C05_gender == true)
                radMale.Checked = true;
            else radFemale.Checked = true;
            txtPhone.Text = std.C06_phonenumber.ToString().Trim();
            txtAddress.Text = std.C07_address.ToString().Trim();
            //picAvatar.Image = AllUser.BinaryToImage(new byte[std.C08_avatar.Length]);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            StudenAccess stdac = new StudenAccess();
            try
            {
                student std = new student
                {
                    C01_id = int.Parse(txtID.Text),
                    C02_firtsname = txtFirstName.Text,
                    C03_lastname = txtLastName.Text,
                    C04_birthday = timeBirthday.Value,
                    C05_gender = radMale.Checked,
                    C06_phonenumber = txtPhone.Text,
                    C07_address = txtAddress.Text,
                    //C08_avatar = new Binary(AllUser.ImageToBinary(picAvatar.Image))
                };
                stdac.Edit(std);
                this.Close();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bynCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picAvatar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    picAvatar.Image = new Bitmap(open.FileName);
                }
            }
            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            StudenAccess stdac = new StudenAccess();
            try
            {
                student std = new student
                {
                    C01_id = int.Parse(txtID.Text),
                    C02_firtsname = txtFirstName.Text,
                    C03_lastname = txtLastName.Text,
                    C04_birthday = timeBirthday.Value,
                    C05_gender = radMale.Checked,
                    C06_phonenumber = txtPhone.Text,
                    C07_address = txtAddress.Text,
                    //C08_avatar = new Binary(AllUser.ImageToBinary(picAvatar.Image))
                };
                stdac.Remove(std);
                this.Close();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
