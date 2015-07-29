namespace Databases
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
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelJobTitle = new System.Windows.Forms.Label();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxDepartment = new System.Windows.Forms.TextBox();
            this.textBoxJobTitle = new System.Windows.Forms.TextBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(37, 30);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(57, 13);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(225, 30);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 1;
            this.labelLastName.Text = "Last Name";
            // 
            // labelJobTitle
            // 
            this.labelJobTitle.AutoSize = true;
            this.labelJobTitle.Location = new System.Drawing.Point(37, 67);
            this.labelJobTitle.Name = "labelJobTitle";
            this.labelJobTitle.Size = new System.Drawing.Size(47, 13);
            this.labelJobTitle.TabIndex = 2;
            this.labelJobTitle.Text = "Job Title";
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Location = new System.Drawing.Point(225, 70);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(62, 13);
            this.labelDepartment.TabIndex = 3;
            this.labelDepartment.Text = "Department";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(100, 27);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 4;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(293, 27);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 5;
            // 
            // textBoxDepartment
            // 
            this.textBoxDepartment.Location = new System.Drawing.Point(293, 63);
            this.textBoxDepartment.Name = "textBoxDepartment";
            this.textBoxDepartment.Size = new System.Drawing.Size(100, 20);
            this.textBoxDepartment.TabIndex = 6;
            // 
            // textBoxJobTitle
            // 
            this.textBoxJobTitle.Location = new System.Drawing.Point(100, 60);
            this.textBoxJobTitle.Name = "textBoxJobTitle";
            this.textBoxJobTitle.Size = new System.Drawing.Size(100, 20);
            this.textBoxJobTitle.TabIndex = 7;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(228, 96);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 8;
            this.buttonNext.Text = "Next Row";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(113, 96);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(87, 23);
            this.buttonPrevious.TabIndex = 9;
            this.buttonPrevious.Text = "Previous Row";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(113, 126);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(87, 23);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Add Row";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 305);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.textBoxJobTitle);
            this.Controls.Add(this.textBoxDepartment);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelDepartment);
            this.Controls.Add(this.labelJobTitle);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelJobTitle;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxDepartment;
        private System.Windows.Forms.TextBox textBoxJobTitle;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonAdd;
    }
}

