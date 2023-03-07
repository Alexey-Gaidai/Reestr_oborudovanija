namespace ReestrClient
{
    partial class FormReestr
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
            this.treeViewDeprecation = new System.Windows.Forms.TreeView();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxStorage = new System.Windows.Forms.ComboBox();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxUsages = new System.Windows.Forms.ComboBox();
            this.comboBoxAccounting = new System.Windows.Forms.ComboBox();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.richTextBoxRequired = new System.Windows.Forms.RichTextBox();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxTransferTo = new System.Windows.Forms.TextBox();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxListCount = new System.Windows.Forms.TextBox();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxFactCount = new System.Windows.Forms.TextBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxResidualValue = new System.Windows.Forms.TextBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxDeprecation = new System.Windows.Forms.TextBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxBalanceValue = new System.Windows.Forms.TextBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxInventoryNumber = new System.Windows.Forms.TextBox();
            this.materialLabelAccounting = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxNameInList = new System.Windows.Forms.TextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.materialButtonUpdate = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonDelete = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButtonCreate = new MaterialSkin.Controls.MaterialButton();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewDeprecation
            // 
            this.treeViewDeprecation.Location = new System.Drawing.Point(3, 130);
            this.treeViewDeprecation.Name = "treeViewDeprecation";
            this.treeViewDeprecation.Size = new System.Drawing.Size(519, 527);
            this.treeViewDeprecation.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(6, 97);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(114, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Оборудование:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.обновитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 64);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1124, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.обновитьToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxStorage);
            this.groupBox1.Controls.Add(this.comboBoxState);
            this.groupBox1.Controls.Add(this.comboBoxStatus);
            this.groupBox1.Controls.Add(this.comboBoxUsages);
            this.groupBox1.Controls.Add(this.comboBoxAccounting);
            this.groupBox1.Controls.Add(this.materialLabel16);
            this.groupBox1.Controls.Add(this.richTextBoxRequired);
            this.groupBox1.Controls.Add(this.materialLabel15);
            this.groupBox1.Controls.Add(this.materialLabel14);
            this.groupBox1.Controls.Add(this.textBoxTransferTo);
            this.groupBox1.Controls.Add(this.materialLabel13);
            this.groupBox1.Controls.Add(this.materialLabel5);
            this.groupBox1.Controls.Add(this.materialLabel12);
            this.groupBox1.Controls.Add(this.materialLabel11);
            this.groupBox1.Controls.Add(this.textBoxListCount);
            this.groupBox1.Controls.Add(this.materialLabel10);
            this.groupBox1.Controls.Add(this.textBoxFactCount);
            this.groupBox1.Controls.Add(this.materialLabel9);
            this.groupBox1.Controls.Add(this.textBoxResidualValue);
            this.groupBox1.Controls.Add(this.materialLabel8);
            this.groupBox1.Controls.Add(this.textBoxDeprecation);
            this.groupBox1.Controls.Add(this.materialLabel7);
            this.groupBox1.Controls.Add(this.textBoxBalanceValue);
            this.groupBox1.Controls.Add(this.materialLabel6);
            this.groupBox1.Controls.Add(this.textBoxInventoryNumber);
            this.groupBox1.Controls.Add(this.materialLabelAccounting);
            this.groupBox1.Controls.Add(this.materialLabel4);
            this.groupBox1.Controls.Add(this.textBoxNameInList);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.materialButtonUpdate);
            this.groupBox1.Controls.Add(this.materialButtonDelete);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.materialButtonCreate);
            this.groupBox1.Controls.Add(this.textBoxID);
            this.groupBox1.Location = new System.Drawing.Point(528, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 560);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Создание/Изменение/Удаление";
            // 
            // comboBoxStorage
            // 
            this.comboBoxStorage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStorage.FormattingEnabled = true;
            this.comboBoxStorage.Location = new System.Drawing.Point(435, 225);
            this.comboBoxStorage.Name = "comboBoxStorage";
            this.comboBoxStorage.Size = new System.Drawing.Size(158, 23);
            this.comboBoxStorage.TabIndex = 40;
            // 
            // comboBoxState
            // 
            this.comboBoxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Location = new System.Drawing.Point(393, 167);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(200, 23);
            this.comboBoxState.TabIndex = 39;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(365, 196);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(228, 23);
            this.comboBoxStatus.TabIndex = 38;
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatus_SelectedIndexChanged);
            this.comboBoxStatus.SelectedValueChanged += new System.EventHandler(this.comboBoxStatus_SelectedValueChanged);
            // 
            // comboBoxUsages
            // 
            this.comboBoxUsages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUsages.FormattingEnabled = true;
            this.comboBoxUsages.Location = new System.Drawing.Point(197, 196);
            this.comboBoxUsages.Name = "comboBoxUsages";
            this.comboBoxUsages.Size = new System.Drawing.Size(100, 23);
            this.comboBoxUsages.TabIndex = 37;
            // 
            // comboBoxAccounting
            // 
            this.comboBoxAccounting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccounting.FormattingEnabled = true;
            this.comboBoxAccounting.Location = new System.Drawing.Point(513, 51);
            this.comboBoxAccounting.Name = "comboBoxAccounting";
            this.comboBoxAccounting.Size = new System.Drawing.Size(80, 23);
            this.comboBoxAccounting.TabIndex = 36;
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel16.Location = new System.Drawing.Point(303, 227);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(126, 19);
            this.materialLabel16.TabIndex = 35;
            this.materialLabel16.Text = "Место хранения:";
            // 
            // richTextBoxRequired
            // 
            this.richTextBoxRequired.Location = new System.Drawing.Point(7, 278);
            this.richTextBoxRequired.Name = "richTextBoxRequired";
            this.richTextBoxRequired.Size = new System.Drawing.Size(586, 234);
            this.richTextBoxRequired.TabIndex = 33;
            this.richTextBoxRequired.Text = "";
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel15.Location = new System.Drawing.Point(7, 256);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(112, 19);
            this.materialLabel15.TabIndex = 32;
            this.materialLabel15.Text = "Что требуется:";
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel14.Location = new System.Drawing.Point(7, 227);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(116, 19);
            this.materialLabel14.TabIndex = 30;
            this.materialLabel14.Text = "Куда передать:";
            // 
            // textBoxTransferTo
            // 
            this.textBoxTransferTo.Enabled = false;
            this.textBoxTransferTo.Location = new System.Drawing.Point(129, 225);
            this.textBoxTransferTo.Name = "textBoxTransferTo";
            this.textBoxTransferTo.Size = new System.Drawing.Size(168, 23);
            this.textBoxTransferTo.TabIndex = 29;
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.Location = new System.Drawing.Point(303, 200);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(56, 19);
            this.materialLabel13.TabIndex = 28;
            this.materialLabel13.Text = "Статус:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(5, 198);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(190, 19);
            this.materialLabel5.TabIndex = 26;
            this.materialLabel5.Text = "Использование в работе:";
            this.materialLabel5.Click += new System.EventHandler(this.materialLabel5_Click);
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.Location = new System.Drawing.Point(303, 169);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(84, 19);
            this.materialLabel12.TabIndex = 24;
            this.materialLabel12.Text = "Состояние:";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(303, 140);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(186, 19);
            this.materialLabel11.TabIndex = 22;
            this.materialLabel11.Text = "Количество(ведомость):";
            // 
            // textBoxListCount
            // 
            this.textBoxListCount.Location = new System.Drawing.Point(495, 138);
            this.textBoxListCount.Name = "textBoxListCount";
            this.textBoxListCount.Size = new System.Drawing.Size(98, 23);
            this.textBoxListCount.TabIndex = 21;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(303, 111);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(142, 19);
            this.materialLabel10.TabIndex = 20;
            this.materialLabel10.Text = "Количество(факт):";
            // 
            // textBoxFactCount
            // 
            this.textBoxFactCount.Location = new System.Drawing.Point(451, 109);
            this.textBoxFactCount.Name = "textBoxFactCount";
            this.textBoxFactCount.Size = new System.Drawing.Size(142, 23);
            this.textBoxFactCount.TabIndex = 19;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(6, 169);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(178, 19);
            this.materialLabel9.TabIndex = 18;
            this.materialLabel9.Text = "Остаточная стоимость:";
            // 
            // textBoxResidualValue
            // 
            this.textBoxResidualValue.Location = new System.Drawing.Point(190, 167);
            this.textBoxResidualValue.Name = "textBoxResidualValue";
            this.textBoxResidualValue.Size = new System.Drawing.Size(107, 23);
            this.textBoxResidualValue.TabIndex = 17;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(6, 140);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(160, 19);
            this.materialLabel8.TabIndex = 16;
            this.materialLabel8.Text = "Сумма амортизации:";
            // 
            // textBoxDeprecation
            // 
            this.textBoxDeprecation.Location = new System.Drawing.Point(170, 138);
            this.textBoxDeprecation.Name = "textBoxDeprecation";
            this.textBoxDeprecation.Size = new System.Drawing.Size(127, 23);
            this.textBoxDeprecation.TabIndex = 15;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(5, 109);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(179, 19);
            this.materialLabel7.TabIndex = 14;
            this.materialLabel7.Text = "Балансовая стоимость:";
            // 
            // textBoxBalanceValue
            // 
            this.textBoxBalanceValue.Location = new System.Drawing.Point(190, 109);
            this.textBoxBalanceValue.Name = "textBoxBalanceValue";
            this.textBoxBalanceValue.Size = new System.Drawing.Size(107, 23);
            this.textBoxBalanceValue.TabIndex = 13;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(6, 80);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(158, 19);
            this.materialLabel6.TabIndex = 12;
            this.materialLabel6.Text = "Инвентарный номер:";
            // 
            // textBoxInventoryNumber
            // 
            this.textBoxInventoryNumber.Location = new System.Drawing.Point(170, 80);
            this.textBoxInventoryNumber.Name = "textBoxInventoryNumber";
            this.textBoxInventoryNumber.Size = new System.Drawing.Size(423, 23);
            this.textBoxInventoryNumber.TabIndex = 11;
            // 
            // materialLabelAccounting
            // 
            this.materialLabelAccounting.AutoSize = true;
            this.materialLabelAccounting.Depth = 0;
            this.materialLabelAccounting.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelAccounting.Location = new System.Drawing.Point(410, 53);
            this.materialLabelAccounting.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelAccounting.Name = "materialLabelAccounting";
            this.materialLabelAccounting.Size = new System.Drawing.Size(97, 19);
            this.materialLabelAccounting.TabIndex = 10;
            this.materialLabelAccounting.Text = "Учет/неучет:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(6, 53);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(185, 19);
            this.materialLabel4.TabIndex = 8;
            this.materialLabel4.Text = "Название по ведомости:";
            // 
            // textBoxNameInList
            // 
            this.textBoxNameInList.Location = new System.Drawing.Point(197, 51);
            this.textBoxNameInList.Name = "textBoxNameInList";
            this.textBoxNameInList.Size = new System.Drawing.Size(205, 23);
            this.textBoxNameInList.TabIndex = 7;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(109, 24);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(77, 19);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "Название:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(192, 22);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(401, 23);
            this.textBoxName.TabIndex = 5;
            // 
            // materialButtonUpdate
            // 
            this.materialButtonUpdate.AutoSize = false;
            this.materialButtonUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonUpdate.Depth = 0;
            this.materialButtonUpdate.HighEmphasis = true;
            this.materialButtonUpdate.Icon = null;
            this.materialButtonUpdate.Location = new System.Drawing.Point(229, 521);
            this.materialButtonUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonUpdate.Name = "materialButtonUpdate";
            this.materialButtonUpdate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonUpdate.Size = new System.Drawing.Size(173, 36);
            this.materialButtonUpdate.TabIndex = 4;
            this.materialButtonUpdate.Text = "Изменить";
            this.materialButtonUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonUpdate.UseAccentColor = false;
            this.materialButtonUpdate.UseVisualStyleBackColor = true;
            this.materialButtonUpdate.Click += new System.EventHandler(this.materialButtonUpdate_Click);
            // 
            // materialButtonDelete
            // 
            this.materialButtonDelete.AutoSize = false;
            this.materialButtonDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonDelete.Depth = 0;
            this.materialButtonDelete.HighEmphasis = true;
            this.materialButtonDelete.Icon = null;
            this.materialButtonDelete.Location = new System.Drawing.Point(410, 521);
            this.materialButtonDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonDelete.Name = "materialButtonDelete";
            this.materialButtonDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonDelete.Size = new System.Drawing.Size(185, 36);
            this.materialButtonDelete.TabIndex = 3;
            this.materialButtonDelete.Text = "Удалить";
            this.materialButtonDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonDelete.UseAccentColor = false;
            this.materialButtonDelete.UseVisualStyleBackColor = true;
            this.materialButtonDelete.Click += new System.EventHandler(this.materialButtonDelete_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(6, 24);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(18, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "id:";
            // 
            // materialButtonCreate
            // 
            this.materialButtonCreate.AutoSize = false;
            this.materialButtonCreate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonCreate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonCreate.Depth = 0;
            this.materialButtonCreate.HighEmphasis = true;
            this.materialButtonCreate.Icon = null;
            this.materialButtonCreate.Location = new System.Drawing.Point(7, 521);
            this.materialButtonCreate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonCreate.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonCreate.Name = "materialButtonCreate";
            this.materialButtonCreate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonCreate.Size = new System.Drawing.Size(214, 36);
            this.materialButtonCreate.TabIndex = 1;
            this.materialButtonCreate.Text = "Создать";
            this.materialButtonCreate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonCreate.UseAccentColor = false;
            this.materialButtonCreate.UseVisualStyleBackColor = true;
            this.materialButtonCreate.Click += new System.EventHandler(this.materialButtonCreate_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(30, 22);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(73, 23);
            this.textBoxID.TabIndex = 0;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // FormReestr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 663);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.treeViewDeprecation);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormReestr";
            this.Sizable = false;
            this.Text = "FormReestr";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TreeView treeViewDeprecation;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem выходToolStripMenuItem;
        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton materialButtonCreate;
        private TextBox textBoxID;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem обновитьToolStripMenuItem;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private TextBox textBoxListCount;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private TextBox textBoxFactCount;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private TextBox textBoxResidualValue;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private TextBox textBoxDeprecation;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private TextBox textBoxBalanceValue;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private TextBox textBoxInventoryNumber;
        private MaterialSkin.Controls.MaterialLabel materialLabelAccounting;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private TextBox textBoxNameInList;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private TextBox textBoxName;
        private MaterialSkin.Controls.MaterialButton materialButtonUpdate;
        private MaterialSkin.Controls.MaterialButton materialButtonDelete;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private ComboBox comboBoxStorage;
        private ComboBox comboBoxState;
        private ComboBox comboBoxStatus;
        private ComboBox comboBoxUsages;
        private ComboBox comboBoxAccounting;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private RichTextBox richTextBoxRequired;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private TextBox textBoxTransferTo;
    }
}