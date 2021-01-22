namespace DatabasUppgift
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
            this.AppPerson = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.TextBox();
            this.ChangeInfo = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Find = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AppPerson
            // 
            this.AppPerson.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppPerson.Location = new System.Drawing.Point(111, 207);
            this.AppPerson.Name = "AppPerson";
            this.AppPerson.Size = new System.Drawing.Size(228, 64);
            this.AppPerson.TabIndex = 0;
            this.AppPerson.Text = "Add Person";
            this.AppPerson.UseVisualStyleBackColor = true;
            // 
            // Title
            // 
            this.Title.Enabled = false;
            this.Title.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Title.Location = new System.Drawing.Point(396, 12);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(529, 97);
            this.Title.TabIndex = 1;
            this.Title.Text = "Softschool";
            this.Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ChangeInfo
            // 
            this.ChangeInfo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeInfo.Location = new System.Drawing.Point(111, 348);
            this.ChangeInfo.Name = "ChangeInfo";
            this.ChangeInfo.Size = new System.Drawing.Size(228, 64);
            this.ChangeInfo.TabIndex = 2;
            this.ChangeInfo.Text = "Change Info";
            this.ChangeInfo.UseVisualStyleBackColor = true;
            // 
            // Remove
            // 
            this.Remove.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove.Location = new System.Drawing.Point(111, 488);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(228, 64);
            this.Remove.TabIndex = 3;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            // 
            // Find
            // 
            this.Find.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Find.Location = new System.Drawing.Point(111, 628);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(228, 64);
            this.Find.TabIndex = 4;
            this.Find.Text = "Find";
            this.Find.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 848);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.ChangeInfo);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.AppPerson);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AppPerson;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Button ChangeInfo;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Find;
    }
}

