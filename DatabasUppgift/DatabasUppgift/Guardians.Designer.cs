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
            this.gBoxAddGuardian.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Enabled = false;
            this.Title.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Title.Location = new System.Drawing.Point(396, 12);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(529, 97);
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
            this.gBoxAddGuardian.Location = new System.Drawing.Point(925, 189);
            this.gBoxAddGuardian.Name = "gBoxAddGuardian";
            this.gBoxAddGuardian.Size = new System.Drawing.Size(282, 219);
            this.gBoxAddGuardian.TabIndex = 28;
            this.gBoxAddGuardian.TabStop = false;
            this.gBoxAddGuardian.Text = "Enter Guardian Details";
            this.gBoxAddGuardian.Enter += new System.EventHandler(this.gBoxAddStudent_Enter);
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
            // Guardians
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 845);
            this.Controls.Add(this.gBoxAddGuardian);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.Title);
            this.Name = "Guardians";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guardians";
            this.gBoxAddGuardian.ResumeLayout(false);
            this.gBoxAddGuardian.PerformLayout();
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
    }
}