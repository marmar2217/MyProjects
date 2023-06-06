
namespace MyContacts
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ViewContact = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.addUser = new System.Windows.Forms.Button();
            this.UpdateUser = new System.Windows.Forms.Button();
            this.DeleteUser = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(13, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(514, 235);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مخاطبان من";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(502, 201);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ViewContact
            // 
            this.ViewContact.ForeColor = System.Drawing.Color.Purple;
            this.ViewContact.Location = new System.Drawing.Point(416, 19);
            this.ViewContact.Name = "ViewContact";
            this.ViewContact.Size = new System.Drawing.Size(105, 28);
            this.ViewContact.TabIndex = 4;
            this.ViewContact.Text = "نمایش مخاطبان";
            this.ViewContact.UseVisualStyleBackColor = true;
            this.ViewContact.Click += new System.EventHandler(this.ViewContact_Click);
            // 
            // Update
            // 
            this.Update.ForeColor = System.Drawing.Color.Purple;
            this.Update.Location = new System.Drawing.Point(293, 19);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(105, 28);
            this.Update.TabIndex = 5;
            this.Update.Text = "به روز رسانی";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // addUser
            // 
            this.addUser.ForeColor = System.Drawing.Color.Purple;
            this.addUser.Location = new System.Drawing.Point(378, 294);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(105, 28);
            this.addUser.TabIndex = 6;
            this.addUser.Text = "افزودن کاربر";
            this.addUser.UseVisualStyleBackColor = true;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // UpdateUser
            // 
            this.UpdateUser.ForeColor = System.Drawing.Color.Purple;
            this.UpdateUser.Location = new System.Drawing.Point(243, 294);
            this.UpdateUser.Name = "UpdateUser";
            this.UpdateUser.Size = new System.Drawing.Size(105, 28);
            this.UpdateUser.TabIndex = 7;
            this.UpdateUser.Text = "ویرایش کاربر";
            this.UpdateUser.UseVisualStyleBackColor = true;
            this.UpdateUser.Click += new System.EventHandler(this.UpdateUser_Click);
            // 
            // DeleteUser
            // 
            this.DeleteUser.ForeColor = System.Drawing.Color.Purple;
            this.DeleteUser.Location = new System.Drawing.Point(91, 294);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(105, 28);
            this.DeleteUser.TabIndex = 8;
            this.DeleteUser.Text = "حذف کاربر";
            this.DeleteUser.UseVisualStyleBackColor = true;
            this.DeleteUser.Click += new System.EventHandler(this.DeleteUser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 346);
            this.Controls.Add(this.DeleteUser);
            this.Controls.Add(this.UpdateUser);
            this.Controls.Add(this.addUser);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.ViewContact);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ViewContact;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.Button UpdateUser;
        private System.Windows.Forms.Button DeleteUser;
    }
}