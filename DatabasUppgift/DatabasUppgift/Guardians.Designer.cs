namespace DatabasUppgift
{
    partial class Guardians
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
            this.lblPage = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.gBoxAddGuardian = new System.Windows.Forms.GroupBox();
            this.tBoxLastName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tBoxEpost = new System.Windows.Forms.TextBox();
            this.lblEpost = new System.Windows.Forms.Label();
            this.tBoxTelenr = new System.Windows.Forms.TextBox();
            this.tBoxAdress = new System.Windows.Forms.TextBox();
            this.tBoxFirstName = new System.Windows.Forms.TextBox();
            this.lblTelenr = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.gBoxGuardians = new System.Windows.Forms.GroupBox();
            this.lBoxGuardians = new System.Windows.Forms.ListBox();
            this.btnLoadGuardians = new System.Windows.Forms.Button();
            this.gBoxFindGuardian = new System.Windows.Forms.GroupBox();
            this.btnSubmitFind = new System.Windows.Forms.Button();
            this.tBoxID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
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
            this.pnlNewDetails = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_DisplayGuardian = new System.Windows.Forms.TextBox();
            this.gBoxAddGuardian.SuspendLayout();
            this.gBoxGuardians.SuspendLayout();
            this.gBoxFindGuardian.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Title.Enabled = false;
            this.Title.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Title.Location = new System.Drawing.Point(396, 12);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(529, 90);
            this.Title.TabIndex = 3;
            this.Title.Text = "Softschool";
            this.Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.Location = new System.Drawing.Point(111, 25);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(82, 23);
            this.lblPage.TabIndex = 26;
            this.lblPage.Text = "Guardians";
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(1236, 786);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(171, 47);
            this.btnHome.TabIndex = 27;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // gBoxAddGuardian
            // 
            this.gBoxAddGuardian.Controls.Add(this.tBoxLastName);
            this.gBoxAddGuardian.Controls.Add(this.btnSubmit);
            this.gBoxAddGuardian.Controls.Add(this.lblLastName);
            this.gBoxAddGuardian.Controls.Add(this.tBoxEpost);
            this.gBoxAddGuardian.Controls.Add(this.lblEpost);
            this.gBoxAddGuardian.Controls.Add(this.tBoxTelenr);
            this.gBoxAddGuardian.Controls.Add(this.tBoxAdress);
            this.gBoxAddGuardian.Controls.Add(this.tBoxFirstName);
            this.gBoxAddGuardian.Controls.Add(this.lblTelenr);
            this.gBoxAddGuardian.Controls.Add(this.lblAdress);
            this.gBoxAddGuardian.Controls.Add(this.lblFirstName);
            this.gBoxAddGuardian.Location = new System.Drawing.Point(516, 175);
            this.gBoxAddGuardian.Name = "gBoxAddGuardian";
            this.gBoxAddGuardian.Size = new System.Drawing.Size(282, 219);
            this.gBoxAddGuardian.TabIndex = 28;
            this.gBoxAddGuardian.TabStop = false;
            this.gBoxAddGuardian.Text = "Enter Guardian Details";
            // 
            // tBoxLastName
            // 
            this.tBoxLastName.Location = new System.Drawing.Point(106, 61);
            this.tBoxLastName.Name = "tBoxLastName";
            this.tBoxLastName.Size = new System.Drawing.Size(170, 20);
            this.tBoxLastName.TabIndex = 9;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(201, 190);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(6, 64);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "Last Name";
            // 
            // tBoxEpost
            // 
            this.tBoxEpost.Location = new System.Drawing.Point(106, 153);
            this.tBoxEpost.Name = "tBoxEpost";
            this.tBoxEpost.Size = new System.Drawing.Size(170, 20);
            this.tBoxEpost.TabIndex = 7;
            // 
            // lblEpost
            // 
            this.lblEpost.AutoSize = true;
            this.lblEpost.Location = new System.Drawing.Point(6, 156);
            this.lblEpost.Name = "lblEpost";
            this.lblEpost.Size = new System.Drawing.Size(37, 13);
            this.lblEpost.TabIndex = 6;
            this.lblEpost.Text = "E-post";
            // 
            // tBoxTelenr
            // 
            this.tBoxTelenr.Location = new System.Drawing.Point(106, 123);
            this.tBoxTelenr.Name = "tBoxTelenr";
            this.tBoxTelenr.Size = new System.Drawing.Size(170, 20);
            this.tBoxTelenr.TabIndex = 5;
            // 
            // tBoxAdress
            // 
            this.tBoxAdress.Location = new System.Drawing.Point(106, 93);
            this.tBoxAdress.Name = "tBoxAdress";
            this.tBoxAdress.Size = new System.Drawing.Size(170, 20);
            this.tBoxAdress.TabIndex = 4;
            // 
            // tBoxFirstName
            // 
            this.tBoxFirstName.Location = new System.Drawing.Point(106, 30);
            this.tBoxFirstName.Name = "tBoxFirstName";
            this.tBoxFirstName.Size = new System.Drawing.Size(170, 20);
            this.tBoxFirstName.TabIndex = 3;
            // 
            // lblTelenr
            // 
            this.lblTelenr.AutoSize = true;
            this.lblTelenr.Location = new System.Drawing.Point(6, 126);
            this.lblTelenr.Name = "lblTelenr";
            this.lblTelenr.Size = new System.Drawing.Size(80, 13);
            this.lblTelenr.TabIndex = 2;
            this.lblTelenr.Text = "Telefonnummer";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(6, 96);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(39, 13);
            this.lblAdress.TabIndex = 1;
            this.lblAdress.Text = "Adress";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(6, 33);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // gBoxGuardians
            // 
            this.gBoxGuardians.Controls.Add(this.lBoxGuardians);
            this.gBoxGuardians.Controls.Add(this.btnLoadGuardians);
            this.gBoxGuardians.Location = new System.Drawing.Point(70, 175);
            this.gBoxGuardians.Name = "gBoxGuardians";
            this.gBoxGuardians.Size = new System.Drawing.Size(282, 611);
            this.gBoxGuardians.TabIndex = 29;
            this.gBoxGuardians.TabStop = false;
            this.gBoxGuardians.Text = "Guardians";
            // 
            // lBoxGuardians
            // 
            this.lBoxGuardians.FormattingEnabled = true;
            this.lBoxGuardians.Location = new System.Drawing.Point(6, 30);
            this.lBoxGuardians.Name = "lBoxGuardians";
            this.lBoxGuardians.Size = new System.Drawing.Size(270, 537);
            this.lBoxGuardians.TabIndex = 11;
            // 
            // btnLoadGuardians
            // 
            this.btnLoadGuardians.Location = new System.Drawing.Point(181, 577);
            this.btnLoadGuardians.Name = "btnLoadGuardians";
            this.btnLoadGuardians.Size = new System.Drawing.Size(95, 28);
            this.btnLoadGuardians.TabIndex = 10;
            this.btnLoadGuardians.Text = "Load guardians";
            this.btnLoadGuardians.UseVisualStyleBackColor = true;
            this.btnLoadGuardians.Click += new System.EventHandler(this.btnLoadGuardians_Click);
            // 
            // gBoxFindGuardian
            // 
            this.gBoxFindGuardian.Controls.Add(this.btnSubmitFind);
            this.gBoxFindGuardian.Controls.Add(this.tBoxID);
            this.gBoxFindGuardian.Controls.Add(this.lblID);
            this.gBoxFindGuardian.Location = new System.Drawing.Point(933, 175);
            this.gBoxFindGuardian.Name = "gBoxFindGuardian";
            this.gBoxFindGuardian.Size = new System.Drawing.Size(282, 109);
            this.gBoxFindGuardian.TabIndex = 30;
            this.gBoxFindGuardian.TabStop = false;
            this.gBoxFindGuardian.Text = "Enter guardian to find";
            // 
            // btnSubmitFind
            // 
            this.btnSubmitFind.Location = new System.Drawing.Point(201, 80);
            this.btnSubmitFind.Name = "btnSubmitFind";
            this.btnSubmitFind.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitFind.TabIndex = 5;
            this.btnSubmitFind.Text = "Submit";
            this.btnSubmitFind.UseVisualStyleBackColor = true;
            this.btnSubmitFind.Click += new System.EventHandler(this.btnSubmitFind_Click);
            // 
            // tBoxID
            // 
            this.tBoxID.Location = new System.Drawing.Point(106, 30);
            this.tBoxID.Name = "tBoxID";
            this.tBoxID.Size = new System.Drawing.Size(170, 20);
            this.tBoxID.TabIndex = 3;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(6, 33);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // pnlOptions
            // 
            this.pnlOptions.Location = new System.Drawing.Point(927, 311);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(298, 138);
            this.pnlOptions.TabIndex = 33;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(156, 73);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(106, 41);
            this.btnRemove.TabIndex = 32;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(6, 73);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(106, 41);
            this.btnChange.TabIndex = 31;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
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
            this.groupBox1.Location = new System.Drawing.Point(933, 469);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 219);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter new guardian details";
            // 
            // tb_ChangeLastName
            // 
            this.tb_ChangeLastName.Location = new System.Drawing.Point(106, 61);
            this.tb_ChangeLastName.Name = "tb_ChangeLastName";
            this.tb_ChangeLastName.Size = new System.Drawing.Size(170, 20);
            this.tb_ChangeLastName.TabIndex = 9;
            // 
            // btn_SubmitChange
            // 
            this.btn_SubmitChange.Location = new System.Drawing.Point(201, 190);
            this.btn_SubmitChange.Name = "btn_SubmitChange";
            this.btn_SubmitChange.Size = new System.Drawing.Size(75, 23);
            this.btn_SubmitChange.TabIndex = 5;
            this.btn_SubmitChange.Text = "Submit";
            this.btn_SubmitChange.UseVisualStyleBackColor = true;
            this.btn_SubmitChange.Click += new System.EventHandler(this.btn_SubmitChange_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Last Name";
            // 
            // tb_ChangeEpost
            // 
            this.tb_ChangeEpost.Location = new System.Drawing.Point(106, 153);
            this.tb_ChangeEpost.Name = "tb_ChangeEpost";
            this.tb_ChangeEpost.Size = new System.Drawing.Size(170, 20);
            this.tb_ChangeEpost.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "E-post";
            // 
            // tb_ChangePhoneNumber
            // 
            this.tb_ChangePhoneNumber.Location = new System.Drawing.Point(106, 123);
            this.tb_ChangePhoneNumber.Name = "tb_ChangePhoneNumber";
            this.tb_ChangePhoneNumber.Size = new System.Drawing.Size(170, 20);
            this.tb_ChangePhoneNumber.TabIndex = 5;
            // 
            // tb_ChangeAdress
            // 
            this.tb_ChangeAdress.Location = new System.Drawing.Point(106, 93);
            this.tb_ChangeAdress.Name = "tb_ChangeAdress";
            this.tb_ChangeAdress.Size = new System.Drawing.Size(170, 20);
            this.tb_ChangeAdress.TabIndex = 4;
            // 
            // tb_ChangeFirstName
            // 
            this.tb_ChangeFirstName.Location = new System.Drawing.Point(106, 30);
            this.tb_ChangeFirstName.Name = "tb_ChangeFirstName";
            this.tb_ChangeFirstName.Size = new System.Drawing.Size(170, 20);
            this.tb_ChangeFirstName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefonnummer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Adress";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "First Name";
            // 
            // pnlNewDetails
            // 
            this.pnlNewDetails.Location = new System.Drawing.Point(927, 469);
            this.pnlNewDetails.Name = "pnlNewDetails";
            this.pnlNewDetails.Size = new System.Drawing.Size(298, 235);
            this.pnlNewDetails.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_DisplayGuardian);
            this.groupBox2.Controls.Add(this.btnChange);
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Location = new System.Drawing.Point(933, 315);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 122);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose action for";
            // 
            // tb_DisplayGuardian
            // 
            this.tb_DisplayGuardian.Enabled = false;
            this.tb_DisplayGuardian.Location = new System.Drawing.Point(6, 19);
            this.tb_DisplayGuardian.Name = "tb_DisplayGuardian";
            this.tb_DisplayGuardian.Size = new System.Drawing.Size(270, 20);
            this.tb_DisplayGuardian.TabIndex = 33;
            // 
            // Guardians
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 845);
            this.Controls.Add(this.pnlNewDetails);
            this.Controls.Add(this.pnlOptions);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gBoxFindGuardian);
            this.Controls.Add(this.gBoxGuardians);
            this.Controls.Add(this.gBoxAddGuardian);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.Title);
            this.Name = "Guardians";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guardians";
            this.gBoxAddGuardian.ResumeLayout(false);
            this.gBoxAddGuardian.PerformLayout();
            this.gBoxGuardians.ResumeLayout(false);
            this.gBoxFindGuardian.ResumeLayout(false);
            this.gBoxFindGuardian.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.GroupBox gBoxAddGuardian;
        private System.Windows.Forms.TextBox tBoxLastName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox tBoxEpost;
        private System.Windows.Forms.Label lblEpost;
        private System.Windows.Forms.TextBox tBoxTelenr;
        private System.Windows.Forms.TextBox tBoxAdress;
        private System.Windows.Forms.TextBox tBoxFirstName;
        private System.Windows.Forms.Label lblTelenr;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.GroupBox gBoxGuardians;
        private System.Windows.Forms.ListBox lBoxGuardians;
        private System.Windows.Forms.Button btnLoadGuardians;
        private System.Windows.Forms.GroupBox gBoxFindGuardian;
        private System.Windows.Forms.Button btnSubmitFind;
        private System.Windows.Forms.TextBox tBoxID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnChange;
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
        private System.Windows.Forms.Panel pnlNewDetails;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_DisplayGuardian;
    }
}