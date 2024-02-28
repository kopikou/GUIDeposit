namespace Deposit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdeposit = new System.Windows.Forms.TextBox();
            this.txtpercentDeposit = new System.Windows.Forms.TextBox();
            this.txtsumm = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вклад на 1 марта руб: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(412, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Величина ежемесячного увеличения вклада превысит B руб: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Размер вклада превысит C руб: ";
            // 
            // txtdeposit
            // 
            this.txtdeposit.Location = new System.Drawing.Point(271, 25);
            this.txtdeposit.Name = "txtdeposit";
            this.txtdeposit.Size = new System.Drawing.Size(100, 22);
            this.txtdeposit.TabIndex = 3;
            // 
            // txtpercentDeposit
            // 
            this.txtpercentDeposit.Location = new System.Drawing.Point(493, 75);
            this.txtpercentDeposit.Name = "txtpercentDeposit";
            this.txtpercentDeposit.Size = new System.Drawing.Size(100, 22);
            this.txtpercentDeposit.TabIndex = 4;
            // 
            // txtsumm
            // 
            this.txtsumm.Location = new System.Drawing.Point(287, 126);
            this.txtsumm.Name = "txtsumm";
            this.txtsumm.Size = new System.Drawing.Size(100, 22);
            this.txtsumm.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(550, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 224);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtsumm);
            this.Controls.Add(this.txtpercentDeposit);
            this.Controls.Add(this.txtdeposit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdeposit;
        private System.Windows.Forms.TextBox txtpercentDeposit;
        private System.Windows.Forms.TextBox txtsumm;
        private System.Windows.Forms.Button button1;
    }
}

