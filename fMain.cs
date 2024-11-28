using System;
using System.Windows.Forms;

namespace FormsApp4
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(tbSquareSide.Text);
                double r = double.Parse(tbCircleRadius.Text);

                Shape square = new Square(a);
                Shape circle = new Circle(r);

                double squareArea = square.GetArea();
                double circleArea = circle.GetArea();

                tbPyramidVolume.Text = squareArea.ToString("F2");
                tbSphereVolume.Text = circleArea.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Будь ласка, введіть коректні числові значення.");
            }
        }
    }
}
