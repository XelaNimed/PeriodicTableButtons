
namespace ButtonExample
{
    partial class PeriodicElementInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeriodicElementInfoForm));
            this.button_OK = new System.Windows.Forms.Button();
            this.pictureBox_ElementInfo = new System.Windows.Forms.PictureBox();
            this.label_Description = new System.Windows.Forms.Label();
            this.label_Designation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_AtomicMass = new System.Windows.Forms.Label();
            this.label_AtomicRadius = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ElementInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // button_OK
            // 
            this.button_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_OK.Location = new System.Drawing.Point(547, 246);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 0;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            // 
            // pictureBox_ElementInfo
            // 
            this.pictureBox_ElementInfo.Location = new System.Drawing.Point(13, 13);
            this.pictureBox_ElementInfo.Name = "pictureBox_ElementInfo";
            this.pictureBox_ElementInfo.Size = new System.Drawing.Size(100, 100);
            this.pictureBox_ElementInfo.TabIndex = 1;
            this.pictureBox_ElementInfo.TabStop = false;
            // 
            // label_Description
            // 
            this.label_Description.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Description.AutoEllipsis = true;
            this.label_Description.Location = new System.Drawing.Point(120, 49);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(502, 121);
            this.label_Description.TabIndex = 2;
            this.label_Description.Text = resources.GetString("label_Description.Text");
            // 
            // label_Designation
            // 
            this.label_Designation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Designation.AutoEllipsis = true;
            this.label_Designation.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Designation.Location = new System.Drawing.Point(119, 9);
            this.label_Designation.Name = "label_Designation";
            this.label_Designation.Size = new System.Drawing.Size(503, 36);
            this.label_Designation.TabIndex = 4;
            this.label_Designation.Text = "He";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Атомная масса";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Атомный радиус";
            // 
            // label_AtomicMass
            // 
            this.label_AtomicMass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_AtomicMass.AutoSize = true;
            this.label_AtomicMass.Location = new System.Drawing.Point(120, 184);
            this.label_AtomicMass.Name = "label_AtomicMass";
            this.label_AtomicMass.Size = new System.Drawing.Size(103, 15);
            this.label_AtomicMass.TabIndex = 7;
            this.label_AtomicMass.Text = "label_AtomicMass";
            // 
            // label_AtomicRadius
            // 
            this.label_AtomicRadius.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_AtomicRadius.AutoSize = true;
            this.label_AtomicRadius.Location = new System.Drawing.Point(120, 210);
            this.label_AtomicRadius.Name = "label_AtomicRadius";
            this.label_AtomicRadius.Size = new System.Drawing.Size(111, 15);
            this.label_AtomicRadius.TabIndex = 8;
            this.label_AtomicRadius.Text = "label_AtomicRadius";
            // 
            // PeriodicElementInfoForm
            // 
            this.AcceptButton = this.button_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 281);
            this.Controls.Add(this.label_AtomicRadius);
            this.Controls.Add(this.label_AtomicMass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Designation);
            this.Controls.Add(this.label_Description);
            this.Controls.Add(this.pictureBox_ElementInfo);
            this.Controls.Add(this.button_OK);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(400, 320);
            this.Name = "PeriodicElementInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PeriodicElementInfo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ElementInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.PictureBox pictureBox_ElementInfo;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.Label label_Designation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_AtomicMass;
        private System.Windows.Forms.Label label_AtomicRadius;
    }
}