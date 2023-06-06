
namespace MyContacts
{
    partial class Form2
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
            this.SubmitData = new System.Windows.Forms.Label();
            this.addresstext = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.phonetext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AgeText = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.Label();
            this.emailtext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.familytext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nametext = new System.Windows.Forms.TextBox();
            this.textname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SubmitData
            // 
            this.SubmitData.AutoSize = true;
            this.SubmitData.Location = new System.Drawing.Point(345, 331);
            this.SubmitData.Name = "SubmitData";
            this.SubmitData.Size = new System.Drawing.Size(23, 13);
            this.SubmitData.TabIndex = 25;
            this.SubmitData.Text = "ثبت";
            this.SubmitData.Click += new System.EventHandler(this.SubmitData_Click);
            // 
            // addresstext
            // 
            this.addresstext.Location = new System.Drawing.Point(24, 156);
            this.addresstext.Multiline = true;
            this.addresstext.Name = "addresstext";
            this.addresstext.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.addresstext.Size = new System.Drawing.Size(383, 160);
            this.addresstext.TabIndex = 24;
            this.addresstext.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "آدرس";
            // 
            // phonetext
            // 
            this.phonetext.Location = new System.Drawing.Point(24, 67);
            this.phonetext.Name = "phonetext";
            this.phonetext.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.phonetext.Size = new System.Drawing.Size(124, 20);
            this.phonetext.TabIndex = 22;
            this.phonetext.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "تلفن";
            // 
            // AgeText
            // 
            this.AgeText.Location = new System.Drawing.Point(282, 67);
            this.AgeText.Name = "AgeText";
            this.AgeText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AgeText.Size = new System.Drawing.Size(124, 20);
            this.AgeText.TabIndex = 20;
            this.AgeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(429, 70);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(23, 13);
            this.age.TabIndex = 19;
            this.age.Text = "سن";
            // 
            // emailtext
            // 
            this.emailtext.Location = new System.Drawing.Point(24, 109);
            this.emailtext.Name = "emailtext";
            this.emailtext.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.emailtext.Size = new System.Drawing.Size(383, 20);
            this.emailtext.TabIndex = 18;
            this.emailtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "ایمیل";
            // 
            // familytext
            // 
            this.familytext.Location = new System.Drawing.Point(24, 27);
            this.familytext.Name = "familytext";
            this.familytext.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.familytext.Size = new System.Drawing.Size(124, 20);
            this.familytext.TabIndex = 16;
            this.familytext.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "نام خانوادگی";
            // 
            // nametext
            // 
            this.nametext.Location = new System.Drawing.Point(283, 26);
            this.nametext.Name = "nametext";
            this.nametext.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nametext.Size = new System.Drawing.Size(124, 20);
            this.nametext.TabIndex = 14;
            this.nametext.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textname
            // 
            this.textname.AutoSize = true;
            this.textname.Location = new System.Drawing.Point(430, 29);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(20, 13);
            this.textname.TabIndex = 13;
            this.textname.Text = "نام";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(479, 364);
            this.Controls.Add(this.SubmitData);
            this.Controls.Add(this.addresstext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phonetext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AgeText);
            this.Controls.Add(this.age);
            this.Controls.Add(this.emailtext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.familytext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nametext);
            this.Controls.Add(this.textname);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SubmitData;
        private System.Windows.Forms.TextBox addresstext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phonetext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AgeText;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.TextBox emailtext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox familytext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nametext;
        private System.Windows.Forms.Label textname;
    }
}