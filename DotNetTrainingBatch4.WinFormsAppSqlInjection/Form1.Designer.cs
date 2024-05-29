namespace DotNetTrainingBatch4.WinFormsAppSqlInjection;

partial class Form1
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
        btnLogin = new Button();
        txtEmail = new TextBox();
        txtPassword = new TextBox();
        SuspendLayout();
        // 
        // btnLogin
        // 
        btnLogin.Location = new Point(122, 175);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(99, 35);
        btnLogin.TabIndex = 0;
        btnLogin.Text = "&Login";
        btnLogin.UseVisualStyleBackColor = true;
        btnLogin.Click += btnLogin_Click;
        // 
        // txtEmail
        // 
        txtEmail.Location = new Point(122, 99);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(439, 32);
        txtEmail.TabIndex = 1;
        // 
        // txtPassword
        // 
        txtPassword.Location = new Point(122, 137);
        txtPassword.Name = "txtPassword";
        txtPassword.Size = new Size(439, 32);
        txtPassword.TabIndex = 2;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(683, 327);
        Controls.Add(txtPassword);
        Controls.Add(txtEmail);
        Controls.Add(btnLogin);
        Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        Margin = new Padding(4, 4, 4, 4);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnLogin;
    private TextBox txtEmail;
    private TextBox txtPassword;
}
