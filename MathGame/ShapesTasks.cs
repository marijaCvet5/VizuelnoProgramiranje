using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathGame
{
    public partial class ShapesTasks : Form
    {
        private String currentDifficulty;
        private int Trials;
        private String correctAnswer;
        private ShapeGame game;
        public ShapesTasks()
        {
            InitializeComponent();
            game = new ShapeGame();
            game.GenerateRandomShape();
            UpdateLabels();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string label = tbAnswer.Text.Trim();
            bool correctAnswer = game.CheckAnswer(label);

            if (correctAnswer)
            {
                lblCorrect.Text = "CORRECT";
                game.GenerateRandomShape();
                tbAnswer.Clear();
            }
            else
            {
                lblCorrect.Text = "INCORRECT";
                tbAnswer.Clear();
            }

            if (game.Tries == 0)
            {
                DialogResult result = MessageBox.Show("Game over! Start a new game?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    game = new ShapeGame();
                    game.GenerateRandomShape();
                    UpdateLabels();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                UpdateLabels();
            }
        }

        private void UpdateLabels()
        {
            lblTries.Text = "Tries: " + game.Tries;
            pnlShape.Invalidate();
        }

        private void pnlShape_Paint(object sender, PaintEventArgs e)
        {
            if (game.CurrentShape != null)
            {
                game.CurrentShape.Draw(e.Graphics, pnlShape.ClientRectangle);
            }
            Invalidate();
        }
    }
}
