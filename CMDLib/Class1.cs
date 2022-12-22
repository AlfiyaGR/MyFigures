using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FiguresLib;

namespace CMDLib
{
    public class ConsoleMethods
    {
        public static Stack<Operator> operators = new Stack<Operator>();
        public static Stack<Operand> operands = new Stack<Operand>();

        public static bool toInt(string x, string y = "0", string w = "0", string h = "0")
        {
            int res;

            if (int.TryParse(x, out res) && int.TryParse(y, out res) &&
                int.TryParse(w, out res) && int.TryParse(h, out res))
                return true;
            return false;
        }

        public static bool inBounds(Figure f, int moveX = 0, int moveY = 0)
        {
            int width = Init.pictureBox.Width - f.w;
            int height = Init.pictureBox.Height - f.h;
            if (f.x + moveX >= 0 && f.x + moveX <= width && f.y + moveY >= 0 && f.y + moveY <= height)
            {
                return true;
            }
            return false;
        }

        public static bool IsNotOperation(char op)
        {
            if (op == 'M' || op == 'R' || op == 'S' || op == 'D' || op == ',' || op == '(' || op == ')')
                return false;
            return true;
        }

        public static void SelectingPerformingOperation(Operator op)
        {
            try
            {
                if (op.symbolOperator == 'R')
                {
                    if (operands.Count == 5)
                    {
                        string x, y, w, h, name;

                        x = operands.Pop().value.ToString();
                        y = operands.Pop().value.ToString();
                        w = operands.Pop().value.ToString();
                        h = operands.Pop().value.ToString();
                        name = operands.Pop().value.ToString();

                        if (toInt(x, y, w, h))
                        {
                            Rect rect = new Rect(int.Parse(x), int.Parse(y), int.Parse(w), int.Parse(h), name);
                            if (inBounds(rect))
                            {
                                op = new Operator(rect.Draw, 'R');
                                ShapeContainer.AddFigure(rect);
                                Init.comboBox.Items.Add(rect.Name + " отрисована");
                                op.operatorMethod();
                            }
                            else
                            {
                                MessageBox.Show("Фигура выходит за рамки положенного!");
                                Init.comboBox.Items.Add("Ошибка: Фигура выходит за рамки положенного!");

                            }
                        }
                        else
                        {
                            MessageBox.Show("Аргументы введены неправильно!");
                            Init.comboBox.Items.Add("Ошибка: Аргументы введены неправильно!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Оператор принимает 5 аргументов!");
                        Init.comboBox.Items.Add("Ошибка: Оператор принимает 5 аргументов!");
                    }
                }
                else if (op.symbolOperator == 'M')
                {
                    if (operands.Count == 3)
                    {
                        string moveX, moveY, name;
                        Rect rect = null;

                        moveX = operands.Pop().value.ToString();
                        moveY = operands.Pop().value.ToString();
                        name = operands.Pop().value.ToString();

                        foreach (Figure f in ShapeContainer.figurelist)
                        {
                            if (f.Name == name)
                                rect = (Rect)f;
                        }

                        if (rect != null && toInt(moveX, moveY))
                        {
                            if (inBounds(rect))
                            {
                                rect.MoveTo(int.Parse(moveX), int.Parse(moveY), false);
                                ShapeContainer.DrawAllFigures(false);
                                Init.comboBox.Items.Add("Фигура " + rect.Name + " перемещена");
                            }
                            else
                            {
                                MessageBox.Show("Фигура выходит за рамки!");
                                Init.comboBox.Items.Add("Ошибка: Фигура выходит за рамки!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Фигуры нет или аргументы введены неверно!");
                            Init.comboBox.Items.Add("Ошибка: Фигуры нет или аргументы введены неверно!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Оператор M принимкает 3 аргумента!");
                        Init.comboBox.Items.Add("Ошибка: Оператор M принимкает 3 аргумента!");
                    }
                }
                else if (op.symbolOperator == 'D')
                {
                    if (operands.Count == 1)
                    {
                        Rect rect = null;
                        string name = operands.Pop().value.ToString();

                        foreach (Figure f in ShapeContainer.figurelist)
                        {
                            if (f.Name == name)
                                rect = (Rect)f;
                        }

                        if (rect != null)
                        {
                            rect.DeleteF();
                            ShapeContainer.DrawAllFigures(false);
                            Init.comboBox.Items.Add(rect.Name + " удалена");
                        }
                        else
                        {
                            MessageBox.Show("Фигуры такой нет!");
                            Init.comboBox.Items.Add("Ошибка: Фигуры такой нет!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Оператор D принимает 1 аргумент!");
                        Init.comboBox.Items.Add("Ошибка: Оператор D принимает 1 аргумент!");
                    }
                }
                else if (op.symbolOperator == 'S')
                {
                    if (operands.Count == 4)
                    {
                        string x, y, w, name;

                        x = operands.Pop().value.ToString();
                        y = operands.Pop().value.ToString();
                        w = operands.Pop().value.ToString();
                        name = operands.Pop().value.ToString();

                        if (toInt(x, y, w))
                        {
                            Square square = new Square(int.Parse(x), int.Parse(y), int.Parse(w), name);
                            if (inBounds(square))
                            {
                                op = new Operator(square.Draw, 'S');
                                ShapeContainer.AddFigure(square);
                                Init.comboBox.Items.Add(square.Name + " отрисована");
                                op.operatorMethod();
                            }
                            else
                            {
                                MessageBox.Show("Фигура выходит за рамки положенного!");
                                Init.comboBox.Items.Add("Ошибка: Фигура выходит за рамки положенного!");

                            }
                        }
                        else
                        {
                            MessageBox.Show("Аргументы введены неправильно!");
                            Init.comboBox.Items.Add("Ошибка: Аргументы введены неправильно!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Оператор принимает 4 аргумента!");
                        Init.comboBox.Items.Add("Ошибка: Оператор принимает 5 аргументов!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Init.comboBox.Items.Add($"Ошибка: {ex.Message}");
            }
        }

        public static void AddOperations(string command)
        {
            for (int i = 0; i < command.Length; i++)
            {
                if (IsNotOperation(command[i]))
                {
                    if (!char.IsDigit(command[i]))
                    {
                        operands.Push(new Operand(command[i]));
                        while (i < command.Length - 1 && IsNotOperation(command[i + 1]))
                        {
                            string str = operands.Pop().value.ToString() + command[i + 1].ToString();
                            operands.Push(new Operand(str));
                            i++;
                        }
                    }
                    else if (char.IsDigit(command[i]))
                    {
                        operands.Push(new Operand(command[i]));
                        while (i < command.Length - 1 && char.IsDigit(command[i + 1])
                            && IsNotOperation(command[i + 1]))
                        {
                            int temp_num = int.Parse(operands.Pop().value.ToString()) * 10 +
                                (int)char.GetNumericValue(command[i + 1]);
                            operands.Push(new Operand(temp_num.ToString()));
                            i++;
                        }
                    }
                }
                else if (command[i] == 'R')
                {
                    if (operators.Count == 0)
                    {
                        operators.Push(OperatorContainer.FindOperator(command[i]));
                    }
                }
                else if (command[i] == 'S')
                {
                    if (operators.Count == 0)
                    {
                        operators.Push(OperatorContainer.FindOperator(command[i]));
                    }
                }
                else if (command[i] == 'M')
                {
                    if (operators.Count == 0)
                    {
                        operators.Push(OperatorContainer.FindOperator(command[i]));
                    }
                }
                else if (command[i] == 'D')
                {
                    if (operators.Count == 0)
                    {
                        operators.Push(OperatorContainer.FindOperator(command[i]));
                    }
                }
                else if (command[i] == '(')
                {
                    operators.Push(OperatorContainer.FindOperator(command[i]));
                }
                else if (command[i] == ')')
                {
                    do
                    {
                        if (operators.Peek().symbolOperator == '(')
                        {
                            operators.Pop();
                            break;
                        }
                        if (operators.Count == 0)
                        {
                            break;
                        }
                    }
                    while (operators.Peek().symbolOperator != '(');
                }
            }
        }
    }

    public class Operand
    {
        public object value;
        public Operand(object NewValue)
        {
            value = NewValue;
        }
    }

    public class Operator : OperatorMethod
    {
        public char symbolOperator;
        public EmptyOperatorMethod operatorMethod = null;
        public BinaryOperatorMethod binaryOperator = null;
        public TrinaryOperatorMethod trinaryOperator = null;
        public UnaryOperatorMethod unaryOperator = null;

        public Operator(EmptyOperatorMethod operatorMethod, char symbolOperator)
        {
            this.operatorMethod = operatorMethod;
            this.symbolOperator = symbolOperator;
        }
        public Operator(UnaryOperatorMethod unaryOperator, char symbolOperator)
        {
            this.unaryOperator = unaryOperator;
            this.symbolOperator = symbolOperator;
        }
        public Operator(BinaryOperatorMethod binaryOperator, char symbolOperator)
        {
            this.binaryOperator = binaryOperator;
            this.symbolOperator = symbolOperator;
        }
        public Operator(TrinaryOperatorMethod trinaryOperator, char symbolOperator)
        {
            this.trinaryOperator = trinaryOperator;
            this.symbolOperator = symbolOperator;
        }
        public Operator(char symbolOperator)
        {
            this.symbolOperator = symbolOperator;
        }
    }

    public class OperatorMethod
    {
        public delegate void EmptyOperatorMethod();
        public delegate void UnaryOperatorMethod(object operand);
        public delegate void BinaryOperatorMethod(object operand1, object operand2);
        public delegate void TrinaryOperatorMethod(object operand1, object operand2, object operand3);
    }

    public static class OperatorContainer
    {
        public static List<Operator> operators = new List<Operator>();

        static OperatorContainer()
        {
            operators.Add(new Operator('S'));
            operators.Add(new Operator('R'));
            operators.Add(new Operator('E'));
            operators.Add(new Operator('C'));
            operators.Add(new Operator('M'));
            operators.Add(new Operator('D'));
            operators.Add(new Operator(','));
            operators.Add(new Operator('('));
            operators.Add(new Operator(')'));
        }
        public static Operator FindOperator(char s)
        {
            foreach (Operator op in operators)
            {
                if (op.symbolOperator == s)
                    return op;
            }
            return null;
        }
    }
}
