namespace WiiBalanceWalker
{
    partial class FormBluetooth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBluetooth));
            this.label_Status = new System.Windows.Forms.Label();
            this.button_DeviceSearch = new System.Windows.Forms.Button();
            this.checkBox_RemoveExisting = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label_Status
            // 
            this.label_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Status.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Status.Location = new System.Drawing.Point(12, 10);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(432, 24);
            this.label_Status.TabIndex = 0;
            this.label_Status.Text = "Click Pair";
            this.label_Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_DeviceSearch
            // 
            this.button_DeviceSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_DeviceSearch.Location = new System.Drawing.Point(255, 48);
            this.button_DeviceSearch.Name = "button_DeviceSearch";
            this.button_DeviceSearch.Size = new System.Drawing.Size(189, 33);
            this.button_DeviceSearch.TabIndex = 0;
            this.button_DeviceSearch.Text = "Pair";
            this.button_DeviceSearch.UseVisualStyleBackColor = true;
            this.button_DeviceSearch.Click += new System.EventHandler(this.button_DeviceSearch_Click);
            // 
            // checkBox_RemoveExisting
            // 
            this.checkBox_RemoveExisting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox_RemoveExisting.AutoSize = true;
            this.checkBox_RemoveExisting.Checked = true;
            this.checkBox_RemoveExisting.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_RemoveExisting.Location = new System.Drawing.Point(14, 56);
            this.checkBox_RemoveExisting.Name = "checkBox_RemoveExisting";
            this.checkBox_RemoveExisting.Size = new System.Drawing.Size(54, 19);
            this.checkBox_RemoveExisting.TabIndex = 0;
            this.checkBox_RemoveExisting.Text = "Reset";
            this.checkBox_RemoveExisting.UseVisualStyleBackColor = true;
            // 
            // FormBluetooth
            // 
            this.AcceptButton = this.button_DeviceSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 96);
            this.Controls.Add(this.button_DeviceSearch);
            this.Controls.Add(this.checkBox_RemoveExisting);
            this.Controls.Add(this.label_Status);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBluetooth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bluetooth Pair";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.Button button_DeviceSearch;
        private System.Windows.Forms.CheckBox checkBox_RemoveExisting;
    }
}