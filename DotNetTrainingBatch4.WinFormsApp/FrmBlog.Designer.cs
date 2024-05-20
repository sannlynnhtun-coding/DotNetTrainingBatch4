namespace DotNetTrainingBatch4.WinFormsApp
{
    partial class FrmBlog
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            txtContent = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(158, 71);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(436, 30);
            txtTitle.TabIndex = 1;
            txtTitle.TextChanged += txtTitle_TextChanged;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(158, 130);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(436, 30);
            txtAuthor.TabIndex = 2;
            // 
            // txtContent
            // 
            txtContent.Location = new Point(158, 198);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(436, 102);
            txtContent.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(158, 45);
            label1.Name = "label1";
            label1.Size = new Size(51, 23);
            label1.TabIndex = 4;
            label1.Text = "Title :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(158, 104);
            label2.Name = "label2";
            label2.Size = new Size(72, 23);
            label2.TabIndex = 5;
            label2.Text = "Author :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(158, 163);
            label3.Name = "label3";
            label3.Size = new Size(81, 23);
            label3.TabIndex = 6;
            label3.Text = "Content :";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(67, 160, 71);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(258, 306);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 35);
            btnSave.TabIndex = 7;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(84, 110, 122);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(158, 306);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 35);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "C&ancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // FrmBlog
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 518);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtContent);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FrmBlog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Blog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private TextBox txtContent;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSave;
        private Button btnCancel;
    }
}
