namespace inoutlinktool
{
    partial class home
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainDirectory = new System.Windows.Forms.TextBox();
            this.getDirectory = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkHash = new System.Windows.Forms.CheckBox();
            this.checkInlink = new System.Windows.Forms.CheckBox();
            this.Start = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.hashprogress = new System.Windows.Forms.ProgressBar();
            this.linkprogress = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainDirectory
            // 
            this.mainDirectory.Enabled = false;
            this.mainDirectory.Location = new System.Drawing.Point(14, 14);
            this.mainDirectory.Name = "mainDirectory";
            this.mainDirectory.Size = new System.Drawing.Size(289, 21);
            this.mainDirectory.TabIndex = 1;
            this.mainDirectory.Text = "Please Select Work Folder";
            // 
            // getDirectory
            // 
            this.getDirectory.Location = new System.Drawing.Point(309, 12);
            this.getDirectory.Name = "getDirectory";
            this.getDirectory.Size = new System.Drawing.Size(33, 23);
            this.getDirectory.TabIndex = 2;
            this.getDirectory.Text = "...";
            this.getDirectory.UseVisualStyleBackColor = true;
            this.getDirectory.Click += new System.EventHandler(this.GetDirectory_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkHash);
            this.groupBox1.Controls.Add(this.checkInlink);
            this.groupBox1.Location = new System.Drawing.Point(14, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 92);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Options ";
            // 
            // checkHash
            // 
            this.checkHash.AutoSize = true;
            this.checkHash.Enabled = false;
            this.checkHash.Location = new System.Drawing.Point(24, 53);
            this.checkHash.Name = "checkHash";
            this.checkHash.Size = new System.Drawing.Size(206, 16);
            this.checkHash.TabIndex = 1;
            this.checkHash.Text = "Remove _hash nodes from XML";
            this.checkHash.UseVisualStyleBackColor = true;
            // 
            // checkInlink
            // 
            this.checkInlink.AutoSize = true;
            this.checkInlink.Enabled = false;
            this.checkInlink.Location = new System.Drawing.Point(24, 30);
            this.checkInlink.Name = "checkInlink";
            this.checkInlink.Size = new System.Drawing.Size(239, 16);
            this.checkInlink.TabIndex = 0;
            this.checkInlink.Text = "Clear _in/_out links (supports source)";
            this.checkInlink.UseVisualStyleBackColor = true;
            // 
            // Start
            // 
            this.Start.Enabled = false;
            this.Start.Location = new System.Drawing.Point(14, 139);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(230, 44);
            this.Start.TabIndex = 4;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(250, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 44);
            this.button2.TabIndex = 5;
            this.button2.Text = "Help";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // hashprogress
            // 
            this.hashprogress.Location = new System.Drawing.Point(14, 189);
            this.hashprogress.Name = "hashprogress";
            this.hashprogress.Size = new System.Drawing.Size(328, 23);
            this.hashprogress.TabIndex = 6;
            // 
            // linkprogress
            // 
            this.linkprogress.Location = new System.Drawing.Point(14, 218);
            this.linkprogress.Name = "linkprogress";
            this.linkprogress.Size = new System.Drawing.Size(328, 23);
            this.linkprogress.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(358, 280);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkprogress);
            this.Controls.Add(this.hashprogress);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.getDirectory);
            this.Controls.Add(this.mainDirectory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XML _in/_out Link Parser by Peter Lee";
            this.Load += new System.EventHandler(this.Home_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox mainDirectory;
        private System.Windows.Forms.Button getDirectory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkHash;
        private System.Windows.Forms.CheckBox checkInlink;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar hashprogress;
        private System.Windows.Forms.ProgressBar linkprogress;
        private System.Windows.Forms.Label label1;
    }
}

