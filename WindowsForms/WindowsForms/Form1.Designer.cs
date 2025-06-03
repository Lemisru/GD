namespace WindowsForms
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
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.LanguageChoice = new System.Windows.Forms.ComboBox();
            this.numericUpDownShift = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectEncDec = new System.Windows.Forms.ComboBox();
            this.buttonLaunch = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonLoadFromFile = new System.Windows.Forms.Button();
            this.buttonSaveToFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShift)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(355, 45);
            this.textBoxInput.MaxLength = 1500;
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxInput.Size = new System.Drawing.Size(580, 106);
            this.textBoxInput.TabIndex = 0;
            // 
            // LanguageChoice
            // 
            this.LanguageChoice.FormattingEnabled = true;
            this.LanguageChoice.Items.AddRange(new object[] {
            "Русский",
            "Английский"});
            this.LanguageChoice.Location = new System.Drawing.Point(532, 202);
            this.LanguageChoice.Name = "LanguageChoice";
            this.LanguageChoice.Size = new System.Drawing.Size(190, 21);
            this.LanguageChoice.TabIndex = 1;
            // 
            // numericUpDownShift
            // 
            this.numericUpDownShift.Location = new System.Drawing.Point(532, 262);
            this.numericUpDownShift.Maximum = new decimal(new int[] {
            33,
            0,
            0,
            0});
            this.numericUpDownShift.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownShift.Name = "numericUpDownShift";
            this.numericUpDownShift.Size = new System.Drawing.Size(190, 20);
            this.numericUpDownShift.TabIndex = 2;
            this.numericUpDownShift.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(528, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выбор языка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(528, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Диапазон шифрования";
            // 
            // SelectEncDec
            // 
            this.SelectEncDec.FormattingEnabled = true;
            this.SelectEncDec.Items.AddRange(new object[] {
            "Шифровать",
            "Дешифровать"});
            this.SelectEncDec.Location = new System.Drawing.Point(532, 316);
            this.SelectEncDec.Name = "SelectEncDec";
            this.SelectEncDec.Size = new System.Drawing.Size(190, 21);
            this.SelectEncDec.TabIndex = 5;
            // 
            // buttonLaunch
            // 
            this.buttonLaunch.Location = new System.Drawing.Point(562, 379);
            this.buttonLaunch.Name = "buttonLaunch";
            this.buttonLaunch.Size = new System.Drawing.Size(120, 27);
            this.buttonLaunch.TabIndex = 6;
            this.buttonLaunch.Text = "Выполнить";
            this.buttonLaunch.UseVisualStyleBackColor = true;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(355, 462);
            this.textBoxOutput.MaxLength = 1500;
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxOutput.Size = new System.Drawing.Size(580, 100);
            this.textBoxOutput.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(528, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Шифровать/Дешифровать";
            // 
            // buttonLoadFromFile
            // 
            this.buttonLoadFromFile.Location = new System.Drawing.Point(418, 379);
            this.buttonLoadFromFile.Name = "buttonLoadFromFile";
            this.buttonLoadFromFile.Size = new System.Drawing.Size(120, 27);
            this.buttonLoadFromFile.TabIndex = 9;
            this.buttonLoadFromFile.Text = "Загрузить из файла";
            this.buttonLoadFromFile.UseVisualStyleBackColor = true;
            this.buttonLoadFromFile.Click += new System.EventHandler(this.buttonLoadFromFile_Click);
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.Location = new System.Drawing.Point(702, 379);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Size = new System.Drawing.Size(120, 27);
            this.buttonSaveToFile.TabIndex = 10;
            this.buttonSaveToFile.Text = "Сохранить в файл";
            this.buttonSaveToFile.UseVisualStyleBackColor = true;
            this.buttonSaveToFile.Click += new System.EventHandler(this.buttonSaveToFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 683);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.buttonLaunch);
            this.Controls.Add(this.SelectEncDec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownShift);
            this.Controls.Add(this.LanguageChoice);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.buttonLoadFromFile);
            this.Controls.Add(this.buttonSaveToFile);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShift)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.ComboBox LanguageChoice;
        private System.Windows.Forms.NumericUpDown numericUpDownShift;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SelectEncDec;
        private System.Windows.Forms.Button buttonLaunch;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonLoadFromFile;
        private System.Windows.Forms.Button buttonSaveToFile;
    }
}

