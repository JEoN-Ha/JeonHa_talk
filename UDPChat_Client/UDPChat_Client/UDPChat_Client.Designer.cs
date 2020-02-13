namespace UDPChat_Client
{
    partial class UDPChat_Client
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
            this.message_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.address_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.port_text = new System.Windows.Forms.TextBox();
            this.connect_button = new System.Windows.Forms.Button();
            this.button_open = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // message_box
            // 
            this.message_box.Location = new System.Drawing.Point(28, 90);
            this.message_box.Multiline = true;
            this.message_box.Name = "message_box";
            this.message_box.Size = new System.Drawing.Size(876, 407);
            this.message_box.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(24, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "서버 주소";
            // 
            // address_text
            // 
            this.address_text.Location = new System.Drawing.Point(126, 45);
            this.address_text.Name = "address_text";
            this.address_text.Size = new System.Drawing.Size(275, 25);
            this.address_text.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(441, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "포트 번호";
            // 
            // port_text
            // 
            this.port_text.Location = new System.Drawing.Point(543, 46);
            this.port_text.Name = "port_text";
            this.port_text.Size = new System.Drawing.Size(137, 25);
            this.port_text.TabIndex = 5;
            // 
            // connect_button
            // 
            this.connect_button.Location = new System.Drawing.Point(695, 45);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(95, 30);
            this.connect_button.TabIndex = 6;
            this.connect_button.Text = "연결";
            this.connect_button.UseVisualStyleBackColor = true;
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(801, 46);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(102, 28);
            this.button_open.TabIndex = 7;
            this.button_open.Text = "Open";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.open_button_Click);
            // 
            // UDPChat_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 523);
            this.Controls.Add(this.button_open);
            this.Controls.Add(this.connect_button);
            this.Controls.Add(this.port_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.address_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.message_box);
            this.Name = "UDPChat_Client";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox message_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox address_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox port_text;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.Button button_open;
    }
}

