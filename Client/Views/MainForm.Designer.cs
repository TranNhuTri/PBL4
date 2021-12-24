
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
            this.lbNameOfDevice = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.show_infor_disk_drive_btn = new System.Windows.Forms.Button();
            this.disk_drive_cbb = new System.Windows.Forms.ComboBox();
            this.labelOption = new System.Windows.Forms.Label();
            this.machine_cbb = new System.Windows.Forms.ComboBox();
            this.bytes_per_sector_txt = new System.Windows.Forms.TextBox();
            this.total_cylinder_txt = new System.Windows.Forms.TextBox();
            this.tracks_per_cylinder_txt = new System.Windows.Forms.TextBox();
            this.sectors_per_track_txt = new System.Windows.Forms.TextBox();
            this.status_txt = new System.Windows.Forms.TextBox();
            this.total_sector_txt = new System.Windows.Forms.TextBox();
            this.free_space_txt = new System.Windows.Forms.TextBox();
            this.space_txt = new System.Windows.Forms.TextBox();
            this.media_type_txt = new System.Windows.Forms.TextBox();
            this.serial_number_txt = new System.Windows.Forms.TextBox();
            this.product_code_txt = new System.Windows.Forms.TextBox();
            this.producer_txt = new System.Windows.Forms.TextBox();
            this.lbFreeSpace = new System.Windows.Forms.Label();
            this.lbBytesPerSector = new System.Windows.Forms.Label();
            this.lbTotalCylinder = new System.Windows.Forms.Label();
            this.lbTracksPerCynlinder = new System.Windows.Forms.Label();
            this.lbSectorsPerTrack = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbSpace = new System.Windows.Forms.Label();
            this.lbTotalSector = new System.Windows.Forms.Label();
            this.lbMediaType = new System.Windows.Forms.Label();
            this.lbSerialNumber = new System.Windows.Forms.Label();
            this.lbProdutCode = new System.Windows.Forms.Label();
            this.lbNSX = new System.Windows.Forms.Label();
            this.disk_drive_name_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lbNameOfDevice
            // 
            this.lbNameOfDevice.AutoSize = true;
            this.lbNameOfDevice.Location = new System.Drawing.Point(97, 14);
            this.lbNameOfDevice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNameOfDevice.Name = "lbNameOfDevice";
            this.lbNameOfDevice.Size = new System.Drawing.Size(143, 13);
            this.lbNameOfDevice.TabIndex = 31;
            this.lbNameOfDevice.Text = "Thông tin ổ cứng của thiết bị";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(664, 42);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(83, 20);
            this.btnReset.TabIndex = 30;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // show_infor_disk_drive_btn
            // 
            this.show_infor_disk_drive_btn.Location = new System.Drawing.Point(531, 42);
            this.show_infor_disk_drive_btn.Margin = new System.Windows.Forms.Padding(2);
            this.show_infor_disk_drive_btn.Name = "show_infor_disk_drive_btn";
            this.show_infor_disk_drive_btn.Size = new System.Drawing.Size(118, 20);
            this.show_infor_disk_drive_btn.TabIndex = 29;
            this.show_infor_disk_drive_btn.Text = "Xem thông tin";
            this.show_infor_disk_drive_btn.UseVisualStyleBackColor = true;
            this.show_infor_disk_drive_btn.Click += new System.EventHandler(this.show_infor_disk_drive_btn_Click);
            // 
            // disk_drive_cbb
            // 
            this.disk_drive_cbb.BackColor = System.Drawing.SystemColors.Control;
            this.disk_drive_cbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.disk_drive_cbb.FormattingEnabled = true;
            this.disk_drive_cbb.Location = new System.Drawing.Point(251, 42);
            this.disk_drive_cbb.Margin = new System.Windows.Forms.Padding(2);
            this.disk_drive_cbb.Name = "disk_drive_cbb";
            this.disk_drive_cbb.Size = new System.Drawing.Size(262, 21);
            this.disk_drive_cbb.TabIndex = 28;
            // 
            // labelOption
            // 
            this.labelOption.AutoSize = true;
            this.labelOption.Location = new System.Drawing.Point(97, 50);
            this.labelOption.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOption.Name = "labelOption";
            this.labelOption.Size = new System.Drawing.Size(52, 13);
            this.labelOption.TabIndex = 27;
            this.labelOption.Text = "Lựa chọn";
            // 
            // machine_cbb
            // 
            this.machine_cbb.BackColor = System.Drawing.SystemColors.Control;
            this.machine_cbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.machine_cbb.FormattingEnabled = true;
            this.machine_cbb.Location = new System.Drawing.Point(251, 11);
            this.machine_cbb.Margin = new System.Windows.Forms.Padding(2);
            this.machine_cbb.Name = "machine_cbb";
            this.machine_cbb.Size = new System.Drawing.Size(262, 21);
            this.machine_cbb.TabIndex = 33;
            this.machine_cbb.SelectedIndexChanged += new System.EventHandler(this.machine_cbb_SelectedIndexChanged);
            // 
            // bytes_per_sector_txt
            // 
            this.bytes_per_sector_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bytes_per_sector_txt.Location = new System.Drawing.Point(580, 228);
            this.bytes_per_sector_txt.Margin = new System.Windows.Forms.Padding(2);
            this.bytes_per_sector_txt.Name = "bytes_per_sector_txt";
            this.bytes_per_sector_txt.ReadOnly = true;
            this.bytes_per_sector_txt.Size = new System.Drawing.Size(135, 20);
            this.bytes_per_sector_txt.TabIndex = 81;
            // 
            // total_cylinder_txt
            // 
            this.total_cylinder_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.total_cylinder_txt.Location = new System.Drawing.Point(580, 203);
            this.total_cylinder_txt.Margin = new System.Windows.Forms.Padding(2);
            this.total_cylinder_txt.Name = "total_cylinder_txt";
            this.total_cylinder_txt.ReadOnly = true;
            this.total_cylinder_txt.Size = new System.Drawing.Size(135, 20);
            this.total_cylinder_txt.TabIndex = 80;
            // 
            // tracks_per_cylinder_txt
            // 
            this.tracks_per_cylinder_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tracks_per_cylinder_txt.Location = new System.Drawing.Point(580, 179);
            this.tracks_per_cylinder_txt.Margin = new System.Windows.Forms.Padding(2);
            this.tracks_per_cylinder_txt.Name = "tracks_per_cylinder_txt";
            this.tracks_per_cylinder_txt.ReadOnly = true;
            this.tracks_per_cylinder_txt.Size = new System.Drawing.Size(135, 20);
            this.tracks_per_cylinder_txt.TabIndex = 79;
            // 
            // sectors_per_track_txt
            // 
            this.sectors_per_track_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sectors_per_track_txt.Location = new System.Drawing.Point(580, 154);
            this.sectors_per_track_txt.Margin = new System.Windows.Forms.Padding(2);
            this.sectors_per_track_txt.Name = "sectors_per_track_txt";
            this.sectors_per_track_txt.ReadOnly = true;
            this.sectors_per_track_txt.Size = new System.Drawing.Size(135, 20);
            this.sectors_per_track_txt.TabIndex = 78;
            // 
            // status_txt
            // 
            this.status_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.status_txt.Location = new System.Drawing.Point(580, 103);
            this.status_txt.Margin = new System.Windows.Forms.Padding(2);
            this.status_txt.Name = "status_txt";
            this.status_txt.ReadOnly = true;
            this.status_txt.Size = new System.Drawing.Size(135, 20);
            this.status_txt.TabIndex = 77;
            // 
            // total_sector_txt
            // 
            this.total_sector_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.total_sector_txt.Location = new System.Drawing.Point(580, 128);
            this.total_sector_txt.Margin = new System.Windows.Forms.Padding(2);
            this.total_sector_txt.Name = "total_sector_txt";
            this.total_sector_txt.ReadOnly = true;
            this.total_sector_txt.Size = new System.Drawing.Size(135, 20);
            this.total_sector_txt.TabIndex = 76;
            // 
            // free_space_txt
            // 
            this.free_space_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.free_space_txt.Location = new System.Drawing.Point(229, 228);
            this.free_space_txt.Margin = new System.Windows.Forms.Padding(2);
            this.free_space_txt.Name = "free_space_txt";
            this.free_space_txt.ReadOnly = true;
            this.free_space_txt.Size = new System.Drawing.Size(135, 20);
            this.free_space_txt.TabIndex = 75;
            // 
            // space_txt
            // 
            this.space_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.space_txt.Location = new System.Drawing.Point(229, 204);
            this.space_txt.Margin = new System.Windows.Forms.Padding(2);
            this.space_txt.Name = "space_txt";
            this.space_txt.ReadOnly = true;
            this.space_txt.Size = new System.Drawing.Size(135, 20);
            this.space_txt.TabIndex = 74;
            // 
            // media_type_txt
            // 
            this.media_type_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.media_type_txt.Location = new System.Drawing.Point(229, 180);
            this.media_type_txt.Margin = new System.Windows.Forms.Padding(2);
            this.media_type_txt.Name = "media_type_txt";
            this.media_type_txt.ReadOnly = true;
            this.media_type_txt.Size = new System.Drawing.Size(135, 20);
            this.media_type_txt.TabIndex = 73;
            // 
            // serial_number_txt
            // 
            this.serial_number_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serial_number_txt.Location = new System.Drawing.Point(229, 156);
            this.serial_number_txt.Margin = new System.Windows.Forms.Padding(2);
            this.serial_number_txt.Name = "serial_number_txt";
            this.serial_number_txt.ReadOnly = true;
            this.serial_number_txt.Size = new System.Drawing.Size(135, 20);
            this.serial_number_txt.TabIndex = 72;
            // 
            // product_code_txt
            // 
            this.product_code_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.product_code_txt.Location = new System.Drawing.Point(229, 132);
            this.product_code_txt.Margin = new System.Windows.Forms.Padding(2);
            this.product_code_txt.Name = "product_code_txt";
            this.product_code_txt.ReadOnly = true;
            this.product_code_txt.Size = new System.Drawing.Size(135, 20);
            this.product_code_txt.TabIndex = 71;
            // 
            // producer_txt
            // 
            this.producer_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.producer_txt.Location = new System.Drawing.Point(229, 109);
            this.producer_txt.Margin = new System.Windows.Forms.Padding(2);
            this.producer_txt.Name = "producer_txt";
            this.producer_txt.ReadOnly = true;
            this.producer_txt.Size = new System.Drawing.Size(135, 20);
            this.producer_txt.TabIndex = 70;
            // 
            // lbFreeSpace
            // 
            this.lbFreeSpace.AutoSize = true;
            this.lbFreeSpace.Location = new System.Drawing.Point(97, 230);
            this.lbFreeSpace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFreeSpace.Name = "lbFreeSpace";
            this.lbFreeSpace.Size = new System.Drawing.Size(56, 13);
            this.lbFreeSpace.TabIndex = 69;
            this.lbFreeSpace.Text = "Còn trống ";
            // 
            // lbBytesPerSector
            // 
            this.lbBytesPerSector.AutoSize = true;
            this.lbBytesPerSector.Location = new System.Drawing.Point(411, 231);
            this.lbBytesPerSector.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBytesPerSector.Name = "lbBytesPerSector";
            this.lbBytesPerSector.Size = new System.Drawing.Size(115, 13);
            this.lbBytesPerSector.TabIndex = 68;
            this.lbBytesPerSector.Text = "Số byte trên mỗi sector";
            // 
            // lbTotalCylinder
            // 
            this.lbTotalCylinder.AutoSize = true;
            this.lbTotalCylinder.Location = new System.Drawing.Point(411, 205);
            this.lbTotalCylinder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotalCylinder.Name = "lbTotalCylinder";
            this.lbTotalCylinder.Size = new System.Drawing.Size(85, 13);
            this.lbTotalCylinder.TabIndex = 67;
            this.lbTotalCylinder.Text = "Tổng số cylinder";
            // 
            // lbTracksPerCynlinder
            // 
            this.lbTracksPerCynlinder.AutoSize = true;
            this.lbTracksPerCynlinder.Location = new System.Drawing.Point(411, 181);
            this.lbTracksPerCynlinder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTracksPerCynlinder.Name = "lbTracksPerCynlinder";
            this.lbTracksPerCynlinder.Size = new System.Drawing.Size(126, 13);
            this.lbTracksPerCynlinder.TabIndex = 66;
            this.lbTracksPerCynlinder.Text = "Số track trên mỗi cylinder";
            // 
            // lbSectorsPerTrack
            // 
            this.lbSectorsPerTrack.AutoSize = true;
            this.lbSectorsPerTrack.Location = new System.Drawing.Point(411, 156);
            this.lbSectorsPerTrack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSectorsPerTrack.Name = "lbSectorsPerTrack";
            this.lbSectorsPerTrack.Size = new System.Drawing.Size(119, 13);
            this.lbSectorsPerTrack.TabIndex = 65;
            this.lbSectorsPerTrack.Text = "Số sector trên mỗi track";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(411, 105);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(55, 13);
            this.lbStatus.TabIndex = 64;
            this.lbStatus.Text = "Trạng thái";
            // 
            // lbSpace
            // 
            this.lbSpace.AutoSize = true;
            this.lbSpace.Location = new System.Drawing.Point(97, 206);
            this.lbSpace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSpace.Name = "lbSpace";
            this.lbSpace.Size = new System.Drawing.Size(60, 13);
            this.lbSpace.TabIndex = 63;
            this.lbSpace.Text = "Kích thước";
            // 
            // lbTotalSector
            // 
            this.lbTotalSector.AutoSize = true;
            this.lbTotalSector.Location = new System.Drawing.Point(411, 130);
            this.lbTotalSector.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotalSector.Name = "lbTotalSector";
            this.lbTotalSector.Size = new System.Drawing.Size(78, 13);
            this.lbTotalSector.TabIndex = 62;
            this.lbTotalSector.Text = "Tổng số sector";
            // 
            // lbMediaType
            // 
            this.lbMediaType.AutoSize = true;
            this.lbMediaType.Location = new System.Drawing.Point(97, 182);
            this.lbMediaType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMediaType.Name = "lbMediaType";
            this.lbMediaType.Size = new System.Drawing.Size(48, 13);
            this.lbMediaType.TabIndex = 61;
            this.lbMediaType.Text = "Loại đĩa";
            // 
            // lbSerialNumber
            // 
            this.lbSerialNumber.AutoSize = true;
            this.lbSerialNumber.Location = new System.Drawing.Point(97, 158);
            this.lbSerialNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSerialNumber.Name = "lbSerialNumber";
            this.lbSerialNumber.Size = new System.Drawing.Size(33, 13);
            this.lbSerialNumber.TabIndex = 60;
            this.lbSerialNumber.Text = "Serial";
            // 
            // lbProdutCode
            // 
            this.lbProdutCode.AutoSize = true;
            this.lbProdutCode.Location = new System.Drawing.Point(96, 134);
            this.lbProdutCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbProdutCode.Name = "lbProdutCode";
            this.lbProdutCode.Size = new System.Drawing.Size(71, 13);
            this.lbProdutCode.TabIndex = 59;
            this.lbProdutCode.Text = "Mã sản phẩm";
            // 
            // lbNSX
            // 
            this.lbNSX.AutoSize = true;
            this.lbNSX.Location = new System.Drawing.Point(96, 109);
            this.lbNSX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNSX.Name = "lbNSX";
            this.lbNSX.Size = new System.Drawing.Size(70, 13);
            this.lbNSX.TabIndex = 58;
            this.lbNSX.Text = "Nhà sản suất";
            // 
            // disk_drive_name_txt
            // 
            this.disk_drive_name_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.disk_drive_name_txt.Location = new System.Drawing.Point(229, 83);
            this.disk_drive_name_txt.Margin = new System.Windows.Forms.Padding(2);
            this.disk_drive_name_txt.Name = "disk_drive_name_txt";
            this.disk_drive_name_txt.ReadOnly = true;
            this.disk_drive_name_txt.Size = new System.Drawing.Size(135, 20);
            this.disk_drive_name_txt.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 83;
            this.label1.Text = "Tên ổ cứng";
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(11, 270);
            this.panel.Margin = new System.Windows.Forms.Padding(2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(767, 217);
            this.panel.TabIndex = 84;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 498);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.disk_drive_name_txt);
            this.Controls.Add(this.bytes_per_sector_txt);
            this.Controls.Add(this.total_cylinder_txt);
            this.Controls.Add(this.tracks_per_cylinder_txt);
            this.Controls.Add(this.sectors_per_track_txt);
            this.Controls.Add(this.status_txt);
            this.Controls.Add(this.total_sector_txt);
            this.Controls.Add(this.free_space_txt);
            this.Controls.Add(this.space_txt);
            this.Controls.Add(this.media_type_txt);
            this.Controls.Add(this.serial_number_txt);
            this.Controls.Add(this.product_code_txt);
            this.Controls.Add(this.producer_txt);
            this.Controls.Add(this.lbFreeSpace);
            this.Controls.Add(this.lbBytesPerSector);
            this.Controls.Add(this.lbTotalCylinder);
            this.Controls.Add(this.lbTracksPerCynlinder);
            this.Controls.Add(this.lbSectorsPerTrack);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbSpace);
            this.Controls.Add(this.lbTotalSector);
            this.Controls.Add(this.lbMediaType);
            this.Controls.Add(this.lbSerialNumber);
            this.Controls.Add(this.lbProdutCode);
            this.Controls.Add(this.lbNSX);
            this.Controls.Add(this.machine_cbb);
            this.Controls.Add(this.lbNameOfDevice);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.show_infor_disk_drive_btn);
            this.Controls.Add(this.disk_drive_cbb);
            this.Controls.Add(this.labelOption);
            this.Name = "MainForm";
            this.Text = "Đọc thông tin ổ cứng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNameOfDevice;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button show_infor_disk_drive_btn;
        private System.Windows.Forms.ComboBox disk_drive_cbb;
        private System.Windows.Forms.Label labelOption;
        private System.Windows.Forms.ComboBox machine_cbb;
        private System.Windows.Forms.TextBox bytes_per_sector_txt;
        private System.Windows.Forms.TextBox total_cylinder_txt;
        private System.Windows.Forms.TextBox tracks_per_cylinder_txt;
        private System.Windows.Forms.TextBox sectors_per_track_txt;
        private System.Windows.Forms.TextBox status_txt;
        private System.Windows.Forms.TextBox total_sector_txt;
        private System.Windows.Forms.TextBox free_space_txt;
        private System.Windows.Forms.TextBox space_txt;
        private System.Windows.Forms.TextBox media_type_txt;
        private System.Windows.Forms.TextBox serial_number_txt;
        private System.Windows.Forms.TextBox product_code_txt;
        private System.Windows.Forms.TextBox producer_txt;
        private System.Windows.Forms.Label lbFreeSpace;
        private System.Windows.Forms.Label lbBytesPerSector;
        private System.Windows.Forms.Label lbTotalCylinder;
        private System.Windows.Forms.Label lbTracksPerCynlinder;
        private System.Windows.Forms.Label lbSectorsPerTrack;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbSpace;
        private System.Windows.Forms.Label lbTotalSector;
        private System.Windows.Forms.Label lbMediaType;
        private System.Windows.Forms.Label lbSerialNumber;
        private System.Windows.Forms.Label lbProdutCode;
        private System.Windows.Forms.Label lbNSX;
        private System.Windows.Forms.TextBox disk_drive_name_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
    }
}

