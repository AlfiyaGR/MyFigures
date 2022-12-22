namespace MyFigures
{
    partial class FormTriangle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxCMD = new System.Windows.Forms.ComboBox();
            this.textBoxCMD = new System.Windows.Forms.TextBox();
            this.buttonDeleteTree = new System.Windows.Forms.Button();
            this.groupBoxTree = new System.Windows.Forms.GroupBox();
            this.textBoxTreeName = new System.Windows.Forms.TextBox();
            this.labelTreeName = new System.Windows.Forms.Label();
            this.textBoxTreeH = new System.Windows.Forms.TextBox();
            this.textBoxTreeW = new System.Windows.Forms.TextBox();
            this.labelTreeH = new System.Windows.Forms.Label();
            this.labelTreeW = new System.Windows.Forms.Label();
            this.buttonMoveTree = new System.Windows.Forms.Button();
            this.buttonDrawTree = new System.Windows.Forms.Button();
            this.textBoxMoveTreeY = new System.Windows.Forms.TextBox();
            this.textBoxMoveTreeX = new System.Windows.Forms.TextBox();
            this.labelMoveTreeY = new System.Windows.Forms.Label();
            this.labelMoveTreeX = new System.Windows.Forms.Label();
            this.labelMoveTree = new System.Windows.Forms.Label();
            this.textBoxTreeY = new System.Windows.Forms.TextBox();
            this.textBoxTreeX = new System.Windows.Forms.TextBox();
            this.labelTreeY = new System.Windows.Forms.Label();
            this.labelTreeX = new System.Windows.Forms.Label();
            this.comboBoxTriangle = new System.Windows.Forms.ComboBox();
            this.button_Delete = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.groupBox_MoveTo = new System.Windows.Forms.GroupBox();
            this.labelMoveY = new System.Windows.Forms.Label();
            this.labelMoveX = new System.Windows.Forms.Label();
            this.button_Move = new System.Windows.Forms.Button();
            this.textBoxMoveY = new System.Windows.Forms.TextBox();
            this.textBoxMoveX = new System.Windows.Forms.TextBox();
            this.labelMove = new System.Windows.Forms.Label();
            this.pictureBoxTree = new System.Windows.Forms.PictureBox();
            this.groupBox_Make = new System.Windows.Forms.GroupBox();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.button_enterPoint = new System.Windows.Forms.Button();
            this.button_Make = new System.Windows.Forms.Button();
            this.labelPoints = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxPoints = new System.Windows.Forms.TextBox();
            this.groupBoxTree.SuspendLayout();
            this.groupBox_MoveTo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTree)).BeginInit();
            this.groupBox_Make.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxCMD
            // 
            this.comboBoxCMD.FormattingEnabled = true;
            this.comboBoxCMD.Location = new System.Drawing.Point(557, 13);
            this.comboBoxCMD.Name = "comboBoxCMD";
            this.comboBoxCMD.Size = new System.Drawing.Size(217, 24);
            this.comboBoxCMD.TabIndex = 63;
            this.comboBoxCMD.Visible = false;
            // 
            // textBoxCMD
            // 
            this.textBoxCMD.Location = new System.Drawing.Point(13, 456);
            this.textBoxCMD.Name = "textBoxCMD";
            this.textBoxCMD.ReadOnly = true;
            this.textBoxCMD.Size = new System.Drawing.Size(267, 22);
            this.textBoxCMD.TabIndex = 62;
            this.textBoxCMD.Text = "Открыть командную строку";
            this.textBoxCMD.Click += new System.EventHandler(this.textBoxCMD_Click);
            this.textBoxCMD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCMD_KeyDown);
            // 
            // buttonDeleteTree
            // 
            this.buttonDeleteTree.BackColor = System.Drawing.Color.MintCream;
            this.buttonDeleteTree.Location = new System.Drawing.Point(288, 431);
            this.buttonDeleteTree.Name = "buttonDeleteTree";
            this.buttonDeleteTree.Size = new System.Drawing.Size(226, 44);
            this.buttonDeleteTree.TabIndex = 61;
            this.buttonDeleteTree.Text = "Удалить ёлочку";
            this.buttonDeleteTree.UseVisualStyleBackColor = false;
            // 
            // groupBoxTree
            // 
            this.groupBoxTree.BackColor = System.Drawing.Color.Aqua;
            this.groupBoxTree.Controls.Add(this.textBoxTreeName);
            this.groupBoxTree.Controls.Add(this.labelTreeName);
            this.groupBoxTree.Controls.Add(this.textBoxTreeH);
            this.groupBoxTree.Controls.Add(this.textBoxTreeW);
            this.groupBoxTree.Controls.Add(this.labelTreeH);
            this.groupBoxTree.Controls.Add(this.labelTreeW);
            this.groupBoxTree.Controls.Add(this.buttonMoveTree);
            this.groupBoxTree.Controls.Add(this.buttonDrawTree);
            this.groupBoxTree.Controls.Add(this.textBoxMoveTreeY);
            this.groupBoxTree.Controls.Add(this.textBoxMoveTreeX);
            this.groupBoxTree.Controls.Add(this.labelMoveTreeY);
            this.groupBoxTree.Controls.Add(this.labelMoveTreeX);
            this.groupBoxTree.Controls.Add(this.labelMoveTree);
            this.groupBoxTree.Controls.Add(this.textBoxTreeY);
            this.groupBoxTree.Controls.Add(this.textBoxTreeX);
            this.groupBoxTree.Controls.Add(this.labelTreeY);
            this.groupBoxTree.Controls.Add(this.labelTreeX);
            this.groupBoxTree.Location = new System.Drawing.Point(781, 193);
            this.groupBoxTree.Name = "groupBoxTree";
            this.groupBoxTree.Size = new System.Drawing.Size(267, 226);
            this.groupBoxTree.TabIndex = 60;
            this.groupBoxTree.TabStop = false;
            this.groupBoxTree.Text = "Ёлочка";
            // 
            // textBoxTreeName
            // 
            this.textBoxTreeName.Location = new System.Drawing.Point(86, 77);
            this.textBoxTreeName.Name = "textBoxTreeName";
            this.textBoxTreeName.Size = new System.Drawing.Size(175, 22);
            this.textBoxTreeName.TabIndex = 22;
            // 
            // labelTreeName
            // 
            this.labelTreeName.AutoSize = true;
            this.labelTreeName.Location = new System.Drawing.Point(5, 76);
            this.labelTreeName.Name = "labelTreeName";
            this.labelTreeName.Size = new System.Drawing.Size(71, 32);
            this.labelTreeName.TabIndex = 21;
            this.labelTreeName.Text = "Введите\r\nназвание";
            // 
            // textBoxTreeH
            // 
            this.textBoxTreeH.Location = new System.Drawing.Point(210, 49);
            this.textBoxTreeH.Name = "textBoxTreeH";
            this.textBoxTreeH.Size = new System.Drawing.Size(51, 22);
            this.textBoxTreeH.TabIndex = 20;
            // 
            // textBoxTreeW
            // 
            this.textBoxTreeW.Location = new System.Drawing.Point(210, 21);
            this.textBoxTreeW.Name = "textBoxTreeW";
            this.textBoxTreeW.Size = new System.Drawing.Size(51, 22);
            this.textBoxTreeW.TabIndex = 19;
            // 
            // labelTreeH
            // 
            this.labelTreeH.AutoSize = true;
            this.labelTreeH.Location = new System.Drawing.Point(146, 52);
            this.labelTreeH.Name = "labelTreeH";
            this.labelTreeH.Size = new System.Drawing.Size(48, 16);
            this.labelTreeH.TabIndex = 18;
            this.labelTreeH.Text = "Длина";
            // 
            // labelTreeW
            // 
            this.labelTreeW.AutoSize = true;
            this.labelTreeW.Location = new System.Drawing.Point(146, 24);
            this.labelTreeW.Name = "labelTreeW";
            this.labelTreeW.Size = new System.Drawing.Size(58, 16);
            this.labelTreeW.TabIndex = 17;
            this.labelTreeW.Text = "Ширина";
            // 
            // buttonMoveTree
            // 
            this.buttonMoveTree.BackColor = System.Drawing.Color.MintCream;
            this.buttonMoveTree.Location = new System.Drawing.Point(11, 194);
            this.buttonMoveTree.Name = "buttonMoveTree";
            this.buttonMoveTree.Size = new System.Drawing.Size(249, 27);
            this.buttonMoveTree.TabIndex = 16;
            this.buttonMoveTree.Text = "Передвинуть ёлочку";
            this.buttonMoveTree.UseVisualStyleBackColor = false;
            // 
            // buttonDrawTree
            // 
            this.buttonDrawTree.BackColor = System.Drawing.Color.MintCream;
            this.buttonDrawTree.Location = new System.Drawing.Point(11, 161);
            this.buttonDrawTree.Name = "buttonDrawTree";
            this.buttonDrawTree.Size = new System.Drawing.Size(249, 27);
            this.buttonDrawTree.TabIndex = 15;
            this.buttonDrawTree.Text = "Нарисовать ёлочку";
            this.buttonDrawTree.UseVisualStyleBackColor = false;
            // 
            // textBoxMoveTreeY
            // 
            this.textBoxMoveTreeY.Location = new System.Drawing.Point(175, 133);
            this.textBoxMoveTreeY.Name = "textBoxMoveTreeY";
            this.textBoxMoveTreeY.Size = new System.Drawing.Size(78, 22);
            this.textBoxMoveTreeY.TabIndex = 15;
            // 
            // textBoxMoveTreeX
            // 
            this.textBoxMoveTreeX.Location = new System.Drawing.Point(48, 133);
            this.textBoxMoveTreeX.Name = "textBoxMoveTreeX";
            this.textBoxMoveTreeX.Size = new System.Drawing.Size(78, 22);
            this.textBoxMoveTreeX.TabIndex = 7;
            // 
            // labelMoveTreeY
            // 
            this.labelMoveTreeY.AutoSize = true;
            this.labelMoveTreeY.Location = new System.Drawing.Point(132, 139);
            this.labelMoveTreeY.Name = "labelMoveTreeY";
            this.labelMoveTreeY.Size = new System.Drawing.Size(37, 16);
            this.labelMoveTreeY.TabIndex = 6;
            this.labelMoveTreeY.Text = "По Y";
            // 
            // labelMoveTreeX
            // 
            this.labelMoveTreeX.AutoSize = true;
            this.labelMoveTreeX.Location = new System.Drawing.Point(6, 139);
            this.labelMoveTreeX.Name = "labelMoveTreeX";
            this.labelMoveTreeX.Size = new System.Drawing.Size(36, 16);
            this.labelMoveTreeX.TabIndex = 5;
            this.labelMoveTreeX.Text = "По X";
            // 
            // labelMoveTree
            // 
            this.labelMoveTree.AutoSize = true;
            this.labelMoveTree.Location = new System.Drawing.Point(75, 114);
            this.labelMoveTree.Name = "labelMoveTree";
            this.labelMoveTree.Size = new System.Drawing.Size(119, 16);
            this.labelMoveTree.TabIndex = 4;
            this.labelMoveTree.Text = "Сместить ёлочку";
            // 
            // textBoxTreeY
            // 
            this.textBoxTreeY.Location = new System.Drawing.Point(86, 49);
            this.textBoxTreeY.Name = "textBoxTreeY";
            this.textBoxTreeY.Size = new System.Drawing.Size(54, 22);
            this.textBoxTreeY.TabIndex = 3;
            // 
            // textBoxTreeX
            // 
            this.textBoxTreeX.Location = new System.Drawing.Point(86, 21);
            this.textBoxTreeX.Name = "textBoxTreeX";
            this.textBoxTreeX.Size = new System.Drawing.Size(54, 22);
            this.textBoxTreeX.TabIndex = 2;
            // 
            // labelTreeY
            // 
            this.labelTreeY.AutoSize = true;
            this.labelTreeY.Location = new System.Drawing.Point(5, 52);
            this.labelTreeY.Name = "labelTreeY";
            this.labelTreeY.Size = new System.Drawing.Size(75, 16);
            this.labelTreeY.TabIndex = 1;
            this.labelTreeY.Text = "Введите Y";
            // 
            // labelTreeX
            // 
            this.labelTreeX.AutoSize = true;
            this.labelTreeX.Location = new System.Drawing.Point(6, 24);
            this.labelTreeX.Name = "labelTreeX";
            this.labelTreeX.Size = new System.Drawing.Size(74, 16);
            this.labelTreeX.TabIndex = 0;
            this.labelTreeX.Text = "Введите X";
            // 
            // comboBoxTriangle
            // 
            this.comboBoxTriangle.FormattingEnabled = true;
            this.comboBoxTriangle.Location = new System.Drawing.Point(13, 426);
            this.comboBoxTriangle.Name = "comboBoxTriangle";
            this.comboBoxTriangle.Size = new System.Drawing.Size(267, 24);
            this.comboBoxTriangle.TabIndex = 59;
            this.comboBoxTriangle.SelectedIndexChanged += new System.EventHandler(this.comboBoxTriangle_SelectedIndexChanged);
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.MintCream;
            this.button_Delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Delete.Location = new System.Drawing.Point(547, 431);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(226, 44);
            this.button_Delete.TabIndex = 58;
            this.button_Delete.Text = "Удалить треугольник";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonExit.Location = new System.Drawing.Point(802, 442);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(119, 38);
            this.buttonExit.TabIndex = 57;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonMenu.Location = new System.Drawing.Point(929, 442);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(119, 38);
            this.buttonMenu.TabIndex = 56;
            this.buttonMenu.Text = "Меню";
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // groupBox_MoveTo
            // 
            this.groupBox_MoveTo.BackColor = System.Drawing.Color.Aqua;
            this.groupBox_MoveTo.Controls.Add(this.labelMoveY);
            this.groupBox_MoveTo.Controls.Add(this.labelMoveX);
            this.groupBox_MoveTo.Controls.Add(this.button_Move);
            this.groupBox_MoveTo.Controls.Add(this.textBoxMoveY);
            this.groupBox_MoveTo.Controls.Add(this.textBoxMoveX);
            this.groupBox_MoveTo.Controls.Add(this.labelMove);
            this.groupBox_MoveTo.Location = new System.Drawing.Point(13, 13);
            this.groupBox_MoveTo.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_MoveTo.Name = "groupBox_MoveTo";
            this.groupBox_MoveTo.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_MoveTo.Size = new System.Drawing.Size(267, 199);
            this.groupBox_MoveTo.TabIndex = 54;
            this.groupBox_MoveTo.TabStop = false;
            this.groupBox_MoveTo.Text = "Движение";
            // 
            // labelMoveY
            // 
            this.labelMoveY.AutoSize = true;
            this.labelMoveY.Location = new System.Drawing.Point(20, 100);
            this.labelMoveY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMoveY.Name = "labelMoveY";
            this.labelMoveY.Size = new System.Drawing.Size(35, 16);
            this.labelMoveY.TabIndex = 13;
            this.labelMoveY.Text = "по Y";
            // 
            // labelMoveX
            // 
            this.labelMoveX.AutoSize = true;
            this.labelMoveX.Location = new System.Drawing.Point(20, 63);
            this.labelMoveX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMoveX.Name = "labelMoveX";
            this.labelMoveX.Size = new System.Drawing.Size(34, 16);
            this.labelMoveX.TabIndex = 13;
            this.labelMoveX.Text = "по X";
            // 
            // button_Move
            // 
            this.button_Move.BackColor = System.Drawing.Color.MintCream;
            this.button_Move.Location = new System.Drawing.Point(8, 164);
            this.button_Move.Margin = new System.Windows.Forms.Padding(4);
            this.button_Move.Name = "button_Move";
            this.button_Move.Size = new System.Drawing.Size(251, 28);
            this.button_Move.TabIndex = 13;
            this.button_Move.Text = "Сместить";
            this.button_Move.UseVisualStyleBackColor = false;
            this.button_Move.Click += new System.EventHandler(this.button_Move_Click);
            // 
            // textBoxMoveY
            // 
            this.textBoxMoveY.Location = new System.Drawing.Point(101, 91);
            this.textBoxMoveY.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMoveY.Name = "textBoxMoveY";
            this.textBoxMoveY.Size = new System.Drawing.Size(132, 22);
            this.textBoxMoveY.TabIndex = 13;
            // 
            // textBoxMoveX
            // 
            this.textBoxMoveX.Location = new System.Drawing.Point(101, 59);
            this.textBoxMoveX.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMoveX.Name = "textBoxMoveX";
            this.textBoxMoveX.Size = new System.Drawing.Size(132, 22);
            this.textBoxMoveX.TabIndex = 13;
            // 
            // labelMove
            // 
            this.labelMove.AutoSize = true;
            this.labelMove.Location = new System.Drawing.Point(83, 27);
            this.labelMove.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMove.Name = "labelMove";
            this.labelMove.Size = new System.Drawing.Size(69, 16);
            this.labelMove.TabIndex = 13;
            this.labelMove.Text = "Сместить";
            // 
            // pictureBoxTree
            // 
            this.pictureBoxTree.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTree.Location = new System.Drawing.Point(288, 13);
            this.pictureBoxTree.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxTree.Name = "pictureBoxTree";
            this.pictureBoxTree.Size = new System.Drawing.Size(485, 406);
            this.pictureBoxTree.TabIndex = 53;
            this.pictureBoxTree.TabStop = false;
            // 
            // groupBox_Make
            // 
            this.groupBox_Make.BackColor = System.Drawing.Color.Aqua;
            this.groupBox_Make.Controls.Add(this.buttonDraw);
            this.groupBox_Make.Controls.Add(this.textBoxName);
            this.groupBox_Make.Controls.Add(this.labelName);
            this.groupBox_Make.Controls.Add(this.button_enterPoint);
            this.groupBox_Make.Controls.Add(this.button_Make);
            this.groupBox_Make.Controls.Add(this.labelPoints);
            this.groupBox_Make.Controls.Add(this.labelY);
            this.groupBox_Make.Controls.Add(this.labelX);
            this.groupBox_Make.Controls.Add(this.textBoxX);
            this.groupBox_Make.Controls.Add(this.textBoxY);
            this.groupBox_Make.Controls.Add(this.textBoxPoints);
            this.groupBox_Make.Location = new System.Drawing.Point(782, 13);
            this.groupBox_Make.Name = "groupBox_Make";
            this.groupBox_Make.Size = new System.Drawing.Size(267, 174);
            this.groupBox_Make.TabIndex = 64;
            this.groupBox_Make.TabStop = false;
            this.groupBox_Make.Text = "Создание";
            // 
            // buttonDraw
            // 
            this.buttonDraw.BackColor = System.Drawing.Color.MintCream;
            this.buttonDraw.Location = new System.Drawing.Point(8, 141);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(252, 27);
            this.buttonDraw.TabIndex = 10;
            this.buttonDraw.Text = "Нарисовать";
            this.buttonDraw.UseVisualStyleBackColor = false;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(161, 40);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 11;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(8, 40);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(130, 16);
            this.labelName.TabIndex = 10;
            this.labelName.Text = "Введите название";
            // 
            // button_enterPoint
            // 
            this.button_enterPoint.BackColor = System.Drawing.Color.MintCream;
            this.button_enterPoint.Location = new System.Drawing.Point(168, 88);
            this.button_enterPoint.Name = "button_enterPoint";
            this.button_enterPoint.Size = new System.Drawing.Size(85, 46);
            this.button_enterPoint.TabIndex = 9;
            this.button_enterPoint.Text = "Добавить точку";
            this.button_enterPoint.UseVisualStyleBackColor = false;
            this.button_enterPoint.Click += new System.EventHandler(this.button_enterPoint_Click);
            // 
            // button_Make
            // 
            this.button_Make.BackColor = System.Drawing.Color.MintCream;
            this.button_Make.Location = new System.Drawing.Point(7, 63);
            this.button_Make.Name = "button_Make";
            this.button_Make.Size = new System.Drawing.Size(254, 23);
            this.button_Make.TabIndex = 8;
            this.button_Make.Text = "Создать";
            this.button_Make.UseVisualStyleBackColor = false;
            this.button_Make.Click += new System.EventHandler(this.button_Make_Click);
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.Location = new System.Drawing.Point(6, 18);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(184, 16);
            this.labelPoints.TabIndex = 6;
            this.labelPoints.Text = "Введите количество точек";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(6, 122);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(75, 16);
            this.labelY.TabIndex = 5;
            this.labelY.Text = "Введите Y";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(8, 94);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(74, 16);
            this.labelX.TabIndex = 4;
            this.labelX.Text = "Введите X";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(99, 88);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.ReadOnly = true;
            this.textBoxX.Size = new System.Drawing.Size(60, 22);
            this.textBoxX.TabIndex = 0;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(99, 116);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.ReadOnly = true;
            this.textBoxY.Size = new System.Drawing.Size(60, 22);
            this.textBoxY.TabIndex = 1;
            // 
            // textBoxPoints
            // 
            this.textBoxPoints.Location = new System.Drawing.Point(201, 15);
            this.textBoxPoints.Name = "textBoxPoints";
            this.textBoxPoints.ReadOnly = true;
            this.textBoxPoints.Size = new System.Drawing.Size(60, 22);
            this.textBoxPoints.TabIndex = 2;
            this.textBoxPoints.Text = "3";
            // 
            // FormTriangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1061, 493);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox_Make);
            this.Controls.Add(this.comboBoxCMD);
            this.Controls.Add(this.textBoxCMD);
            this.Controls.Add(this.buttonDeleteTree);
            this.Controls.Add(this.groupBoxTree);
            this.Controls.Add(this.comboBoxTriangle);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.groupBox_MoveTo);
            this.Controls.Add(this.pictureBoxTree);
            this.Name = "FormTriangle";
            this.Text = "FormTriangle";
            this.Load += new System.EventHandler(this.FormTriangle_Load);
            this.groupBoxTree.ResumeLayout(false);
            this.groupBoxTree.PerformLayout();
            this.groupBox_MoveTo.ResumeLayout(false);
            this.groupBox_MoveTo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTree)).EndInit();
            this.groupBox_Make.ResumeLayout(false);
            this.groupBox_Make.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCMD;
        private System.Windows.Forms.TextBox textBoxCMD;
        private System.Windows.Forms.Button buttonDeleteTree;
        private System.Windows.Forms.GroupBox groupBoxTree;
        private System.Windows.Forms.TextBox textBoxTreeName;
        private System.Windows.Forms.Label labelTreeName;
        private System.Windows.Forms.TextBox textBoxTreeH;
        private System.Windows.Forms.TextBox textBoxTreeW;
        private System.Windows.Forms.Label labelTreeH;
        private System.Windows.Forms.Label labelTreeW;
        private System.Windows.Forms.Button buttonMoveTree;
        private System.Windows.Forms.Button buttonDrawTree;
        private System.Windows.Forms.TextBox textBoxMoveTreeY;
        private System.Windows.Forms.TextBox textBoxMoveTreeX;
        private System.Windows.Forms.Label labelMoveTreeY;
        private System.Windows.Forms.Label labelMoveTreeX;
        private System.Windows.Forms.Label labelMoveTree;
        private System.Windows.Forms.TextBox textBoxTreeY;
        private System.Windows.Forms.TextBox textBoxTreeX;
        private System.Windows.Forms.Label labelTreeY;
        private System.Windows.Forms.Label labelTreeX;
        private System.Windows.Forms.ComboBox comboBoxTriangle;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.GroupBox groupBox_MoveTo;
        private System.Windows.Forms.Label labelMoveY;
        private System.Windows.Forms.Label labelMoveX;
        private System.Windows.Forms.Button button_Move;
        private System.Windows.Forms.TextBox textBoxMoveY;
        private System.Windows.Forms.TextBox textBoxMoveX;
        private System.Windows.Forms.Label labelMove;
        private System.Windows.Forms.PictureBox pictureBoxTree;
        private System.Windows.Forms.GroupBox groupBox_Make;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button button_enterPoint;
        private System.Windows.Forms.Button button_Make;
        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxPoints;
    }
}