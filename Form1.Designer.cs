namespace WindowsFormsApplication3
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
            this.USD_bay = new System.Windows.Forms.Label();
            this.USB_bay_res = new System.Windows.Forms.Label();
            this.USB_sell_res = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EUR_sell_res = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EUR_bay_res = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RUB_sell_res = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RUB_bay_res = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Курс валют";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // USD_bay
            // 
            this.USD_bay.AutoSize = true;
            this.USD_bay.Location = new System.Drawing.Point(13, 69);
            this.USD_bay.Name = "USD_bay";
            this.USD_bay.Size = new System.Drawing.Size(74, 13);
            this.USD_bay.TabIndex = 1;
            this.USD_bay.Text = "USD покупка";
            // 
            // USB_bay_res
            // 
            this.USB_bay_res.AutoSize = true;
            this.USB_bay_res.Location = new System.Drawing.Point(237, 68);
            this.USB_bay_res.Name = "USB_bay_res";
            this.USB_bay_res.Size = new System.Drawing.Size(35, 13);
            this.USB_bay_res.TabIndex = 2;
            this.USB_bay_res.Text = "label2";
            // 
            // USB_sell_res
            // 
            this.USB_sell_res.AutoSize = true;
            this.USB_sell_res.Location = new System.Drawing.Point(236, 85);
            this.USB_sell_res.Name = "USB_sell_res";
            this.USB_sell_res.Size = new System.Drawing.Size(35, 13);
            this.USB_sell_res.TabIndex = 4;
            this.USB_sell_res.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "USD продажа";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // EUR_sell_res
            // 
            this.EUR_sell_res.AutoSize = true;
            this.EUR_sell_res.Location = new System.Drawing.Point(235, 119);
            this.EUR_sell_res.Name = "EUR_sell_res";
            this.EUR_sell_res.Size = new System.Drawing.Size(35, 13);
            this.EUR_sell_res.TabIndex = 8;
            this.EUR_sell_res.Text = "label2";
            this.EUR_sell_res.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "EUR продажа";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // EUR_bay_res
            // 
            this.EUR_bay_res.AutoSize = true;
            this.EUR_bay_res.Location = new System.Drawing.Point(236, 102);
            this.EUR_bay_res.Name = "EUR_bay_res";
            this.EUR_bay_res.Size = new System.Drawing.Size(35, 13);
            this.EUR_bay_res.TabIndex = 6;
            this.EUR_bay_res.Text = "label2";
            this.EUR_bay_res.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "EUR покупка";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // RUB_sell_res
            // 
            this.RUB_sell_res.AutoSize = true;
            this.RUB_sell_res.Location = new System.Drawing.Point(235, 153);
            this.RUB_sell_res.Name = "RUB_sell_res";
            this.RUB_sell_res.Size = new System.Drawing.Size(35, 13);
            this.RUB_sell_res.TabIndex = 12;
            this.RUB_sell_res.Text = "label2";
            this.RUB_sell_res.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "RUB продажа";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // RUB_bay_res
            // 
            this.RUB_bay_res.AutoSize = true;
            this.RUB_bay_res.Location = new System.Drawing.Point(236, 136);
            this.RUB_bay_res.Name = "RUB_bay_res";
            this.RUB_bay_res.Size = new System.Drawing.Size(35, 13);
            this.RUB_bay_res.TabIndex = 10;
            this.RUB_bay_res.Text = "label2";
            this.RUB_bay_res.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "RUB покупка";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 179);
            this.Controls.Add(this.RUB_sell_res);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RUB_bay_res);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.EUR_sell_res);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EUR_bay_res);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.USB_sell_res);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.USB_bay_res);
            this.Controls.Add(this.USD_bay);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Курс валют";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label USD_bay;
        private System.Windows.Forms.Label USB_bay_res;
        private System.Windows.Forms.Label USB_sell_res;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label EUR_sell_res;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label EUR_bay_res;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label RUB_sell_res;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label RUB_bay_res;
        private System.Windows.Forms.Label label8;
    }
}

