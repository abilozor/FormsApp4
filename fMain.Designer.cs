namespace FormsApp4
{
    partial class fMain
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbSquareSide = new System.Windows.Forms.TextBox();
            this.tbCircleRadius = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPyramidVolume = new System.Windows.Forms.TextBox();
            this.tbSphereVolume = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сторона квадрата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Радіус круга";
            // 
            // tbSquareSide
            // 
            this.tbSquareSide.Location = new System.Drawing.Point(178, 45);
            this.tbSquareSide.Name = "tbSquareSide";
            this.tbSquareSide.Size = new System.Drawing.Size(100, 22);
            this.tbSquareSide.TabIndex = 3;
            // 
            // tbCircleRadius
            // 
            this.tbCircleRadius.Location = new System.Drawing.Point(178, 135);
            this.tbCircleRadius.Name = "tbCircleRadius";
            this.tbCircleRadius.Size = new System.Drawing.Size(100, 22);
            this.tbCircleRadius.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Площа квадрата = ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Площа круга = ";
            // 
            // tbPyramidVolume
            // 
            this.tbPyramidVolume.Location = new System.Drawing.Point(454, 45);
            this.tbPyramidVolume.Name = "tbPyramidVolume";
            this.tbPyramidVolume.ReadOnly = true;
            this.tbPyramidVolume.Size = new System.Drawing.Size(100, 22);
            this.tbPyramidVolume.TabIndex = 8;
            // 
            // tbSphereVolume
            // 
            this.tbSphereVolume.Location = new System.Drawing.Point(454, 135);
            this.tbSphereVolume.Name = "tbSphereVolume";
            this.tbSphereVolume.ReadOnly = true;
            this.tbSphereVolume.Size = new System.Drawing.Size(100, 22);
            this.tbSphereVolume.TabIndex = 9;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(28, 200);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(154, 35);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Розрахувати площі";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.tbSphereVolume);
            this.Controls.Add(this.tbPyramidVolume);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCircleRadius);
            this.Controls.Add(this.tbSquareSide);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "fMain";
            this.Text = "Лабораторна робота №6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSquareSide;
        private System.Windows.Forms.TextBox tbCircleRadius;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPyramidVolume;
        private System.Windows.Forms.TextBox tbSphereVolume;
        private System.Windows.Forms.Button btnCalculate;
    }
}

