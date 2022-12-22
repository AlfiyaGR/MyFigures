using FiguresLib;
using CMDLib;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyFigures
{
    public partial class FormTriangle : Form
    {
        public FormTriangle()
        {
            InitializeComponent();
            Init.pictureBox = pictureBoxTree;
            Init.bitmap = new Bitmap(pictureBoxTree.ClientSize.Width, pictureBoxTree.ClientSize.Height);
            Init.pen = new Pen(Color.Black, 5);
            Init.comboBox = comboBoxTriangle;
        }

        Triangle triangle;
        int i = 0;
        //ChristmasTree tree;

        private void FormTriangle_Load(object sender, EventArgs e)
        {
            ShapeContainer.DrawTypeFigures(typeof(Triangle));
            triangle = null;
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
            string name = textBoxName.Text;

            triangle = new Triangle(3, name);
            textBoxX.ReadOnly = false;
            textBoxY.ReadOnly = false;
        }

        private void button_enterPoint_Click(object sender, EventArgs e)
        {
            if (ConsoleMethods.toInt(textBoxX.Text, textBoxY.Text))
            {
                int x, y;
                x = int.Parse(textBoxX.Text);
                y = int.Parse(textBoxY.Text);

                triangle.AddPoint(x, y, i);
                i++;
                if (i > 2)
                {
                    i = 0;
                    textBoxX.ReadOnly = true;
                    textBoxY.ReadOnly = true;
                    triangle.AddToBox();
                }
            }
            else
                MessageBox.Show("Попробуй еще раз!");
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            try
            {
                triangle.Draw();
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
                        triangle.MoveTo(moveX, moveY);
                    }
                    catch
                    {
                        MessageBox.Show("Фигура не создана!");
                    }
                    ShapeContainer.DrawTypeFigures(typeof(Triangle), false);
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
                if (triangle != null)
                {
                    triangle.DeleteF();
                    triangle = null;

                    ShapeContainer.DrawTypeFigures(typeof(Triangle), false);
                }
                else
                {
                    MessageBox.Show("Фигура удалена!");
                }
            }
        }

        private void comboBoxTriangle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Init.comboBox.Items.Count != 0)
            {
                foreach (Figure f in ShapeContainer.figurelist)
                {
                    if (f.Name == Init.comboBox.SelectedItem.ToString())
                    {
                        try
                        {
                            triangle = (Triangle)f;
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
            groupBoxTree.Hide();
            groupBox_Make.Hide();
            groupBox_MoveTo.Hide();
            buttonDeleteTree.Hide();
            button_Delete.Hide();
            comboBoxTriangle.Hide();

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
