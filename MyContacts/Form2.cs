using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyContacts
{
    public partial class Form2 : Form
    {
        IContactsDB repository;
        int ID = Form1.Id;

        public Form2()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            if (ID == 0)
            {
                this.Text = "افزودن شخص جدید";
            }
            else
            {
                repository = new ContactsDB();
                DataTable dt = repository.SelectRow(ID);
                this.Text = "ویرایش شخص";
                nametext.Text = dt.Rows[0][1].ToString();
                familytext.Text = dt.Rows[0][2].ToString();
                AgeText.Text = dt.Rows[0][3].ToString();
                phonetext.Text = dt.Rows[0][4].ToString();
                emailtext.Text = dt.Rows[0][5].ToString();
                addresstext.Text = dt.Rows[0][6].ToString();
            }
        }
        private void SubmitData_Click(object sender, EventArgs e)
        {
            repository = new ContactsDB();
            bool isSuccess;

            if (ID == 0)
            {
                isSuccess = repository.Insert(nametext.Text, familytext.Text, int.Parse(AgeText.Text), phonetext.Text, emailtext.Text, addresstext.Text);
            }
            else
            {
                isSuccess = repository.Update(ID, nametext.Text, familytext.Text, int.Parse(AgeText.Text), phonetext.Text, emailtext.Text, addresstext.Text);                
            }

            if (isSuccess)
            {
                MessageBox.Show(".عملیات با موفقیت انجام شد");
            }
            else
            {
                MessageBox.Show(".عملیات با شکست مواجه شد");
            }
        }
    }
}
