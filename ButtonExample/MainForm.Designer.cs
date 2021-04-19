
namespace ButtonExample
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.periodicElementButton1 = new ButtonExample.PeriodicElementButton();
            this.periodicElementButton2 = new ButtonExample.PeriodicElementButton();
            this.periodicElementButton3 = new ButtonExample.PeriodicElementButton();
            this.SuspendLayout();
            // 
            // periodicElementButton1
            // 
            this.periodicElementButton1.ElementNumber = 1;
            this.periodicElementButton1.Location = new System.Drawing.Point(26, 26);
            this.periodicElementButton1.Name = "periodicElementButton1";
            this.periodicElementButton1.Size = new System.Drawing.Size(50, 50);
            this.periodicElementButton1.TabIndex = 0;
            this.periodicElementButton1.Text = "H";
            this.periodicElementButton1.UseVisualStyleBackColor = true;
            // 
            // periodicElementButton2
            // 
            this.periodicElementButton2.ElementNumber = 2;
            this.periodicElementButton2.Location = new System.Drawing.Point(83, 26);
            this.periodicElementButton2.Name = "periodicElementButton2";
            this.periodicElementButton2.Size = new System.Drawing.Size(50, 50);
            this.periodicElementButton2.TabIndex = 1;
            this.periodicElementButton2.Text = "He";
            this.periodicElementButton2.UseVisualStyleBackColor = true;
            // 
            // periodicElementButton3
            // 
            this.periodicElementButton3.ElementNumber = 3;
            this.periodicElementButton3.Location = new System.Drawing.Point(140, 26);
            this.periodicElementButton3.Name = "periodicElementButton3";
            this.periodicElementButton3.Size = new System.Drawing.Size(50, 50);
            this.periodicElementButton3.TabIndex = 2;
            this.periodicElementButton3.Text = "Li";
            this.periodicElementButton3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 106);
            this.Controls.Add(this.periodicElementButton3);
            this.Controls.Add(this.periodicElementButton2);
            this.Controls.Add(this.periodicElementButton1);
            this.MinimumSize = new System.Drawing.Size(240, 145);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private PeriodicElementButton periodicElementButton1;
        private PeriodicElementButton periodicElementButton2;
        private PeriodicElementButton periodicElementButton3;
    }
}

