namespace DatabasUppgift
{
    partial class Students
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
            this.Title = new System.Windows.Forms.TextBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.gBoxAdd = new System.Windows.Forms.GroupBox();
            this.tBoxLastName = new System.Windows.Forms.TextBox();
            this.btnSubmitAdd = new System.Windows.Forms.Button();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tBoxEpost = new System.Windows.Forms.TextBox();
            this.lblEpost = new System.Windows.Forms.Label();
            this.tBoxTelenr = new System.Windows.Forms.TextBox();
            this.tBoxAdress = new System.Windows.Forms.TextBox();
            this.tBoxFirstName = new System.Windows.Forms.TextBox();
            this.lblTelenr = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblPage = new System.Windows.Forms.Label();
            this.gBoxRemove = new System.Windows.Forms.GroupBox();
            this.btnSubmitRemove = new System.Windows.Forms.Button();
            this.tBoxID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.gBoxStudents = new System.Windows.Forms.GroupBox();
            this.lBoxStudents = new System.Windows.Forms.ListBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_ChangeLastName = new System.Windows.Forms.TextBox();
            this.btn_SubmitChange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_ChangeEpost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ChangePhoneNumber = new System.Windows.Forms.TextBox();
            this.tb_ChangeAdress = new System.Windows.Forms.TextBox();
            this.tb_ChangeFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gBoxAdd.SuspendLayout();
            this.gBoxRemove.SuspendLayout();
            this.gBoxStudents.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Enabled = false;
            this.Title.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Title.Location = new System.Drawing.Point(528, 15);
            this.Title.Margin = new System.Windows.Forms.Padding(4);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(704, 119);
            this.Title.TabIndex = 2;
            this.Title.Text = "Softschool";
            this.Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(1648, 967);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(228, 58);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // gBoxAdd
            // 
            this.gBoxAdd.Controls.Add(this.tBoxLastName);
            this.gBoxAdd.Controls.Add(this.btnSubmitAdd);
            this.gBoxAdd.Controls.Add(this.lblLastName);
            this.gBoxAdd.Controls.Add(this.tBoxEpost);
            this.gBoxAdd.Controls.Add(this.lblEpost);
            this.gBoxAdd.Controls.Add(this.tBoxTelenr);
            this.gBoxAdd.Controls.Add(this.tBoxAdress);
            this.gBoxAdd.Controls.Add(this.tBoxFirstName);
            this.gBoxAdd.Controls.Add(this.lblTelenr);
            this.gBoxAdd.Controls.Add(this.lblAdress);
            this.gBoxAdd.Controls.Add(this.lblFirstName);
            this.gBoxAdd.Location = new System.Drawing.Point(688, 215);
            this.gBoxAdd.Margin = new System.Windows.Forms.Padding(4);
            this.gBoxAdd.Name = "gBoxAdd";
            this.gBoxAdd.Padding = new System.Windows.Forms.Padding(4);
            this.gBoxAdd.Size = new System.Drawing.Size(376, 270);
            this.gBoxAdd.TabIndex = 4;
            this.gBoxAdd.TabStop = false;
            this.gBoxAdd.Text = "Enter student to add";
            // 
            // tBoxLastName
            // 
            this.tBoxLastName.Location = new System.Drawing.Point(141, 75);
            this.tBoxLastName.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxLastName.Name = "tBoxLastName";
            this.tBoxLastName.Size = new System.Drawing.Size(225, 22);
            this.tBoxLastName.TabIndex = 9;
            // 
            // btnSubmitAdd
            // 
            this.btnSubmitAdd.Location = new System.Drawing.Point(268, 234);
            this.btnSubmitAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmitAdd.Name = "btnSubmitAdd";
            this.btnSubmitAdd.Size = new System.Drawing.Size(100, 28);
            this.btnSubmitAdd.TabIndex = 5;
            this.btnSubmitAdd.Text = "Submit";
            this.btnSubmitAdd.UseVisualStyleBackColor = true;
            this.btnSubmitAdd.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(8, 79);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 17);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "Last Name";
            // 
            // tBoxEpost
            // 
            this.tBoxEpost.Location = new System.Drawing.Point(141, 188);
            this.tBoxEpost.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxEpost.Name = "tBoxEpost";
            this.tBoxEpost.Size = new System.Drawing.Size(225, 22);
            this.tBoxEpost.TabIndex = 7;
            // 
            // lblEpost
            // 
            this.lblEpost.AutoSize = true;
            this.lblEpost.Location = new System.Drawing.Point(8, 192);
            this.lblEpost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEpost.Name = "lblEpost";
            this.lblEpost.Size = new System.Drawing.Size(49, 17);
            this.lblEpost.TabIndex = 6;
            this.lblEpost.Text = "E-post";
            // 
            // tBoxTelenr
            // 
            this.tBoxTelenr.Location = new System.Drawing.Point(141, 151);
            this.tBoxTelenr.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxTelenr.Name = "tBoxTelenr";
            this.tBoxTelenr.Size = new System.Drawing.Size(225, 22);
            this.tBoxTelenr.TabIndex = 5;
            // 
            // tBoxAdress
            // 
            this.tBoxAdress.Location = new System.Drawing.Point(141, 114);
            this.tBoxAdress.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxAdress.Name = "tBoxAdress";
            this.tBoxAdress.Size = new System.Drawing.Size(225, 22);
            this.tBoxAdress.TabIndex = 4;
            // 
            // tBoxFirstName
            // 
            this.tBoxFirstName.Location = new System.Drawing.Point(141, 37);
            this.tBoxFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxFirstName.Name = "tBoxFirstName";
            this.tBoxFirstName.Size = new System.Drawing.Size(225, 22);
            this.tBoxFirstName.TabIndex = 3;
            // 
            // lblTelenr
            // 
            this.lblTelenr.AutoSize = true;
            this.lblTelenr.Location = new System.Drawing.Point(8, 155);
            this.lblTelenr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelenr.Name = "lblTelenr";
            this.lblTelenr.Size = new System.Drawing.Size(107, 17);
            this.lblTelenr.TabIndex = 2;
            this.lblTelenr.Text = "Telefonnummer";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(8, 118);
            this.lblAdress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(52, 17);
            this.lblAdress.TabIndex = 1;
            this.lblAdress.Text = "Adress";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(8, 41);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(76, 17);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.Location = new System.Drawing.Point(148, 31);
            this.lblPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(95, 28);
            this.lblPage.TabIndex = 25;
            this.lblPage.Text = "Students";
            // 
            // gBoxRemove
            // 
            this.gBoxRemove.Controls.Add(this.btnSubmitRemove);
            this.gBoxRemove.Controls.Add(this.tBoxID);
            this.gBoxRemove.Controls.Add(this.lblID);
            this.gBoxRemove.Location = new System.Drawing.Point(1244, 215);
            this.gBoxRemove.Margin = new System.Windows.Forms.Padding(4);
            this.gBoxRemove.Name = "gBoxRemove";
            this.gBoxRemove.Padding = new System.Windows.Forms.Padding(4);
            this.gBoxRemove.Size = new System.Drawing.Size(376, 134);
            this.gBoxRemove.TabIndex = 10;
            this.gBoxRemove.TabStop = false;
            this.gBoxRemove.Text = "Enter student to remove";
            // 
            // btnSubmitRemove
            // 
            this.btnSubmitRemove.Location = new System.Drawing.Point(268, 98);
            this.btnSubmitRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmitRemove.Name = "btnSubmitRemove";
            this.btnSubmitRemove.Size = new System.Drawing.Size(100, 28);
            this.btnSubmitRemove.TabIndex = 5;
            this.btnSubmitRemove.Text = "Submit";
            this.btnSubmitRemove.UseVisualStyleBackColor = true;
            this.btnSubmitRemove.Click += new System.EventHandler(this.BtnSubmitRemove_Click_1);
            // 
            // tBoxID
            // 
            this.tBoxID.Location = new System.Drawing.Point(141, 37);
            this.tBoxID.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxID.Name = "tBoxID";
            this.tBoxID.Size = new System.Drawing.Size(225, 22);
            this.tBoxID.TabIndex = 3;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(8, 41);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 17);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // gBoxStudents
            // 
            this.gBoxStudents.Controls.Add(this.lBoxStudents);
            this.gBoxStudents.Controls.Add(this.btnLoad);
            this.gBoxStudents.Location = new System.Drawing.Point(93, 215);
            this.gBoxStudents.Margin = new System.Windows.Forms.Padding(4);
            this.gBoxStudents.Name = "gBoxStudents";
            this.gBoxStudents.Padding = new System.Windows.Forms.Padding(4);
            this.gBoxStudents.Size = new System.Drawing.Size(376, 752);
            this.gBoxStudents.TabIndex = 11;
            this.gBoxStudents.TabStop = false;
            this.gBoxStudents.Text = "Students";
            // 
            // lBoxStudents
            // 
            this.lBoxStudents.FormattingEnabled = true;
            this.lBoxStudents.ItemHeight = 16;
            this.lBoxStudents.Location = new System.Drawing.Point(8, 37);
            this.lBoxStudents.Margin = new System.Windows.Forms.Padding(4);
            this.lBoxStudents.Name = "lBoxStudents";
            this.lBoxStudents.Size = new System.Drawing.Size(359, 660);
            this.lBoxStudents.TabIndex = 11;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(241, 710);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(127, 34);
            this.btnLoad.TabIndex = 10;
            this.btnLoad.Text = "Load students";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(1256, 378);
            this.btnChange.Margin = new System.Windows.Forms.Padding(4);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(141, 50);
            this.btnChange.TabIndex = 26;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(1456, 378);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(141, 50);
            this.btnRemove.TabIndex = 27;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click_1);
            // 
            // pnlOptions
            // 
            this.pnlOptions.Location = new System.Drawing.Point(1259, 403);
            this.pnlOptions.Margin = new System.Windows.Forms.Padding(4);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(353, 50);
            this.pnlOptions.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_ChangeLastName);
            this.groupBox1.Controls.Add(this.btn_SubmitChange);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_ChangeEpost);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_ChangePhoneNumber);
            this.groupBox1.Controls.Add(this.tb_ChangeAdress);
            this.groupBox1.Controls.Add(this.tb_ChangeFirstName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(1221, 480);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(376, 270);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter student to add";
            // 
            // tb_ChangeLastName
            // 
            this.tb_ChangeLastName.Location = new System.Drawing.Point(141, 75);
            this.tb_ChangeLastName.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ChangeLastName.Name = "tb_ChangeLastName";
            this.tb_ChangeLastName.Size = new System.Drawing.Size(225, 22);
            this.tb_ChangeLastName.TabIndex = 9;
            // 
            // btn_SubmitChange
            // 
            this.btn_SubmitChange.Location = new System.Drawing.Point(268, 234);
            this.btn_SubmitChange.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SubmitChange.Name = "btn_SubmitChange";
            this.btn_SubmitChange.Size = new System.Drawing.Size(100, 28);
            this.btn_SubmitChange.TabIndex = 5;
            this.btn_SubmitChange.Text = "Submit";
            this.btn_SubmitChange.UseVisualStyleBackColor = true;
            this.btn_SubmitChange.Click += new System.EventHandler(this.Btn_SubmitChange_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Last Name";
            // 
            // tb_ChangeEpost
            // 
            this.tb_ChangeEpost.Location = new System.Drawing.Point(141, 188);
            this.tb_ChangeEpost.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ChangeEpost.Name = "tb_ChangeEpost";
            this.tb_ChangeEpost.Size = new System.Drawing.Size(225, 22);
            this.tb_ChangeEpost.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "E-post";
            // 
            // tb_ChangePhoneNumber
            // 
            this.tb_ChangePhoneNumber.Location = new System.Drawing.Point(141, 151);
            this.tb_ChangePhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ChangePhoneNumber.Name = "tb_ChangePhoneNumber";
            this.tb_ChangePhoneNumber.Size = new System.Drawing.Size(225, 22);
            this.tb_ChangePhoneNumber.TabIndex = 5;
            // 
            // tb_ChangeAdress
            // 
            this.tb_ChangeAdress.Location = new System.Drawing.Point(141, 114);
            this.tb_ChangeAdress.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ChangeAdress.Name = "tb_ChangeAdress";
            this.tb_ChangeAdress.Size = new System.Drawing.Size(225, 22);
            this.tb_ChangeAdress.TabIndex = 4;
            // 
            // tb_ChangeFirstName
            // 
            this.tb_ChangeFirstName.Location = new System.Drawing.Point(141, 37);
            this.tb_ChangeFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ChangeFirstName.Name = "tb_ChangeFirstName";
            this.tb_ChangeFirstName.Size = new System.Drawing.Size(225, 22);
            this.tb_ChangeFirstName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefonnummer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Adress";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "First Name";
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1892, 1040);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlOptions);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.gBoxStudents);
            this.Controls.Add(this.gBoxRemove);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.gBoxAdd);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.Title);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Students";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.gBoxAdd.ResumeLayout(false);
            this.gBoxAdd.PerformLayout();
            this.gBoxRemove.ResumeLayout(false);
            this.gBoxRemove.PerformLayout();
            this.gBoxStudents.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.GroupBox gBoxAdd;
        private System.Windows.Forms.TextBox tBoxFirstName;
        private System.Windows.Forms.Label lblTelenr;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox tBoxTelenr;
        private System.Windows.Forms.TextBox tBoxAdress;
        private System.Windows.Forms.Button btnSubmitAdd;
        private System.Windows.Forms.TextBox tBoxEpost;
        private System.Windows.Forms.Label lblEpost;
        private System.Windows.Forms.TextBox tBoxLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.GroupBox gBoxRemove;
        private System.Windows.Forms.Button btnSubmitRemove;
        private System.Windows.Forms.TextBox tBoxID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox gBoxStudents;
        private System.Windows.Forms.ListBox lBoxStudents;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_ChangeLastName;
        private System.Windows.Forms.Button btn_SubmitChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ChangeEpost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_ChangePhoneNumber;
        private System.Windows.Forms.TextBox tb_ChangeAdress;
        private System.Windows.Forms.TextBox tb_ChangeFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}