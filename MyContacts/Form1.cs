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
    public partial class Form1 : Form
    {

        IContactsDB repository;

        public static int Id;
        
        public Form1()
        {
            InitializeComponent();
        }
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewContacts_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void BindGrid()
        {
            repository = new ContactsDB();
            dataGridView1.DataSource = repository.SelectAll();
        }
        private void ViewContact_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void addUser_Click(object sender, EventArgs e)
        {                       
            Form2 frmAddOrEdit = new Form2();
            frmAddOrEdit.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UpdateUser_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.CurrentRow != null)
            {
                Form1.Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                Form2 frmAddOrEdit = new Form2();
                frmAddOrEdit.ShowDialog();
            }
            else
            {
                MessageBox.Show("لطفا یک کاربر را انتخاب کنید");
            }
           
        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int ID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                DialogResult dialogResult = MessageBox.Show("", "آیا از حذف مخاطب مطمئن هستید؟", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    repository = new ContactsDB();
                    bool isSuccess = repository.Delete(ID);
                    MessageBox.Show(".مخاطب با موفقیت حذف شد");
                }
                else if (dialogResult == DialogResult.No)
                {
                }
            }
            else
            {
                MessageBox.Show("لطفا یک کاربر را انتخاب کنید");
            }
        }
    }
}
