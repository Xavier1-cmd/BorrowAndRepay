namespace BorrowAndRepay
{
    public partial class Form1 : Form
    {
        Person i, friend;

        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            i = new Person(myNameInput.Text, 0);
            friend = new Person(friendNameInput.Text, 8000);

            myNameInput.Enabled = false;
            friendNameInput.Enabled = false;
            submitButton.Enabled = false;

            borrowButton.Text = $"跟 {friend.Name} 借 1000 元";
            repayButton.Text = $"還給 {friend.Name} 1000 元";

            borrowButton.Enabled = true;
            repayButton.Enabled = true;

            myNameLabel.Text = i.Name;
            friendNameLabel.Text = friend.Name;
        }

        private void borrowButton_Click(object sender, EventArgs e)
        {
            i.borrow(friend, 1000);
            updateMoney();
        }

        private void repayButton_Click(object sender, EventArgs e)
        {
            i.repay(friend, 1000);
            updateMoney();
        }

        private void updateMoney()
        {
            myMoneyLabel.Text = i.Money.ToString();
            friendMoneyLabel.Text = friend.Money.ToString();
        }
    }
}
