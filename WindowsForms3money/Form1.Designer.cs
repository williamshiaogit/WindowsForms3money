namespace WindowsForms3money
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
            this.label_input_me = new System.Windows.Forms.Label();
            this.label_input_friend = new System.Windows.Forms.Label();
            this.textBox_input_me = new System.Windows.Forms.TextBox();
            this.textBox_input_friend = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_myMoney = new System.Windows.Forms.Label();
            this.label_myName = new System.Windows.Forms.Label();
            this.label_friendMoney = new System.Windows.Forms.Label();
            this.label_friendName = new System.Windows.Forms.Label();
            this.button_payBack = new System.Windows.Forms.Button();
            this.button_borrow = new System.Windows.Forms.Button();
            this.button_confirm = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label_myTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_input_me
            // 
            this.label_input_me.AutoSize = true;
            this.label_input_me.Location = new System.Drawing.Point(35, 36);
            this.label_input_me.Name = "label_input_me";
            this.label_input_me.Size = new System.Drawing.Size(101, 15);
            this.label_input_me.TabIndex = 1;
            this.label_input_me.Text = "輸入我的名字:";
            // 
            // label_input_friend
            // 
            this.label_input_friend.AutoSize = true;
            this.label_input_friend.Location = new System.Drawing.Point(35, 67);
            this.label_input_friend.Name = "label_input_friend";
            this.label_input_friend.Size = new System.Drawing.Size(116, 15);
            this.label_input_friend.TabIndex = 2;
            this.label_input_friend.Text = "輸入朋友的名字:";
            // 
            // textBox_input_me
            // 
            this.textBox_input_me.Location = new System.Drawing.Point(176, 33);
            this.textBox_input_me.Name = "textBox_input_me";
            this.textBox_input_me.Size = new System.Drawing.Size(100, 25);
            this.textBox_input_me.TabIndex = 3;
            // 
            // textBox_input_friend
            // 
            this.textBox_input_friend.Location = new System.Drawing.Point(176, 64);
            this.textBox_input_friend.Name = "textBox_input_friend";
            this.textBox_input_friend.Size = new System.Drawing.Size(100, 25);
            this.textBox_input_friend.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "我的名字:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "我的錢:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "朋友的錢:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "朋友的名字:";
            // 
            // label_myMoney
            // 
            this.label_myMoney.AutoSize = true;
            this.label_myMoney.Location = new System.Drawing.Point(143, 197);
            this.label_myMoney.Name = "label_myMoney";
            this.label_myMoney.Size = new System.Drawing.Size(14, 15);
            this.label_myMoney.TabIndex = 10;
            this.label_myMoney.Text = "$";
            // 
            // label_myName
            // 
            this.label_myName.AutoSize = true;
            this.label_myName.Location = new System.Drawing.Point(143, 165);
            this.label_myName.Name = "label_myName";
            this.label_myName.Size = new System.Drawing.Size(37, 15);
            this.label_myName.TabIndex = 9;
            this.label_myName.Text = "名字";
            // 
            // label_friendMoney
            // 
            this.label_friendMoney.AutoSize = true;
            this.label_friendMoney.Location = new System.Drawing.Point(403, 197);
            this.label_friendMoney.Name = "label_friendMoney";
            this.label_friendMoney.Size = new System.Drawing.Size(14, 15);
            this.label_friendMoney.TabIndex = 12;
            this.label_friendMoney.Text = "$";
            // 
            // label_friendName
            // 
            this.label_friendName.AutoSize = true;
            this.label_friendName.Location = new System.Drawing.Point(403, 165);
            this.label_friendName.Name = "label_friendName";
            this.label_friendName.Size = new System.Drawing.Size(37, 15);
            this.label_friendName.TabIndex = 11;
            this.label_friendName.Text = "名字";
            // 
            // button_payBack
            // 
            this.button_payBack.Enabled = false;
            this.button_payBack.Location = new System.Drawing.Point(68, 343);
            this.button_payBack.Name = "button_payBack";
            this.button_payBack.Size = new System.Drawing.Size(112, 46);
            this.button_payBack.TabIndex = 13;
            this.button_payBack.Text = "還朋友1000";
            this.button_payBack.UseVisualStyleBackColor = true;
            this.button_payBack.Click += new System.EventHandler(this.button_payBack_Click);
            // 
            // button_borrow
            // 
            this.button_borrow.Enabled = false;
            this.button_borrow.Location = new System.Drawing.Point(68, 276);
            this.button_borrow.Name = "button_borrow";
            this.button_borrow.Size = new System.Drawing.Size(112, 46);
            this.button_borrow.TabIndex = 14;
            this.button_borrow.Text = "向朋友借1000";
            this.button_borrow.UseVisualStyleBackColor = true;
            this.button_borrow.Click += new System.EventHandler(this.button_borrow_Click);
            // 
            // button_confirm
            // 
            this.button_confirm.Location = new System.Drawing.Point(345, 36);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(112, 46);
            this.button_confirm.TabIndex = 15;
            this.button_confirm.Text = "確認";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "總共借了:";
            // 
            // label_myTotal
            // 
            this.label_myTotal.AutoSize = true;
            this.label_myTotal.Location = new System.Drawing.Point(143, 228);
            this.label_myTotal.Name = "label_myTotal";
            this.label_myTotal.Size = new System.Drawing.Size(14, 15);
            this.label_myTotal.TabIndex = 17;
            this.label_myTotal.Text = "$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 450);
            this.Controls.Add(this.label_myTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.button_borrow);
            this.Controls.Add(this.button_payBack);
            this.Controls.Add(this.label_friendMoney);
            this.Controls.Add(this.label_friendName);
            this.Controls.Add(this.label_myMoney);
            this.Controls.Add(this.label_myName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_input_friend);
            this.Controls.Add(this.textBox_input_me);
            this.Controls.Add(this.label_input_friend);
            this.Controls.Add(this.label_input_me);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_input_me;
        private System.Windows.Forms.Label label_input_friend;
        private System.Windows.Forms.TextBox textBox_input_me;
        private System.Windows.Forms.TextBox textBox_input_friend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_myMoney;
        private System.Windows.Forms.Label label_myName;
        private System.Windows.Forms.Label label_friendMoney;
        private System.Windows.Forms.Label label_friendName;
        private System.Windows.Forms.Button button_payBack;
        private System.Windows.Forms.Button button_borrow;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_myTotal;
    }
}

