
namespace zad_12
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
            this.CreateArray = new System.Windows.Forms.Button();
            this.TextArray = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ChangedArray = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CreateArray
            // 
            this.CreateArray.Location = new System.Drawing.Point(12, 9);
            this.CreateArray.Name = "CreateArray";
            this.CreateArray.Size = new System.Drawing.Size(107, 23);
            this.CreateArray.TabIndex = 0;
            this.CreateArray.Text = "Создать массив:";
            this.CreateArray.UseVisualStyleBackColor = true;
            this.CreateArray.Click += new System.EventHandler(this.CreateArray_Click);
            // 
            // TextArray
            // 
            this.TextArray.Location = new System.Drawing.Point(12, 38);
            this.TextArray.Name = "TextArray";
            this.TextArray.ReadOnly = true;
            this.TextArray.Size = new System.Drawing.Size(444, 20);
            this.TextArray.TabIndex = 1;
            this.TextArray.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(123, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Изменненый массив:";
            this.textBox2.Visible = false;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ChangedArray
            // 
            this.ChangedArray.Location = new System.Drawing.Point(12, 90);
            this.ChangedArray.Name = "ChangedArray";
            this.ChangedArray.ReadOnly = true;
            this.ChangedArray.Size = new System.Drawing.Size(444, 20);
            this.ChangedArray.TabIndex = 3;
            this.ChangedArray.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChangedArray);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TextArray);
            this.Controls.Add(this.CreateArray);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateArray;
        private System.Windows.Forms.TextBox TextArray;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox ChangedArray;
    }
}

