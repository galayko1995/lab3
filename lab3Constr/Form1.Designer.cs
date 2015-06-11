namespace lab3Constr
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.sort1 = new MetroFramework.Controls.MetroButton();
            this.fastSort = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.InitialData = new MetroFramework.Controls.MetroTextBox();
            this.resultData = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 70);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(123, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Исходные данные:";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(531, 89);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(157, 23);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Задать новые значения";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // sort1
            // 
            this.sort1.Location = new System.Drawing.Point(65, 130);
            this.sort1.Name = "sort1";
            this.sort1.Size = new System.Drawing.Size(204, 62);
            this.sort1.TabIndex = 3;
            this.sort1.Text = "Сортировка ставками";
            this.sort1.UseSelectable = true;
            this.sort1.Click += new System.EventHandler(this.sort1_Click);
            // 
            // fastSort
            // 
            this.fastSort.Location = new System.Drawing.Point(385, 130);
            this.fastSort.Name = "fastSort";
            this.fastSort.Size = new System.Drawing.Size(187, 62);
            this.fastSort.TabIndex = 4;
            this.fastSort.Text = "Быстрая сортировка";
            this.fastSort.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 206);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(69, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Результат:";
            // 
            // InitialData
            // 
            this.InitialData.Lines = new string[0];
            this.InitialData.Location = new System.Drawing.Point(23, 89);
            this.InitialData.MaxLength = 32767;
            this.InitialData.Name = "InitialData";
            this.InitialData.PasswordChar = '\0';
            this.InitialData.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.InitialData.SelectedText = "";
            this.InitialData.Size = new System.Drawing.Size(502, 23);
            this.InitialData.TabIndex = 7;
            this.InitialData.UseSelectable = true;
            // 
            // resultData
            // 
            this.resultData.Lines = new string[0];
            this.resultData.Location = new System.Drawing.Point(23, 228);
            this.resultData.MaxLength = 32767;
            this.resultData.Name = "resultData";
            this.resultData.PasswordChar = '\0';
            this.resultData.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.resultData.SelectedText = "";
            this.resultData.Size = new System.Drawing.Size(665, 23);
            this.resultData.TabIndex = 8;
            this.resultData.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 281);
            this.Controls.Add(this.resultData);
            this.Controls.Add(this.InitialData);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.fastSort);
            this.Controls.Add(this.sort1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Form1";
            this.Text = "Лаба3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton sort1;
        private MetroFramework.Controls.MetroButton fastSort;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox InitialData;
        private MetroFramework.Controls.MetroTextBox resultData;
    }
}

