using System.Drawing;
using System.Windows.Forms;

namespace YunZhiFaceReco {
    partial class FaceForm {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
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
            this.videoSource = new AForge.Controls.VideoSourcePlayer();
            this.btnStartVideo = new System.Windows.Forms.Button();
            this.txtThreshold = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNowTimeAndWeek = new System.Windows.Forms.Label();
            this.pictureBoxSwiper = new System.Windows.Forms.PictureBox();
            this.labelLoginUserName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxTempLockPwd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelVideoSourceIsRunning = new System.Windows.Forms.Label();
            this.labelMultiFaceInfo = new System.Windows.Forms.Label();
            this.labelMaxFace = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImageCompare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSwiper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.chooseMultiImgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chooseMultiImgBtn.Location = new System.Drawing.Point(14, 469);
            this.chooseMultiImgBtn.Name = "chooseMultiImgBtn";
            this.chooseMultiImgBtn.Size = new System.Drawing.Size(133, 26);
            this.chooseMultiImgBtn.TabIndex = 32;
            this.chooseMultiImgBtn.Text = "注册人脸";
            this.chooseMultiImgBtn.UseVisualStyleBackColor = true;
            this.chooseMultiImgBtn.Click += new System.EventHandler(this.ChooseMultiImg);
            // 
            // logBox
            // 
            this.logBox.BackColor = System.Drawing.Color.White;
            this.logBox.Location = new System.Drawing.Point(15, 721);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logBox.Size = new System.Drawing.Size(315, 113);
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
            this.imageList.Location = new System.Drawing.Point(14, 104);
            this.imageList.Name = "imageList";
            this.imageList.Size = new System.Drawing.Size(527, 362);
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
            this.btnClearFaceList.Location = new System.Drawing.Point(414, 469);
            this.btnClearFaceList.Name = "btnClearFaceList";
            this.btnClearFaceList.Size = new System.Drawing.Size(125, 26);
            this.btnClearFaceList.TabIndex = 35;
            this.btnClearFaceList.Text = "清空人脸库";
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
            // videoSource
            // 
            this.videoSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoSource.Location = new System.Drawing.Point(0, 0);
            this.videoSource.Margin = new System.Windows.Forms.Padding(0);
            this.videoSource.Name = "videoSource";
            this.videoSource.Size = new System.Drawing.Size(1920, 1080);
            this.videoSource.TabIndex = 38;
            this.videoSource.Text = "videoSource";
            this.videoSource.VideoSource = null;
            this.videoSource.Paint += new System.Windows.Forms.PaintEventHandler(this.videoSource_Paint);
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
            this.btnStartVideo.Click += new System.EventHandler(this.btnStartVideo_Click);
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
            this.labelNowTimeAndWeek.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelNowTimeAndWeek.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelNowTimeAndWeek.Location = new System.Drawing.Point(0, 1059);
            this.labelNowTimeAndWeek.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNowTimeAndWeek.Name = "labelNowTimeAndWeek";
            this.labelNowTimeAndWeek.Size = new System.Drawing.Size(168, 21);
            this.labelNowTimeAndWeek.TabIndex = 42;
            this.labelNowTimeAndWeek.Text = "当前时间+星期几";
            // 
            // pictureBoxSwiper
            // 
            this.pictureBoxSwiper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxSwiper.BackgroundImage")));
            this.pictureBoxSwiper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSwiper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxSwiper.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxSwiper.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxSwiper.Name = "pictureBoxSwiper";
            this.pictureBoxSwiper.Size = new System.Drawing.Size(1920, 1080);
            this.pictureBoxSwiper.TabIndex = 46;
            this.pictureBoxSwiper.TabStop = false;
            // 
            // labelLoginUserName
            // 
            this.labelLoginUserName.AutoSize = true;
            this.labelLoginUserName.Location = new System.Drawing.Point(1351, 166);
            this.labelLoginUserName.Name = "labelLoginUserName";
            this.labelLoginUserName.Size = new System.Drawing.Size(29, 12);
            this.labelLoginUserName.TabIndex = 47;
            this.labelLoginUserName.Text = "工号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1280, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 48;
            this.label3.Text = "员工编号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1280, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 49;
            this.label4.Text = "员工姓名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1351, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 50;
            this.label5.Text = "姓名";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "锁屏";
            this.notifyIcon.Visible = true;
            this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 21);
            this.button1.TabIndex = 51;
            this.button1.Text = "锁屏";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBoxTempLockPwd
            // 
            this.textBoxTempLockPwd.Location = new System.Drawing.Point(21, 146);
            this.textBoxTempLockPwd.Name = "textBoxTempLockPwd";
            this.textBoxTempLockPwd.Size = new System.Drawing.Size(124, 21);
            this.textBoxTempLockPwd.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 53;
            this.label6.Text = "锁屏临时密码";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(4, 981);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1196, 75);
            this.pictureBox2.TabIndex = 55;
            this.pictureBox2.TabStop = false;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(13, 266);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(35, 12);
            this.labelX.TabIndex = 56;
            this.labelX.Text = "RectX";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(12, 280);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(35, 12);
            this.labelY.TabIndex = 57;
            this.labelY.Text = "RectY";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(12, 306);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(65, 12);
            this.labelHeight.TabIndex = 58;
            this.labelHeight.Text = "RectHeight";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(12, 292);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(59, 12);
            this.labelWidth.TabIndex = 59;
            this.labelWidth.Text = "RectWidth";
            // 
            // labelVideoSourceIsRunning
            // 
            this.labelVideoSourceIsRunning.AutoSize = true;
            this.labelVideoSourceIsRunning.Location = new System.Drawing.Point(12, 208);
            this.labelVideoSourceIsRunning.Name = "labelVideoSourceIsRunning";
            this.labelVideoSourceIsRunning.Size = new System.Drawing.Size(155, 12);
            this.labelVideoSourceIsRunning.TabIndex = 60;
            this.labelVideoSourceIsRunning.Text = "labelVideoSourceIsRunning";
            // 
            // labelMultiFaceInfo
            // 
            this.labelMultiFaceInfo.AutoSize = true;
            this.labelMultiFaceInfo.Location = new System.Drawing.Point(12, 229);
            this.labelMultiFaceInfo.Name = "labelMultiFaceInfo";
            this.labelMultiFaceInfo.Size = new System.Drawing.Size(77, 12);
            this.labelMultiFaceInfo.TabIndex = 61;
            this.labelMultiFaceInfo.Text = "得到的Rect框";
            // 
            // labelMaxFace
            // 
            this.labelMaxFace.AutoSize = true;
            this.labelMaxFace.Location = new System.Drawing.Point(13, 247);
            this.labelMaxFace.Name = "labelMaxFace";
            this.labelMaxFace.Size = new System.Drawing.Size(53, 12);
            this.labelMaxFace.TabIndex = 62;
            this.labelMaxFace.Text = "最大人脸";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(916, 124);
            this.label2.TabIndex = 63;
            this.label2.Text = "智慧化身份识别系统";
            // 
            // FaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelMaxFace);
            this.Controls.Add(this.labelMultiFaceInfo);
            this.Controls.Add(this.labelVideoSourceIsRunning);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelNowTimeAndWeek);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxTempLockPwd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.videoSource);
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
            this.Controls.Add(this.btnClearFaceList);
            this.Controls.Add(this.matchBtn);
            this.Controls.Add(this.imageList);
            this.Controls.Add(this.chooseMultiImgBtn);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.chooseImgBtn);
            this.Controls.Add(this.lblImageList);
            this.Controls.Add(this.picImageCompare);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FaceForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "扬州云智人脸识别系统";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FaceForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Closed);
            this.SizeChanged += new System.EventHandler(this.FaceForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.picImageCompare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSwiper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private AForge.Controls.VideoSourcePlayer videoSource;
        private System.Windows.Forms.Button btnStartVideo;
        private System.Windows.Forms.TextBox txtThreshold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNowTimeAndWeek;
        private System.Windows.Forms.PictureBox pictureBoxSwiper;
        private System.Windows.Forms.Label labelLoginUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxTempLockPwd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Label labelX;
        private Label labelY;
        private Label labelHeight;
        private Label labelWidth;
        private Label labelVideoSourceIsRunning;
        private Label labelMultiFaceInfo;
        private Label labelMaxFace;
        private Label label2;
    }
}

