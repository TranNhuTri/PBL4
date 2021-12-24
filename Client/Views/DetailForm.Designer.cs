
namespace Client.Views
{
    partial class DetailForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtUsedSpace = new System.Windows.Forms.TextBox();
            this.lbUsedSpace = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbNameDrive = new System.Windows.Forms.Label();
            this.txtSectorsPerCluster = new System.Windows.Forms.TextBox();
            this.lbSectorsPerCluster = new System.Windows.Forms.Label();
            this.txtFreeSpace = new System.Windows.Forms.TextBox();
            this.lbfreeSpace = new System.Windows.Forms.Label();
            this.txtSpace = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lbspaceOfDrive = new System.Windows.Forms.Label();
            this.lbtypeOfDrive = new System.Windows.Forms.Label();
            this.txtNameDrive = new System.Windows.Forms.TextBox();
            this.lbnameOfDrive = new System.Windows.Forms.Label();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(13, 223);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 2);
            this.label1.TabIndex = 51;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(212, 346);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(76, 21);
            this.btnOk.TabIndex = 50;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtUsedSpace
            // 
            this.txtUsedSpace.BackColor = System.Drawing.Color.White;
            this.txtUsedSpace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsedSpace.Location = new System.Drawing.Point(157, 124);
            this.txtUsedSpace.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsedSpace.Name = "txtUsedSpace";
            this.txtUsedSpace.ReadOnly = true;
            this.txtUsedSpace.Size = new System.Drawing.Size(131, 20);
            this.txtUsedSpace.TabIndex = 49;
            // 
            // lbUsedSpace
            // 
            this.lbUsedSpace.AutoSize = true;
            this.lbUsedSpace.Location = new System.Drawing.Point(45, 128);
            this.lbUsedSpace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUsedSpace.Name = "lbUsedSpace";
            this.lbUsedSpace.Size = new System.Drawing.Size(62, 13);
            this.lbUsedSpace.TabIndex = 48;
            this.lbUsedSpace.Text = "Đã sử dụng";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.pictureBox2.Location = new System.Drawing.Point(28, 158);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(12, 14);
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(161)))), ((int)(((byte)(219)))));
            this.pictureBox1.Location = new System.Drawing.Point(28, 128);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(12, 14);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // lbNameDrive
            // 
            this.lbNameDrive.AutoSize = true;
            this.lbNameDrive.Location = new System.Drawing.Point(144, 320);
            this.lbNameDrive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNameDrive.Name = "lbNameDrive";
            this.lbNameDrive.Size = new System.Drawing.Size(24, 13);
            this.lbNameDrive.TabIndex = 45;
            this.lbNameDrive.Text = "asd";
            // 
            // txtSectorsPerCluster
            // 
            this.txtSectorsPerCluster.BackColor = System.Drawing.Color.White;
            this.txtSectorsPerCluster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSectorsPerCluster.Location = new System.Drawing.Point(157, 91);
            this.txtSectorsPerCluster.Margin = new System.Windows.Forms.Padding(2);
            this.txtSectorsPerCluster.Name = "txtSectorsPerCluster";
            this.txtSectorsPerCluster.ReadOnly = true;
            this.txtSectorsPerCluster.Size = new System.Drawing.Size(131, 20);
            this.txtSectorsPerCluster.TabIndex = 44;
            // 
            // lbSectorsPerCluster
            // 
            this.lbSectorsPerCluster.AutoSize = true;
            this.lbSectorsPerCluster.Location = new System.Drawing.Point(45, 91);
            this.lbSectorsPerCluster.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSectorsPerCluster.Name = "lbSectorsPerCluster";
            this.lbSectorsPerCluster.Size = new System.Drawing.Size(80, 13);
            this.lbSectorsPerCluster.TabIndex = 43;
            this.lbSectorsPerCluster.Text = "Sectors/Cluster";
            // 
            // txtFreeSpace
            // 
            this.txtFreeSpace.BackColor = System.Drawing.Color.White;
            this.txtFreeSpace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFreeSpace.Location = new System.Drawing.Point(157, 158);
            this.txtFreeSpace.Margin = new System.Windows.Forms.Padding(2);
            this.txtFreeSpace.Name = "txtFreeSpace";
            this.txtFreeSpace.ReadOnly = true;
            this.txtFreeSpace.Size = new System.Drawing.Size(131, 20);
            this.txtFreeSpace.TabIndex = 42;
            // 
            // lbfreeSpace
            // 
            this.lbfreeSpace.AutoSize = true;
            this.lbfreeSpace.Location = new System.Drawing.Point(47, 160);
            this.lbfreeSpace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbfreeSpace.Name = "lbfreeSpace";
            this.lbfreeSpace.Size = new System.Drawing.Size(53, 13);
            this.lbfreeSpace.TabIndex = 41;
            this.lbfreeSpace.Text = "Còn trống";
            // 
            // txtSpace
            // 
            this.txtSpace.BackColor = System.Drawing.Color.White;
            this.txtSpace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSpace.Location = new System.Drawing.Point(157, 191);
            this.txtSpace.Margin = new System.Windows.Forms.Padding(2);
            this.txtSpace.Name = "txtSpace";
            this.txtSpace.ReadOnly = true;
            this.txtSpace.Size = new System.Drawing.Size(131, 20);
            this.txtSpace.TabIndex = 40;
            // 
            // txtType
            // 
            this.txtType.BackColor = System.Drawing.Color.White;
            this.txtType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtType.Location = new System.Drawing.Point(157, 56);
            this.txtType.Margin = new System.Windows.Forms.Padding(2);
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(131, 20);
            this.txtType.TabIndex = 39;
            // 
            // lbspaceOfDrive
            // 
            this.lbspaceOfDrive.AutoSize = true;
            this.lbspaceOfDrive.Location = new System.Drawing.Point(45, 193);
            this.lbspaceOfDrive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbspaceOfDrive.Name = "lbspaceOfDrive";
            this.lbspaceOfDrive.Size = new System.Drawing.Size(62, 13);
            this.lbspaceOfDrive.TabIndex = 38;
            this.lbspaceOfDrive.Text = "Dung lượng";
            // 
            // lbtypeOfDrive
            // 
            this.lbtypeOfDrive.AutoSize = true;
            this.lbtypeOfDrive.Location = new System.Drawing.Point(45, 60);
            this.lbtypeOfDrive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbtypeOfDrive.Name = "lbtypeOfDrive";
            this.lbtypeOfDrive.Size = new System.Drawing.Size(56, 13);
            this.lbtypeOfDrive.TabIndex = 37;
            this.lbtypeOfDrive.Text = "Định dạng";
            // 
            // txtNameDrive
            // 
            this.txtNameDrive.BackColor = System.Drawing.Color.White;
            this.txtNameDrive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNameDrive.Location = new System.Drawing.Point(157, 26);
            this.txtNameDrive.Margin = new System.Windows.Forms.Padding(2);
            this.txtNameDrive.Name = "txtNameDrive";
            this.txtNameDrive.ReadOnly = true;
            this.txtNameDrive.Size = new System.Drawing.Size(131, 20);
            this.txtNameDrive.TabIndex = 36;
            // 
            // lbnameOfDrive
            // 
            this.lbnameOfDrive.AutoSize = true;
            this.lbnameOfDrive.Location = new System.Drawing.Point(45, 28);
            this.lbnameOfDrive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbnameOfDrive.Name = "lbnameOfDrive";
            this.lbnameOfDrive.Size = new System.Drawing.Size(56, 13);
            this.lbnameOfDrive.TabIndex = 35;
            this.lbnameOfDrive.Text = "Tên ổ đĩa";
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.circularProgressBar1.InnerColor = System.Drawing.SystemColors.Control;
            this.circularProgressBar1.InnerMargin = -13;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(122, 227);
            this.circularProgressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(161)))), ((int)(((byte)(219)))));
            this.circularProgressBar1.ProgressWidth = 25;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(72, 74);
            this.circularProgressBar1.StartAngle = 180;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = ".23";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "°C";
            this.circularProgressBar1.TabIndex = 52;
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 68;
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 384);
            this.Controls.Add(this.circularProgressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtUsedSpace);
            this.Controls.Add(this.lbUsedSpace);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbNameDrive);
            this.Controls.Add(this.txtSectorsPerCluster);
            this.Controls.Add(this.lbSectorsPerCluster);
            this.Controls.Add(this.txtFreeSpace);
            this.Controls.Add(this.lbfreeSpace);
            this.Controls.Add(this.txtSpace);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.lbspaceOfDrive);
            this.Controls.Add(this.lbtypeOfDrive);
            this.Controls.Add(this.txtNameDrive);
            this.Controls.Add(this.lbnameOfDrive);
            this.Name = "DetailForm";
            this.Text = "DetailForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtUsedSpace;
        private System.Windows.Forms.Label lbUsedSpace;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbNameDrive;
        private System.Windows.Forms.TextBox txtSectorsPerCluster;
        private System.Windows.Forms.Label lbSectorsPerCluster;
        private System.Windows.Forms.TextBox txtFreeSpace;
        private System.Windows.Forms.Label lbfreeSpace;
        private System.Windows.Forms.TextBox txtSpace;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lbspaceOfDrive;
        private System.Windows.Forms.Label lbtypeOfDrive;
        private System.Windows.Forms.TextBox txtNameDrive;
        private System.Windows.Forms.Label lbnameOfDrive;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
    }
}