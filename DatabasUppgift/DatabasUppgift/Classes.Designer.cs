namespace DatabasUppgift
{
    partial class Classes
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
            this.Title.TabIndex = 5;
            this.Title.Text = "Softschool";
            this.Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.Location = new System.Drawing.Point(111, 25);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(62, 23);
            this.lblPage.TabIndex = 28;
            this.lblPage.Text = "Classes";
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(1236, 786);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(171, 47);
            this.btnHome.TabIndex = 29;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // Classes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 845);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.Title);
            this.Name = "Classes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Classes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Button btnHome;
    }
}