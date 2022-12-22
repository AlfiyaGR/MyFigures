﻿using FiguresLib;
using CMDLib;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyFigures
{
    public partial class FormCircle : Form
    {
        public FormCircle()
        {
            InitializeComponent();
            Init.pictureBox = pictureBoxCircle;
            Init.bitmap = new Bitmap(pictureBoxCircle.ClientSize.Width, pictureBoxCircle.ClientSize.Height);
            Init.pen = new Pen(Color.Black, 5);
            Init.comboBox = comboBoxCircle;
        }

        Circle circle;
        //Goosetail goosetail;

        private void FormCircle_Load(object sender, EventArgs e)
        {
            ShapeContainer.DrawTypeFigures(typeof(Circle));
            circle = null;
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
            if (ConsoleMethods.toInt(textBoxX.Text, textBoxY.Text, textBoxW.Text))
            {
                int x, y, w;
                string name;

                x = int.Parse(textBoxX.Text);
                y = int.Parse(textBoxY.Text);
                w = int.Parse(textBoxW.Text);
                name = textBoxName.Text;

                circle = new Circle(x, y, w, name);

                if (ConsoleMethods.inBounds(circle))
                {
                    circle.Draw();
                    circle.AddToBox();
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
            if (ConsoleMethods.toInt(textBoxMoveX.Text, textBoxMoveY.Text) && circle != null)
            {
                int moveX, moveY;

                moveX = int.Parse(textBoxMoveX.Text);
                moveY = int.Parse(textBoxMoveY.Text);

                if (ConsoleMethods.inBounds(circle, moveX, moveY))
                {
                    circle.MoveTo(moveX, moveY);
                }

                ShapeContainer.DrawTypeFigures(typeof(Circle), false);
            }
            else
            {
                MessageBox.Show("Повторите ввод значений!");
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (circle != null)
            {
                circle.DeleteF();
                circle = null;

                ShapeContainer.DrawTypeFigures(typeof(Circle), false);
            }
            else
            {
                MessageBox.Show("Фигура удалена!");
            }
        }

        private void button_Change_Click(object sender, EventArgs e)
        {
            if (ConsoleMethods.toInt(textBoxNewW.Text) && circle != null)
            {
                int newW;

                newW = int.Parse(textBoxNewW.Text);

                circle.Change(newW);
                circle.AddToBox();

                ShapeContainer.DrawTypeFigures(typeof(Circle), false);
            }
            else
            {
                MessageBox.Show("Повторите попытку!");
            }
        }
        private void comboBoxCircle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Init.comboBox.Items.Count != 0)
            {
                foreach (Figure f in ShapeContainer.figurelist)
                {
                    if (f.Name == Init.comboBox.SelectedItem.ToString())
                    {
                        try
                        {
                            circle = (Circle)f;
                        }
                        catch
                        {
                            continue;
                            /*
                            try
                            {
                                goosetail = (Goosetail)f;
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
            groupBoxGoosetail.Hide();
            groupBox_Change.Hide();
            groupBox_Make.Hide();
            groupBox_MoveTo.Hide();
            buttonDeleteGoosetail.Hide();
            button_Delete.Hide();
            comboBoxCircle.Hide();

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
