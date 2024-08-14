namespace BorrowAndRepay
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            myNameInput = new TextBox();
            friendNameInput = new TextBox();
            submitButton = new Button();
            label3 = new Label();
            label4 = new Label();
            myNameLabel = new Label();
            myMoneyLabel = new Label();
            label7 = new Label();
            friendNameLabel = new Label();
            friendMoneyLabel = new Label();
            label10 = new Label();
            borrowButton = new Button();
            repayButton = new Button();
            friendBorrowButton = new Button();
            friendRepayButton = new Button();
            myLoanLabel = new Label();
            label6 = new Label();
            friendLoanLabel = new Label();
            label9 = new Label();
            resetButton = new Button();
            borrowMoneyAmount = new NumericUpDown();
            label5 = new Label();
            borrowMoneyAmountConfirm = new Button();
            label8 = new Label();
            label11 = new Label();
            myDeposit = new NumericUpDown();
            friendDeposit = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)borrowMoneyAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)myDeposit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)friendDeposit).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 56);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "我的名字：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 97);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 0;
            label2.Text = "朋友的名字：";
            // 
            // myNameInput
            // 
            myNameInput.Location = new Point(122, 53);
            myNameInput.Name = "myNameInput";
            myNameInput.Size = new Size(72, 23);
            myNameInput.TabIndex = 1;
            // 
            // friendNameInput
            // 
            friendNameInput.Location = new Point(122, 94);
            friendNameInput.Name = "friendNameInput";
            friendNameInput.Size = new Size(72, 23);
            friendNameInput.TabIndex = 1;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(356, 54);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(105, 63);
            submitButton.TabIndex = 2;
            submitButton.Text = "確認";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 193);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 3;
            label3.Text = "我的名字：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 222);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 3;
            label4.Text = "我的錢：";
            // 
            // myNameLabel
            // 
            myNameLabel.AutoSize = true;
            myNameLabel.Location = new Point(148, 193);
            myNameLabel.Name = "myNameLabel";
            myNameLabel.Size = new Size(46, 15);
            myNameLabel.TabIndex = 3;
            myNameLabel.Text = "無名氏";
            // 
            // myMoneyLabel
            // 
            myMoneyLabel.AutoSize = true;
            myMoneyLabel.Location = new Point(148, 222);
            myMoneyLabel.Name = "myMoneyLabel";
            myMoneyLabel.Size = new Size(12, 15);
            myMoneyLabel.TabIndex = 3;
            myMoneyLabel.Text = "?";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(283, 193);
            label7.Name = "label7";
            label7.Size = new Size(85, 15);
            label7.TabIndex = 3;
            label7.Text = "朋友的名字：";
            // 
            // friendNameLabel
            // 
            friendNameLabel.AutoSize = true;
            friendNameLabel.Location = new Point(374, 193);
            friendNameLabel.Name = "friendNameLabel";
            friendNameLabel.Size = new Size(46, 15);
            friendNameLabel.TabIndex = 3;
            friendNameLabel.Text = "無名氏";
            // 
            // friendMoneyLabel
            // 
            friendMoneyLabel.AutoSize = true;
            friendMoneyLabel.Location = new Point(377, 222);
            friendMoneyLabel.Name = "friendMoneyLabel";
            friendMoneyLabel.Size = new Size(12, 15);
            friendMoneyLabel.TabIndex = 3;
            friendMoneyLabel.Text = "?";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(283, 222);
            label10.Name = "label10";
            label10.Size = new Size(72, 15);
            label10.TabIndex = 3;
            label10.Text = "朋友的錢：";
            // 
            // borrowButton
            // 
            borrowButton.Enabled = false;
            borrowButton.Location = new Point(35, 255);
            borrowButton.Name = "borrowButton";
            borrowButton.Size = new Size(207, 48);
            borrowButton.TabIndex = 2;
            borrowButton.Text = "跟 xxx 借 ??? 元";
            borrowButton.UseVisualStyleBackColor = true;
            borrowButton.Click += borrowButton_Click;
            // 
            // repayButton
            // 
            repayButton.Enabled = false;
            repayButton.Location = new Point(35, 309);
            repayButton.Name = "repayButton";
            repayButton.Size = new Size(207, 48);
            repayButton.TabIndex = 2;
            repayButton.Text = "還給 xxx ??? 元";
            repayButton.UseVisualStyleBackColor = true;
            repayButton.Click += repayButton_Click;
            // 
            // friendBorrowButton
            // 
            friendBorrowButton.Enabled = false;
            friendBorrowButton.Location = new Point(254, 255);
            friendBorrowButton.Name = "friendBorrowButton";
            friendBorrowButton.Size = new Size(207, 48);
            friendBorrowButton.TabIndex = 2;
            friendBorrowButton.Text = "xxx 跟我借了 ??? 元";
            friendBorrowButton.UseVisualStyleBackColor = true;
            friendBorrowButton.Click += friendBorrowButton_Click;
            // 
            // friendRepayButton
            // 
            friendRepayButton.Enabled = false;
            friendRepayButton.Location = new Point(254, 309);
            friendRepayButton.Name = "friendRepayButton";
            friendRepayButton.Size = new Size(207, 48);
            friendRepayButton.TabIndex = 2;
            friendRepayButton.Text = "xxx 還給我 ??? 元";
            friendRepayButton.UseVisualStyleBackColor = true;
            friendRepayButton.Click += friendRepayButton_Click;
            // 
            // myLoanLabel
            // 
            myLoanLabel.AutoSize = true;
            myLoanLabel.Location = new Point(148, 166);
            myLoanLabel.Name = "myLoanLabel";
            myLoanLabel.Size = new Size(13, 15);
            myLoanLabel.TabIndex = 3;
            myLoanLabel.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(70, 166);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 3;
            label6.Text = "借款：";
            // 
            // friendLoanLabel
            // 
            friendLoanLabel.AutoSize = true;
            friendLoanLabel.Location = new Point(377, 166);
            friendLoanLabel.Name = "friendLoanLabel";
            friendLoanLabel.Size = new Size(13, 15);
            friendLoanLabel.TabIndex = 3;
            friendLoanLabel.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(283, 166);
            label9.Name = "label9";
            label9.Size = new Size(46, 15);
            label9.TabIndex = 3;
            label9.Text = "借款：";
            // 
            // resetButton
            // 
            resetButton.Enabled = false;
            resetButton.Location = new Point(386, 130);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(75, 23);
            resetButton.TabIndex = 4;
            resetButton.Text = "重置";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // borrowMoneyAmount
            // 
            borrowMoneyAmount.Location = new Point(152, 130);
            borrowMoneyAmount.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            borrowMoneyAmount.Name = "borrowMoneyAmount";
            borrowMoneyAmount.Size = new Size(81, 23);
            borrowMoneyAmount.TabIndex = 5;
            borrowMoneyAmount.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 134);
            label5.Name = "label5";
            label5.Size = new Size(111, 15);
            label5.TabIndex = 0;
            label5.Text = "請輸入借款金額：";
            // 
            // borrowMoneyAmountConfirm
            // 
            borrowMoneyAmountConfirm.Enabled = false;
            borrowMoneyAmountConfirm.Location = new Point(254, 130);
            borrowMoneyAmountConfirm.Name = "borrowMoneyAmountConfirm";
            borrowMoneyAmountConfirm.Size = new Size(75, 23);
            borrowMoneyAmountConfirm.TabIndex = 4;
            borrowMoneyAmountConfirm.Text = "設定";
            borrowMoneyAmountConfirm.UseVisualStyleBackColor = true;
            borrowMoneyAmountConfirm.Click += borrowMoneyAmountConfirm_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(202, 56);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 0;
            label8.Text = "存款：";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(202, 97);
            label11.Name = "label11";
            label11.Size = new Size(46, 15);
            label11.TabIndex = 0;
            label11.Text = "存款：";
            // 
            // myDeposit
            // 
            myDeposit.Location = new Point(254, 54);
            myDeposit.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            myDeposit.Name = "myDeposit";
            myDeposit.Size = new Size(81, 23);
            myDeposit.TabIndex = 6;
            myDeposit.Value = new decimal(new int[] { 5000, 0, 0, 0 });
            // 
            // friendDeposit
            // 
            friendDeposit.Location = new Point(254, 94);
            friendDeposit.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            friendDeposit.Name = "friendDeposit";
            friendDeposit.Size = new Size(81, 23);
            friendDeposit.TabIndex = 7;
            friendDeposit.Value = new decimal(new int[] { 200000, 0, 0, 0 });
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 377);
            Controls.Add(friendDeposit);
            Controls.Add(myDeposit);
            Controls.Add(borrowMoneyAmount);
            Controls.Add(borrowMoneyAmountConfirm);
            Controls.Add(resetButton);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(friendLoanLabel);
            Controls.Add(myLoanLabel);
            Controls.Add(friendMoneyLabel);
            Controls.Add(myMoneyLabel);
            Controls.Add(friendNameLabel);
            Controls.Add(myNameLabel);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(friendRepayButton);
            Controls.Add(repayButton);
            Controls.Add(friendBorrowButton);
            Controls.Add(borrowButton);
            Controls.Add(submitButton);
            Controls.Add(friendNameInput);
            Controls.Add(myNameInput);
            Controls.Add(label5);
            Controls.Add(label11);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(label1);
            Name = "Form1";
            Text = "BorrowAndRepay";
            ((System.ComponentModel.ISupportInitialize)borrowMoneyAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)myDeposit).EndInit();
            ((System.ComponentModel.ISupportInitialize)friendDeposit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox myNameInput;
        private TextBox friendNameInput;
        private Button submitButton;
        private Label label3;
        private Label label4;
        private Label myNameLabel;
        private Label myMoneyLabel;
        private Label label7;
        private Label friendNameLabel;
        private Label friendMoneyLabel;
        private Label label10;
        private Button borrowButton;
        private Button repayButton;
        private Button friendBorrowButton;
        private Button friendRepayButton;
        private Label myLoanLabel;
        private Label label6;
        private Label friendLoanLabel;
        private Label label9;
        private Button resetButton;
        private NumericUpDown borrowMoneyAmount;
        private Label label5;
        private Button borrowMoneyAmountConfirm;
        private Label label8;
        private Label label11;
        private NumericUpDown myDeposit;
        private NumericUpDown friendDeposit;
    }
}
