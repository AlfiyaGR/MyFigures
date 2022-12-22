using System;
using System.Drawing;
using System.Windows.Forms;
using FiguresLib;
using CMDLib;

namespace MyFigures
{
    public partial class FormRect : Form
    {
        public FormRect()
        {
            InitializeComponent();
            Init.pictureBox = pictureBoxRect;
            Init.bitmap = new Bitmap(pictureBoxRect.ClientSize.Width, pictureBoxRect.ClientSize.Height);
            Init.pen = new Pen(Color.Black, 5);
            Init.comboBox = comboBoxRect;
        }

        Rect rectangle;
        Fridge fridge;

        private void FormRect_Load(object sender, EventArgs e)
        {
            ShapeContainer.DrawTypeFigures(typeof(Rect));
            rectangle = null;
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

                rectangle = new Rect(x, y, w, h, name);

                if (ConsoleMethods.inBounds(rectangle))
                {
                    rectangle.Draw();
                    rectangle.AddToBox();
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
            if (ConsoleMethods.toInt(textBoxMoveX.Text, textBoxMoveY.Text) && rectangle != null)
            {
                int moveX, moveY;

                moveX = int.Parse(textBoxMoveX.Text);
                moveY = int.Parse(textBoxMoveY.Text);

                if (ConsoleMethods.inBounds(rectangle, moveX, moveY))
                {
                    rectangle.MoveTo(moveX, moveY);
                }

                ShapeContainer.DrawTypeFigures(typeof(Rect), false);
            }
            else
            {
                MessageBox.Show("Повторите ввод значений!");
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (rectangle != null)
            {
                rectangle.DeleteF();
                rectangle = null;

                ShapeContainer.DrawTypeFigures(typeof(Rect), false);
            }
            else
            {
                MessageBox.Show("Фигура удалена!");
            }
        }

        private void button_Change_Click(object sender, EventArgs e)
        {
            if (ConsoleMethods.toInt(textBoxNewW.Text, textBoxNewH.Text) && rectangle != null)
            {
                int newW, newH;

                newW = int.Parse(textBoxNewW.Text);
                newH = int.Parse(textBoxNewH.Text);

                rectangle.Change(newW, newH);
                rectangle.AddToBox();

                ShapeContainer.DrawTypeFigures(typeof(Rect), false);
            }
            else
            {
                MessageBox.Show("Повторите попытку!");
            }
        }

        private void buttonDrawFridge_Click(object sender, EventArgs e)
        {
            if (ConsoleMethods.toInt(textBoxFridgeX.Text, textBoxFridgeY.Text, textBoxFridgeW.Text, textBoxFridgeH.Text))
            {
                int x, y, w, h;
                string name;

                x = int.Parse(textBoxFridgeX.Text);
                y = int.Parse(textBoxFridgeY.Text);
                w = int.Parse(textBoxFridgeW.Text);
                h = int.Parse(textBoxFridgeH.Text);
                name = textBoxFridgeName.Text;

                fridge = new Fridge(x, y, w, h, name);

                if (ConsoleMethods.inBounds(fridge))
                {
                    fridge.Draw();
                    fridge.AddToBox();
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

        private void buttonMoveFridge_Click(object sender, EventArgs e)
        {
            if (ConsoleMethods.toInt(textBoxMoveFridgeX.Text, textBoxMoveFridgeY.Text) && fridge != null)
            {
                int moveX, moveY;

                moveX = int.Parse(textBoxMoveFridgeX.Text);
                moveY = int.Parse(textBoxMoveFridgeY.Text);

                if (ConsoleMethods.inBounds(fridge, moveX, moveY))
                {
                    fridge.MoveTo(moveX, moveY);
                }

                ShapeContainer.DrawTypeFigures(typeof(Fridge), false);
                ShapeContainer.DrawTypeFigures(typeof(Rect), false);
            }
            else
            {
                MessageBox.Show("Повторите ввод значений!");
            }
        }

        private void buttonDeleteFridge_Click(object sender, EventArgs e)
        {
            if (fridge != null)
            {
                fridge.DeleteF();
                fridge = null;

                ShapeContainer.DrawTypeFigures(typeof(Fridge), false);
                ShapeContainer.DrawTypeFigures(typeof(Rect), false);
            }
            else
            {
                MessageBox.Show("Фигура удалена!");
            }
        }

        private void comboBoxRect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Init.comboBox.Items.Count != 0)
            {
                foreach (Figure f in ShapeContainer.figurelist)
                {
                    if (f.Name == Init.comboBox.SelectedItem.ToString())
                    {
                        try
                        {
                            rectangle = (Rect)f;
                        }
                        catch
                        {
                            try
                            {
                                fridge = (Fridge)f;
                            }
                            catch
                            {
                                continue;
                            }
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
            groupBox_Change.Hide();
            groupBox_Make.Hide();
            groupBox_MoveTo.Hide();
            buttonDeleteFridge.Hide();
            button_Delete.Hide();
            comboBoxRect.Hide();

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
