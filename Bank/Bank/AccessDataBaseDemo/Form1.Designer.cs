namespace AccessDataBaseDemo
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Search1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_New0 = new System.Windows.Forms.TextBox();
            this.textBox_0 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_NewIDClient = new System.Windows.Forms.TextBox();
            this.textBox_IDClient1 = new System.Windows.Forms.TextBox();
            this.textBox_NewDate = new System.Windows.Forms.TextBox();
            this.textBox_NewSumma = new System.Windows.Forms.TextBox();
            this.textBox_NewIDTC = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Date = new System.Windows.Forms.TextBox();
            this.textBox_Summa = new System.Windows.Forms.TextBox();
            this.textBox_IDTC = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox_NewMounthly = new System.Windows.Forms.TextBox();
            this.textBox_NewIDPER = new System.Windows.Forms.TextBox();
            this.textBox_NewAdds = new System.Windows.Forms.TextBox();
            this.textBox_NewNumberT = new System.Windows.Forms.TextBox();
            this.textBox_NewM = new System.Windows.Forms.TextBox();
            this.textBox_NewL = new System.Windows.Forms.TextBox();
            this.textBox_Mounthly = new System.Windows.Forms.TextBox();
            this.textBox_IDPER = new System.Windows.Forms.TextBox();
            this.textBox_Adds = new System.Windows.Forms.TextBox();
            this.textBox_NumberT = new System.Windows.Forms.TextBox();
            this.textBox_M = new System.Windows.Forms.TextBox();
            this.textBox_L = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.Старые = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_NewF = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_IDClient = new System.Windows.Forms.TextBox();
            this.textBox_F = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(415, 22);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 3;
            this.selectButton.Text = "Изменить";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton2_Click);
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(342, 502);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(75, 23);
            this.insertButton.TabIndex = 4;
            this.insertButton.Text = "Ввод";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(334, 22);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Удаление";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 662);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.AllowDrop = true;
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.textBox_Search1);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.textBox_New0);
            this.tabPage1.Controls.Add(this.textBox_0);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBox_NewIDClient);
            this.tabPage1.Controls.Add(this.textBox_IDClient1);
            this.tabPage1.Controls.Add(this.textBox_NewDate);
            this.tabPage1.Controls.Add(this.textBox_NewSumma);
            this.tabPage1.Controls.Add(this.textBox_NewIDTC);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBox_Date);
            this.tabPage1.Controls.Add(this.textBox_Summa);
            this.tabPage1.Controls.Add(this.textBox_IDTC);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.textBox_NewMounthly);
            this.tabPage1.Controls.Add(this.textBox_NewIDPER);
            this.tabPage1.Controls.Add(this.textBox_NewAdds);
            this.tabPage1.Controls.Add(this.textBox_NewNumberT);
            this.tabPage1.Controls.Add(this.textBox_NewM);
            this.tabPage1.Controls.Add(this.textBox_NewL);
            this.tabPage1.Controls.Add(this.textBox_Mounthly);
            this.tabPage1.Controls.Add(this.textBox_IDPER);
            this.tabPage1.Controls.Add(this.textBox_Adds);
            this.tabPage1.Controls.Add(this.textBox_NumberT);
            this.tabPage1.Controls.Add(this.textBox_M);
            this.tabPage1.Controls.Add(this.textBox_L);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox_Search);
            this.tabPage1.Controls.Add(this.Старые);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox_NewF);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.textBox_IDClient);
            this.tabPage1.Controls.Add(this.textBox_F);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.selectButton);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.insertButton);
            this.tabPage1.Controls.Add(this.deleteButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(992, 636);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(835, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Поиск";
            // 
            // textBox_Search1
            // 
            this.textBox_Search1.Location = new System.Drawing.Point(763, 339);
            this.textBox_Search1.Name = "textBox_Search1";
            this.textBox_Search1.Size = new System.Drawing.Size(202, 20);
            this.textBox_Search1.TabIndex = 49;
            this.textBox_Search1.TextChanged += new System.EventHandler(this.textBox_Search1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(516, 586);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Выдан (0)";
            // 
            // textBox_New0
            // 
            this.textBox_New0.Location = new System.Drawing.Point(601, 582);
            this.textBox_New0.Name = "textBox_New0";
            this.textBox_New0.Size = new System.Drawing.Size(94, 20);
            this.textBox_New0.TabIndex = 47;
            // 
            // textBox_0
            // 
            this.textBox_0.Location = new System.Drawing.Point(793, 582);
            this.textBox_0.Name = "textBox_0";
            this.textBox_0.Size = new System.Drawing.Size(94, 20);
            this.textBox_0.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(516, 557);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Клиент";
            // 
            // textBox_NewIDClient
            // 
            this.textBox_NewIDClient.Location = new System.Drawing.Point(601, 556);
            this.textBox_NewIDClient.Name = "textBox_NewIDClient";
            this.textBox_NewIDClient.Size = new System.Drawing.Size(94, 20);
            this.textBox_NewIDClient.TabIndex = 44;
            // 
            // textBox_IDClient1
            // 
            this.textBox_IDClient1.Location = new System.Drawing.Point(793, 556);
            this.textBox_IDClient1.Name = "textBox_IDClient1";
            this.textBox_IDClient1.Size = new System.Drawing.Size(94, 20);
            this.textBox_IDClient1.TabIndex = 43;
            // 
            // textBox_NewDate
            // 
            this.textBox_NewDate.Location = new System.Drawing.Point(601, 530);
            this.textBox_NewDate.Name = "textBox_NewDate";
            this.textBox_NewDate.Size = new System.Drawing.Size(94, 20);
            this.textBox_NewDate.TabIndex = 42;
            // 
            // textBox_NewSumma
            // 
            this.textBox_NewSumma.Location = new System.Drawing.Point(601, 504);
            this.textBox_NewSumma.Name = "textBox_NewSumma";
            this.textBox_NewSumma.Size = new System.Drawing.Size(94, 20);
            this.textBox_NewSumma.TabIndex = 41;
            // 
            // textBox_NewIDTC
            // 
            this.textBox_NewIDTC.Location = new System.Drawing.Point(601, 479);
            this.textBox_NewIDTC.Name = "textBox_NewIDTC";
            this.textBox_NewIDTC.Size = new System.Drawing.Size(94, 20);
            this.textBox_NewIDTC.TabIndex = 40;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(601, 605);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 23);
            this.button5.TabIndex = 39;
            this.button5.Text = "Ввод";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(496, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 38;
            this.button4.Text = "Расчитать";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(516, 530);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Дата";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(516, 504);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Сумма";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(516, 479);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Тип клиента";
            // 
            // textBox_Date
            // 
            this.textBox_Date.Location = new System.Drawing.Point(793, 530);
            this.textBox_Date.Name = "textBox_Date";
            this.textBox_Date.Size = new System.Drawing.Size(94, 20);
            this.textBox_Date.TabIndex = 34;
            // 
            // textBox_Summa
            // 
            this.textBox_Summa.Location = new System.Drawing.Point(793, 504);
            this.textBox_Summa.Name = "textBox_Summa";
            this.textBox_Summa.Size = new System.Drawing.Size(94, 20);
            this.textBox_Summa.TabIndex = 33;
            // 
            // textBox_IDTC
            // 
            this.textBox_IDTC.Location = new System.Drawing.Point(793, 479);
            this.textBox_IDTC.Name = "textBox_IDTC";
            this.textBox_IDTC.Size = new System.Drawing.Size(94, 20);
            this.textBox_IDTC.TabIndex = 32;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(516, 368);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(449, 101);
            this.dataGridView2.TabIndex = 31;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // textBox_NewMounthly
            // 
            this.textBox_NewMounthly.Location = new System.Drawing.Point(270, 475);
            this.textBox_NewMounthly.Name = "textBox_NewMounthly";
            this.textBox_NewMounthly.Size = new System.Drawing.Size(225, 20);
            this.textBox_NewMounthly.TabIndex = 30;
            // 
            // textBox_NewIDPER
            // 
            this.textBox_NewIDPER.Location = new System.Drawing.Point(270, 449);
            this.textBox_NewIDPER.Name = "textBox_NewIDPER";
            this.textBox_NewIDPER.Size = new System.Drawing.Size(225, 20);
            this.textBox_NewIDPER.TabIndex = 29;
            // 
            // textBox_NewAdds
            // 
            this.textBox_NewAdds.Location = new System.Drawing.Point(270, 424);
            this.textBox_NewAdds.Name = "textBox_NewAdds";
            this.textBox_NewAdds.Size = new System.Drawing.Size(225, 20);
            this.textBox_NewAdds.TabIndex = 28;
            // 
            // textBox_NewNumberT
            // 
            this.textBox_NewNumberT.Location = new System.Drawing.Point(270, 397);
            this.textBox_NewNumberT.Name = "textBox_NewNumberT";
            this.textBox_NewNumberT.Size = new System.Drawing.Size(225, 20);
            this.textBox_NewNumberT.TabIndex = 27;
            // 
            // textBox_NewM
            // 
            this.textBox_NewM.Location = new System.Drawing.Point(270, 368);
            this.textBox_NewM.Name = "textBox_NewM";
            this.textBox_NewM.Size = new System.Drawing.Size(225, 20);
            this.textBox_NewM.TabIndex = 26;
            // 
            // textBox_NewL
            // 
            this.textBox_NewL.Location = new System.Drawing.Point(270, 342);
            this.textBox_NewL.Name = "textBox_NewL";
            this.textBox_NewL.Size = new System.Drawing.Size(225, 20);
            this.textBox_NewL.TabIndex = 25;
            // 
            // textBox_Mounthly
            // 
            this.textBox_Mounthly.Location = new System.Drawing.Point(28, 502);
            this.textBox_Mounthly.Name = "textBox_Mounthly";
            this.textBox_Mounthly.Size = new System.Drawing.Size(225, 20);
            this.textBox_Mounthly.TabIndex = 24;
            // 
            // textBox_IDPER
            // 
            this.textBox_IDPER.Location = new System.Drawing.Point(28, 475);
            this.textBox_IDPER.Name = "textBox_IDPER";
            this.textBox_IDPER.Size = new System.Drawing.Size(225, 20);
            this.textBox_IDPER.TabIndex = 23;
            // 
            // textBox_Adds
            // 
            this.textBox_Adds.Location = new System.Drawing.Point(28, 449);
            this.textBox_Adds.Name = "textBox_Adds";
            this.textBox_Adds.Size = new System.Drawing.Size(225, 20);
            this.textBox_Adds.TabIndex = 22;
            // 
            // textBox_NumberT
            // 
            this.textBox_NumberT.Location = new System.Drawing.Point(28, 423);
            this.textBox_NumberT.Name = "textBox_NumberT";
            this.textBox_NumberT.Size = new System.Drawing.Size(225, 20);
            this.textBox_NumberT.TabIndex = 21;
            // 
            // textBox_M
            // 
            this.textBox_M.Location = new System.Drawing.Point(28, 397);
            this.textBox_M.Name = "textBox_M";
            this.textBox_M.Size = new System.Drawing.Size(225, 20);
            this.textBox_M.TabIndex = 20;
            // 
            // textBox_L
            // 
            this.textBox_L.Location = new System.Drawing.Point(28, 368);
            this.textBox_L.Name = "textBox_L";
            this.textBox_L.Size = new System.Drawing.Size(225, 20);
            this.textBox_L.TabIndex = 19;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(135, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Очистка";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(703, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Поиск";
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(618, 22);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(225, 20);
            this.textBox_Search.TabIndex = 16;
            this.textBox_Search.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Старые
            // 
            this.Старые.AutoSize = true;
            this.Старые.Location = new System.Drawing.Point(94, 300);
            this.Старые.Name = "Старые";
            this.Старые.Size = new System.Drawing.Size(92, 13);
            this.Старые.TabIndex = 15;
            this.Старые.Text = "Данные клиента";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Новый клиент";
            // 
            // textBox_NewF
            // 
            this.textBox_NewF.Location = new System.Drawing.Point(270, 316);
            this.textBox_NewF.Name = "textBox_NewF";
            this.textBox_NewF.Size = new System.Drawing.Size(225, 20);
            this.textBox_NewF.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Обновить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_IDClient
            // 
            this.textBox_IDClient.Location = new System.Drawing.Point(28, 316);
            this.textBox_IDClient.Name = "textBox_IDClient";
            this.textBox_IDClient.Size = new System.Drawing.Size(225, 20);
            this.textBox_IDClient.TabIndex = 10;
            // 
            // textBox_F
            // 
            this.textBox_F.Location = new System.Drawing.Point(28, 342);
            this.textBox_F.Name = "textBox_F";
            this.textBox_F.Size = new System.Drawing.Size(225, 20);
            this.textBox_F.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(937, 248);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(992, 636);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 696);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Access Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox_IDClient;
        private System.Windows.Forms.TextBox textBox_F;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Старые;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_NewF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox_NewMounthly;
        private System.Windows.Forms.TextBox textBox_NewIDPER;
        private System.Windows.Forms.TextBox textBox_NewAdds;
        private System.Windows.Forms.TextBox textBox_NewNumberT;
        private System.Windows.Forms.TextBox textBox_NewM;
        private System.Windows.Forms.TextBox textBox_NewL;
        private System.Windows.Forms.TextBox textBox_Mounthly;
        private System.Windows.Forms.TextBox textBox_IDPER;
        private System.Windows.Forms.TextBox textBox_Adds;
        private System.Windows.Forms.TextBox textBox_NumberT;
        private System.Windows.Forms.TextBox textBox_M;
        private System.Windows.Forms.TextBox textBox_L;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Date;
        private System.Windows.Forms.TextBox textBox_Summa;
        private System.Windows.Forms.TextBox textBox_IDTC;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox_NewDate;
        private System.Windows.Forms.TextBox textBox_NewSumma;
        private System.Windows.Forms.TextBox textBox_NewIDTC;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox_NewIDClient;
        private System.Windows.Forms.TextBox textBox_IDClient1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_New0;
        private System.Windows.Forms.TextBox textBox_0;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_Search1;
    }
}

