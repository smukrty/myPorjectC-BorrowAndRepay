
namespace BorrowAndRepay
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.submitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.myNameInput = new System.Windows.Forms.TextBox();
            this.friendNameInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.myNameLabel = new System.Windows.Forms.Label();
            this.myMoneyLabel = new System.Windows.Forms.Label();
            this.friendMoneyLabel = new System.Windows.Forms.Label();
            this.frienfNameLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.myBorrowButton = new System.Windows.Forms.Button();
            this.myRepayBotton = new System.Windows.Forms.Button();
            this.friendRepayBotton = new System.Windows.Forms.Button();
            this.friendBorrowButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(287, 30);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(82, 55);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "確認";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "請輸入我的名子：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(27, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "請輸入朋友的名子：";
            // 
            // myNameInput
            // 
            this.myNameInput.Location = new System.Drawing.Point(181, 30);
            this.myNameInput.Name = "myNameInput";
            this.myNameInput.Size = new System.Drawing.Size(100, 22);
            this.myNameInput.TabIndex = 3;
            // 
            // friendNameInput
            // 
            this.friendNameInput.Location = new System.Drawing.Point(181, 63);
            this.friendNameInput.Name = "friendNameInput";
            this.friendNameInput.Size = new System.Drawing.Size(100, 22);
            this.friendNameInput.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(27, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "我的名子：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(27, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "我的$$：";
            // 
            // myNameLabel
            // 
            this.myNameLabel.AutoSize = true;
            this.myNameLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.myNameLabel.Location = new System.Drawing.Point(121, 115);
            this.myNameLabel.Name = "myNameLabel";
            this.myNameLabel.Size = new System.Drawing.Size(56, 16);
            this.myNameLabel.TabIndex = 7;
            this.myNameLabel.Text = "無名氏";
            // 
            // myMoneyLabel
            // 
            this.myMoneyLabel.AutoSize = true;
            this.myMoneyLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.myMoneyLabel.Location = new System.Drawing.Point(121, 150);
            this.myMoneyLabel.Name = "myMoneyLabel";
            this.myMoneyLabel.Size = new System.Drawing.Size(16, 16);
            this.myMoneyLabel.TabIndex = 8;
            this.myMoneyLabel.Text = "0";
            // 
            // friendMoneyLabel
            // 
            this.friendMoneyLabel.AutoSize = true;
            this.friendMoneyLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.friendMoneyLabel.Location = new System.Drawing.Point(306, 150);
            this.friendMoneyLabel.Name = "friendMoneyLabel";
            this.friendMoneyLabel.Size = new System.Drawing.Size(56, 16);
            this.friendMoneyLabel.TabIndex = 12;
            this.friendMoneyLabel.Text = "200000";
            // 
            // frienfNameLabel
            // 
            this.frienfNameLabel.AutoSize = true;
            this.frienfNameLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.frienfNameLabel.Location = new System.Drawing.Point(306, 115);
            this.frienfNameLabel.Name = "frienfNameLabel";
            this.frienfNameLabel.Size = new System.Drawing.Size(56, 16);
            this.frienfNameLabel.TabIndex = 11;
            this.frienfNameLabel.Text = "無名氏";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(212, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "朋友的$$：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(212, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "朋友的名子：";
            // 
            // myBorrowButton
            // 
            this.myBorrowButton.Enabled = false;
            this.myBorrowButton.Location = new System.Drawing.Point(30, 188);
            this.myBorrowButton.Name = "myBorrowButton";
            this.myBorrowButton.Size = new System.Drawing.Size(147, 36);
            this.myBorrowButton.TabIndex = 13;
            this.myBorrowButton.Text = "xxx 跟 xxx 借 1000$";
            this.myBorrowButton.UseVisualStyleBackColor = true;
            this.myBorrowButton.Click += new System.EventHandler(this.borrowButton_Click);
            // 
            // myRepayBotton
            // 
            this.myRepayBotton.Enabled = false;
            this.myRepayBotton.Location = new System.Drawing.Point(30, 230);
            this.myRepayBotton.Name = "myRepayBotton";
            this.myRepayBotton.Size = new System.Drawing.Size(147, 36);
            this.myRepayBotton.TabIndex = 14;
            this.myRepayBotton.Text = "xxx 還 xxx 借 1000$";
            this.myRepayBotton.UseVisualStyleBackColor = true;
            this.myRepayBotton.Click += new System.EventHandler(this.repayBotton_Click);
            // 
            // friendRepayBotton
            // 
            this.friendRepayBotton.Enabled = false;
            this.friendRepayBotton.Location = new System.Drawing.Point(215, 230);
            this.friendRepayBotton.Name = "friendRepayBotton";
            this.friendRepayBotton.Size = new System.Drawing.Size(147, 36);
            this.friendRepayBotton.TabIndex = 16;
            this.friendRepayBotton.Text = "xxx 還 xxx 借 1000$";
            this.friendRepayBotton.UseVisualStyleBackColor = true;
            this.friendRepayBotton.Click += new System.EventHandler(this.friendRepayBotton_Click);
            // 
            // friendBorrowButton
            // 
            this.friendBorrowButton.Enabled = false;
            this.friendBorrowButton.Location = new System.Drawing.Point(215, 188);
            this.friendBorrowButton.Name = "friendBorrowButton";
            this.friendBorrowButton.Size = new System.Drawing.Size(147, 36);
            this.friendBorrowButton.TabIndex = 15;
            this.friendBorrowButton.Text = "xxx 跟 xxx 借 1000$";
            this.friendBorrowButton.UseVisualStyleBackColor = true;
            this.friendBorrowButton.Click += new System.EventHandler(this.friendBorrowButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 369);
            this.Controls.Add(this.friendRepayBotton);
            this.Controls.Add(this.friendBorrowButton);
            this.Controls.Add(this.myRepayBotton);
            this.Controls.Add(this.myBorrowButton);
            this.Controls.Add(this.friendMoneyLabel);
            this.Controls.Add(this.frienfNameLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.myMoneyLabel);
            this.Controls.Add(this.myNameLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.friendNameInput);
            this.Controls.Add(this.myNameInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitButton);
            this.Name = "Form1";
            this.Text = "借還錢程式";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox myNameInput;
        private System.Windows.Forms.TextBox friendNameInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label myNameLabel;
        private System.Windows.Forms.Label myMoneyLabel;
        private System.Windows.Forms.Label friendMoneyLabel;
        private System.Windows.Forms.Label frienfNameLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button myBorrowButton;
        private System.Windows.Forms.Button myRepayBotton;
        private System.Windows.Forms.Button friendRepayBotton;
        private System.Windows.Forms.Button friendBorrowButton;
    }
}

