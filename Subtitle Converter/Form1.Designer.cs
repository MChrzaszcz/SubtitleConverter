namespace Subtitle_Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.browseButton = new System.Windows.Forms.Button();
            this.TBBrowse = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.TBUnconverted = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TBConverted = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // browseButton
            // 
            this.browseButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.browseButton.Location = new System.Drawing.Point(225, 23);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = false;
            this.browseButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // TBBrowse
            // 
            this.TBBrowse.Location = new System.Drawing.Point(31, 23);
            this.TBBrowse.Name = "TBBrowse";
            this.TBBrowse.Size = new System.Drawing.Size(179, 22);
            this.TBBrowse.TabIndex = 1;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(106, 388);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 2;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // TBUnconverted
            // 
            this.TBUnconverted.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TBUnconverted.Location = new System.Drawing.Point(31, 79);
            this.TBUnconverted.MaxLength = 200000;
            this.TBUnconverted.Multiline = true;
            this.TBUnconverted.Name = "TBUnconverted";
            this.TBUnconverted.ReadOnly = true;
            this.TBUnconverted.Size = new System.Drawing.Size(245, 287);
            this.TBUnconverted.TabIndex = 3;
            this.TBUnconverted.TextChanged += new System.EventHandler(this.TBUnconverted_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TBConverted
            // 
            this.TBConverted.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TBConverted.Location = new System.Drawing.Point(323, 79);
            this.TBConverted.MaxLength = 200000;
            this.TBConverted.Multiline = true;
            this.TBConverted.Name = "TBConverted";
            this.TBConverted.ReadOnly = true;
            this.TBConverted.Size = new System.Drawing.Size(245, 287);
            this.TBConverted.TabIndex = 4;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(419, 388);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(606, 465);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.TBConverted);
            this.Controls.Add(this.TBUnconverted);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.TBBrowse);
            this.Controls.Add(this.browseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Subtitle Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox TBBrowse;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.TextBox TBUnconverted;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox TBConverted;
        private System.Windows.Forms.Button saveButton;
    }
}

