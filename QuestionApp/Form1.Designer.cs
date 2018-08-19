namespace Questions
{
    partial class QuestionForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Answer1 = new System.Windows.Forms.Button();
            this.Question = new System.Windows.Forms.Label();
            this.Answer2 = new System.Windows.Forms.Button();
            this.Answer3 = new System.Windows.Forms.Button();
            this.Answer4 = new System.Windows.Forms.Button();
            this.QuestionImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionImage)).BeginInit();
            this.SuspendLayout();
            // 
            // Answer1
            // 
            this.Answer1.Location = new System.Drawing.Point(186, 420);
            this.Answer1.Name = "Answer1";
            this.Answer1.Size = new System.Drawing.Size(75, 23);
            this.Answer1.TabIndex = 0;
            this.Answer1.Text = "回答1";
            this.Answer1.UseVisualStyleBackColor = true;
            this.Answer1.Click += new System.EventHandler(this.answer1_Click);
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.Location = new System.Drawing.Point(53, 9);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(41, 12);
            this.Question.TabIndex = 1;
            this.Question.Text = "問題文";
            // 
            // Answer2
            // 
            this.Answer2.Location = new System.Drawing.Point(287, 420);
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(75, 23);
            this.Answer2.TabIndex = 2;
            this.Answer2.Text = "回答2";
            this.Answer2.UseVisualStyleBackColor = true;
            this.Answer2.Click += new System.EventHandler(this.answer2_Click);
            // 
            // Answer3
            // 
            this.Answer3.Location = new System.Drawing.Point(383, 420);
            this.Answer3.Name = "Answer3";
            this.Answer3.Size = new System.Drawing.Size(75, 23);
            this.Answer3.TabIndex = 3;
            this.Answer3.Text = "回答3";
            this.Answer3.UseVisualStyleBackColor = true;
            this.Answer3.Click += new System.EventHandler(this.answer3_Click);
            // 
            // Answer4
            // 
            this.Answer4.Location = new System.Drawing.Point(480, 420);
            this.Answer4.Name = "Answer4";
            this.Answer4.Size = new System.Drawing.Size(75, 23);
            this.Answer4.TabIndex = 4;
            this.Answer4.Text = "回答4";
            this.Answer4.UseVisualStyleBackColor = true;
            this.Answer4.Click += new System.EventHandler(this.answer4_Click);
            // 
            // QuestionImage
            // 
            this.QuestionImage.Location = new System.Drawing.Point(135, 30);
            this.QuestionImage.Name = "QuestionImage";
            this.QuestionImage.Size = new System.Drawing.Size(512, 384);
            this.QuestionImage.TabIndex = 5;
            this.QuestionImage.TabStop = false;
            // 
            // sample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.QuestionImage);
            this.Controls.Add(this.Answer4);
            this.Controls.Add(this.Answer3);
            this.Controls.Add(this.Answer2);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.Answer1);
            this.Name = "sample";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.QuestionImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Answer1;
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.Button Answer2;
        private System.Windows.Forms.Button Answer3;
        private System.Windows.Forms.Button Answer4;
        private System.Windows.Forms.PictureBox QuestionImage;
    }
}

