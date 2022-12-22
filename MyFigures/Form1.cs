using System;
using System.Drawing;
using System.Windows.Forms;
using FiguresLib;

namespace MyFigures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Init.pictureBox = pictureBoxAll;
            Init.bitmap = new Bitmap(pictureBoxAll.ClientSize.Width, pictureBoxAll.ClientSize.Height);
            Init.pen = new Pen(Color.Black, 5);
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Figure_Click(object sender, EventArgs e)
        {
            if (radioButton_Rect.Checked)
            {
                Hide();
                FormRect formRect = new FormRect();
                formRect.Show();
            }
            else if (radioButton_Square.Checked)
            {
                Hide();
                FormSquare formSquare = new FormSquare();
                formSquare.Show();
            }
            else if (radioButton_Ellipse.Checked)
            {
                Hide();
                FormEllipse formEllipse = new FormEllipse();
                formEllipse.Show();
            }
            else if (radioButton_Circle.Checked)
            {
                Hide();
                FormCircle formCircle = new FormCircle();
                formCircle.Show();
            }
            else if (radioButton_Polygon.Checked)
            {
                Hide();
                FormPolygon formPolygon = new FormPolygon();
                formPolygon.Show();
            }
            else if (radioButton_Triangle.Checked)
            {
                Hide();
                FormTriangle formTriangle = new FormTriangle();
                formTriangle.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShapeContainer.DrawAllFigures(false);
        }
    }
}
