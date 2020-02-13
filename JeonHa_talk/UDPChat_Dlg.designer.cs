namespace UDPChatServer
{
    partial class UDPChat_Dlg
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
            this.Sever_Address = new System.Windows.Forms.TextBox();
            this.Port_number = new System.Windows.Forms.TextBox();
            this.Server_Connect = new System.Windows.Forms.Button();
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
            this.label2.Location = new System.Drawing.Point(35, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "포트 번호";
            // 
            // Sever_Address
            // 
            this.Sever_Address.Location = new System.Drawing.Point(125, 23);
            this.Sever_Address.Name = "Sever_Address";
            this.Sever_Address.Size = new System.Drawing.Size(241, 21);
            this.Sever_Address.TabIndex = 2;
            // 
            // Port_number
            // 
            this.Port_number.Location = new System.Drawing.Point(125, 60);
            this.Port_number.Name = "Port_number";
            this.Port_number.Size = new System.Drawing.Size(241, 21);
            this.Port_number.TabIndex = 3;
            // 
            // Server_Connect
            // 
            this.Server_Connect.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Server_Connect.Location = new System.Drawing.Point(392, 60);
            this.Server_Connect.Name = "Server_Connect";
            this.Server_Connect.Size = new System.Drawing.Size(83, 24);
            this.Server_Connect.TabIndex = 5;
            this.Server_Connect.Text = "연결";
            this.Server_Connect.UseVisualStyleBackColor = true;
            this.Server_Connect.Click += new System.EventHandler(this.server_connect_Click);
            // 
            // UDPChat_Dlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(491, 98);
            this.Controls.Add(this.Server_Connect);
            this.Controls.Add(this.Port_number);
            this.Controls.Add(this.Sever_Address);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UDPChat_Dlg";
            this.Text = "UDPChatServer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Sever_Address;
        private System.Windows.Forms.TextBox Port_number;
        private System.Windows.Forms.Button Server_Connect;
    }
}

