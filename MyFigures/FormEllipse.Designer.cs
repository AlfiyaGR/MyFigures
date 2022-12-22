namespace MyFigures
{
    partial class FormEllipse
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
            this.buttonDeleteFlower = new System.Windows.Forms.Button();
            this.groupBoxFlower = new System.Windows.Forms.GroupBox();
            this.textBoxFlowerName = new System.Windows.Forms.TextBox();
            this.labelFlowerName = new System.Windows.Forms.Label();
            this.textBoxFlowerH = new System.Windows.Forms.TextBox();
            this.textBoxFlowerW = new System.Windows.Forms.TextBox();
            this.labelFlowerH = new System.Windows.Forms.Label();
            this.labelFlowerW = new System.Windows.Forms.Label();
            this.buttonMoveFlower = new System.Windows.Forms.Button();
            this.buttonDrawFlower = new System.Windows.Forms.Button();
            this.textBoxMoveFlowerY = new System.Windows.Forms.TextBox();
            this.textBoxMoveFlowerX = new System.Windows.Forms.TextBox();
            this.labelMoveFlowerY = new System.Windows.Forms.Label();
            this.labelMoveFlowerX = new System.Windows.Forms.Label();
            this.labelMoveFlower = new System.Windows.Forms.Label();
            this.textBoxFlowerY = new System.Windows.Forms.TextBox();
            this.textBoxFlowerX = new System.Windows.Forms.TextBox();
            this.labelFlowerY = new System.Windows.Forms.Label();
            this.labelFlowerX = new System.Windows.Forms.Label();
            this.comboBoxEllipse = new System.Windows.Forms.ComboBox();
            this.button_Delete = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.groupBox_Change = new System.Windows.Forms.GroupBox();
            this.button_Change = new System.Windows.Forms.Button();
            this.textBoxNewH = new System.Windows.Forms.TextBox();
            this.textBoxNewW = new System.Windows.Forms.TextBox();
            this.labelNewH = new System.Windows.Forms.Label();
            this.labelNewW = new System.Windows.Forms.Label();
            this.groupBox_MoveTo = new System.Windows.Forms.GroupBox();
            this.labelMoveY = new System.Windows.Forms.Label();
            this.labelMoveX = new System.Windows.Forms.Label();
            this.button_Move = new System.Windows.Forms.Button();
            this.textBoxMoveY = new System.Windows.Forms.TextBox();
            this.textBoxMoveX = new System.Windows.Forms.TextBox();
            this.labelMove = new System.Windows.Forms.Label();
            this.pictureBoxEllipse = new System.Windows.Forms.PictureBox();
            this.groupBox_Make = new System.Windows.Forms.GroupBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.button_Make = new System.Windows.Forms.Button();
            this.labelH = new System.Windows.Forms.Label();
            this.labelW = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.textBoxW = new System.Windows.Forms.TextBox();
            this.groupBoxFlower.SuspendLayout();
            this.groupBox_Change.SuspendLayout();
            this.groupBox_MoveTo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEllipse)).BeginInit();
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
            // buttonDeleteFlower
            // 
            this.buttonDeleteFlower.BackColor = System.Drawing.Color.MintCream;
            this.buttonDeleteFlower.Location = new System.Drawing.Point(288, 431);
            this.buttonDeleteFlower.Name = "buttonDeleteFlower";
            this.buttonDeleteFlower.Size = new System.Drawing.Size(226, 44);
            this.buttonDeleteFlower.TabIndex = 37;
            this.buttonDeleteFlower.Text = "Удалить цветок";
            this.buttonDeleteFlower.UseVisualStyleBackColor = false;
            // 
            // groupBoxFlower
            // 
            this.groupBoxFlower.BackColor = System.Drawing.Color.Bisque;
            this.groupBoxFlower.Controls.Add(this.textBoxFlowerName);
            this.groupBoxFlower.Controls.Add(this.labelFlowerName);
            this.groupBoxFlower.Controls.Add(this.textBoxFlowerH);
            this.groupBoxFlower.Controls.Add(this.textBoxFlowerW);
            this.groupBoxFlower.Controls.Add(this.labelFlowerH);
            this.groupBoxFlower.Controls.Add(this.labelFlowerW);
            this.groupBoxFlower.Controls.Add(this.buttonMoveFlower);
            this.groupBoxFlower.Controls.Add(this.buttonDrawFlower);
            this.groupBoxFlower.Controls.Add(this.textBoxMoveFlowerY);
            this.groupBoxFlower.Controls.Add(this.textBoxMoveFlowerX);
            this.groupBoxFlower.Controls.Add(this.labelMoveFlowerY);
            this.groupBoxFlower.Controls.Add(this.labelMoveFlowerX);
            this.groupBoxFlower.Controls.Add(this.labelMoveFlower);
            this.groupBoxFlower.Controls.Add(this.textBoxFlowerY);
            this.groupBoxFlower.Controls.Add(this.textBoxFlowerX);
            this.groupBoxFlower.Controls.Add(this.labelFlowerY);
            this.groupBoxFlower.Controls.Add(this.labelFlowerX);
            this.groupBoxFlower.Location = new System.Drawing.Point(781, 193);
            this.groupBoxFlower.Name = "groupBoxFlower";
            this.groupBoxFlower.Size = new System.Drawing.Size(267, 226);
            this.groupBoxFlower.TabIndex = 36;
            this.groupBoxFlower.TabStop = false;
            this.groupBoxFlower.Text = "Холодильник";
            // 
            // textBoxFlowerName
            // 
            this.textBoxFlowerName.Location = new System.Drawing.Point(86, 77);
            this.textBoxFlowerName.Name = "textBoxFlowerName";
            this.textBoxFlowerName.Size = new System.Drawing.Size(175, 22);
            this.textBoxFlowerName.TabIndex = 22;
            // 
            // labelFlowerName
            // 
            this.labelFlowerName.AutoSize = true;
            this.labelFlowerName.Location = new System.Drawing.Point(5, 76);
            this.labelFlowerName.Name = "labelFlowerName";
            this.labelFlowerName.Size = new System.Drawing.Size(71, 32);
            this.labelFlowerName.TabIndex = 21;
            this.labelFlowerName.Text = "Введите\r\nназвание";
            // 
            // textBoxFlowerH
            // 
            this.textBoxFlowerH.Location = new System.Drawing.Point(210, 49);
            this.textBoxFlowerH.Name = "textBoxFlowerH";
            this.textBoxFlowerH.Size = new System.Drawing.Size(51, 22);
            this.textBoxFlowerH.TabIndex = 20;
            // 
            // textBoxFlowerW
            // 
            this.textBoxFlowerW.Location = new System.Drawing.Point(210, 21);
            this.textBoxFlowerW.Name = "textBoxFlowerW";
            this.textBoxFlowerW.Size = new System.Drawing.Size(51, 22);
            this.textBoxFlowerW.TabIndex = 19;
            // 
            // labelFlowerH
            // 
            this.labelFlowerH.AutoSize = true;
            this.labelFlowerH.Location = new System.Drawing.Point(146, 52);
            this.labelFlowerH.Name = "labelFlowerH";
            this.labelFlowerH.Size = new System.Drawing.Size(48, 16);
            this.labelFlowerH.TabIndex = 18;
            this.labelFlowerH.Text = "Длина";
            // 
            // labelFlowerW
            // 
            this.labelFlowerW.AutoSize = true;
            this.labelFlowerW.Location = new System.Drawing.Point(146, 24);
            this.labelFlowerW.Name = "labelFlowerW";
            this.labelFlowerW.Size = new System.Drawing.Size(58, 16);
            this.labelFlowerW.TabIndex = 17;
            this.labelFlowerW.Text = "Ширина";
            // 
            // buttonMoveFlower
            // 
            this.buttonMoveFlower.BackColor = System.Drawing.Color.MintCream;
            this.buttonMoveFlower.Location = new System.Drawing.Point(11, 194);
            this.buttonMoveFlower.Name = "buttonMoveFlower";
            this.buttonMoveFlower.Size = new System.Drawing.Size(249, 27);
            this.buttonMoveFlower.TabIndex = 16;
            this.buttonMoveFlower.Text = "Передвинуть холодильник";
            this.buttonMoveFlower.UseVisualStyleBackColor = false;
            // 
            // buttonDrawFlower
            // 
            this.buttonDrawFlower.BackColor = System.Drawing.Color.MintCream;
            this.buttonDrawFlower.Location = new System.Drawing.Point(11, 161);
            this.buttonDrawFlower.Name = "buttonDrawFlower";
            this.buttonDrawFlower.Size = new System.Drawing.Size(249, 27);
            this.buttonDrawFlower.TabIndex = 15;
            this.buttonDrawFlower.Text = "Нарисовать холодильник";
            this.buttonDrawFlower.UseVisualStyleBackColor = false;
            // 
            // textBoxMoveFlowerY
            // 
            this.textBoxMoveFlowerY.Location = new System.Drawing.Point(175, 133);
            this.textBoxMoveFlowerY.Name = "textBoxMoveFlowerY";
            this.textBoxMoveFlowerY.Size = new System.Drawing.Size(78, 22);
            this.textBoxMoveFlowerY.TabIndex = 15;
            // 
            // textBoxMoveFlowerX
            // 
            this.textBoxMoveFlowerX.Location = new System.Drawing.Point(48, 133);
            this.textBoxMoveFlowerX.Name = "textBoxMoveFlowerX";
            this.textBoxMoveFlowerX.Size = new System.Drawing.Size(78, 22);
            this.textBoxMoveFlowerX.TabIndex = 7;
            // 
            // labelMoveFlowerY
            // 
            this.labelMoveFlowerY.AutoSize = true;
            this.labelMoveFlowerY.Location = new System.Drawing.Point(132, 139);
            this.labelMoveFlowerY.Name = "labelMoveFlowerY";
            this.labelMoveFlowerY.Size = new System.Drawing.Size(37, 16);
            this.labelMoveFlowerY.TabIndex = 6;
            this.labelMoveFlowerY.Text = "По Y";
            // 
            // labelMoveFlowerX
            // 
            this.labelMoveFlowerX.AutoSize = true;
            this.labelMoveFlowerX.Location = new System.Drawing.Point(6, 139);
            this.labelMoveFlowerX.Name = "labelMoveFlowerX";
            this.labelMoveFlowerX.Size = new System.Drawing.Size(36, 16);
            this.labelMoveFlowerX.TabIndex = 5;
            this.labelMoveFlowerX.Text = "По X";
            // 
            // labelMoveFlower
            // 
            this.labelMoveFlower.AutoSize = true;
            this.labelMoveFlower.Location = new System.Drawing.Point(58, 114);
            this.labelMoveFlower.Name = "labelMoveFlower";
            this.labelMoveFlower.Size = new System.Drawing.Size(156, 16);
            this.labelMoveFlower.TabIndex = 4;
            this.labelMoveFlower.Text = "Сместить холодильник";
            // 
            // textBoxFlowerY
            // 
            this.textBoxFlowerY.Location = new System.Drawing.Point(86, 49);
            this.textBoxFlowerY.Name = "textBoxFlowerY";
            this.textBoxFlowerY.Size = new System.Drawing.Size(54, 22);
            this.textBoxFlowerY.TabIndex = 3;
            // 
            // textBoxFlowerX
            // 
            this.textBoxFlowerX.Location = new System.Drawing.Point(86, 21);
            this.textBoxFlowerX.Name = "textBoxFlowerX";
            this.textBoxFlowerX.Size = new System.Drawing.Size(54, 22);
            this.textBoxFlowerX.TabIndex = 2;
            // 
            // labelFlowerY
            // 
            this.labelFlowerY.AutoSize = true;
            this.labelFlowerY.Location = new System.Drawing.Point(5, 52);
            this.labelFlowerY.Name = "labelFlowerY";
            this.labelFlowerY.Size = new System.Drawing.Size(75, 16);
            this.labelFlowerY.TabIndex = 1;
            this.labelFlowerY.Text = "Введите Y";
            // 
            // labelFlowerX
            // 
            this.labelFlowerX.AutoSize = true;
            this.labelFlowerX.Location = new System.Drawing.Point(6, 24);
            this.labelFlowerX.Name = "labelFlowerX";
            this.labelFlowerX.Size = new System.Drawing.Size(74, 16);
            this.labelFlowerX.TabIndex = 0;
            this.labelFlowerX.Text = "Введите X";
            // 
            // comboBoxEllipse
            // 
            this.comboBoxEllipse.FormattingEnabled = true;
            this.comboBoxEllipse.Location = new System.Drawing.Point(13, 426);
            this.comboBoxEllipse.Name = "comboBoxEllipse";
            this.comboBoxEllipse.Size = new System.Drawing.Size(267, 24);
            this.comboBoxEllipse.TabIndex = 35;
            this.comboBoxEllipse.SelectedIndexChanged += new System.EventHandler(this.comboBoxEllipse_SelectedIndexChanged);
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
            this.button_Delete.Text = "Удалить эллипс";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Chocolate;
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
            this.buttonMenu.BackColor = System.Drawing.Color.Chocolate;
            this.buttonMenu.Location = new System.Drawing.Point(929, 442);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(119, 38);
            this.buttonMenu.TabIndex = 32;
            this.buttonMenu.Text = "Меню";
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // groupBox_Change
            // 
            this.groupBox_Change.BackColor = System.Drawing.Color.Bisque;
            this.groupBox_Change.Controls.Add(this.button_Change);
            this.groupBox_Change.Controls.Add(this.textBoxNewH);
            this.groupBox_Change.Controls.Add(this.textBoxNewW);
            this.groupBox_Change.Controls.Add(this.labelNewH);
            this.groupBox_Change.Controls.Add(this.labelNewW);
            this.groupBox_Change.Location = new System.Drawing.Point(13, 220);
            this.groupBox_Change.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_Change.Name = "groupBox_Change";
            this.groupBox_Change.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_Change.Size = new System.Drawing.Size(267, 199);
            this.groupBox_Change.TabIndex = 31;
            this.groupBox_Change.TabStop = false;
            this.groupBox_Change.Text = "Изменить";
            // 
            // button_Change
            // 
            this.button_Change.BackColor = System.Drawing.Color.MintCream;
            this.button_Change.Location = new System.Drawing.Point(8, 164);
            this.button_Change.Margin = new System.Windows.Forms.Padding(4);
            this.button_Change.Name = "button_Change";
            this.button_Change.Size = new System.Drawing.Size(251, 28);
            this.button_Change.TabIndex = 13;
            this.button_Change.Text = "Изменить размеры";
            this.button_Change.UseVisualStyleBackColor = false;
            this.button_Change.Click += new System.EventHandler(this.button_Change_Click);
            // 
            // textBoxNewH
            // 
            this.textBoxNewH.Location = new System.Drawing.Point(101, 89);
            this.textBoxNewH.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNewH.Name = "textBoxNewH";
            this.textBoxNewH.Size = new System.Drawing.Size(132, 22);
            this.textBoxNewH.TabIndex = 13;
            // 
            // textBoxNewW
            // 
            this.textBoxNewW.Location = new System.Drawing.Point(101, 46);
            this.textBoxNewW.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNewW.Name = "textBoxNewW";
            this.textBoxNewW.Size = new System.Drawing.Size(132, 22);
            this.textBoxNewW.TabIndex = 13;
            // 
            // labelNewH
            // 
            this.labelNewH.AutoSize = true;
            this.labelNewH.Location = new System.Drawing.Point(20, 92);
            this.labelNewH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNewH.Name = "labelNewH";
            this.labelNewH.Size = new System.Drawing.Size(48, 16);
            this.labelNewH.TabIndex = 13;
            this.labelNewH.Text = "Длина";
            // 
            // labelNewW
            // 
            this.labelNewW.AutoSize = true;
            this.labelNewW.Location = new System.Drawing.Point(20, 49);
            this.labelNewW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNewW.Name = "labelNewW";
            this.labelNewW.Size = new System.Drawing.Size(58, 16);
            this.labelNewW.TabIndex = 13;
            this.labelNewW.Text = "Ширина";
            // 
            // groupBox_MoveTo
            // 
            this.groupBox_MoveTo.BackColor = System.Drawing.Color.Bisque;
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
            // pictureBoxEllipse
            // 
            this.pictureBoxEllipse.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEllipse.Location = new System.Drawing.Point(288, 13);
            this.pictureBoxEllipse.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxEllipse.Name = "pictureBoxEllipse";
            this.pictureBoxEllipse.Size = new System.Drawing.Size(485, 406);
            this.pictureBoxEllipse.TabIndex = 29;
            this.pictureBoxEllipse.TabStop = false;
            // 
            // groupBox_Make
            // 
            this.groupBox_Make.BackColor = System.Drawing.Color.Bisque;
            this.groupBox_Make.Controls.Add(this.textBoxName);
            this.groupBox_Make.Controls.Add(this.labelName);
            this.groupBox_Make.Controls.Add(this.button_Make);
            this.groupBox_Make.Controls.Add(this.labelH);
            this.groupBox_Make.Controls.Add(this.labelW);
            this.groupBox_Make.Controls.Add(this.labelY);
            this.groupBox_Make.Controls.Add(this.labelX);
            this.groupBox_Make.Controls.Add(this.textBoxX);
            this.groupBox_Make.Controls.Add(this.textBoxY);
            this.groupBox_Make.Controls.Add(this.textBoxH);
            this.groupBox_Make.Controls.Add(this.textBoxW);
            this.groupBox_Make.Location = new System.Drawing.Point(781, 13);
            this.groupBox_Make.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_Make.Name = "groupBox_Make";
            this.groupBox_Make.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_Make.Size = new System.Drawing.Size(267, 173);
            this.groupBox_Make.TabIndex = 28;
            this.groupBox_Make.TabStop = false;
            this.groupBox_Make.Text = "Создание";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(157, 82);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 10;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(172, 42);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(71, 32);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "Введите \r\nназвание";
            // 
            // button_Make
            // 
            this.button_Make.BackColor = System.Drawing.Color.MintCream;
            this.button_Make.Location = new System.Drawing.Point(7, 136);
            this.button_Make.Margin = new System.Windows.Forms.Padding(4);
            this.button_Make.Name = "button_Make";
            this.button_Make.Size = new System.Drawing.Size(251, 28);
            this.button_Make.TabIndex = 8;
            this.button_Make.Text = "Создать фигуру";
            this.button_Make.UseVisualStyleBackColor = false;
            this.button_Make.Click += new System.EventHandler(this.button_Make_Click);
            // 
            // labelH
            // 
            this.labelH.AutoSize = true;
            this.labelH.Location = new System.Drawing.Point(8, 109);
            this.labelH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(48, 16);
            this.labelH.TabIndex = 7;
            this.labelH.Text = "Длина";
            // 
            // labelW
            // 
            this.labelW.AutoSize = true;
            this.labelW.Location = new System.Drawing.Point(8, 82);
            this.labelW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelW.Name = "labelW";
            this.labelW.Size = new System.Drawing.Size(58, 16);
            this.labelW.TabIndex = 6;
            this.labelW.Text = "Ширина";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(8, 55);
            this.labelY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(75, 16);
            this.labelY.TabIndex = 5;
            this.labelY.Text = "Введите Y";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(8, 27);
            this.labelX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(74, 16);
            this.labelX.TabIndex = 4;
            this.labelX.Text = "Введите X";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(90, 24);
            this.textBoxX.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(50, 22);
            this.textBoxX.TabIndex = 0;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(90, 52);
            this.textBoxY.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(50, 22);
            this.textBoxY.TabIndex = 1;
            // 
            // textBoxH
            // 
            this.textBoxH.Location = new System.Drawing.Point(90, 106);
            this.textBoxH.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.Size = new System.Drawing.Size(50, 22);
            this.textBoxH.TabIndex = 3;
            // 
            // textBoxW
            // 
            this.textBoxW.Location = new System.Drawing.Point(90, 79);
            this.textBoxW.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxW.Name = "textBoxW";
            this.textBoxW.Size = new System.Drawing.Size(50, 22);
            this.textBoxW.TabIndex = 2;
            // 
            // FormEllipse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1069, 491);
            this.ControlBox = false;
            this.Controls.Add(this.comboBoxCMD);
            this.Controls.Add(this.textBoxCMD);
            this.Controls.Add(this.buttonDeleteFlower);
            this.Controls.Add(this.groupBoxFlower);
            this.Controls.Add(this.comboBoxEllipse);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.groupBox_Change);
            this.Controls.Add(this.groupBox_MoveTo);
            this.Controls.Add(this.pictureBoxEllipse);
            this.Controls.Add(this.groupBox_Make);
            this.Name = "FormEllipse";
            this.Text = "FormEllipse";
            this.Load += new System.EventHandler(this.FormEllipse_Load);
            this.groupBoxFlower.ResumeLayout(false);
            this.groupBoxFlower.PerformLayout();
            this.groupBox_Change.ResumeLayout(false);
            this.groupBox_Change.PerformLayout();
            this.groupBox_MoveTo.ResumeLayout(false);
            this.groupBox_MoveTo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEllipse)).EndInit();
            this.groupBox_Make.ResumeLayout(false);
            this.groupBox_Make.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCMD;
        private System.Windows.Forms.TextBox textBoxCMD;
        private System.Windows.Forms.Button buttonDeleteFlower;
        private System.Windows.Forms.GroupBox groupBoxFlower;
        private System.Windows.Forms.TextBox textBoxFlowerName;
        private System.Windows.Forms.Label labelFlowerName;
        private System.Windows.Forms.TextBox textBoxFlowerH;
        private System.Windows.Forms.TextBox textBoxFlowerW;
        private System.Windows.Forms.Label labelFlowerH;
        private System.Windows.Forms.Label labelFlowerW;
        private System.Windows.Forms.Button buttonMoveFlower;
        private System.Windows.Forms.Button buttonDrawFlower;
        private System.Windows.Forms.TextBox textBoxMoveFlowerY;
        private System.Windows.Forms.TextBox textBoxMoveFlowerX;
        private System.Windows.Forms.Label labelMoveFlowerY;
        private System.Windows.Forms.Label labelMoveFlowerX;
        private System.Windows.Forms.Label labelMoveFlower;
        private System.Windows.Forms.TextBox textBoxFlowerY;
        private System.Windows.Forms.TextBox textBoxFlowerX;
        private System.Windows.Forms.Label labelFlowerY;
        private System.Windows.Forms.Label labelFlowerX;
        private System.Windows.Forms.ComboBox comboBoxEllipse;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.GroupBox groupBox_Change;
        private System.Windows.Forms.Button button_Change;
        private System.Windows.Forms.TextBox textBoxNewH;
        private System.Windows.Forms.TextBox textBoxNewW;
        private System.Windows.Forms.Label labelNewH;
        private System.Windows.Forms.Label labelNewW;
        private System.Windows.Forms.GroupBox groupBox_MoveTo;
        private System.Windows.Forms.Label labelMoveY;
        private System.Windows.Forms.Label labelMoveX;
        private System.Windows.Forms.Button button_Move;
        private System.Windows.Forms.TextBox textBoxMoveY;
        private System.Windows.Forms.TextBox textBoxMoveX;
        private System.Windows.Forms.Label labelMove;
        private System.Windows.Forms.PictureBox pictureBoxEllipse;
        private System.Windows.Forms.GroupBox groupBox_Make;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button button_Make;
        private System.Windows.Forms.Label labelH;
        private System.Windows.Forms.Label labelW;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxH;
        private System.Windows.Forms.TextBox textBoxW;
    }
}