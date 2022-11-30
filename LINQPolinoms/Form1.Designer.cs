namespace LINQPolinoms
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
            this.listbox_polinomsData = new System.Windows.Forms.ListBox();
            this.listbox_filtredData = new System.Windows.Forms.ListBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_sort = new System.Windows.Forms.Button();
            this.btn_group = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listbox_polinomsData
            // 
            this.listbox_polinomsData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listbox_polinomsData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.listbox_polinomsData.FormattingEnabled = true;
            this.listbox_polinomsData.ItemHeight = 20;
            this.listbox_polinomsData.Location = new System.Drawing.Point(12, 12);
            this.listbox_polinomsData.Name = "listbox_polinomsData";
            this.listbox_polinomsData.Size = new System.Drawing.Size(277, 424);
            this.listbox_polinomsData.TabIndex = 0;
            // 
            // listbox_filtredData
            // 
            this.listbox_filtredData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listbox_filtredData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.listbox_filtredData.FormattingEnabled = true;
            this.listbox_filtredData.ItemHeight = 20;
            this.listbox_filtredData.Location = new System.Drawing.Point(511, 12);
            this.listbox_filtredData.Name = "listbox_filtredData";
            this.listbox_filtredData.Size = new System.Drawing.Size(277, 424);
            this.listbox_filtredData.TabIndex = 0;
            // 
            // btn_add
            // 
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btn_add.Location = new System.Drawing.Point(296, 13);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(209, 35);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Добавить Полином";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button2.Location = new System.Drawing.Point(295, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "результат  < 50";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_sort
            // 
            this.btn_sort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btn_sort.Location = new System.Drawing.Point(295, 177);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(209, 35);
            this.btn_sort.TabIndex = 1;
            this.btn_sort.Text = "Сортировать";
            this.btn_sort.UseVisualStyleBackColor = true;
            // 
            // btn_group
            // 
            this.btn_group.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_group.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btn_group.Location = new System.Drawing.Point(295, 218);
            this.btn_group.Name = "btn_group";
            this.btn_group.Size = new System.Drawing.Size(209, 35);
            this.btn_group.TabIndex = 1;
            this.btn_group.Text = "Сгруппировать";
            this.btn_group.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button1.Location = new System.Drawing.Point(295, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Очистить все";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_group);
            this.Controls.Add(this.btn_sort);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.listbox_filtredData);
            this.Controls.Add(this.listbox_polinomsData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listbox_polinomsData;
        private System.Windows.Forms.ListBox listbox_filtredData;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.Button btn_group;
        private System.Windows.Forms.Button button1;
    }
}

