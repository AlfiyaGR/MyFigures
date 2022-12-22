using FiguresLib;
using CMDLib;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyFigures
{
    public partial class FormPolygon : Form
    {
        public FormPolygon()
        {
            InitializeComponent();
            Init.pictureBox = pictureBoxPolygon;
            Init.bitmap = new Bitmap(pictureBoxPolygon.ClientSize.Width, pictureBoxPolygon.ClientSize.Height);
            Init.pen = new Pen(Color.Black, 5);
            Init.comboBox = comboBoxPolygon;
        }

        Polygon polygon;
        int i = 0;

        private void FormPolygon_Load(object sender, EventArgs e)
        {
            ShapeContainer.DrawTypeFigures(typeof(Polygon));
            polygon = null;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void button_Make_Click(object sender, EventArgs e)
        {
            if (ConsoleMethods.toInt(textBoxPoints.Text))
            {
                int points = int.Parse(textBoxPoints.Text);
                string name = textBoxName.Text;

                polygon = new Polygon(points, name);
                textBoxX.ReadOnly = false;
                textBoxY.ReadOnly = false;
            }
            else
                MessageBox.Show("Попробуй еще раз!");
        }

        private void button_enterPoint_Click(object sender, EventArgs e)
        {
            if (ConsoleMethods.toInt(textBoxX.Text, textBoxY.Text, textBoxPoints.Text))
            {
                int x, y, points;
                x = int.Parse(textBoxX.Text);
                y = int.Parse(textBoxY.Text);
                points = int.Parse(textBoxPoints.Text);

                polygon.AddPoint(x, y, i);
                i++;
                if (i > points - 1)
                {
                    i = 0;
                    textBoxX.ReadOnly = true;
                    textBoxY.ReadOnly = true;
                    polygon.AddToBox();
                }
            }
            else
                MessageBox.Show("Попробуй еще раз!");
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            try
            {
                polygon.Draw();
            }
            catch
            {
                MessageBox.Show("Выбери фигуру!");
            }
        }

        private void button_Move_Click(object sender, EventArgs e)
        {
            if (ShapeContainer.figurelist.Count > 0)
            {
                if (ConsoleMethods.toInt(textBoxMoveX.Text, textBoxMoveY.Text))
                {
                    int moveX, moveY;
                    moveX = int.Parse(textBoxMoveX.Text);
                    moveY = int.Parse(textBoxMoveY.Text);

                    try
                    {
                        polygon.MoveTo(moveX, moveY);
                    }
                    catch
                    {
                        MessageBox.Show("Фигура не создана!");
                    }
                    ShapeContainer.DrawTypeFigures(typeof(Polygon), false);
                }
                else
                    MessageBox.Show("Попробуй еще раз!");
            }
            else
                MessageBox.Show("Нет никаких фигур");
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (ShapeContainer.figurelist.Count != 0)
            {
                if (polygon != null)
                {
                    polygon.DeleteF();
                    polygon = null;

                    ShapeContainer.DrawTypeFigures(typeof(Polygon), false);
                }
                else
                {
                    MessageBox.Show("Фигура удалена!");
                }
            }
        }

        private void comboBoxPolygon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Init.comboBox.Items.Count != 0)
            {
                foreach (Figure f in ShapeContainer.figurelist)
                {
                    if (f.Name == Init.comboBox.SelectedItem.ToString())
                    {
                        try
                        {
                            polygon = (Polygon)f;
                        }
                        catch
                        {
                            continue;
                            /*
                            try
                            {
                                fridge = (Fridge)f;
                            }
                            catch
                            {
                                continue;
                            }
                            */
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Нет фигур в списке!");
            }
        }


        private void textBoxCMD_Click(object sender, EventArgs e)
        {
            groupBoxFridge.Hide();
            groupBox_Make.Hide();
            groupBox_MoveTo.Hide();
            buttonDeleteFridge.Hide();
            button_Delete.Hide();
            comboBoxPolygon.Hide();

            textBoxCMD.ReadOnly = false;
            textBoxCMD.Location = new Point(13, 12);
            textBoxCMD.Size = new Size(400, 22);
            textBoxCMD.Text = "";

            Init.pictureBox.Location = new Point(13, 50);
            Init.pictureBox.BackColor = Color.AliceBlue;

            Init.comboBox = comboBoxCMD;
            Init.comboBox.Visible = true;
        }

        private void textBoxCMD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConsoleMethods.operands.Clear();
                ConsoleMethods.operators.Clear();
                try
                {
                    string command = textBoxCMD.Text;
                    textBoxCMD.Clear();
                    ConsoleMethods.AddOperations(command);
                }
                catch
                {
                    MessageBox.Show("Аргументы введены некорректно.");
                    Init.comboBox.Items.Add("Ошибка: Аргументы введены некорректно.");
                }
                try
                {
                    ConsoleMethods.SelectingPerformingOperation(ConsoleMethods.operators.Peek());
                }
                catch
                {
                    MessageBox.Show($"Введенной операции /{textBoxCMD.Text} не существует.");
                    Init.comboBox.Items.Add($"Ошибка: Введенной операции /{textBoxCMD.Text} не существует.");
                }
            }
        }
    }
}
