namespace Log
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
            this.btnDatabase = new System.Windows.Forms.Button();
            this.btnOverflow = new System.Windows.Forms.Button();
            this.btnTypeConversion = new System.Windows.Forms.Button();
            this.btnFileWrite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDatabase
            // 
            this.btnDatabase.Location = new System.Drawing.Point(13, 13);
            this.btnDatabase.Name = "btnDatabase";
            this.btnDatabase.Size = new System.Drawing.Size(152, 39);
            this.btnDatabase.TabIndex = 0;
            this.btnDatabase.Text = "Работа с БД";
            this.btnDatabase.UseVisualStyleBackColor = true;
            this.btnDatabase.Click += new System.EventHandler(this.btnDatabase_Click);
            // 
            // btnOverflow
            // 
            this.btnOverflow.Location = new System.Drawing.Point(13, 58);
            this.btnOverflow.Name = "btnOverflow";
            this.btnOverflow.Size = new System.Drawing.Size(152, 39);
            this.btnOverflow.TabIndex = 1;
            this.btnOverflow.Text = "Переполнение";
            this.btnOverflow.UseVisualStyleBackColor = true;
            this.btnOverflow.Click += new System.EventHandler(this.btnOverflow_Click);
            // 
            // btnTypeConversion
            // 
            this.btnTypeConversion.Location = new System.Drawing.Point(13, 103);
            this.btnTypeConversion.Name = "btnTypeConversion";
            this.btnTypeConversion.Size = new System.Drawing.Size(152, 39);
            this.btnTypeConversion.TabIndex = 2;
            this.btnTypeConversion.Text = "Приведение типов";
            this.btnTypeConversion.UseVisualStyleBackColor = true;
            this.btnTypeConversion.Click += new System.EventHandler(this.btnTypeConversion_Click);
            // 
            // btnFileWrite
            // 
            this.btnFileWrite.Location = new System.Drawing.Point(13, 148);
            this.btnFileWrite.Name = "btnFileWrite";
            this.btnFileWrite.Size = new System.Drawing.Size(152, 39);
            this.btnFileWrite.TabIndex = 3;
            this.btnFileWrite.Text = "Запись в файл";
            this.btnFileWrite.UseVisualStyleBackColor = true;
            this.btnFileWrite.Click += new System.EventHandler(this.btnFileWrite_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFileWrite);
            this.Controls.Add(this.btnTypeConversion);
            this.Controls.Add(this.btnOverflow);
            this.Controls.Add(this.btnDatabase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDatabase;
        private System.Windows.Forms.Button btnOverflow;
        private System.Windows.Forms.Button btnTypeConversion;
        private System.Windows.Forms.Button btnFileWrite;
    }
}

