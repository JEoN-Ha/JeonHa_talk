namespace JeonHa_talk
{
    partial class UDPClientDlg
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_strIP = new System.Windows.Forms.TextBox();
            this.TextBox_port = new System.Windows.Forms.TextBox();
            this.Button_connect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(35, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "서버 주소";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(35, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "포트 번호";
            // 
            // TextBox_strIP
            // 
            this.TextBox_strIP.Location = new System.Drawing.Point(125, 23);
            this.TextBox_strIP.Name = "TextBox_strIP";
            this.TextBox_strIP.Size = new System.Drawing.Size(241, 21);
            this.TextBox_strIP.TabIndex = 2;
            // 
            // TextBox_port
            // 
            this.TextBox_port.Location = new System.Drawing.Point(125, 59);
            this.TextBox_port.Name = "TextBox_port";
            this.TextBox_port.Size = new System.Drawing.Size(241, 21);
            this.TextBox_port.TabIndex = 3;
            // 
            // Button_connect
            // 
            this.Button_connect.Location = new System.Drawing.Point(384, 61);
            this.Button_connect.Name = "Button_connect";
            this.Button_connect.Size = new System.Drawing.Size(83, 24);
            this.Button_connect.TabIndex = 5;
            this.Button_connect.Text = "연결";
            this.Button_connect.UseVisualStyleBackColor = true;
            this.Button_connect.Click += new System.EventHandler(this.Button_connect_Click);
            // 
            // UDPClientDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(497, 105);
            this.Controls.Add(this.Button_connect);
            this.Controls.Add(this.TextBox_port);
            this.Controls.Add(this.TextBox_strIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UDPClientDlg";
            this.Text = "UDPChatServer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBox_strIP;
        private System.Windows.Forms.TextBox TextBox_port;
        private System.Windows.Forms.Button Button_connect;
    }
}

