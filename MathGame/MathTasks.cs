using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathGame
{
    public partial class MathTasks : Form
    {
        private string currentDifficulty;
        private string currentOperation;
        private int trials = 5;
        private int correctAnswer;
        public MathTasks()
        {
            InitializeComponent();
        }
        private void btnEasy_Click(object sender, EventArgs e)
        {
            currentDifficulty = "Easy";
            MessageBox.Show("Easy difficulty selected.");
        }
        private void btnMedium_Click(object sender, EventArgs e)
        {
            currentDifficulty = "Medium";
            MessageBox.Show("Medium difficulty selected.");
        }
        private void btnHard_Click(object sender, EventArgs e)
        {
            currentDifficulty = "Hard";
            MessageBox.Show("Hard difficulty selected.");
        }
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            currentOperation = "Multiply";
            GenerateQuestion();
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            currentOperation = "Divide";
            GenerateQuestion();
        }
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            currentOperation = "Subtract";
            GenerateQuestion();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            currentOperation = "Add";
            GenerateQuestion();
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            GenerateQuestion();
        }
        private void GenerateQuestion()
        {
            Random random = new Random();
            int num1, num2;
            switch (currentDifficulty)
            {
                case "Easy":
                    num1 = random.Next(1, 10);
                    num2 = random.Next(1, 10);
                    break;
                case "Medium":
                    num1 = random.Next(10, 50);
                    num2 = random.Next(10, 50);
                    break;
                case "Hard":
                    num1 = random.Next(50, 100);
                    num2 = random.Next(50, 100);
                    break;
                default:
                    num1 = random.Next(1, 10);
                    num2 = random.Next(1, 10);
                    break;
            }
            switch(currentOperation)
            {
                case "Multiply":
                    correctAnswer = num1 * num2;
                    lbQuestion.Text = $"How much is {num1} * {num2}?";
                    break;
                case "Divide":
                    correctAnswer = num1 / num2;
                    lbQuestion.Text = $"How much is {num1} / {num2}?";
                    break;
                case "Subtract":
                    correctAnswer = num1 - num2;
                    lbQuestion.Text = $"How much is {num1} - {num2}?";
                    break;
                case "Add":
                    correctAnswer = num1 + num2;
                    lbQuestion.Text = $"How much is {num1} + {num2}?";
                    break;
                default:
                    correctAnswer = num1 * num2;
                    lbQuestion.Text = $"How much is {num1} * {num2}?";
                    break;
            }
            txtAnswer.Clear();
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            int userAnswer;
            bool isNumeric = int.TryParse(txtAnswer.Text, out userAnswer);
            if(!isNumeric)
            {
                MessageBox.Show("Please enter a valid number.");
                return;
            }
            if(userAnswer==correctAnswer)
            {
                lbFeedBack.ForeColor = Color.Green;
                lbFeedBack.Text = "CORRECT";
            }
            else
            {
                lbFeedBack.ForeColor = Color.Red;
                lbFeedBack.Text = "INCORRECT";
                trials--;
                if (trials <= 0)
                {
                    trials = 5;
                    GenerateQuestion();
                }
            }
            lbTrial.Text = $"Trials: {trials}";
        }

        private void MathTasks_Load(object sender, EventArgs e)
        {

        }
    }
}
