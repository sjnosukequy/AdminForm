﻿partial class LoginForm
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
            this.UserID_tb = new System.Windows.Forms.TextBox();
            this.Password_tb = new System.Windows.Forms.TextBox();
            this.Login_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserID_tb
            // 
            this.UserID_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserID_tb.Location = new System.Drawing.Point(96, 68);
            this.UserID_tb.Margin = new System.Windows.Forms.Padding(4);
            this.UserID_tb.Name = "UserID_tb";
            this.UserID_tb.Size = new System.Drawing.Size(187, 34);
            this.UserID_tb.TabIndex = 20;
            // 
            // Password_tb
            // 
            this.Password_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_tb.Location = new System.Drawing.Point(96, 124);
            this.Password_tb.Margin = new System.Windows.Forms.Padding(4);
            this.Password_tb.Name = "Password_tb";
            this.Password_tb.Size = new System.Drawing.Size(187, 34);
            this.Password_tb.TabIndex = 22;
            // 
            // Login_btn
            // 
            this.Login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_btn.Location = new System.Drawing.Point(315, 90);
            this.Login_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(112, 36);
            this.Login_btn.TabIndex = 23;
            this.Login_btn.Tag = "NoDel";
            this.Login_btn.Text = "Login";
            this.Login_btn.UseVisualStyleBackColor = true;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 204);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.Password_tb);
            this.Controls.Add(this.UserID_tb);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Login";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.TextBox UserID_tb;
    private System.Windows.Forms.TextBox Password_tb;
    private System.Windows.Forms.Button Login_btn;
}