
namespace Client
{
    partial class MainForm
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
            this.cbbDeviceName = new System.Windows.Forms.ComboBox();
            this.labelNameOfDevice = new System.Windows.Forms.Label();
            this.cbbDiskDrive = new System.Windows.Forms.ComboBox();
            this.labelOption = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnShowInforDiskDrive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbDeviceName
            // 
            this.cbbDeviceName.FormattingEnabled = true;
            this.cbbDeviceName.Location = new System.Drawing.Point(295, 19);
            this.cbbDeviceName.Name = "cbbDeviceName";
            this.cbbDeviceName.Size = new System.Drawing.Size(213, 21);
            this.cbbDeviceName.TabIndex = 1;
            // 
            // labelNameOfDevice
            // 
            this.labelNameOfDevice.AutoSize = true;
            this.labelNameOfDevice.Location = new System.Drawing.Point(147, 22);
            this.labelNameOfDevice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNameOfDevice.Name = "labelNameOfDevice";
            this.labelNameOfDevice.Size = new System.Drawing.Size(143, 13);
            this.labelNameOfDevice.TabIndex = 26;
            this.labelNameOfDevice.Text = "Thông tin ổ cứng của thiết bị";
            // 
            // cbbDiskDrive
            // 
            this.cbbDiskDrive.BackColor = System.Drawing.SystemColors.Control;
            this.cbbDiskDrive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDiskDrive.FormattingEnabled = true;
            this.cbbDiskDrive.Location = new System.Drawing.Point(295, 53);
            this.cbbDiskDrive.Margin = new System.Windows.Forms.Padding(2);
            this.cbbDiskDrive.Name = "cbbDiskDrive";
            this.cbbDiskDrive.Size = new System.Drawing.Size(213, 21);
            this.cbbDiskDrive.TabIndex = 28;
            // 
            // labelOption
            // 
            this.labelOption.AutoSize = true;
            this.labelOption.Location = new System.Drawing.Point(147, 56);
            this.labelOption.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOption.Name = "labelOption";
            this.labelOption.Size = new System.Drawing.Size(52, 13);
            this.labelOption.TabIndex = 27;
            this.labelOption.Text = "Lựa chọn";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(652, 54);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(114, 20);
            this.btnReset.TabIndex = 30;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnShowInforDiskDrive
            // 
            this.btnShowInforDiskDrive.Location = new System.Drawing.Point(523, 54);
            this.btnShowInforDiskDrive.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowInforDiskDrive.Name = "btnShowInforDiskDrive";
            this.btnShowInforDiskDrive.Size = new System.Drawing.Size(114, 20);
            this.btnShowInforDiskDrive.TabIndex = 29;
            this.btnShowInforDiskDrive.Text = "Xem thông tin";
            this.btnShowInforDiskDrive.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 393);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnShowInforDiskDrive);
            this.Controls.Add(this.cbbDiskDrive);
            this.Controls.Add(this.labelOption);
            this.Controls.Add(this.labelNameOfDevice);
            this.Controls.Add(this.cbbDeviceName);
            this.Name = "MainForm";
            this.Text = "Đọc thông tin ổ cứng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbbDeviceName;
        private System.Windows.Forms.Label labelNameOfDevice;
        private System.Windows.Forms.ComboBox cbbDiskDrive;
        private System.Windows.Forms.Label labelOption;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnShowInforDiskDrive;
    }
}

