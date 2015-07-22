namespace CheckboxesAndRadioButtons
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
            this.groupBoxCheckboxes = new System.Windows.Forms.GroupBox();
            this.checkBoxHorror = new System.Windows.Forms.CheckBox();
            this.checkBoxFantasy = new System.Windows.Forms.CheckBox();
            this.checkBoxDrama = new System.Windows.Forms.CheckBox();
            this.checkBoxAction = new System.Windows.Forms.CheckBox();
            this.checkBoxComedy = new System.Windows.Forms.CheckBox();
            this.groupBoxRadioButtons = new System.Windows.Forms.GroupBox();
            this.radioButtonHorror = new System.Windows.Forms.RadioButton();
            this.radioButtonFantasy = new System.Windows.Forms.RadioButton();
            this.radioButtonDrama = new System.Windows.Forms.RadioButton();
            this.radioButtonAction = new System.Windows.Forms.RadioButton();
            this.radioButtonComedy = new System.Windows.Forms.RadioButton();
            this.buttonSelectedMovies = new System.Windows.Forms.Button();
            this.buttonFavoriteGenre = new System.Windows.Forms.Button();
            this.groupBoxCheckboxes.SuspendLayout();
            this.groupBoxRadioButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCheckboxes
            // 
            this.groupBoxCheckboxes.Controls.Add(this.checkBoxHorror);
            this.groupBoxCheckboxes.Controls.Add(this.checkBoxFantasy);
            this.groupBoxCheckboxes.Controls.Add(this.checkBoxDrama);
            this.groupBoxCheckboxes.Controls.Add(this.checkBoxAction);
            this.groupBoxCheckboxes.Controls.Add(this.checkBoxComedy);
            this.groupBoxCheckboxes.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCheckboxes.Name = "groupBoxCheckboxes";
            this.groupBoxCheckboxes.Size = new System.Drawing.Size(200, 141);
            this.groupBoxCheckboxes.TabIndex = 0;
            this.groupBoxCheckboxes.TabStop = false;
            this.groupBoxCheckboxes.Text = "What genres of movies do you like?";
            // 
            // checkBoxHorror
            // 
            this.checkBoxHorror.AutoSize = true;
            this.checkBoxHorror.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxHorror.Location = new System.Drawing.Point(6, 112);
            this.checkBoxHorror.Name = "checkBoxHorror";
            this.checkBoxHorror.Size = new System.Drawing.Size(61, 17);
            this.checkBoxHorror.TabIndex = 4;
            this.checkBoxHorror.Text = "Horror";
            this.checkBoxHorror.UseVisualStyleBackColor = true;
            // 
            // checkBoxFantasy
            // 
            this.checkBoxFantasy.AutoSize = true;
            this.checkBoxFantasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFantasy.Location = new System.Drawing.Point(6, 89);
            this.checkBoxFantasy.Name = "checkBoxFantasy";
            this.checkBoxFantasy.Size = new System.Drawing.Size(70, 17);
            this.checkBoxFantasy.TabIndex = 3;
            this.checkBoxFantasy.Text = "Fantasy";
            this.checkBoxFantasy.UseVisualStyleBackColor = true;
            // 
            // checkBoxDrama
            // 
            this.checkBoxDrama.AutoSize = true;
            this.checkBoxDrama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDrama.Location = new System.Drawing.Point(6, 66);
            this.checkBoxDrama.Name = "checkBoxDrama";
            this.checkBoxDrama.Size = new System.Drawing.Size(62, 17);
            this.checkBoxDrama.TabIndex = 2;
            this.checkBoxDrama.Text = "Drama";
            this.checkBoxDrama.UseVisualStyleBackColor = true;
            // 
            // checkBoxAction
            // 
            this.checkBoxAction.AutoSize = true;
            this.checkBoxAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAction.Location = new System.Drawing.Point(6, 43);
            this.checkBoxAction.Name = "checkBoxAction";
            this.checkBoxAction.Size = new System.Drawing.Size(62, 17);
            this.checkBoxAction.TabIndex = 1;
            this.checkBoxAction.Text = "Action";
            this.checkBoxAction.UseVisualStyleBackColor = true;
            // 
            // checkBoxComedy
            // 
            this.checkBoxComedy.AutoSize = true;
            this.checkBoxComedy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxComedy.Location = new System.Drawing.Point(7, 20);
            this.checkBoxComedy.Name = "checkBoxComedy";
            this.checkBoxComedy.Size = new System.Drawing.Size(70, 17);
            this.checkBoxComedy.TabIndex = 0;
            this.checkBoxComedy.Text = "Comedy";
            this.checkBoxComedy.UseVisualStyleBackColor = true;
            // 
            // groupBoxRadioButtons
            // 
            this.groupBoxRadioButtons.Controls.Add(this.radioButtonHorror);
            this.groupBoxRadioButtons.Controls.Add(this.radioButtonFantasy);
            this.groupBoxRadioButtons.Controls.Add(this.radioButtonDrama);
            this.groupBoxRadioButtons.Controls.Add(this.radioButtonAction);
            this.groupBoxRadioButtons.Controls.Add(this.radioButtonComedy);
            this.groupBoxRadioButtons.Location = new System.Drawing.Point(218, 12);
            this.groupBoxRadioButtons.Name = "groupBoxRadioButtons";
            this.groupBoxRadioButtons.Size = new System.Drawing.Size(200, 141);
            this.groupBoxRadioButtons.TabIndex = 1;
            this.groupBoxRadioButtons.TabStop = false;
            this.groupBoxRadioButtons.Text = "What is your favorite movie genre?";
            // 
            // radioButtonHorror
            // 
            this.radioButtonHorror.AutoSize = true;
            this.radioButtonHorror.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHorror.Location = new System.Drawing.Point(6, 111);
            this.radioButtonHorror.Name = "radioButtonHorror";
            this.radioButtonHorror.Size = new System.Drawing.Size(60, 17);
            this.radioButtonHorror.TabIndex = 4;
            this.radioButtonHorror.TabStop = true;
            this.radioButtonHorror.Text = "Horror";
            this.radioButtonHorror.UseVisualStyleBackColor = true;
            // 
            // radioButtonFantasy
            // 
            this.radioButtonFantasy.AutoSize = true;
            this.radioButtonFantasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFantasy.Location = new System.Drawing.Point(6, 88);
            this.radioButtonFantasy.Name = "radioButtonFantasy";
            this.radioButtonFantasy.Size = new System.Drawing.Size(69, 17);
            this.radioButtonFantasy.TabIndex = 3;
            this.radioButtonFantasy.TabStop = true;
            this.radioButtonFantasy.Text = "Fantasy";
            this.radioButtonFantasy.UseVisualStyleBackColor = true;
            // 
            // radioButtonDrama
            // 
            this.radioButtonDrama.AutoSize = true;
            this.radioButtonDrama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDrama.Location = new System.Drawing.Point(6, 65);
            this.radioButtonDrama.Name = "radioButtonDrama";
            this.radioButtonDrama.Size = new System.Drawing.Size(61, 17);
            this.radioButtonDrama.TabIndex = 2;
            this.radioButtonDrama.TabStop = true;
            this.radioButtonDrama.Text = "Drama";
            this.radioButtonDrama.UseVisualStyleBackColor = true;
            // 
            // radioButtonAction
            // 
            this.radioButtonAction.AutoSize = true;
            this.radioButtonAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAction.Location = new System.Drawing.Point(6, 42);
            this.radioButtonAction.Name = "radioButtonAction";
            this.radioButtonAction.Size = new System.Drawing.Size(61, 17);
            this.radioButtonAction.TabIndex = 1;
            this.radioButtonAction.TabStop = true;
            this.radioButtonAction.Text = "Action";
            this.radioButtonAction.UseVisualStyleBackColor = true;
            // 
            // radioButtonComedy
            // 
            this.radioButtonComedy.AutoSize = true;
            this.radioButtonComedy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonComedy.Location = new System.Drawing.Point(6, 19);
            this.radioButtonComedy.Name = "radioButtonComedy";
            this.radioButtonComedy.Size = new System.Drawing.Size(69, 17);
            this.radioButtonComedy.TabIndex = 0;
            this.radioButtonComedy.TabStop = true;
            this.radioButtonComedy.Text = "Comedy";
            this.radioButtonComedy.UseVisualStyleBackColor = true;
            // 
            // buttonSelectedMovies
            // 
            this.buttonSelectedMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectedMovies.Location = new System.Drawing.Point(12, 160);
            this.buttonSelectedMovies.Name = "buttonSelectedMovies";
            this.buttonSelectedMovies.Size = new System.Drawing.Size(200, 23);
            this.buttonSelectedMovies.TabIndex = 2;
            this.buttonSelectedMovies.Text = "Selected Movies";
            this.buttonSelectedMovies.UseVisualStyleBackColor = true;
            this.buttonSelectedMovies.Click += new System.EventHandler(this.buttonSelectedMovies_Click);
            // 
            // buttonFavoriteGenre
            // 
            this.buttonFavoriteGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFavoriteGenre.Location = new System.Drawing.Point(218, 160);
            this.buttonFavoriteGenre.Name = "buttonFavoriteGenre";
            this.buttonFavoriteGenre.Size = new System.Drawing.Size(200, 23);
            this.buttonFavoriteGenre.TabIndex = 3;
            this.buttonFavoriteGenre.Text = "Favorite Genre";
            this.buttonFavoriteGenre.UseVisualStyleBackColor = true;
            this.buttonFavoriteGenre.Click += new System.EventHandler(this.buttonFavoriteGenre_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 261);
            this.Controls.Add(this.buttonFavoriteGenre);
            this.Controls.Add(this.buttonSelectedMovies);
            this.Controls.Add(this.groupBoxRadioButtons);
            this.Controls.Add(this.groupBoxCheckboxes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxCheckboxes.ResumeLayout(false);
            this.groupBoxCheckboxes.PerformLayout();
            this.groupBoxRadioButtons.ResumeLayout(false);
            this.groupBoxRadioButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCheckboxes;
        private System.Windows.Forms.GroupBox groupBoxRadioButtons;
        private System.Windows.Forms.CheckBox checkBoxHorror;
        private System.Windows.Forms.CheckBox checkBoxFantasy;
        private System.Windows.Forms.CheckBox checkBoxDrama;
        private System.Windows.Forms.CheckBox checkBoxAction;
        private System.Windows.Forms.CheckBox checkBoxComedy;
        private System.Windows.Forms.RadioButton radioButtonHorror;
        private System.Windows.Forms.RadioButton radioButtonFantasy;
        private System.Windows.Forms.RadioButton radioButtonDrama;
        private System.Windows.Forms.RadioButton radioButtonAction;
        private System.Windows.Forms.RadioButton radioButtonComedy;
        private System.Windows.Forms.Button buttonSelectedMovies;
        private System.Windows.Forms.Button buttonFavoriteGenre;
    }
}

