namespace ClinicApp.UI;

partial class LoginForm
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
        EmailInput = new TextBox();
        label1 = new Label();
        label2 = new Label();
        textBox1 = new TextBox();
        loginButton = new Button();
        SuspendLayout();
        // 
        // EmailInput
        // 
        EmailInput.Location = new Point(103, 25);
        EmailInput.Name = "EmailInput";
        EmailInput.Size = new Size(216, 23);
        EmailInput.TabIndex = 0;
        EmailInput.TextChanged += textBox1_TextChanged;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(25, 25);
        label1.Name = "label1";
        label1.Size = new Size(42, 15);
        label1.TabIndex = 1;
        label1.Text = "Email :";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(25, 66);
        label2.Name = "label2";
        label2.Size = new Size(57, 15);
        label2.TabIndex = 3;
        label2.Text = "Password";
        // 
        // textBox1
        // 
        textBox1.Location = new Point(103, 66);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(75, 23);
        textBox1.TabIndex = 2;
        // 
        // loginButton
        // 
        loginButton.Location = new Point(103, 113);
        loginButton.Name = "loginButton";
        loginButton.Size = new Size(75, 23);
        loginButton.TabIndex = 4;
        loginButton.Text = "Login";
        loginButton.UseVisualStyleBackColor = true;
        loginButton.Click += loginButton_Click;
        // 
        // LoginForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(613, 220);
        Controls.Add(loginButton);
        Controls.Add(label2);
        Controls.Add(textBox1);
        Controls.Add(label1);
        Controls.Add(EmailInput);
        Name = "LoginForm";
        Text = "LoginForm";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox EmailInput;
    private Label label1;
    private Label label2;
    private TextBox textBox1;
    private Button loginButton;
}