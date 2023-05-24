namespace ML1
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.PointY = new System.Windows.Forms.TextBox();
            this.PointX = new System.Windows.Forms.TextBox();
            this.RealTime = new System.Windows.Forms.Button();
            this.StartStop = new System.Windows.Forms.Button();
            this.SetPoint = new System.Windows.Forms.Button();
            this.SkipStepN = new System.Windows.Forms.TextBox();
            this.SkipStep = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(614, 381);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ML1.Properties.Resources.map;
            this.pictureBox1.Location = new System.Drawing.Point(203, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(408, 375);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.RealTime, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.StartStop, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.SetPoint, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.SkipStepN, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.SkipStep, 0, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(194, 181);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.53191F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.46809F));
            this.tableLayoutPanel3.Controls.Add(this.PointY, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.PointX, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 90);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(188, 31);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // PointY
            // 
            this.PointY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PointY.Location = new System.Drawing.Point(97, 3);
            this.PointY.Name = "PointY";
            this.PointY.Size = new System.Drawing.Size(88, 20);
            this.PointY.TabIndex = 1;
            // 
            // PointX
            // 
            this.PointX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PointX.Location = new System.Drawing.Point(3, 3);
            this.PointX.Name = "PointX";
            this.PointX.Size = new System.Drawing.Size(88, 20);
            this.PointX.TabIndex = 0;
            // 
            // RealTime
            // 
            this.RealTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RealTime.Location = new System.Drawing.Point(3, 32);
            this.RealTime.Name = "RealTime";
            this.RealTime.Size = new System.Drawing.Size(188, 23);
            this.RealTime.TabIndex = 3;
            this.RealTime.Text = "Номальная скорость";
            this.RealTime.UseVisualStyleBackColor = true;
            // 
            // StartStop
            // 
            this.StartStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartStop.ForeColor = System.Drawing.Color.Black;
            this.StartStop.Location = new System.Drawing.Point(3, 3);
            this.StartStop.Name = "StartStop";
            this.StartStop.Size = new System.Drawing.Size(188, 23);
            this.StartStop.TabIndex = 1;
            this.StartStop.Text = "Старт";
            this.StartStop.UseVisualStyleBackColor = true;
            this.StartStop.Click += new System.EventHandler(this.StartStop_Click);
            // 
            // SetPoint
            // 
            this.SetPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SetPoint.Location = new System.Drawing.Point(3, 61);
            this.SetPoint.Name = "SetPoint";
            this.SetPoint.Size = new System.Drawing.Size(188, 23);
            this.SetPoint.TabIndex = 2;
            this.SetPoint.Text = "Установить точку (x,y)";
            this.SetPoint.UseVisualStyleBackColor = true;
            this.SetPoint.Click += new System.EventHandler(this.SetPoint_Click);
            // 
            // SkipStepN
            // 
            this.SkipStepN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SkipStepN.Location = new System.Drawing.Point(3, 156);
            this.SkipStepN.Name = "SkipStepN";
            this.SkipStepN.Size = new System.Drawing.Size(188, 20);
            this.SkipStepN.TabIndex = 0;
            // 
            // SkipStep
            // 
            this.SkipStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SkipStep.Location = new System.Drawing.Point(3, 127);
            this.SkipStep.Name = "SkipStep";
            this.SkipStep.Size = new System.Drawing.Size(188, 23);
            this.SkipStep.TabIndex = 5;
            this.SkipStep.Text = "Пропустить N итераций";
            this.SkipStep.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 381);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox PointY;
        private System.Windows.Forms.TextBox PointX;
        private System.Windows.Forms.Button RealTime;
        private System.Windows.Forms.Button StartStop;
        private System.Windows.Forms.Button SetPoint;
        private System.Windows.Forms.TextBox SkipStepN;
        private System.Windows.Forms.Button SkipStep;
        private System.Windows.Forms.Timer timer1;
    }
}

