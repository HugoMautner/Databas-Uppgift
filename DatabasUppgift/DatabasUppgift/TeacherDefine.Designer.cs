namespace DatabasUppgift
{
    partial class TeacherDefine
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
            this.gBoxRemove = new System.Windows.Forms.GroupBox();
            this.btnSubmitId = new System.Windows.Forms.Button();
            this.tBoxID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSubmitGuardianId = new System.Windows.Forms.Button();
            this.tbGuardianId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gBoxRemove.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxRemove
            // 
            this.gBoxRemove.Controls.Add(this.btnSubmitId);
            this.gBoxRemove.Controls.Add(this.tBoxID);
            this.gBoxRemove.Controls.Add(this.lblID);
            this.gBoxRemove.Location = new System.Drawing.Point(38, 21);
            this.gBoxRemove.Name = "gBoxRemove";
            this.gBoxRemove.Size = new System.Drawing.Size(282, 109);
            this.gBoxRemove.TabIndex = 32;
            this.gBoxRemove.TabStop = false;
            this.gBoxRemove.Text = "Enter teacher id to continue";
            // 
            // btnSubmitId
            // 
            this.btnSubmitId.Location = new System.Drawing.Point(201, 80);
            this.btnSubmitId.Name = "btnSubmitId";
            this.btnSubmitId.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitId.TabIndex = 5;
            this.btnSubmitId.Text = "Submit";
            this.btnSubmitId.UseVisualStyleBackColor = true;
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
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(47, 248);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(106, 41);
            this.btnAddCourse.TabIndex = 48;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            // 
            // btnAddClass
            // 
            this.btnAddClass.Location = new System.Drawing.Point(197, 201);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(106, 41);
            this.btnAddClass.TabIndex = 47;
            this.btnAddClass.Text = "Add Class";
            this.btnAddClass.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(197, 154);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(106, 41);
            this.btnRemove.TabIndex = 45;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(47, 154);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(106, 41);
            this.btnChange.TabIndex = 44;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSubmitGuardianId);
            this.groupBox1.Controls.Add(this.tbGuardianId);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(38, 332);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 109);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter guardian id to add";
            // 
            // btnSubmitGuardianId
            // 
            this.btnSubmitGuardianId.Location = new System.Drawing.Point(201, 80);
            this.btnSubmitGuardianId.Name = "btnSubmitGuardianId";
            this.btnSubmitGuardianId.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitGuardianId.TabIndex = 5;
            this.btnSubmitGuardianId.Text = "Submit";
            this.btnSubmitGuardianId.UseVisualStyleBackColor = true;
            // 
            // tbGuardianId
            // 
            this.tbGuardianId.Location = new System.Drawing.Point(106, 30);
            this.tbGuardianId.Name = "tbGuardianId";
            this.tbGuardianId.Size = new System.Drawing.Size(170, 20);
            this.tbGuardianId.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID";
            // 
            // TeacherDefine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 845);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.btnAddClass);
            this.Controls.Add(this.gBoxRemove);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnRemove);
            this.Name = "TeacherDefine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherDefine";
            this.gBoxRemove.ResumeLayout(false);
            this.gBoxRemove.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxRemove;
        private System.Windows.Forms.Button btnSubmitId;
        private System.Windows.Forms.TextBox tBoxID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSubmitGuardianId;
        private System.Windows.Forms.TextBox tbGuardianId;
        private System.Windows.Forms.Label label6;
    }
}