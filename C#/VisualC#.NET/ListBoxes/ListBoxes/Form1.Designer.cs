namespace ListBoxes
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
            this.listBoxResults = new System.Windows.Forms.ListBox();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelEnd = new System.Windows.Forms.Label();
            this.textBoxStart = new System.Windows.Forms.TextBox();
            this.textBoxEnd = new System.Windows.Forms.TextBox();
            this.buttonLoop = new System.Windows.Forms.Button();
            this.labelMultiplicand = new System.Windows.Forms.Label();
            this.textBoxMultiplicand = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxResults
            // 
            this.listBoxResults.FormattingEnabled = true;
            this.listBoxResults.Location = new System.Drawing.Point(31, 136);
            this.listBoxResults.Name = "listBoxResults";
            this.listBoxResults.Size = new System.Drawing.Size(228, 95);
            this.listBoxResults.TabIndex = 0;
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(28, 22);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(56, 13);
            this.labelStart.TabIndex = 1;
            this.labelStart.Text = "Loop Start";
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Location = new System.Drawing.Point(28, 55);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(53, 13);
            this.labelEnd.TabIndex = 2;
            this.labelEnd.Text = "Loop End";
            // 
            // textBoxStart
            // 
            this.textBoxStart.Location = new System.Drawing.Point(87, 19);
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.Size = new System.Drawing.Size(114, 20);
            this.textBoxStart.TabIndex = 3;
            // 
            // textBoxEnd
            // 
            this.textBoxEnd.Location = new System.Drawing.Point(87, 52);
            this.textBoxEnd.Name = "textBoxEnd";
            this.textBoxEnd.Size = new System.Drawing.Size(114, 20);
            this.textBoxEnd.TabIndex = 4;
            // 
            // buttonLoop
            // 
            this.buttonLoop.Location = new System.Drawing.Point(207, 43);
            this.buttonLoop.Name = "buttonLoop";
            this.buttonLoop.Size = new System.Drawing.Size(52, 36);
            this.buttonLoop.TabIndex = 5;
            this.buttonLoop.Text = "Start Loop";
            this.buttonLoop.UseVisualStyleBackColor = true;
            this.buttonLoop.Click += new System.EventHandler(this.buttonLoop_Click);
            // 
            // labelMultiplicand
            // 
            this.labelMultiplicand.AutoSize = true;
            this.labelMultiplicand.Location = new System.Drawing.Point(28, 85);
            this.labelMultiplicand.Name = "labelMultiplicand";
            this.labelMultiplicand.Size = new System.Drawing.Size(57, 13);
            this.labelMultiplicand.TabIndex = 6;
            this.labelMultiplicand.Text = "Multiply By";
            // 
            // textBoxMultiplicand
            // 
            this.textBoxMultiplicand.Location = new System.Drawing.Point(87, 82);
            this.textBoxMultiplicand.Name = "textBoxMultiplicand";
            this.textBoxMultiplicand.Size = new System.Drawing.Size(114, 20);
            this.textBoxMultiplicand.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBoxMultiplicand);
            this.Controls.Add(this.labelMultiplicand);
            this.Controls.Add(this.buttonLoop);
            this.Controls.Add(this.textBoxEnd);
            this.Controls.Add(this.textBoxStart);
            this.Controls.Add(this.labelEnd);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.listBoxResults);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxResults;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.TextBox textBoxStart;
        private System.Windows.Forms.TextBox textBoxEnd;
        private System.Windows.Forms.Button buttonLoop;
        private System.Windows.Forms.Label labelMultiplicand;
        private System.Windows.Forms.TextBox textBoxMultiplicand;
    }
}

