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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 54);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 0;
            label1.Text = "請輸入我的名字：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 97);
            label2.Name = "label2";
            label2.Size = new Size(124, 15);
            label2.TabIndex = 0;
            label2.Text = "請輸入朋友的名字：";
            // 
            // myNameInput
            // 
            myNameInput.Location = new Point(161, 54);
            myNameInput.Name = "myNameInput";
            myNameInput.Size = new Size(135, 23);
            myNameInput.TabIndex = 1;
            // 
            // friendNameInput
            // 
            friendNameInput.Location = new Point(161, 94);
            friendNameInput.Name = "friendNameInput";
            friendNameInput.Size = new Size(135, 23);
            friendNameInput.TabIndex = 1;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(328, 54);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(133, 63);
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
            myMoneyLabel.Size = new Size(13, 15);
            myMoneyLabel.TabIndex = 3;
            myMoneyLabel.Text = "0";
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
            friendMoneyLabel.Size = new Size(43, 15);
            friendMoneyLabel.TabIndex = 3;
            friendMoneyLabel.Text = "200000";
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
            borrowButton.Size = new Size(426, 48);
            borrowButton.TabIndex = 2;
            borrowButton.Text = "跟 xxx 借 1000 元";
            borrowButton.UseVisualStyleBackColor = true;
            borrowButton.Click += borrowButton_Click;
            // 
            // repayButton
            // 
            repayButton.Enabled = false;
            repayButton.Location = new Point(35, 309);
            repayButton.Name = "repayButton";
            repayButton.Size = new Size(426, 48);
            repayButton.TabIndex = 2;
            repayButton.Text = "還給 xxx 1000 元";
            repayButton.UseVisualStyleBackColor = true;
            repayButton.Click += repayButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 377);
            Controls.Add(label10);
            Controls.Add(label4);
            Controls.Add(friendMoneyLabel);
            Controls.Add(myMoneyLabel);
            Controls.Add(friendNameLabel);
            Controls.Add(myNameLabel);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(repayButton);
            Controls.Add(borrowButton);
            Controls.Add(submitButton);
            Controls.Add(friendNameInput);
            Controls.Add(myNameInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "BorrowAndRepay";
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
    }
}
