namespace assignment6_NikolaiKa
{
    public partial class Form1 : Form
    {
        public int computerChoice = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public void StartGame()
        {
            computerChoice = new Random().Next(1, 3);
        }
        enum Choice
        {
            Rock = 1,
            Scissors = 2,
            Paper = 3
        }

        public void Check(int userChoice)
        {
            string result;
            if (userChoice == (int)Choice.Rock && computerChoice == (int)Choice.Scissors)
            {
                result = "Computer chose: Scissors\nUser chose: Rock\nRock smashes scissors\nYou won";
            }
            else if (userChoice == (int)Choice.Scissors && computerChoice == (int)Choice.Paper)
            {
                result = "Computer chose: Paper\nUser chose: Scissors\nScissors cuts paper\nYou won";
            }
            else if (userChoice == (int)Choice.Paper && computerChoice == (int)Choice.Rock)
            {
                result = "Computer chose: Rock\nUser chose: Paper\nPaper wraps rock\nYou won";
            }
            else if (computerChoice == (int)Choice.Rock && userChoice == (int)Choice.Scissors)
            {
                result = "Computer chose: Rock\nUser chose: Scissors\nRock smashes scissors\nThe computer won";
            }
            else if (computerChoice == (int)Choice.Scissors && userChoice == (int)Choice.Paper)
            {
                result = "Computer chose: Scissors\nUser chose: Paper\nScissors cuts paper\nThe computer won";
            }
            else if (computerChoice == (int)Choice.Paper && userChoice == (int)Choice.Rock)
            {
                result = "Computer chose: Paper\nUser chose: Rock\nPaper wraps rock\nThe computer won";
            }
            else
            {
                result = "Computer and User selected: " + (Choice)userChoice + "\nYou have to play again";
            }

            MessageBox.Show(result);
            StartGame();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int choise = Convert.ToInt32(btn.Tag);
            Check(choise);
        }
    }
}