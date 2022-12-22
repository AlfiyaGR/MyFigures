using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FiguresLib
{
    public static class Init
    {
        public static Pen pen;
        public static PictureBox pictureBox;
        public static Bitmap bitmap;
        public static ComboBox comboBox;
    }
    public class ShapeContainer
    {
        public static List<Figure> figurelist = new List<Figure>();
        public static void AddFigure(Figure figure)
        {
            figurelist.Add(figure);
        }
        public static void RemoveFigure(Figure figure)
        {
            figurelist.Remove(figure);
        }
        public static void DrawAllFigures(bool flag = true)
        {
            foreach (Figure f in figurelist)
            {
                f.Draw();
                if (flag)
                    Init.comboBox.Items.Add(f.Name);
            }
        }
        public static void DrawTypeFigures(Type type, bool flag = true)
        {
            foreach (Figure f in figurelist)
            {
                try
                {
                    if (type == typeof(Rect))
                    {
                        try
                        {
                            Square r = (Square)f;
                        }
                        catch
                        {
                            try
                            {
                                Fridge fr = (Fridge)f;
                                fr.Draw();
                                if (flag)
                                    Init.comboBox.Items.Add(fr.Name);
                            }
                            catch
                            {
                                Rect r = (Rect)f;
                                r.Draw();
                                if (flag)
                                    Init.comboBox.Items.Add(r.Name);
                            }
                        }
                    }
                    else if (type == typeof(Square))
                    {
                        Square r = (Square)f;
                        r.Draw();
                        if (flag)
                            Init.comboBox.Items.Add(r.Name);
                    }
                    else if (type == typeof(Ellipse))
                    {
                        try
                        {
                            Circle r = (Circle)f;
                        }
                        catch
                        {
                            Ellipse r = (Ellipse)f;
                            r.Draw();
                            if (flag)
                                Init.comboBox.Items.Add(r.Name);
                        }
                    }
                    else if (type == typeof(Circle))
                    {
                        Circle r = (Circle)f;
                        r.Draw();
                        if (flag)
                            Init.comboBox.Items.Add(r.Name);
                    }
                    else if (type == typeof(Polygon))
                    {
                        try
                        {
                            Triangle r = (Triangle)f;
                        }
                        catch
                        {
                            Polygon r = (Polygon)f;
                            r.Draw();
                            if (flag)
                                Init.comboBox.Items.Add(r.Name);
                        }
                    }
                    else if (type == typeof(Triangle))
                    {
                        Triangle r = (Triangle)f;
                        r.Draw();
                        if (flag)
                            Init.comboBox.Items.Add(r.Name);
                    }
                }
                catch
                {
                    continue;
                }
            }
        }
    }

    abstract public class Figure
    {
        public int x;
        public int y;
        public int w;
        public int h;
        public string Name;

        abstract public void Draw();
        abstract public void MoveTo(int x, int y, bool inBox = true);
        public void DeleteF(bool flag = true, bool inBox = true)
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            ShapeContainer.RemoveFigure(this);
            if (inBox)
                Init.comboBox.Items.Remove(Name);
            g.Clear(Color.Transparent);
            Init.pictureBox.Image = Init.bitmap;
            if (!flag)
            {
                ShapeContainer.AddFigure(this);
                if (inBox)
                    Init.comboBox.Items.Add(Name);
            }
        }
        public void AddToBox()
        {
            ShapeContainer.AddFigure(this);
            Init.comboBox.Items.Add(Name);
        }
    }


    public class Rect : Figure
    {
        public Rect()
        {
            x = 0;
            y = 0;
            w = 0;
            h = 0;
            Name = "Приямоугольник";
        }
        public Rect(int x, int y, int w, int h, string name)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
            Name = name;
        }

        public override void Draw()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawRectangle(Init.pen, x, y, w, h);
            Init.pictureBox.Image = Init.bitmap;
        }
        public override void MoveTo(int moveX, int moveY, bool inBox = true)
        {
            int width = Init.pictureBox.Width - w;
            int height = Init.pictureBox.Height - h;
            if (x + moveX >= 0 && x + moveX <= width && y + moveY >= 0 && y + moveY <= height)
            {
                x += moveX;
                y += moveY;
                DeleteF(false, inBox);
                Draw();
            }
        }

        public void Change(int New_w, int New_h)
        {
            int width = Init.pictureBox.Width - New_w;
            int height = Init.pictureBox.Height - New_h;

            if (x >= 0 && x <= width && y >= 0 && y <= height)
            {
                w = New_w;
                h = New_h;

                DeleteF();
                Draw();
            }
        }
    }
    public class Square : Rect
    {
        public Square()
        {
            Name = "Квадрат";
        }
        public Square(int x, int y, int w, string name) : base(x, y, w, w, name)
        { }

        public void Change(int New_w)
        {
            w = New_w;
            DeleteF();
            Draw();
        }
    }


    public class Ellipse : Figure
    {
        public Ellipse()
        {
            x = 0;
            y = 0;
            w = 0;
            h = 0;
            Name = "Эллипс";
        }
        public Ellipse(int x, int y, int w, int h, string name)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
            Name = name;
        }

        public override void Draw()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawEllipse(Init.pen, x, y, w, h);
            Init.pictureBox.Image = Init.bitmap;
        }
        public override void MoveTo(int moveX, int moveY, bool inBox = true)
        {
            int width = Init.pictureBox.Width - w;
            int height = Init.pictureBox.Height - h;
            if (x + moveX >= 0 && x + moveX <= width && y + moveY >= 0 && y + moveY <= height)
            {
                x += moveX;
                y += moveY;
                DeleteF(false, inBox);
                Draw();
            }
        }
        public void Change(int New_w, int New_h)
        {
            int width = Init.pictureBox.Width - New_w;
            int height = Init.pictureBox.Height - New_h;

            if (x >= 0 && x <= width && y >= 0 && y <= height)
            {
                w = New_w;
                h = New_h;

                DeleteF();
                Draw();
            }
        }
    }
    public class Circle : Ellipse
    {
        public Circle()
        {
            Name = "Круг";
        }
        public Circle(int x, int y, int w, string name) : base(x, y, w, w, name)
        { }

        public void Change(int r)
        {
            w = r * 2;
            h = r * 2;
            DeleteF();
            Draw();
            //ShapeContainer.AddFigure(this);
        }
    }


    public class Polygon : Figure
    {
        public Point[] Points;
        public Polygon()
        {
            x = 0;
            y = 0;
            h = 0;
            w = 0;
            Name = "Многоугольник";
        }

        public Polygon(int countPoint, string name)
        {
            Name = name;
            Points = new Point[countPoint];
        }
        public void AddPoint(int x, int y, int count)
        {
            Points[count].X = x;
            Points[count].Y = y;
        }

        public override void Draw()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawPolygon(Init.pen, Points);
            Init.pictureBox.Image = Init.bitmap;
        }
        public override void MoveTo(int moveX, int moveY, bool inBox = true)
        {
            int width = Init.pictureBox.Width;
            int height = Init.pictureBox.Height;
            int x;
            int y;
            bool move = true;
            for (int i = 0; i < Points.Length; i++)
            {
                x = Points[i].X;
                y = Points[i].Y;
                if (x + moveX >= 0 && x + moveX <= width && y + moveY >= 0 && y + moveY <= height)
                {
                    Points[i].X += x;
                    Points[i].Y += y;
                }
                else
                {
                    move = false;
                    break;
                }
            }
            if (move == true)
            {
                DeleteF(false, inBox);
                Draw();
            }
        }
    }
    public class Triangle : Polygon
    {
        public Triangle()
        {
            Name = "Треугольник";
        }
        public Triangle(int countPoint, string name) : base(3, name)
        { }
    }


    public class Fridge : Figure
    {
        public Rect r1;
        public Rect r2;
        public Rect r3;

        public Fridge(int x, int y, int w, int h, string name)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
            r1 = new Rect(x, y, w, h / 3, "Морозилка");
            r2 = new Rect(x, y + h / 3, w, (2 * h) / 3, "Холодильная камера");
            r3 = new Rect(x + 5, y + h / 3 + 15, w / 5, h / 3, "Ручка");
            Name = name;
        }

        public override void Draw()
        {
            r1.Draw();
            r2.Draw();
            r3.Draw();
            Init.pictureBox.Image = Init.bitmap;
        }
        public override void MoveTo(int moveX, int moveY, bool inBox = true) // Перемещает без учета границ
        {
            int width = Init.pictureBox.Width;
            int height = Init.pictureBox.Height;
            if (x + moveX >= 0 && x + moveX <= width && y + moveY >= 0 && y + moveY <= height)
            {
                r1.x += x;
                r1.y += y;
                r2.x += x;
                r2.y += y;
                r3.x += x;
                r3.y += y;
                DeleteF(false, inBox);
                Draw();
            }
        }
    }
}
