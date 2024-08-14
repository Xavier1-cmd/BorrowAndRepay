namespace BorrowAndRepay
{
    public partial class Form1 : Form
    {
        Person i, friend;
        int BorrowMoneyAmount,
            MyDeposit,
            FriendDeposit;

        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            MyDeposit = (int)myDeposit.Value;
            FriendDeposit = (int)friendDeposit.Value;

            i = new Person(myNameInput.Text, MyDeposit);
            friend = new Person(friendNameInput.Text, FriendDeposit);

            myNameInput.Enabled = false;
            friendNameInput.Enabled = false;
            submitButton.Enabled = false;

            BorrowMoneyAmount = (int)borrowMoneyAmount.Value;

            borrowButton.Enabled = true;
            repayButton.Enabled = true;
            friendBorrowButton.Enabled = true;
            friendRepayButton.Enabled = true;
            resetButton.Enabled = true;
            borrowMoneyAmountConfirm.Enabled = true;

            myNameLabel.Text = i.Name;
            friendNameLabel.Text = friend.Name;

            updateInfo();
        }

        private void borrowButton_Click(object sender, EventArgs e)
        {
            i.borrow(friend, BorrowMoneyAmount);
            updateInfo();
        }

        private void repayButton_Click(object sender, EventArgs e)
        {
            i.repay(friend, BorrowMoneyAmount);
            updateInfo();
        }

        private void updateInfo()
        {
            myMoneyLabel.Text = i.Money.ToString();
            myLoanLabel.Text = i.Loan.ToString();
            friendMoneyLabel.Text = friend.Money.ToString();
            friendLoanLabel.Text = friend.Loan.ToString();
            borrowButton.Text = $"跟 {friend.Name} 借 {BorrowMoneyAmount} 元";
            repayButton.Text = $"還給 {friend.Name} {BorrowMoneyAmount} 元";
            friendBorrowButton.Text = $"{friend.Name} 跟我借了 {BorrowMoneyAmount} 元";
            friendRepayButton.Text = $"{friend.Name} 還給我 {BorrowMoneyAmount} 元";
        }

        private void friendBorrowButton_Click(object sender, EventArgs e)
        {
            friend.borrow(i, BorrowMoneyAmount);
            updateInfo();
        }

        private void friendRepayButton_Click(object sender, EventArgs e)
        {
            friend.repay(i, BorrowMoneyAmount);
            updateInfo();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            i.Money = MyDeposit;
            friend.Money = FriendDeposit;
            i.Loan = 0;
            friend.Loan = 0;
            updateInfo();

            borrowButton.Enabled = false;
            repayButton.Enabled = false;
            friendBorrowButton.Enabled = false;
            friendRepayButton.Enabled = false;
            resetButton.Enabled = false;

            myNameInput.Enabled = true;
            friendNameInput.Enabled = true;
            submitButton.Enabled = true;
        }

        private void borrowMoneyAmountConfirm_Click(object sender, EventArgs e)
        {
            BorrowMoneyAmount = (int)borrowMoneyAmount.Value;
            updateInfo();
        }
    }
}
