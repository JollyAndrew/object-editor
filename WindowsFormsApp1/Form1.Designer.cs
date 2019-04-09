namespace WindowsFormsApp1
{
    partial class Window
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
            this.BCreateClass = new System.Windows.Forms.Button();
            this.CBClasses = new System.Windows.Forms.ComboBox();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TBBudget = new System.Windows.Forms.TextBox();
            this.LBudget = new System.Windows.Forms.Label();
            this.LSalary = new System.Windows.Forms.Label();
            this.TBSalary = new System.Windows.Forms.TextBox();
            this.LGainADay = new System.Windows.Forms.Label();
            this.TBGainADay = new System.Windows.Forms.TextBox();
            this.LRooms = new System.Windows.Forms.Label();
            this.TBRooms = new System.Windows.Forms.TextBox();
            this.LEmployees = new System.Windows.Forms.Label();
            this.TBEmployees = new System.Windows.Forms.TextBox();
            this.LCashers = new System.Windows.Forms.Label();
            this.TBCashers = new System.Windows.Forms.TextBox();
            this.LRealGain = new System.Windows.Forms.Label();
            this.TBRealGain = new System.Windows.Forms.TextBox();
            this.LGoal = new System.Windows.Forms.Label();
            this.TBGoal = new System.Windows.Forms.TextBox();
            this.TBEditNum = new System.Windows.Forms.TextBox();
            this.LEditNum = new System.Windows.Forms.Label();
            this.BEdit = new System.Windows.Forms.Button();
            this.BDelete = new System.Windows.Forms.Button();
            this.LDelete = new System.Windows.Forms.Label();
            this.TBDelete = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // BCreateClass
            // 
            this.BCreateClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.BCreateClass.Location = new System.Drawing.Point(264, 320);
            this.BCreateClass.Margin = new System.Windows.Forms.Padding(2);
            this.BCreateClass.Name = "BCreateClass";
            this.BCreateClass.Size = new System.Drawing.Size(134, 41);
            this.BCreateClass.TabIndex = 0;
            this.BCreateClass.Text = "Создать объект";
            this.BCreateClass.UseVisualStyleBackColor = true;
            this.BCreateClass.Click += new System.EventHandler(this.BCreateClass_Click);
            // 
            // CBClasses
            // 
            this.CBClasses.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CBClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.CBClasses.FormattingEnabled = true;
            this.CBClasses.Items.AddRange(new object[] {
            "Покупатель",
            "Служащий",
            "Уборщик",
            "Кассир",
            "Старший кассир",
            "Менеджер",
            "Директор"});
            this.CBClasses.Location = new System.Drawing.Point(9, 320);
            this.CBClasses.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.CBClasses.Name = "CBClasses";
            this.CBClasses.Size = new System.Drawing.Size(223, 25);
            this.CBClasses.TabIndex = 1;
            this.CBClasses.Text = "Выбор создаваемого объекта ";
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.DGV.Location = new System.Drawing.Point(8, 11);
            this.DGV.Margin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.DGV.MinimumSize = new System.Drawing.Size(3, 3);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowTemplate.Height = 24;
            this.DGV.Size = new System.Drawing.Size(954, 280);
            this.DGV.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "№";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Имя класса";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Бюджет";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Зарплата";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Кол-во вымытых комнат";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Выручка за день";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Кол-во подчиненных кассиров";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Кол-во подчиненных";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "План выручки";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Выручка на данный момент";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // TBBudget
            // 
            this.TBBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.TBBudget.Location = new System.Drawing.Point(425, 320);
            this.TBBudget.Name = "TBBudget";
            this.TBBudget.Size = new System.Drawing.Size(130, 23);
            this.TBBudget.TabIndex = 3;
            // 
            // LBudget
            // 
            this.LBudget.AutoSize = true;
            this.LBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LBudget.Location = new System.Drawing.Point(428, 300);
            this.LBudget.Name = "LBudget";
            this.LBudget.Size = new System.Drawing.Size(59, 17);
            this.LBudget.TabIndex = 4;
            this.LBudget.Text = "Бюджет";
            // 
            // LSalary
            // 
            this.LSalary.AutoSize = true;
            this.LSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LSalary.Location = new System.Drawing.Point(428, 357);
            this.LSalary.Name = "LSalary";
            this.LSalary.Size = new System.Drawing.Size(72, 17);
            this.LSalary.TabIndex = 6;
            this.LSalary.Text = "Зарплата";
            // 
            // TBSalary
            // 
            this.TBSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.TBSalary.Location = new System.Drawing.Point(425, 377);
            this.TBSalary.Name = "TBSalary";
            this.TBSalary.Size = new System.Drawing.Size(130, 23);
            this.TBSalary.TabIndex = 5;
            // 
            // LGainADay
            // 
            this.LGainADay.AutoSize = true;
            this.LGainADay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LGainADay.Location = new System.Drawing.Point(564, 357);
            this.LGainADay.Name = "LGainADay";
            this.LGainADay.Size = new System.Drawing.Size(119, 17);
            this.LGainADay.TabIndex = 10;
            this.LGainADay.Text = "Выручка за день";
            // 
            // TBGainADay
            // 
            this.TBGainADay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.TBGainADay.Location = new System.Drawing.Point(561, 377);
            this.TBGainADay.Name = "TBGainADay";
            this.TBGainADay.Size = new System.Drawing.Size(130, 23);
            this.TBGainADay.TabIndex = 9;
            // 
            // LRooms
            // 
            this.LRooms.AutoSize = true;
            this.LRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LRooms.Location = new System.Drawing.Point(564, 300);
            this.LRooms.Name = "LRooms";
            this.LRooms.Size = new System.Drawing.Size(132, 17);
            this.LRooms.TabIndex = 8;
            this.LRooms.Text = "Вымытые комнаты";
            // 
            // TBRooms
            // 
            this.TBRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.TBRooms.Location = new System.Drawing.Point(561, 320);
            this.TBRooms.Name = "TBRooms";
            this.TBRooms.Size = new System.Drawing.Size(130, 23);
            this.TBRooms.TabIndex = 7;
            // 
            // LEmployees
            // 
            this.LEmployees.AutoSize = true;
            this.LEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LEmployees.Location = new System.Drawing.Point(700, 357);
            this.LEmployees.Name = "LEmployees";
            this.LEmployees.Size = new System.Drawing.Size(100, 17);
            this.LEmployees.TabIndex = 14;
            this.LEmployees.Text = "Подчиненные";
            // 
            // TBEmployees
            // 
            this.TBEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.TBEmployees.Location = new System.Drawing.Point(697, 377);
            this.TBEmployees.Name = "TBEmployees";
            this.TBEmployees.Size = new System.Drawing.Size(130, 23);
            this.TBEmployees.TabIndex = 13;
            // 
            // LCashers
            // 
            this.LCashers.AutoSize = true;
            this.LCashers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LCashers.Location = new System.Drawing.Point(700, 300);
            this.LCashers.Name = "LCashers";
            this.LCashers.Size = new System.Drawing.Size(117, 17);
            this.LCashers.TabIndex = 12;
            this.LCashers.Text = "Кол-во кассиров";
            // 
            // TBCashers
            // 
            this.TBCashers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.TBCashers.Location = new System.Drawing.Point(697, 320);
            this.TBCashers.Name = "TBCashers";
            this.TBCashers.Size = new System.Drawing.Size(130, 23);
            this.TBCashers.TabIndex = 11;
            // 
            // LRealGain
            // 
            this.LRealGain.AutoSize = true;
            this.LRealGain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LRealGain.Location = new System.Drawing.Point(835, 357);
            this.LRealGain.Name = "LRealGain";
            this.LRealGain.Size = new System.Drawing.Size(125, 17);
            this.LRealGain.TabIndex = 18;
            this.LRealGain.Text = "Текушая выручка";
            // 
            // TBRealGain
            // 
            this.TBRealGain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.TBRealGain.Location = new System.Drawing.Point(832, 377);
            this.TBRealGain.Name = "TBRealGain";
            this.TBRealGain.Size = new System.Drawing.Size(130, 23);
            this.TBRealGain.TabIndex = 17;
            // 
            // LGoal
            // 
            this.LGoal.AutoSize = true;
            this.LGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LGoal.Location = new System.Drawing.Point(835, 300);
            this.LGoal.Name = "LGoal";
            this.LGoal.Size = new System.Drawing.Size(101, 17);
            this.LGoal.TabIndex = 16;
            this.LGoal.Text = "План выручки";
            // 
            // TBGoal
            // 
            this.TBGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.TBGoal.Location = new System.Drawing.Point(832, 320);
            this.TBGoal.Name = "TBGoal";
            this.TBGoal.Size = new System.Drawing.Size(130, 23);
            this.TBGoal.TabIndex = 15;
            // 
            // TBEditNum
            // 
            this.TBEditNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.TBEditNum.Location = new System.Drawing.Point(8, 377);
            this.TBEditNum.Name = "TBEditNum";
            this.TBEditNum.Size = new System.Drawing.Size(224, 23);
            this.TBEditNum.TabIndex = 19;
            // 
            // LEditNum
            // 
            this.LEditNum.AutoSize = true;
            this.LEditNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LEditNum.Location = new System.Drawing.Point(10, 357);
            this.LEditNum.Name = "LEditNum";
            this.LEditNum.Size = new System.Drawing.Size(221, 17);
            this.LEditNum.TabIndex = 20;
            this.LEditNum.Text = "Номер редактируемого объекта";
            // 
            // BEdit
            // 
            this.BEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.BEdit.Location = new System.Drawing.Point(264, 377);
            this.BEdit.Margin = new System.Windows.Forms.Padding(2);
            this.BEdit.Name = "BEdit";
            this.BEdit.Size = new System.Drawing.Size(134, 54);
            this.BEdit.TabIndex = 21;
            this.BEdit.Text = "Редактировать объект";
            this.BEdit.UseVisualStyleBackColor = true;
            this.BEdit.Click += new System.EventHandler(this.BEdit_Click);
            // 
            // BDelete
            // 
            this.BDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.BDelete.Location = new System.Drawing.Point(264, 440);
            this.BDelete.Name = "BDelete";
            this.BDelete.Size = new System.Drawing.Size(134, 42);
            this.BDelete.TabIndex = 22;
            this.BDelete.Text = "Удалить объект";
            this.BDelete.UseVisualStyleBackColor = true;
            this.BDelete.Click += new System.EventHandler(this.BDelete_Click);
            // 
            // LDelete
            // 
            this.LDelete.AutoSize = true;
            this.LDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LDelete.Location = new System.Drawing.Point(13, 420);
            this.LDelete.Name = "LDelete";
            this.LDelete.Size = new System.Drawing.Size(191, 17);
            this.LDelete.TabIndex = 24;
            this.LDelete.Text = "Номер удаляемого объекта";
            // 
            // TBDelete
            // 
            this.TBDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.TBDelete.Location = new System.Drawing.Point(8, 440);
            this.TBDelete.Name = "TBDelete";
            this.TBDelete.Size = new System.Drawing.Size(224, 23);
            this.TBDelete.TabIndex = 23;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(972, 514);
            this.Controls.Add(this.LDelete);
            this.Controls.Add(this.TBDelete);
            this.Controls.Add(this.BDelete);
            this.Controls.Add(this.BEdit);
            this.Controls.Add(this.LEditNum);
            this.Controls.Add(this.TBEditNum);
            this.Controls.Add(this.LRealGain);
            this.Controls.Add(this.TBRealGain);
            this.Controls.Add(this.LGoal);
            this.Controls.Add(this.TBGoal);
            this.Controls.Add(this.LEmployees);
            this.Controls.Add(this.TBEmployees);
            this.Controls.Add(this.LCashers);
            this.Controls.Add(this.TBCashers);
            this.Controls.Add(this.LGainADay);
            this.Controls.Add(this.TBGainADay);
            this.Controls.Add(this.LRooms);
            this.Controls.Add(this.TBRooms);
            this.Controls.Add(this.LSalary);
            this.Controls.Add(this.TBSalary);
            this.Controls.Add(this.LBudget);
            this.Controls.Add(this.TBBudget);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.CBClasses);
            this.Controls.Add(this.BCreateClass);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Window";
            this.Text = "Работники ресторана";
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BCreateClass;
        private System.Windows.Forms.ComboBox CBClasses;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.TextBox TBBudget;
        private System.Windows.Forms.Label LBudget;
        private System.Windows.Forms.Label LSalary;
        private System.Windows.Forms.TextBox TBSalary;
        private System.Windows.Forms.Label LGainADay;
        private System.Windows.Forms.TextBox TBGainADay;
        private System.Windows.Forms.Label LRooms;
        private System.Windows.Forms.TextBox TBRooms;
        private System.Windows.Forms.Label LEmployees;
        private System.Windows.Forms.TextBox TBEmployees;
        private System.Windows.Forms.Label LCashers;
        private System.Windows.Forms.TextBox TBCashers;
        private System.Windows.Forms.Label LRealGain;
        private System.Windows.Forms.TextBox TBRealGain;
        private System.Windows.Forms.Label LGoal;
        private System.Windows.Forms.TextBox TBGoal;
        private System.Windows.Forms.TextBox TBEditNum;
        private System.Windows.Forms.Label LEditNum;
        private System.Windows.Forms.Button BEdit;
        private System.Windows.Forms.Button BDelete;
        private System.Windows.Forms.Label LDelete;
        private System.Windows.Forms.TextBox TBDelete;
    }
}

