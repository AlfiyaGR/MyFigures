namespace MyFigures
{
    partial class FormSquare
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
            this.buttonDeletePresent = new System.Windows.Forms.Button();
            this.groupBoxPresent = new System.Windows.Forms.GroupBox();
            this.textBoxPresentName = new System.Windows.Forms.TextBox();
            this.labelPresentName = new System.Windows.Forms.Label();
            this.textBoxPresentW = new System.Windows.Forms.TextBox();
            this.labelPresentW = new System.Windows.Forms.Label();
            this.buttonMovePresent = new System.Windows.Forms.Button();
            this.buttonDrawPresent = new System.Windows.Forms.Button();
            this.textBoxMovePresentY = new System.Windows.Forms.TextBox();
            this.textBoxMovePresentX = new System.Windows.Forms.TextBox();
            this.labelMovePresentY = new System.Windows.Forms.Label();
            this.labelMovePresentX = new System.Windows.Forms.Label();
            this.labelMovePresent = new System.Windows.Forms.Label();
            this.textBoxPresentY = new System.Windows.Forms.TextBox();
            this.textBoxPresentX = new System.Windows.Forms.TextBox();
            this.labelPresentY = new System.Windows.Forms.Label();
            this.labelPresentX = new System.Windows.Forms.Label();
            this.comboBoxSquare = new System.Windows.Forms.ComboBox();
            this.button_Delete = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.groupBox_Change = new System.Windows.Forms.GroupBox();
            this.button_Change = new System.Windows.Forms.Button();
            this.textBoxNewW = new System.Windows.Forms.TextBox();
            this.labelNewW = new System.Windows.Forms.Label();
            this.groupBox_MoveTo = new System.Windows.Forms.GroupBox();
            this.labelMoveY = new System.Windows.Forms.Label();
            this.labelMoveX = new System.Windows.Forms.Label();
            this.button_Move = new System.Windows.Forms.Button();
            this.textBoxMoveY = new System.Windows.Forms.TextBox();
            this.textBoxMoveX = new System.Windows.Forms.TextBox();
            this.labelMove = new System.Windows.Forms.Label();
            this.pictureBoxSquare = new System.Windows.Forms.PictureBox();
            this.groupBox_Make = new System.Windows.Forms.GroupBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.button_Make = new System.Windows.Forms.Button();
            this.labelW = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxW = new System.Windows.Forms.TextBox();
            this.groupBoxPresent.SuspendLayout();
            this.groupBox_Change.SuspendLayout();
            this.groupBox_MoveTo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSquare)).BeginInit();
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
            // buttonDeletePresent
            // 
            this.buttonDeletePresent.BackColor = System.Drawing.Color.MintCream;
            this.buttonDeletePresent.Location = new System.Drawing.Point(288, 431);
            this.buttonDeletePresent.Name = "buttonDeletePresent";
            this.buttonDeletePresent.Size = new System.Drawing.Size(226, 44);
            this.buttonDeletePresent.TabIndex = 37;
            this.buttonDeletePresent.Text = "Удалить подарок";
            this.buttonDeletePresent.UseVisualStyleBackColor = false;
            // 
            // groupBoxPresent
            // 
            this.groupBoxPresent.BackColor = System.Drawing.Color.LavenderBlush;
            this.groupBoxPresent.Controls.Add(this.textBoxPresentName);
            this.groupBoxPresent.Controls.Add(this.labelPresentName);
            this.groupBoxPresent.Controls.Add(this.textBoxPresentW);
            this.groupBoxPresent.Controls.Add(this.labelPresentW);
            this.groupBoxPresent.Controls.Add(this.buttonMovePresent);
            this.groupBoxPresent.Controls.Add(this.buttonDrawPresent);
            this.groupBoxPresent.Controls.Add(this.textBoxMovePresentY);
            this.groupBoxPresent.Controls.Add(this.textBoxMovePresentX);
            this.groupBoxPresent.Controls.Add(this.labelMovePresentY);
            this.groupBoxPresent.Controls.Add(this.labelMovePresentX);
            this.groupBoxPresent.Controls.Add(this.labelMovePresent);
            this.groupBoxPresent.Controls.Add(this.textBoxPresentY);
            this.groupBoxPresent.Controls.Add(this.textBoxPresentX);
            this.groupBoxPresent.Controls.Add(this.labelPresentY);
            this.groupBoxPresent.Controls.Add(this.labelPresentX);
            this.groupBoxPresent.Location = new System.Drawing.Point(781, 193);
            this.groupBoxPresent.Name = "groupBoxPresent";
            this.groupBoxPresent.Size = new System.Drawing.Size(267, 226);
            this.groupBoxPresent.TabIndex = 36;
            this.groupBoxPresent.TabStop = false;
            this.groupBoxPresent.Text = "Подарок";
            // 
            // textBoxPresentName
            // 
            this.textBoxPresentName.Location = new System.Drawing.Point(86, 77);
            this.textBoxPresentName.Name = "textBoxPresentName";
            this.textBoxPresentName.Size = new System.Drawing.Size(175, 22);
            this.textBoxPresentName.TabIndex = 22;
            // 
            // labelPresentName
            // 
            this.labelPresentName.AutoSize = true;
            this.labelPresentName.Location = new System.Drawing.Point(5, 76);
            this.labelPresentName.Name = "labelPresentName";
            this.labelPresentName.Size = new System.Drawing.Size(71, 32);
            this.labelPresentName.TabIndex = 21;
            this.labelPresentName.Text = "Введите\r\nназвание";
            // 
            // textBoxPresentW
            // 
            this.textBoxPresentW.Location = new System.Drawing.Point(210, 21);
            this.textBoxPresentW.Name = "textBoxPresentW";
            this.textBoxPresentW.Size = new System.Drawing.Size(51, 22);
            this.textBoxPresentW.TabIndex = 19;
            // 
            // labelPresentW
            // 
            this.labelPresentW.AutoSize = true;
            this.labelPresentW.Location = new System.Drawing.Point(146, 24);
            this.labelPresentW.Name = "labelPresentW";
            this.labelPresentW.Size = new System.Drawing.Size(58, 16);
            this.labelPresentW.TabIndex = 17;
            this.labelPresentW.Text = "Ширина";
            // 
            // buttonMovePresent
            // 
            this.buttonMovePresent.BackColor = System.Drawing.Color.MintCream;
            this.buttonMovePresent.Location = new System.Drawing.Point(11, 194);
            this.buttonMovePresent.Name = "buttonMovePresent";
            this.buttonMovePresent.Size = new System.Drawing.Size(249, 27);
            this.buttonMovePresent.TabIndex = 16;
            this.buttonMovePresent.Text = "Передвинуть подарок";
            this.buttonMovePresent.UseVisualStyleBackColor = false;
            // 
            // buttonDrawPresent
            // 
            this.buttonDrawPresent.BackColor = System.Drawing.Color.MintCream;
            this.buttonDrawPresent.Location = new System.Drawing.Point(11, 161);
            this.buttonDrawPresent.Name = "buttonDrawPresent";
            this.buttonDrawPresent.Size = new System.Drawing.Size(249, 27);
            this.buttonDrawPresent.TabIndex = 15;
            this.buttonDrawPresent.Text = "Нарисовать подарок";
            this.buttonDrawPresent.UseVisualStyleBackColor = false;
            // 
            // textBoxMovePresentY
            // 
            this.textBoxMovePresentY.Location = new System.Drawing.Point(175, 133);
            this.textBoxMovePresentY.Name = "textBoxMovePresentY";
            this.textBoxMovePresentY.Size = new System.Drawing.Size(78, 22);
            this.textBoxMovePresentY.TabIndex = 15;
            // 
            // textBoxMovePresentX
            // 
            this.textBoxMovePresentX.Location = new System.Drawing.Point(48, 133);
            this.textBoxMovePresentX.Name = "textBoxMovePresentX";
            this.textBoxMovePresentX.Size = new System.Drawing.Size(78, 22);
            this.textBoxMovePresentX.TabIndex = 7;
            // 
            // labelMovePresentY
            // 
            this.labelMovePresentY.AutoSize = true;
            this.labelMovePresentY.Location = new System.Drawing.Point(132, 139);
            this.labelMovePresentY.Name = "labelMovePresentY";
            this.labelMovePresentY.Size = new System.Drawing.Size(37, 16);
            this.labelMovePresentY.TabIndex = 6;
            this.labelMovePresentY.Text = "По Y";
            // 
            // labelMovePresentX
            // 
            this.labelMovePresentX.AutoSize = true;
            this.labelMovePresentX.Location = new System.Drawing.Point(6, 139);
            this.labelMovePresentX.Name = "labelMovePresentX";
            this.labelMovePresentX.Size = new System.Drawing.Size(36, 16);
            this.labelMovePresentX.TabIndex = 5;
            this.labelMovePresentX.Text = "По X";
            // 
            // labelMovePresent
            // 
            this.labelMovePresent.AutoSize = true;
            this.labelMovePresent.Location = new System.Drawing.Point(58, 114);
            this.labelMovePresent.Name = "labelMovePresent";
            this.labelMovePresent.Size = new System.Drawing.Size(127, 16);
            this.labelMovePresent.TabIndex = 4;
            this.labelMovePresent.Text = "Сместить подарок";
            // 
            // textBoxPresentY
            // 
            this.textBoxPresentY.Location = new System.Drawing.Point(86, 49);
            this.textBoxPresentY.Name = "textBoxPresentY";
            this.textBoxPresentY.Size = new System.Drawing.Size(54, 22);
            this.textBoxPresentY.TabIndex = 3;
            // 
            // textBoxPresentX
            // 
            this.textBoxPresentX.Location = new System.Drawing.Point(86, 21);
            this.textBoxPresentX.Name = "textBoxPresentX";
            this.textBoxPresentX.Size = new System.Drawing.Size(54, 22);
            this.textBoxPresentX.TabIndex = 2;
            // 
            // labelPresentY
            // 
            this.labelPresentY.AutoSize = true;
            this.labelPresentY.Location = new System.Drawing.Point(5, 52);
            this.labelPresentY.Name = "labelPresentY";
            this.labelPresentY.Size = new System.Drawing.Size(75, 16);
            this.labelPresentY.TabIndex = 1;
            this.labelPresentY.Text = "Введите Y";
            // 
            // labelPresentX
            // 
            this.labelPresentX.AutoSize = true;
            this.labelPresentX.Location = new System.Drawing.Point(6, 24);
            this.labelPresentX.Name = "labelPresentX";
            this.labelPresentX.Size = new System.Drawing.Size(74, 16);
            this.labelPresentX.TabIndex = 0;
            this.labelPresentX.Text = "Введите X";
            // 
            // comboBoxSquare
            // 
            this.comboBoxSquare.FormattingEnabled = true;
            this.comboBoxSquare.Location = new System.Drawing.Point(13, 426);
            this.comboBoxSquare.Name = "comboBoxSquare";
            this.comboBoxSquare.Size = new System.Drawing.Size(267, 24);
            this.comboBoxSquare.TabIndex = 35;
            this.comboBoxSquare.SelectedIndexChanged += new System.EventHandler(this.comboBoxSquare_SelectedIndexChanged);
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
            this.button_Delete.Text = "Удалить квадрат";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.DeepPink;
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
            this.buttonMenu.BackColor = System.Drawing.Color.DeepPink;
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
            this.groupBox_Change.BackColor = System.Drawing.Color.LavenderBlush;
            this.groupBox_Change.Controls.Add(this.button_Change);
            this.groupBox_Change.Controls.Add(this.textBoxNewW);
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
            // textBoxNewW
            // 
            this.textBoxNewW.Location = new System.Drawing.Point(101, 46);
            this.textBoxNewW.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNewW.Name = "textBoxNewW";
            this.textBoxNewW.Size = new System.Drawing.Size(132, 22);
            this.textBoxNewW.TabIndex = 13;
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
            this.groupBox_MoveTo.BackColor = System.Drawing.Color.LavenderBlush;
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
            // pictureBoxSquare
            // 
            this.pictureBoxSquare.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSquare.Location = new System.Drawing.Point(288, 13);
            this.pictureBoxSquare.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxSquare.Name = "pictureBoxSquare";
            this.pictureBoxSquare.Size = new System.Drawing.Size(485, 406);
            this.pictureBoxSquare.TabIndex = 29;
            this.pictureBoxSquare.TabStop = false;
            // 
            // groupBox_Make
            // 
            this.groupBox_Make.BackColor = System.Drawing.Color.LavenderBlush;
            this.groupBox_Make.Controls.Add(this.textBoxName);
            this.groupBox_Make.Controls.Add(this.labelName);
            this.groupBox_Make.Controls.Add(this.button_Make);
            this.groupBox_Make.Controls.Add(this.labelW);
            this.groupBox_Make.Controls.Add(this.labelY);
            this.groupBox_Make.Controls.Add(this.labelX);
            this.groupBox_Make.Controls.Add(this.textBoxX);
            this.groupBox_Make.Controls.Add(this.textBoxY);
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
            // textBoxW
            // 
            this.textBoxW.Location = new System.Drawing.Point(90, 79);
            this.textBoxW.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxW.Name = "textBoxW";
            this.textBoxW.Size = new System.Drawing.Size(50, 22);
            this.textBoxW.TabIndex = 2;
            // 
            // FormSquare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(1064, 490);
            this.ControlBox = false;
            this.Controls.Add(this.comboBoxCMD);
            this.Controls.Add(this.textBoxCMD);
            this.Controls.Add(this.buttonDeletePresent);
            this.Controls.Add(this.groupBoxPresent);
            this.Controls.Add(this.comboBoxSquare);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.groupBox_Change);
            this.Controls.Add(this.groupBox_MoveTo);
            this.Controls.Add(this.pictureBoxSquare);
            this.Controls.Add(this.groupBox_Make);
            this.Name = "FormSquare";
            this.Text = "FormSquare";
            this.Load += new System.EventHandler(this.FormSquare_Load);
            this.groupBoxPresent.ResumeLayout(false);
            this.groupBoxPresent.PerformLayout();
            this.groupBox_Change.ResumeLayout(false);
            this.groupBox_Change.PerformLayout();
            this.groupBox_MoveTo.ResumeLayout(false);
            this.groupBox_MoveTo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSquare)).EndInit();
            this.groupBox_Make.ResumeLayout(false);
            this.groupBox_Make.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCMD;
        private System.Windows.Forms.TextBox textBoxCMD;
        private System.Windows.Forms.Button buttonDeletePresent;
        private System.Windows.Forms.GroupBox groupBoxPresent;
        private System.Windows.Forms.TextBox textBoxPresentName;
        private System.Windows.Forms.Label labelPresentName;
        private System.Windows.Forms.TextBox textBoxPresentW;
        private System.Windows.Forms.Label labelPresentW;
        private System.Windows.Forms.Button buttonMovePresent;
        private System.Windows.Forms.Button buttonDrawPresent;
        private System.Windows.Forms.TextBox textBoxMovePresentY;
        private System.Windows.Forms.TextBox textBoxMovePresentX;
        private System.Windows.Forms.Label labelMovePresentY;
        private System.Windows.Forms.Label labelMovePresentX;
        private System.Windows.Forms.Label labelMovePresent;
        private System.Windows.Forms.TextBox textBoxPresentY;
        private System.Windows.Forms.TextBox textBoxPresentX;
        private System.Windows.Forms.Label labelPresentY;
        private System.Windows.Forms.Label labelPresentX;
        private System.Windows.Forms.ComboBox comboBoxSquare;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.GroupBox groupBox_Change;
        private System.Windows.Forms.Button button_Change;
        private System.Windows.Forms.TextBox textBoxNewW;
        private System.Windows.Forms.Label labelNewW;
        private System.Windows.Forms.GroupBox groupBox_MoveTo;
        private System.Windows.Forms.Label labelMoveY;
        private System.Windows.Forms.Label labelMoveX;
        private System.Windows.Forms.Button button_Move;
        private System.Windows.Forms.TextBox textBoxMoveY;
        private System.Windows.Forms.TextBox textBoxMoveX;
        private System.Windows.Forms.Label labelMove;
        private System.Windows.Forms.PictureBox pictureBoxSquare;
        private System.Windows.Forms.GroupBox groupBox_Make;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button button_Make;
        private System.Windows.Forms.Label labelW;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxW;
    }
}