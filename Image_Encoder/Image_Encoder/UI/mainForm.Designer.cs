
namespace Project
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonChoice = new System.Windows.Forms.Button();
            this.buttonEncryptDownload = new System.Windows.Forms.Button();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.textBoxStartX = new System.Windows.Forms.TextBox();
            this.textBoxStartY = new System.Windows.Forms.TextBox();
            this.labelMenu = new System.Windows.Forms.Label();
            this.textBoxShiftY = new System.Windows.Forms.TextBox();
            this.textBoxShiftX = new System.Windows.Forms.TextBox();
            this.richTextBoxMessage = new System.Windows.Forms.RichTextBox();
            this.labelStartX = new System.Windows.Forms.Label();
            this.labelStartY = new System.Windows.Forms.Label();
            this.labelShiftY = new System.Windows.Forms.Label();
            this.labelShiftX = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.labelKey = new System.Windows.Forms.Label();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.buttonDecoder = new System.Windows.Forms.Button();
            this.buttonMessageDownload = new System.Windows.Forms.Button();
            this.richTextBoxDecoder = new System.Windows.Forms.RichTextBox();
            this.labelLenght = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(378, 485);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(240, 64);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Вихід";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonChoice
            // 
            this.buttonChoice.BackColor = System.Drawing.Color.Lime;
            this.buttonChoice.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.buttonChoice.Location = new System.Drawing.Point(378, 38);
            this.buttonChoice.Name = "buttonChoice";
            this.buttonChoice.Size = new System.Drawing.Size(240, 93);
            this.buttonChoice.TabIndex = 1;
            this.buttonChoice.Text = "Вибрати зображення ";
            this.buttonChoice.UseVisualStyleBackColor = false;
            this.buttonChoice.Click += new System.EventHandler(this.buttonChoice_Click);
            // 
            // buttonEncryptDownload
            // 
            this.buttonEncryptDownload.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonEncryptDownload.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.buttonEncryptDownload.Location = new System.Drawing.Point(674, 197);
            this.buttonEncryptDownload.Name = "buttonEncryptDownload";
            this.buttonEncryptDownload.Size = new System.Drawing.Size(235, 100);
            this.buttonEncryptDownload.TabIndex = 2;
            this.buttonEncryptDownload.Text = "Завантажити закодоване зображення";
            this.buttonEncryptDownload.UseVisualStyleBackColor = false;
            this.buttonEncryptDownload.Visible = false;
            this.buttonEncryptDownload.Click += new System.EventHandler(this.buttonEncryptDownload_Click);
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.BackColor = System.Drawing.Color.Orange;
            this.buttonEncrypt.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.buttonEncrypt.Location = new System.Drawing.Point(378, 197);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(240, 100);
            this.buttonEncrypt.TabIndex = 3;
            this.buttonEncrypt.Text = "Закодувати зображення";
            this.buttonEncrypt.UseVisualStyleBackColor = false;
            this.buttonEncrypt.Visible = false;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // textBoxStartX
            // 
            this.textBoxStartX.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStartX.Location = new System.Drawing.Point(200, 85);
            this.textBoxStartX.MaxLength = 5;
            this.textBoxStartX.Name = "textBoxStartX";
            this.textBoxStartX.Size = new System.Drawing.Size(128, 33);
            this.textBoxStartX.TabIndex = 4;
            // 
            // textBoxStartY
            // 
            this.textBoxStartY.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStartY.Location = new System.Drawing.Point(200, 133);
            this.textBoxStartY.MaxLength = 5;
            this.textBoxStartY.Name = "textBoxStartY";
            this.textBoxStartY.Size = new System.Drawing.Size(128, 33);
            this.textBoxStartY.TabIndex = 5;
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMenu.Location = new System.Drawing.Point(28, 18);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(313, 39);
            this.labelMenu.TabIndex = 6;
            this.labelMenu.Text = "Панель управління";
            // 
            // textBoxShiftY
            // 
            this.textBoxShiftY.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxShiftY.Location = new System.Drawing.Point(200, 245);
            this.textBoxShiftY.MaxLength = 5;
            this.textBoxShiftY.Name = "textBoxShiftY";
            this.textBoxShiftY.Size = new System.Drawing.Size(128, 33);
            this.textBoxShiftY.TabIndex = 8;
            // 
            // textBoxShiftX
            // 
            this.textBoxShiftX.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxShiftX.Location = new System.Drawing.Point(200, 197);
            this.textBoxShiftX.MaxLength = 5;
            this.textBoxShiftX.Name = "textBoxShiftX";
            this.textBoxShiftX.Size = new System.Drawing.Size(128, 33);
            this.textBoxShiftX.TabIndex = 7;
            // 
            // richTextBoxMessage
            // 
            this.richTextBoxMessage.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxMessage.Location = new System.Drawing.Point(35, 385);
            this.richTextBoxMessage.MaxLength = 1000;
            this.richTextBoxMessage.Name = "richTextBoxMessage";
            this.richTextBoxMessage.Size = new System.Drawing.Size(293, 164);
            this.richTextBoxMessage.TabIndex = 9;
            this.richTextBoxMessage.Text = "";
            // 
            // labelStartX
            // 
            this.labelStartX.AutoSize = true;
            this.labelStartX.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStartX.Location = new System.Drawing.Point(37, 88);
            this.labelStartX.Name = "labelStartX";
            this.labelStartX.Size = new System.Drawing.Size(157, 25);
            this.labelStartX.TabIndex = 10;
            this.labelStartX.Text = "Початковий Х";
            // 
            // labelStartY
            // 
            this.labelStartY.AutoSize = true;
            this.labelStartY.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStartY.Location = new System.Drawing.Point(37, 136);
            this.labelStartY.Name = "labelStartY";
            this.labelStartY.Size = new System.Drawing.Size(156, 25);
            this.labelStartY.TabIndex = 11;
            this.labelStartY.Text = "Початковий Y";
            // 
            // labelShiftY
            // 
            this.labelShiftY.AutoSize = true;
            this.labelShiftY.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelShiftY.Location = new System.Drawing.Point(78, 248);
            this.labelShiftY.Name = "labelShiftY";
            this.labelShiftY.Size = new System.Drawing.Size(114, 25);
            this.labelShiftY.TabIndex = 13;
            this.labelShiftY.Text = "Крок по Y";
            // 
            // labelShiftX
            // 
            this.labelShiftX.AutoSize = true;
            this.labelShiftX.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelShiftX.Location = new System.Drawing.Point(78, 200);
            this.labelShiftX.Name = "labelShiftX";
            this.labelShiftX.Size = new System.Drawing.Size(115, 25);
            this.labelShiftX.TabIndex = 12;
            this.labelShiftX.Text = "Крок по Х";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelData.Location = new System.Drawing.Point(58, 357);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(244, 25);
            this.labelData.TabIndex = 14;
            this.labelData.Text = "Поле для вводу даних";
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelKey.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKey.ForeColor = System.Drawing.Color.Maroon;
            this.labelKey.Location = new System.Drawing.Point(126, 312);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(66, 25);
            this.labelKey.TabIndex = 16;
            this.labelKey.Text = "Ключ";
            // 
            // textBoxKey
            // 
            this.textBoxKey.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxKey.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxKey.ForeColor = System.Drawing.Color.DarkGreen;
            this.textBoxKey.Location = new System.Drawing.Point(202, 309);
            this.textBoxKey.MaxLength = 4;
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(128, 33);
            this.textBoxKey.TabIndex = 15;
            // 
            // buttonDecoder
            // 
            this.buttonDecoder.BackColor = System.Drawing.Color.Firebrick;
            this.buttonDecoder.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.buttonDecoder.Location = new System.Drawing.Point(378, 319);
            this.buttonDecoder.Name = "buttonDecoder";
            this.buttonDecoder.Size = new System.Drawing.Size(240, 100);
            this.buttonDecoder.TabIndex = 18;
            this.buttonDecoder.Text = "Розкодувати зображення";
            this.buttonDecoder.UseVisualStyleBackColor = false;
            this.buttonDecoder.Visible = false;
            this.buttonDecoder.Click += new System.EventHandler(this.buttonDecoder_Click);
            // 
            // buttonMessageDownload
            // 
            this.buttonMessageDownload.BackColor = System.Drawing.Color.LightGreen;
            this.buttonMessageDownload.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.buttonMessageDownload.Location = new System.Drawing.Point(674, 319);
            this.buttonMessageDownload.Name = "buttonMessageDownload";
            this.buttonMessageDownload.Size = new System.Drawing.Size(235, 100);
            this.buttonMessageDownload.TabIndex = 19;
            this.buttonMessageDownload.Text = "Завантажити розкодовану інформацію";
            this.buttonMessageDownload.UseVisualStyleBackColor = false;
            this.buttonMessageDownload.Visible = false;
            this.buttonMessageDownload.Click += new System.EventHandler(this.buttonMessageDownload_Click);
            // 
            // richTextBoxDecoder
            // 
            this.richTextBoxDecoder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.richTextBoxDecoder.Location = new System.Drawing.Point(674, 38);
            this.richTextBoxDecoder.Name = "richTextBoxDecoder";
            this.richTextBoxDecoder.ReadOnly = true;
            this.richTextBoxDecoder.Size = new System.Drawing.Size(235, 142);
            this.richTextBoxDecoder.TabIndex = 20;
            this.richTextBoxDecoder.Text = "";
            this.richTextBoxDecoder.Visible = false;
            // 
            // labelLenght
            // 
            this.labelLenght.AutoSize = true;
            this.labelLenght.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLenght.Location = new System.Drawing.Point(21, 312);
            this.labelLenght.Name = "labelLenght";
            this.labelLenght.Size = new System.Drawing.Size(0, 25);
            this.labelLenght.TabIndex = 21;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.labelLenght);
            this.Controls.Add(this.richTextBoxDecoder);
            this.Controls.Add(this.buttonMessageDownload);
            this.Controls.Add(this.buttonDecoder);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelShiftY);
            this.Controls.Add(this.labelShiftX);
            this.Controls.Add(this.labelStartY);
            this.Controls.Add(this.labelStartX);
            this.Controls.Add(this.richTextBoxMessage);
            this.Controls.Add(this.textBoxShiftY);
            this.Controls.Add(this.textBoxShiftX);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.textBoxStartY);
            this.Controls.Add(this.textBoxStartX);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.buttonEncryptDownload);
            this.Controls.Add(this.buttonChoice);
            this.Controls.Add(this.buttonExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Encoder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonChoice;
        private System.Windows.Forms.Button buttonEncryptDownload;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.TextBox textBoxStartX;
        private System.Windows.Forms.TextBox textBoxStartY;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.TextBox textBoxShiftY;
        private System.Windows.Forms.TextBox textBoxShiftX;
        private System.Windows.Forms.RichTextBox richTextBoxMessage;
        private System.Windows.Forms.Label labelStartX;
        private System.Windows.Forms.Label labelStartY;
        private System.Windows.Forms.Label labelShiftY;
        private System.Windows.Forms.Label labelShiftX;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Button buttonDecoder;
        private System.Windows.Forms.Button buttonMessageDownload;
        private System.Windows.Forms.RichTextBox richTextBoxDecoder;
        private System.Windows.Forms.Label labelLenght;
    }
}

