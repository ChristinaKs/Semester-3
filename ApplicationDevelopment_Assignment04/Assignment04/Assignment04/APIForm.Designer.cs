
namespace Assignment04
{
    partial class APIForm
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
            this.nextButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.nameOutputLabel = new System.Windows.Forms.Label();
            this.ageOutputLabel = new System.Windows.Forms.Label();
            this.idOutputLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.salaryOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.nextButton.Location = new System.Drawing.Point(347, 207);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(105, 56);
            this.nextButton.TabIndex = 23;
            this.nextButton.Text = "Next Entry";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.exitButton.Location = new System.Drawing.Point(191, 207);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(105, 56);
            this.exitButton.TabIndex = 22;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.prevButton.Location = new System.Drawing.Point(35, 207);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(105, 56);
            this.prevButton.TabIndex = 21;
            this.prevButton.Text = "Previous Entry";
            this.prevButton.UseVisualStyleBackColor = false;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // nameOutputLabel
            // 
            this.nameOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameOutputLabel.Location = new System.Drawing.Point(191, 105);
            this.nameOutputLabel.Name = "nameOutputLabel";
            this.nameOutputLabel.Size = new System.Drawing.Size(261, 23);
            this.nameOutputLabel.TabIndex = 19;
            // 
            // ageOutputLabel
            // 
            this.ageOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ageOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageOutputLabel.Location = new System.Drawing.Point(191, 171);
            this.ageOutputLabel.Name = "ageOutputLabel";
            this.ageOutputLabel.Size = new System.Drawing.Size(261, 23);
            this.ageOutputLabel.TabIndex = 18;
            this.ageOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // idOutputLabel
            // 
            this.idOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idOutputLabel.Location = new System.Drawing.Point(191, 70);
            this.idOutputLabel.Name = "idOutputLabel";
            this.idOutputLabel.Size = new System.Drawing.Size(261, 23);
            this.idOutputLabel.TabIndex = 17;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(31, 105);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(136, 20);
            this.nameLabel.TabIndex = 16;
            this.nameLabel.Text = "Employee Name:";
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryLabel.Location = new System.Drawing.Point(31, 137);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(139, 20);
            this.salaryLabel.TabIndex = 15;
            this.salaryLabel.Text = "Employee Salary:";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLabel.Location = new System.Drawing.Point(31, 171);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(121, 20);
            this.ageLabel.TabIndex = 14;
            this.ageLabel.Text = "Employee Age:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(31, 73);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(109, 20);
            this.idLabel.TabIndex = 13;
            this.idLabel.Text = "Employee ID:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(107, 26);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(238, 24);
            this.titleLabel.TabIndex = 12;
            this.titleLabel.Text = "JSON Employee Record";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // salaryOutputLabel
            // 
            this.salaryOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salaryOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryOutputLabel.Location = new System.Drawing.Point(191, 137);
            this.salaryOutputLabel.Name = "salaryOutputLabel";
            this.salaryOutputLabel.Size = new System.Drawing.Size(261, 23);
            this.salaryOutputLabel.TabIndex = 24;
            this.salaryOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // APIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 294);
            this.Controls.Add(this.salaryOutputLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.nameOutputLabel);
            this.Controls.Add(this.ageOutputLabel);
            this.Controls.Add(this.idOutputLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.salaryLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "APIForm";
            this.Text = "JSON RESTgul API Employee Record Viewer";
            this.Load += new System.EventHandler(this.APIForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Label nameOutputLabel;
        private System.Windows.Forms.Label ageOutputLabel;
        private System.Windows.Forms.Label idOutputLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label salaryOutputLabel;
    }
}

