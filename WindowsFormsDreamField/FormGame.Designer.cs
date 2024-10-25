namespace WindowsFormsDreamField
{
    partial class FormGame
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
            this.pictureBoxGallows = new System.Windows.Forms.PictureBox();
            this.labelTemplate = new System.Windows.Forms.Label();
            this.textBoxLetter = new System.Windows.Forms.TextBox();
            this.buttonCheckLetter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGallows)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxGallows
            // 
            this.pictureBoxGallows.Location = new System.Drawing.Point(530, 97);
            this.pictureBoxGallows.Name = "pictureBoxGallows";
            this.pictureBoxGallows.Size = new System.Drawing.Size(157, 194);
            this.pictureBoxGallows.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGallows.TabIndex = 0;
            this.pictureBoxGallows.TabStop = false;
            // 
            // labelTemplate
            // 
            this.labelTemplate.AutoSize = true;
            this.labelTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTemplate.Location = new System.Drawing.Point(75, 74);
            this.labelTemplate.Name = "labelTemplate";
            this.labelTemplate.Size = new System.Drawing.Size(311, 108);
            this.labelTemplate.TabIndex = 1;
            this.labelTemplate.Text = "*******";
            // 
            // textBoxLetter
            // 
            this.textBoxLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLetter.Location = new System.Drawing.Point(93, 204);
            this.textBoxLetter.Name = "textBoxLetter";
            this.textBoxLetter.Size = new System.Drawing.Size(48, 49);
            this.textBoxLetter.TabIndex = 2;
            this.textBoxLetter.Text = "а";
            // 
            // buttonCheckLetter
            // 
            this.buttonCheckLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCheckLetter.Location = new System.Drawing.Point(192, 207);
            this.buttonCheckLetter.Name = "buttonCheckLetter";
            this.buttonCheckLetter.Size = new System.Drawing.Size(286, 49);
            this.buttonCheckLetter.TabIndex = 3;
            this.buttonCheckLetter.Text = "Проверить букву";
            this.buttonCheckLetter.UseVisualStyleBackColor = true;
            this.buttonCheckLetter.Click += new System.EventHandler(this.buttonCheckLetter_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCheckLetter);
            this.Controls.Add(this.textBoxLetter);
            this.Controls.Add(this.labelTemplate);
            this.Controls.Add(this.pictureBoxGallows);
            this.Name = "FormGame";
            this.Text = "Поле чудес или висилица";
            this.Load += new System.EventHandler(this.FormGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGallows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxGallows;
        private System.Windows.Forms.Label labelTemplate;
        private System.Windows.Forms.TextBox textBoxLetter;
        private System.Windows.Forms.Button buttonCheckLetter;
    }
}

