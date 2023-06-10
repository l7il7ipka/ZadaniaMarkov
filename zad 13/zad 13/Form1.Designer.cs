
namespace zad_13
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
            this.ArrayOne = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ArrayTwo = new System.Windows.Forms.TextBox();
            this.ArrayRezult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CreateArray
            // 
            this.CreateArray.Location = new System.Drawing.Point(0, 0);
            this.CreateArray.Name = "CreateArray";
            this.CreateArray.Size = new System.Drawing.Size(131, 23);
            this.CreateArray.TabIndex = 0;
            this.CreateArray.Text = "Создать два массива:";
            this.CreateArray.UseVisualStyleBackColor = true;
            this.CreateArray.Click += new System.EventHandler(this.CreateArray_Click);
            // 
            // ArrayOne
            // 
            this.ArrayOne.Location = new System.Drawing.Point(12, 29);
            this.ArrayOne.Name = "ArrayOne";
            this.ArrayOne.ReadOnly = true;
            this.ArrayOne.Size = new System.Drawing.Size(369, 20);
            this.ArrayOne.TabIndex = 1;
            this.ArrayOne.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 81);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(137, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Скомпанованый массив:";
            this.textBox2.Visible = false;
            // 
            // ArrayTwo
            // 
            this.ArrayTwo.Location = new System.Drawing.Point(12, 55);
            this.ArrayTwo.Name = "ArrayTwo";
            this.ArrayTwo.ReadOnly = true;
            this.ArrayTwo.Size = new System.Drawing.Size(369, 20);
            this.ArrayTwo.TabIndex = 3;
            this.ArrayTwo.Visible = false;
            // 
            // ArrayRezult
            // 
            this.ArrayRezult.Location = new System.Drawing.Point(12, 107);
            this.ArrayRezult.Name = "ArrayRezult";
            this.ArrayRezult.ReadOnly = true;
            this.ArrayRezult.Size = new System.Drawing.Size(711, 20);
            this.ArrayRezult.TabIndex = 4;
            this.ArrayRezult.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ArrayRezult);
            this.Controls.Add(this.ArrayTwo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ArrayOne);
            this.Controls.Add(this.CreateArray);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateArray;
        private System.Windows.Forms.TextBox ArrayOne;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox ArrayTwo;
        private System.Windows.Forms.TextBox ArrayRezult;
    }
}

