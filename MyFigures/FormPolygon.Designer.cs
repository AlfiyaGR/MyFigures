namespace MyFigures
{
    partial class FormPolygon
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
            this.buttonDeleteFridge = new System.Windows.Forms.Button();
            this.groupBoxFridge = new System.Windows.Forms.GroupBox();
            this.textBoxFridgeName = new System.Windows.Forms.TextBox();
            this.labelFridgeName = new System.Windows.Forms.Label();
            this.textBoxFridgeH = new System.Windows.Forms.TextBox();
            this.textBoxFridgeW = new System.Windows.Forms.TextBox();
            this.labelFridgeH = new System.Windows.Forms.Label();
            this.labelFridgeW = new System.Windows.Forms.Label();
            this.buttonMoveFridge = new System.Windows.Forms.Button();
            this.buttonDrawFridge = new System.Windows.Forms.Button();
            this.textBoxMoveFridgeY = new System.Windows.Forms.TextBox();
            this.textBoxMoveFridgeX = new System.Windows.Forms.TextBox();
            this.labelMoveFridgeY = new System.Windows.Forms.Label();
            this.labelMoveFridgeX = new System.Windows.Forms.Label();
            this.labelMoveFridge = new System.Windows.Forms.Label();
            this.textBoxFridgeY = new System.Windows.Forms.TextBox();
            this.textBoxFridgeX = new System.Windows.Forms.TextBox();
            this.labelFridgeY = new System.Windows.Forms.Label();
            this.labelFridgeX = new System.Windows.Forms.Label();
            this.comboBoxPolygon = new System.Windows.Forms.ComboBox();
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
            this.pictureBoxPolygon = new System.Windows.Forms.PictureBox();
            this.groupBox_Make = new System.Windows.Forms.GroupBox();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.button_enterPoint = new System.Windows.Forms.Button();
            this.button_Make = new System.Windows.Forms.Button();
            this.labelPoints = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxPoints = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.groupBoxFridge.SuspendLayout();
            this.groupBox_MoveTo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPolygon)).BeginInit();
            this.groupBox_Make.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxCMD
            // 
            this.comboBoxCMD.FormattingEnabled = true;
            this.comboBoxCMD.Location = new System.Drawing.Point(557, 13);
            this.comboBoxCMD.Name = "comboBoxCMD";
            this.comboBoxCMD.Size = new System.Drawing.Size(217, 24);
            this.comboBoxCMD.TabIndex = 39;
            this.comboBoxCMD.Visible = false;
            // 
            // textBoxCMD
            // 
            this.textBoxCMD.Location = new System.Drawing.Point(13, 456);
            this.textBoxCMD.Name = "textBoxCMD";
            this.textBoxCMD.ReadOnly = true;
            this.textBoxCMD.Size = new System.Drawing.Size(267, 22);
            this.textBoxCMD.TabIndex = 38;
            this.textBoxCMD.Text = "Открыть командную строку";
            this.textBoxCMD.Click += new System.EventHandler(this.textBoxCMD_Click);
            this.textBoxCMD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCMD_KeyDown);
            // 
            // buttonDeleteFridge
            // 
            this.buttonDeleteFridge.BackColor = System.Drawing.Color.MintCream;
            this.buttonDeleteFridge.Location = new System.Drawing.Point(288, 431);
            this.buttonDeleteFridge.Name = "buttonDeleteFridge";
            this.buttonDeleteFridge.Size = new System.Drawing.Size(226, 44);
            this.buttonDeleteFridge.TabIndex = 37;
            this.buttonDeleteFridge.Text = "Удалить холодильник";
            this.buttonDeleteFridge.UseVisualStyleBackColor = false;
            // 
            // groupBoxFridge
            // 
            this.groupBoxFridge.BackColor = System.Drawing.Color.MediumPurple;
            this.groupBoxFridge.Controls.Add(this.textBoxFridgeName);
            this.groupBoxFridge.Controls.Add(this.labelFridgeName);
            this.groupBoxFridge.Controls.Add(this.textBoxFridgeH);
            this.groupBoxFridge.Controls.Add(this.textBoxFridgeW);
            this.groupBoxFridge.Controls.Add(this.labelFridgeH);
            this.groupBoxFridge.Controls.Add(this.labelFridgeW);
            this.groupBoxFridge.Controls.Add(this.buttonMoveFridge);
            this.groupBoxFridge.Controls.Add(this.buttonDrawFridge);
            this.groupBoxFridge.Controls.Add(this.textBoxMoveFridgeY);
            this.groupBoxFridge.Controls.Add(this.textBoxMoveFridgeX);
            this.groupBoxFridge.Controls.Add(this.labelMoveFridgeY);
            this.groupBoxFridge.Controls.Add(this.labelMoveFridgeX);
            this.groupBoxFridge.Controls.Add(this.labelMoveFridge);
            this.groupBoxFridge.Controls.Add(this.textBoxFridgeY);
            this.groupBoxFridge.Controls.Add(this.textBoxFridgeX);
            this.groupBoxFridge.Controls.Add(this.labelFridgeY);
            this.groupBoxFridge.Controls.Add(this.labelFridgeX);
            this.groupBoxFridge.Location = new System.Drawing.Point(781, 193);
            this.groupBoxFridge.Name = "groupBoxFridge";
            this.groupBoxFridge.Size = new System.Drawing.Size(267, 226);
            this.groupBoxFridge.TabIndex = 36;
            this.groupBoxFridge.TabStop = false;
            this.groupBoxFridge.Text = "Холодильник";
            // 
            // textBoxFridgeName
            // 
            this.textBoxFridgeName.Location = new System.Drawing.Point(86, 77);
            this.textBoxFridgeName.Name = "textBoxFridgeName";
            this.textBoxFridgeName.Size = new System.Drawing.Size(175, 22);
            this.textBoxFridgeName.TabIndex = 22;
            // 
            // labelFridgeName
            // 
            this.labelFridgeName.AutoSize = true;
            this.labelFridgeName.Location = new System.Drawing.Point(5, 76);
            this.labelFridgeName.Name = "labelFridgeName";
            this.labelFridgeName.Size = new System.Drawing.Size(71, 32);
            this.labelFridgeName.TabIndex = 21;
            this.labelFridgeName.Text = "Введите\r\nназвание";
            // 
            // textBoxFridgeH
            // 
            this.textBoxFridgeH.Location = new System.Drawing.Point(210, 49);
            this.textBoxFridgeH.Name = "textBoxFridgeH";
            this.textBoxFridgeH.Size = new System.Drawing.Size(51, 22);
            this.textBoxFridgeH.TabIndex = 20;
            // 
            // textBoxFridgeW
            // 
            this.textBoxFridgeW.Location = new System.Drawing.Point(210, 21);
            this.textBoxFridgeW.Name = "textBoxFridgeW";
            this.textBoxFridgeW.Size = new System.Drawing.Size(51, 22);
            this.textBoxFridgeW.TabIndex = 19;
            // 
            // labelFridgeH
            // 
            this.labelFridgeH.AutoSize = true;
            this.labelFridgeH.Location = new System.Drawing.Point(146, 52);
            this.labelFridgeH.Name = "labelFridgeH";
            this.labelFridgeH.Size = new System.Drawing.Size(48, 16);
            this.labelFridgeH.TabIndex = 18;
            this.labelFridgeH.Text = "Длина";
            // 
            // labelFridgeW
            // 
            this.labelFridgeW.AutoSize = true;
            this.labelFridgeW.Location = new System.Drawing.Point(146, 24);
            this.labelFridgeW.Name = "labelFridgeW";
            this.labelFridgeW.Size = new System.Drawing.Size(58, 16);
            this.labelFridgeW.TabIndex = 17;
            this.labelFridgeW.Text = "Ширина";
            // 
            // buttonMoveFridge
            // 
            this.buttonMoveFridge.BackColor = System.Drawing.Color.MintCream;
            this.buttonMoveFridge.Location = new System.Drawing.Point(11, 194);
            this.buttonMoveFridge.Name = "buttonMoveFridge";
            this.buttonMoveFridge.Size = new System.Drawing.Size(249, 27);
            this.buttonMoveFridge.TabIndex = 16;
            this.buttonMoveFridge.Text = "Передвинуть холодильник";
            this.buttonMoveFridge.UseVisualStyleBackColor = false;
            // 
            // buttonDrawFridge
            // 
            this.buttonDrawFridge.BackColor = System.Drawing.Color.MintCream;
            this.buttonDrawFridge.Location = new System.Drawing.Point(11, 161);
            this.buttonDrawFridge.Name = "buttonDrawFridge";
            this.buttonDrawFridge.Size = new System.Drawing.Size(249, 27);
            this.buttonDrawFridge.TabIndex = 15;
            this.buttonDrawFridge.Text = "Нарисовать холодильник";
            this.buttonDrawFridge.UseVisualStyleBackColor = false;
            // 
            // textBoxMoveFridgeY
            // 
            this.textBoxMoveFridgeY.Location = new System.Drawing.Point(175, 133);
            this.textBoxMoveFridgeY.Name = "textBoxMoveFridgeY";
            this.textBoxMoveFridgeY.Size = new System.Drawing.Size(78, 22);
            this.textBoxMoveFridgeY.TabIndex = 15;
            // 
            // textBoxMoveFridgeX
            // 
            this.textBoxMoveFridgeX.Location = new System.Drawing.Point(48, 133);
            this.textBoxMoveFridgeX.Name = "textBoxMoveFridgeX";
            this.textBoxMoveFridgeX.Size = new System.Drawing.Size(78, 22);
            this.textBoxMoveFridgeX.TabIndex = 7;
            // 
            // labelMoveFridgeY
            // 
            this.labelMoveFridgeY.AutoSize = true;
            this.labelMoveFridgeY.Location = new System.Drawing.Point(132, 139);
            this.labelMoveFridgeY.Name = "labelMoveFridgeY";
            this.labelMoveFridgeY.Size = new System.Drawing.Size(37, 16);
            this.labelMoveFridgeY.TabIndex = 6;
            this.labelMoveFridgeY.Text = "По Y";
            // 
            // labelMoveFridgeX
            // 
            this.labelMoveFridgeX.AutoSize = true;
            this.labelMoveFridgeX.Location = new System.Drawing.Point(6, 139);
            this.labelMoveFridgeX.Name = "labelMoveFridgeX";
            this.labelMoveFridgeX.Size = new System.Drawing.Size(36, 16);
            this.labelMoveFridgeX.TabIndex = 5;
            this.labelMoveFridgeX.Text = "По X";
            // 
            // labelMoveFridge
            // 
            this.labelMoveFridge.AutoSize = true;
            this.labelMoveFridge.Location = new System.Drawing.Point(58, 114);
            this.labelMoveFridge.Name = "labelMoveFridge";
            this.labelMoveFridge.Size = new System.Drawing.Size(156, 16);
            this.labelMoveFridge.TabIndex = 4;
            this.labelMoveFridge.Text = "Сместить холодильник";
            // 
            // textBoxFridgeY
            // 
            this.textBoxFridgeY.Location = new System.Drawing.Point(86, 49);
            this.textBoxFridgeY.Name = "textBoxFridgeY";
            this.textBoxFridgeY.Size = new System.Drawing.Size(54, 22);
            this.textBoxFridgeY.TabIndex = 3;
            // 
            // textBoxFridgeX
            // 
            this.textBoxFridgeX.Location = new System.Drawing.Point(86, 21);
            this.textBoxFridgeX.Name = "textBoxFridgeX";
            this.textBoxFridgeX.Size = new System.Drawing.Size(54, 22);
            this.textBoxFridgeX.TabIndex = 2;
            // 
            // labelFridgeY
            // 
            this.labelFridgeY.AutoSize = true;
            this.labelFridgeY.Location = new System.Drawing.Point(5, 52);
            this.labelFridgeY.Name = "labelFridgeY";
            this.labelFridgeY.Size = new System.Drawing.Size(75, 16);
            this.labelFridgeY.TabIndex = 1;
            this.labelFridgeY.Text = "Введите Y";
            // 
            // labelFridgeX
            // 
            this.labelFridgeX.AutoSize = true;
            this.labelFridgeX.Location = new System.Drawing.Point(6, 24);
            this.labelFridgeX.Name = "labelFridgeX";
            this.labelFridgeX.Size = new System.Drawing.Size(74, 16);
            this.labelFridgeX.TabIndex = 0;
            this.labelFridgeX.Text = "Введите X";
            // 
            // comboBoxPolygon
            // 
            this.comboBoxPolygon.FormattingEnabled = true;
            this.comboBoxPolygon.Location = new System.Drawing.Point(13, 426);
            this.comboBoxPolygon.Name = "comboBoxPolygon";
            this.comboBoxPolygon.Size = new System.Drawing.Size(267, 24);
            this.comboBoxPolygon.TabIndex = 35;
            this.comboBoxPolygon.SelectedIndexChanged += new System.EventHandler(this.comboBoxPolygon_SelectedIndexChanged);
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.MintCream;
            this.button_Delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Delete.Location = new System.Drawing.Point(547, 431);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(226, 44);
            this.button_Delete.TabIndex = 34;
            this.button_Delete.Text = "Удалить многоугольник";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonExit.Location = new System.Drawing.Point(802, 442);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(119, 38);
            this.buttonExit.TabIndex = 33;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonMenu.Location = new System.Drawing.Point(929, 442);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(119, 38);
            this.buttonMenu.TabIndex = 32;
            this.buttonMenu.Text = "Меню";
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // groupBox_MoveTo
            // 
            this.groupBox_MoveTo.BackColor = System.Drawing.Color.MediumPurple;
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
            this.groupBox_MoveTo.TabIndex = 30;
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
            // pictureBoxPolygon
            // 
            this.pictureBoxPolygon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPolygon.Location = new System.Drawing.Point(288, 13);
            this.pictureBoxPolygon.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPolygon.Name = "pictureBoxPolygon";
            this.pictureBoxPolygon.Size = new System.Drawing.Size(485, 406);
            this.pictureBoxPolygon.TabIndex = 29;
            this.pictureBoxPolygon.TabStop = false;
            // 
            // groupBox_Make
            // 
            this.groupBox_Make.BackColor = System.Drawing.Color.MediumPurple;
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
            this.groupBox_Make.Location = new System.Drawing.Point(781, 13);
            this.groupBox_Make.Name = "groupBox_Make";
            this.groupBox_Make.Size = new System.Drawing.Size(267, 174);
            this.groupBox_Make.TabIndex = 40;
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
            this.textBoxPoints.Size = new System.Drawing.Size(60, 22);
            this.textBoxPoints.TabIndex = 2;
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
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(161, 40);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 11;
            // 
            // FormPolygon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1070, 500);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox_Make);
            this.Controls.Add(this.comboBoxCMD);
            this.Controls.Add(this.textBoxCMD);
            this.Controls.Add(this.buttonDeleteFridge);
            this.Controls.Add(this.groupBoxFridge);
            this.Controls.Add(this.comboBoxPolygon);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.groupBox_MoveTo);
            this.Controls.Add(this.pictureBoxPolygon);
            this.Name = "FormPolygon";
            this.Text = "FormPolygon";
            this.Load += new System.EventHandler(this.FormPolygon_Load);
            this.groupBoxFridge.ResumeLayout(false);
            this.groupBoxFridge.PerformLayout();
            this.groupBox_MoveTo.ResumeLayout(false);
            this.groupBox_MoveTo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPolygon)).EndInit();
            this.groupBox_Make.ResumeLayout(false);
            this.groupBox_Make.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCMD;
        private System.Windows.Forms.TextBox textBoxCMD;
        private System.Windows.Forms.Button buttonDeleteFridge;
        private System.Windows.Forms.GroupBox groupBoxFridge;
        private System.Windows.Forms.TextBox textBoxFridgeName;
        private System.Windows.Forms.Label labelFridgeName;
        private System.Windows.Forms.TextBox textBoxFridgeH;
        private System.Windows.Forms.TextBox textBoxFridgeW;
        private System.Windows.Forms.Label labelFridgeH;
        private System.Windows.Forms.Label labelFridgeW;
        private System.Windows.Forms.Button buttonMoveFridge;
        private System.Windows.Forms.Button buttonDrawFridge;
        private System.Windows.Forms.TextBox textBoxMoveFridgeY;
        private System.Windows.Forms.TextBox textBoxMoveFridgeX;
        private System.Windows.Forms.Label labelMoveFridgeY;
        private System.Windows.Forms.Label labelMoveFridgeX;
        private System.Windows.Forms.Label labelMoveFridge;
        private System.Windows.Forms.TextBox textBoxFridgeY;
        private System.Windows.Forms.TextBox textBoxFridgeX;
        private System.Windows.Forms.Label labelFridgeY;
        private System.Windows.Forms.Label labelFridgeX;
        private System.Windows.Forms.ComboBox comboBoxPolygon;
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
        private System.Windows.Forms.PictureBox pictureBoxPolygon;
        private System.Windows.Forms.GroupBox groupBox_Make;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Button button_enterPoint;
        private System.Windows.Forms.Button button_Make;
        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxPoints;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
    }
}