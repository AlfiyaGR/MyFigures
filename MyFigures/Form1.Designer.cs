namespace MyFigures
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_Figure = new System.Windows.Forms.GroupBox();
            this.radioButton_Triangle = new System.Windows.Forms.RadioButton();
            this.radioButton_Polygon = new System.Windows.Forms.RadioButton();
            this.button_Exit = new System.Windows.Forms.Button();
            this.radioButton_Circle = new System.Windows.Forms.RadioButton();
            this.radioButton_Ellipse = new System.Windows.Forms.RadioButton();
            this.radioButton_Square = new System.Windows.Forms.RadioButton();
            this.radioButton_Rect = new System.Windows.Forms.RadioButton();
            this.button_Figure = new System.Windows.Forms.Button();
            this.pictureBoxAll = new System.Windows.Forms.PictureBox();
            this.groupBox_Figure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAll)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Figure
            // 
            this.groupBox_Figure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox_Figure.Controls.Add(this.radioButton_Triangle);
            this.groupBox_Figure.Controls.Add(this.radioButton_Polygon);
            this.groupBox_Figure.Controls.Add(this.button_Exit);
            this.groupBox_Figure.Controls.Add(this.radioButton_Circle);
            this.groupBox_Figure.Controls.Add(this.radioButton_Ellipse);
            this.groupBox_Figure.Controls.Add(this.radioButton_Square);
            this.groupBox_Figure.Controls.Add(this.radioButton_Rect);
            this.groupBox_Figure.Controls.Add(this.button_Figure);
            this.groupBox_Figure.ForeColor = System.Drawing.Color.Black;
            this.groupBox_Figure.Location = new System.Drawing.Point(13, 96);
            this.groupBox_Figure.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_Figure.Name = "groupBox_Figure";
            this.groupBox_Figure.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_Figure.Size = new System.Drawing.Size(404, 226);
            this.groupBox_Figure.TabIndex = 2;
            this.groupBox_Figure.TabStop = false;
            this.groupBox_Figure.Text = "Фигуры";
            // 
            // radioButton_Triangle
            // 
            this.radioButton_Triangle.AutoSize = true;
            this.radioButton_Triangle.Location = new System.Drawing.Point(92, 160);
            this.radioButton_Triangle.Name = "radioButton_Triangle";
            this.radioButton_Triangle.Size = new System.Drawing.Size(113, 20);
            this.radioButton_Triangle.TabIndex = 6;
            this.radioButton_Triangle.TabStop = true;
            this.radioButton_Triangle.Text = "Треугольник";
            this.radioButton_Triangle.UseVisualStyleBackColor = true;
            // 
            // radioButton_Polygon
            // 
            this.radioButton_Polygon.AutoSize = true;
            this.radioButton_Polygon.Location = new System.Drawing.Point(92, 134);
            this.radioButton_Polygon.Name = "radioButton_Polygon";
            this.radioButton_Polygon.Size = new System.Drawing.Size(129, 20);
            this.radioButton_Polygon.TabIndex = 5;
            this.radioButton_Polygon.TabStop = true;
            this.radioButton_Polygon.Text = "Многоугольник";
            this.radioButton_Polygon.UseVisualStyleBackColor = true;
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.Color.SeaShell;
            this.button_Exit.Location = new System.Drawing.Point(189, 192);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(100, 25);
            this.button_Exit.TabIndex = 2;
            this.button_Exit.Text = "Выйти";
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // radioButton_Circle
            // 
            this.radioButton_Circle.AutoSize = true;
            this.radioButton_Circle.Location = new System.Drawing.Point(92, 107);
            this.radioButton_Circle.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_Circle.Name = "radioButton_Circle";
            this.radioButton_Circle.Size = new System.Drawing.Size(58, 20);
            this.radioButton_Circle.TabIndex = 4;
            this.radioButton_Circle.TabStop = true;
            this.radioButton_Circle.Text = "Круг";
            this.radioButton_Circle.UseVisualStyleBackColor = true;
            // 
            // radioButton_Ellipse
            // 
            this.radioButton_Ellipse.AutoSize = true;
            this.radioButton_Ellipse.Location = new System.Drawing.Point(92, 79);
            this.radioButton_Ellipse.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_Ellipse.Name = "radioButton_Ellipse";
            this.radioButton_Ellipse.Size = new System.Drawing.Size(77, 20);
            this.radioButton_Ellipse.TabIndex = 3;
            this.radioButton_Ellipse.TabStop = true;
            this.radioButton_Ellipse.Text = "Эллипс";
            this.radioButton_Ellipse.UseVisualStyleBackColor = true;
            // 
            // radioButton_Square
            // 
            this.radioButton_Square.AutoSize = true;
            this.radioButton_Square.Location = new System.Drawing.Point(92, 51);
            this.radioButton_Square.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_Square.Name = "radioButton_Square";
            this.radioButton_Square.Size = new System.Drawing.Size(83, 20);
            this.radioButton_Square.TabIndex = 2;
            this.radioButton_Square.TabStop = true;
            this.radioButton_Square.Text = "Квадрат";
            this.radioButton_Square.UseVisualStyleBackColor = true;
            // 
            // radioButton_Rect
            // 
            this.radioButton_Rect.AutoSize = true;
            this.radioButton_Rect.Location = new System.Drawing.Point(92, 23);
            this.radioButton_Rect.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_Rect.Name = "radioButton_Rect";
            this.radioButton_Rect.Size = new System.Drawing.Size(130, 20);
            this.radioButton_Rect.TabIndex = 1;
            this.radioButton_Rect.TabStop = true;
            this.radioButton_Rect.Text = "Прямоугольник";
            this.radioButton_Rect.UseVisualStyleBackColor = true;
            // 
            // button_Figure
            // 
            this.button_Figure.BackColor = System.Drawing.Color.SeaShell;
            this.button_Figure.Location = new System.Drawing.Point(296, 190);
            this.button_Figure.Margin = new System.Windows.Forms.Padding(4);
            this.button_Figure.Name = "button_Figure";
            this.button_Figure.Size = new System.Drawing.Size(100, 28);
            this.button_Figure.TabIndex = 0;
            this.button_Figure.Text = "Перейти";
            this.button_Figure.UseVisualStyleBackColor = false;
            this.button_Figure.Click += new System.EventHandler(this.button_Figure_Click);
            // 
            // pictureBoxAll
            // 
            this.pictureBoxAll.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAll.Location = new System.Drawing.Point(425, 13);
            this.pictureBoxAll.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxAll.Name = "pictureBoxAll";
            this.pictureBoxAll.Size = new System.Drawing.Size(485, 406);
            this.pictureBoxAll.TabIndex = 30;
            this.pictureBoxAll.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(924, 433);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBoxAll);
            this.Controls.Add(this.groupBox_Figure);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_Figure.ResumeLayout(false);
            this.groupBox_Figure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Figure;
        private System.Windows.Forms.RadioButton radioButton_Triangle;
        private System.Windows.Forms.RadioButton radioButton_Polygon;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.RadioButton radioButton_Circle;
        private System.Windows.Forms.RadioButton radioButton_Ellipse;
        private System.Windows.Forms.RadioButton radioButton_Square;
        private System.Windows.Forms.RadioButton radioButton_Rect;
        private System.Windows.Forms.Button button_Figure;
        private System.Windows.Forms.PictureBox pictureBoxAll;
    }
}

