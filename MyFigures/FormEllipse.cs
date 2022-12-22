using FiguresLib;
using CMDLib;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyFigures
{
    public partial class FormEllipse : Form
    {
        public FormEllipse()
        {
            InitializeComponent();
            Init.pictureBox = pictureBoxEllipse;
            Init.bitmap = new Bitmap(pictureBoxEllipse.ClientSize.Width, pictureBoxEllipse.ClientSize.Height);
            Init.pen = new Pen(Color.Black, 5);
            Init.comboBox = comboBoxEllipse;
        }

        Ellipse ellipse;
        //Flower flower;

        private void FormEllipse_Load(object sender, EventArgs e)
        {
            ShapeContainer.DrawTypeFigures(typeof(Ellipse));
            ellipse = null;
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
            if (ConsoleMethods.toInt(textBoxX.Text, textBoxY.Text, textBoxW.Text, textBoxH.Text))
            {
                int x, y, w, h;
                string name;

                x = int.Parse(textBoxX.Text);
                y = int.Parse(textBoxY.Text);
                w = int.Parse(textBoxW.Text);
                h = int.Parse(textBoxH.Text);
                name = textBoxName.Text;

                ellipse = new Ellipse(x, y, w, h, name);

                if (ConsoleMethods.inBounds(ellipse))
                {
                    ellipse.Draw();
                    ellipse.AddToBox();
                }
                else
                {
                    MessageBox.Show("Фигура выходит за рамки!");
                }
            }
            else
            {
                MessageBox.Show("Значения введены неверно!");
            }
        }

        private void button_Move_Click(object sender, EventArgs e)
        {
            if (ConsoleMethods.toInt(textBoxMoveX.Text, textBoxMoveY.Text) && ellipse != null)
            {
                int moveX, moveY;

                moveX = int.Parse(textBoxMoveX.Text);
                moveY = int.Parse(textBoxMoveY.Text);

                if (ConsoleMethods.inBounds(ellipse, moveX, moveY))
                {
                    ellipse.MoveTo(moveX, moveY);
                }

                ShapeContainer.DrawTypeFigures(typeof(Ellipse), false);
            }
            else
            {
                MessageBox.Show("Повторите ввод значений!");
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (ellipse != null)
            {
                ellipse.DeleteF();
                ellipse = null;

                ShapeContainer.DrawTypeFigures(typeof(Ellipse), false);
            }
            else
            {
                MessageBox.Show("Фигура удалена!");
            }
        }

        private void button_Change_Click(object sender, EventArgs e)
        {
            if (ConsoleMethods.toInt(textBoxNewW.Text, textBoxNewH.Text) && ellipse != null)
            {
                int newW, newH;

                newW = int.Parse(textBoxNewW.Text);
                newH = int.Parse(textBoxNewH.Text);

                ellipse.Change(newW, newH);
                ellipse.AddToBox();

                ShapeContainer.DrawTypeFigures(typeof(Ellipse), false);
            }
            else
            {
                MessageBox.Show("Повторите попытку!");
            }
        }

        private void comboBoxEllipse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Init.comboBox.Items.Count != 0)
            {
                foreach (Figure f in ShapeContainer.figurelist)
                {
                    if (f.Name == Init.comboBox.SelectedItem.ToString())
                    {
                        try
                        {
                            ellipse = (Ellipse)f;
                        }
                        catch
                        {
                            continue;
                            /*
                            try
                            {
                                flower = (Flower)f;
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
            groupBoxFlower.Hide();
            groupBox_Change.Hide();
            groupBox_Make.Hide();
            groupBox_MoveTo.Hide();
            buttonDeleteFlower.Hide();
            button_Delete.Hide();
            comboBoxEllipse.Hide();

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
