namespace WindowsFormsApp2
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
            this.progress = new System.Windows.Forms.ProgressBar();
            this.file_location = new System.Windows.Forms.Button();
            this.review = new System.Windows.Forms.Button();
            this.done = new System.Windows.Forms.Button();
            this.way_fileCopy = new System.Windows.Forms.TextBox();
            this.way_filePaste = new System.Windows.Forms.TextBox();
            this.agree = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(12, 70);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(247, 23);
            this.progress.TabIndex = 0;
            // 
            // file_location
            // 
            this.file_location.Location = new System.Drawing.Point(265, 10);
            this.file_location.Name = "file_location";
            this.file_location.Size = new System.Drawing.Size(75, 23);
            this.file_location.TabIndex = 1;
            this.file_location.Text = "File_location";
            this.file_location.UseVisualStyleBackColor = true;
            this.file_location.Click += new System.EventHandler(this.file_location_Click);
            // 
            // review
            // 
            this.review.Location = new System.Drawing.Point(265, 42);
            this.review.Name = "review";
            this.review.Size = new System.Drawing.Size(75, 23);
            this.review.TabIndex = 2;
            this.review.Text = "review";
            this.review.UseVisualStyleBackColor = true;
            this.review.Click += new System.EventHandler(this.review_Click);
            // 
            // done
            // 
            this.done.Location = new System.Drawing.Point(265, 70);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(75, 23);
            this.done.TabIndex = 3;
            this.done.Text = "do";
            this.done.UseVisualStyleBackColor = true;
            this.done.Click += new System.EventHandler(this.done_Click);
            // 
            // way_fileCopy
            // 
            this.way_fileCopy.Location = new System.Drawing.Point(12, 12);
            this.way_fileCopy.Name = "way_fileCopy";
            this.way_fileCopy.Size = new System.Drawing.Size(247, 20);
            this.way_fileCopy.TabIndex = 4;
            // 
            // way_filePaste
            // 
            this.way_filePaste.Location = new System.Drawing.Point(12, 44);
            this.way_filePaste.Name = "way_filePaste";
            this.way_filePaste.Size = new System.Drawing.Size(247, 20);
            this.way_filePaste.TabIndex = 5;
            // 
            // agree
            // 
            this.agree.AutoSize = true;
            this.agree.Location = new System.Drawing.Point(12, 99);
            this.agree.Name = "agree";
            this.agree.Size = new System.Drawing.Size(143, 17);
            this.agree.TabIndex = 6;
            this.agree.Text = "I\'am agree with condition";
            this.agree.UseVisualStyleBackColor = true;
            this.agree.CheckedChanged += new System.EventHandler(this.agree_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 134);
            this.Controls.Add(this.agree);
            this.Controls.Add(this.way_filePaste);
            this.Controls.Add(this.way_fileCopy);
            this.Controls.Add(this.done);
            this.Controls.Add(this.review);
            this.Controls.Add(this.file_location);
            this.Controls.Add(this.progress);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Button file_location;
        private System.Windows.Forms.Button review;
        private System.Windows.Forms.Button done;
        private System.Windows.Forms.TextBox way_fileCopy;
        private System.Windows.Forms.TextBox way_filePaste;
        private System.Windows.Forms.CheckBox agree;
    }
}

