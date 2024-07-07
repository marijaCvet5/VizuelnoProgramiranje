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
    public partial class MathQuiz2 : Form
    {
        public MathQuiz2()
        {
            InitializeComponent();
        }

        private void btnForms_Click(object sender, EventArgs e)
        {
            ShapesTasks shapesTasks = new ShapesTasks();
            shapesTasks.Show();
        }

        private void btnTasks_Click(object sender, EventArgs e)
        {
            MathTasks mathTasks = new MathTasks();
            mathTasks.Show();
        }
    }
}
