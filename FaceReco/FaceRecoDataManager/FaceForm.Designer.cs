namespace YunZhiFaceReco
{
    partial class FaceForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaceForm));
            this.picImageCompare = new System.Windows.Forms.PictureBox();
            this.lblImageList = new System.Windows.Forms.Label();
            this.chooseMultiImgBtn = new System.Windows.Forms.Button();
            this.logBox = new System.Windows.Forms.TextBox();
            this.chooseImgBtn = new System.Windows.Forms.Button();
            this.imageLists = new System.Windows.Forms.ImageList(this.components);
            this.imageList = new System.Windows.Forms.ListView();
            this.matchBtn = new System.Windows.Forms.Button();
            this.btnClearFaceList = new System.Windows.Forms.Button();
            this.lblCompareImage = new System.Windows.Forms.Label();
            this.lblCompareInfo = new System.Windows.Forms.Label();
            this.btnStartVideo = new System.Windows.Forms.Button();
            this.txtThreshold = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNowTimeAndWeek = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxSwiper = new System.Windows.Forms.PictureBox();
            this.labelLoginUserName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImageCompare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSwiper)).BeginInit();
            this.SuspendLayout();
            // 
            // picImageCompare
            // 
            this.picImageCompare.BackColor = System.Drawing.Color.White;
            this.picImageCompare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picImageCompare.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picImageCompare.Location = new System.Drawing.Point(604, 103);
            this.picImageCompare.Name = "picImageCompare";
            this.picImageCompare.Size = new System.Drawing.Size(494, 362);
            this.picImageCompare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picImageCompare.TabIndex = 1;
            this.picImageCompare.TabStop = false;
            // 
            // lblImageList
            // 
            this.lblImageList.AutoSize = true;
            this.lblImageList.Location = new System.Drawing.Point(12, 89);
            this.lblImageList.Name = "lblImageList";
            this.lblImageList.Size = new System.Drawing.Size(47, 12);
            this.lblImageList.TabIndex = 7;
            this.lblImageList.Text = "人脸库:";
            // 
            // chooseMultiImgBtn
            // 
            this.chooseMultiImgBtn.AutoSize = true;
            this.chooseMultiImgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chooseMultiImgBtn.Location = new System.Drawing.Point(1164, 406);
            this.chooseMultiImgBtn.Name = "chooseMultiImgBtn";
            this.chooseMultiImgBtn.Size = new System.Drawing.Size(133, 35);
            this.chooseMultiImgBtn.TabIndex = 32;
            this.chooseMultiImgBtn.Text = "注册人脸";
            this.chooseMultiImgBtn.UseVisualStyleBackColor = true;
            this.chooseMultiImgBtn.Click += new System.EventHandler(this.ChooseMultiImg);
            // 
            // logBox
            // 
            this.logBox.BackColor = System.Drawing.Color.White;
            this.logBox.Location = new System.Drawing.Point(12, 543);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logBox.Size = new System.Drawing.Size(1085, 281);
            this.logBox.TabIndex = 31;
            // 
            // chooseImgBtn
            // 
            this.chooseImgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chooseImgBtn.Location = new System.Drawing.Point(603, 469);
            this.chooseImgBtn.Name = "chooseImgBtn";
            this.chooseImgBtn.Size = new System.Drawing.Size(109, 26);
            this.chooseImgBtn.TabIndex = 30;
            this.chooseImgBtn.Text = "选择识别图";
            this.chooseImgBtn.UseVisualStyleBackColor = true;
            this.chooseImgBtn.Click += new System.EventHandler(this.ChooseImg);
            // 
            // imageLists
            // 
            this.imageLists.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageLists.ImageStream")));
            this.imageLists.TransparentColor = System.Drawing.Color.Transparent;
            this.imageLists.Images.SetKeyName(0, "alai_152784032385984494.jpg");
            // 
            // imageList
            // 
            this.imageList.LargeImageList = this.imageLists;
            this.imageList.Location = new System.Drawing.Point(12, 103);
            this.imageList.Name = "imageList";
            this.imageList.Size = new System.Drawing.Size(1086, 424);
            this.imageList.TabIndex = 33;
            this.imageList.UseCompatibleStateImageBehavior = false;
            // 
            // matchBtn
            // 
            this.matchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.matchBtn.Location = new System.Drawing.Point(747, 469);
            this.matchBtn.Name = "matchBtn";
            this.matchBtn.Size = new System.Drawing.Size(104, 26);
            this.matchBtn.TabIndex = 34;
            this.matchBtn.Text = "开始匹配";
            this.matchBtn.UseVisualStyleBackColor = true;
            this.matchBtn.Click += new System.EventHandler(this.matchBtn_Click);
            // 
            // btnClearFaceList
            // 
            this.btnClearFaceList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFaceList.Location = new System.Drawing.Point(1164, 492);
            this.btnClearFaceList.Name = "btnClearFaceList";
            this.btnClearFaceList.Size = new System.Drawing.Size(133, 35);
            this.btnClearFaceList.TabIndex = 35;
            this.btnClearFaceList.Text = "清空列表";
            this.btnClearFaceList.UseVisualStyleBackColor = true;
            this.btnClearFaceList.Click += new System.EventHandler(this.btnClearFaceList_Click);
            // 
            // lblCompareImage
            // 
            this.lblCompareImage.AutoSize = true;
            this.lblCompareImage.Location = new System.Drawing.Point(601, 88);
            this.lblCompareImage.Name = "lblCompareImage";
            this.lblCompareImage.Size = new System.Drawing.Size(59, 12);
            this.lblCompareImage.TabIndex = 36;
            this.lblCompareImage.Text = "比对人脸:";
            // 
            // lblCompareInfo
            // 
            this.lblCompareInfo.AutoSize = true;
            this.lblCompareInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCompareInfo.Location = new System.Drawing.Point(667, 11);
            this.lblCompareInfo.Name = "lblCompareInfo";
            this.lblCompareInfo.Size = new System.Drawing.Size(0, 16);
            this.lblCompareInfo.TabIndex = 37;
            // 
            // btnStartVideo
            // 
            this.btnStartVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartVideo.Location = new System.Drawing.Point(884, 469);
            this.btnStartVideo.Name = "btnStartVideo";
            this.btnStartVideo.Size = new System.Drawing.Size(107, 26);
            this.btnStartVideo.TabIndex = 39;
            this.btnStartVideo.Text = "启用摄像头";
            this.btnStartVideo.UseVisualStyleBackColor = true;
            // 
            // txtThreshold
            // 
            this.txtThreshold.BackColor = System.Drawing.SystemColors.Window;
            this.txtThreshold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThreshold.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtThreshold.Location = new System.Drawing.Point(1037, 469);
            this.txtThreshold.Name = "txtThreshold";
            this.txtThreshold.Size = new System.Drawing.Size(60, 25);
            this.txtThreshold.TabIndex = 40;
            this.txtThreshold.Text = "0.8";
            this.txtThreshold.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThreshold_KeyPress);
            this.txtThreshold.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtThreshold_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(996, 475);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 41;
            this.label1.Text = "阈值：";
            // 
            // labelNowTimeAndWeek
            // 
            this.labelNowTimeAndWeek.AutoSize = true;
            this.labelNowTimeAndWeek.BackColor = System.Drawing.Color.Transparent;
            this.labelNowTimeAndWeek.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelNowTimeAndWeek.Location = new System.Drawing.Point(11, 9);
            this.labelNowTimeAndWeek.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNowTimeAndWeek.Name = "labelNowTimeAndWeek";
            this.labelNowTimeAndWeek.Size = new System.Drawing.Size(128, 16);
            this.labelNowTimeAndWeek.TabIndex = 42;
            this.labelNowTimeAndWeek.Text = "当前时间+星期几";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(310, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 38);
            this.label2.TabIndex = 45;
            this.label2.Text = "智慧化身份识别系统";
            // 
            // pictureBoxSwiper
            // 
            this.pictureBoxSwiper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxSwiper.BackgroundImage")));
            this.pictureBoxSwiper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSwiper.Location = new System.Drawing.Point(-12, -38);
            this.pictureBoxSwiper.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxSwiper.Name = "pictureBoxSwiper";
            this.pictureBoxSwiper.Size = new System.Drawing.Size(1470, 873);
            this.pictureBoxSwiper.TabIndex = 46;
            this.pictureBoxSwiper.TabStop = false;
            // 
            // labelLoginUserName
            // 
            this.labelLoginUserName.AutoSize = true;
            this.labelLoginUserName.BackColor = System.Drawing.Color.Transparent;
            this.labelLoginUserName.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelLoginUserName.Location = new System.Drawing.Point(1162, 180);
            this.labelLoginUserName.Name = "labelLoginUserName";
            this.labelLoginUserName.Size = new System.Drawing.Size(52, 27);
            this.labelLoginUserName.TabIndex = 47;
            this.labelLoginUserName.Text = "赵伟";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(1162, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 27);
            this.label3.TabIndex = 48;
            this.label3.Text = "员工姓名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(1159, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 27);
            this.label4.TabIndex = 49;
            this.label4.Text = "员工电话";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(1162, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 27);
            this.label5.TabIndex = 50;
            this.label5.Text = "18955555555";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(802, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 51;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(621, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 52;
            // 
            // FaceForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1441, 836);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClearFaceList);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.chooseMultiImgBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNowTimeAndWeek);
            this.Controls.Add(this.imageList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelLoginUserName);
            this.Controls.Add(this.pictureBoxSwiper);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtThreshold);
            this.Controls.Add(this.btnStartVideo);
            this.Controls.Add(this.lblCompareInfo);
            this.Controls.Add(this.lblCompareImage);
            this.Controls.Add(this.matchBtn);
            this.Controls.Add(this.chooseImgBtn);
            this.Controls.Add(this.lblImageList);
            this.Controls.Add(this.picImageCompare);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FaceForm";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "智慧化身份识别系统人脸录入";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Closed);
            ((System.ComponentModel.ISupportInitialize)(this.picImageCompare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSwiper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picImageCompare;
        private System.Windows.Forms.Label lblImageList;
        private System.Windows.Forms.Button chooseMultiImgBtn;
        private System.Windows.Forms.TextBox logBox;// 日志框
        private System.Windows.Forms.Button chooseImgBtn;
        private System.Windows.Forms.ImageList imageLists;
        private System.Windows.Forms.ListView imageList;
        private System.Windows.Forms.Button matchBtn;
        private System.Windows.Forms.Button btnClearFaceList;
        private System.Windows.Forms.Label lblCompareImage;
        private System.Windows.Forms.Label lblCompareInfo;
        private System.Windows.Forms.Button btnStartVideo;
        private System.Windows.Forms.TextBox txtThreshold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNowTimeAndWeek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxSwiper;
        private System.Windows.Forms.Label labelLoginUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

