namespace Base
{
    partial class Start
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
            this.pass = new System.Windows.Forms.TextBox();
            this.enter = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.TextBox();
            this.label_log = new System.Windows.Forms.Label();
            this.label_pass = new System.Windows.Forms.Label();
            this.hide_check = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(78, 59);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(100, 20);
            this.pass.TabIndex = 0;
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(28, 99);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(174, 25);
            this.enter.TabIndex = 1;
            this.enter.Text = "Войти";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // log
            // 
            this.log.ForeColor = System.Drawing.SystemColors.InfoText;
            this.log.Location = new System.Drawing.Point(78, 27);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(100, 20);
            this.log.TabIndex = 2;
            // 
            // label_log
            // 
            this.label_log.AutoSize = true;
            this.label_log.Location = new System.Drawing.Point(25, 30);
            this.label_log.Name = "label_log";
            this.label_log.Size = new System.Drawing.Size(38, 13);
            this.label_log.TabIndex = 4;
            this.label_log.Text = "Логин";
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.Location = new System.Drawing.Point(25, 62);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(45, 13);
            this.label_pass.TabIndex = 5;
            this.label_pass.Text = "Пароль";
            // 
            // hide_check
            // 
            this.hide_check.AutoSize = true;
            this.hide_check.Location = new System.Drawing.Point(187, 62);
            this.hide_check.Name = "hide_check";
            this.hide_check.Size = new System.Drawing.Size(15, 14);
            this.hide_check.TabIndex = 3;
            this.hide_check.UseVisualStyleBackColor = true;
            this.hide_check.CheckedChanged += new System.EventHandler(this.hide_check_CheckedChanged);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 135);
            this.Controls.Add(this.label_pass);
            this.Controls.Add(this.label_log);
            this.Controls.Add(this.hide_check);
            this.Controls.Add(this.log);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.pass);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Start";
            this.Text = "Вход в систему";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.Label label_log;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.CheckBox hide_check;
    }
}

