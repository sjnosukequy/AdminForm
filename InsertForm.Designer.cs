namespace AdminForm
{
    partial class InsertForm
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
            this.UserID = new System.Windows.Forms.ComboBox();
            this.ShowTimeID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // UserID
            // 
            this.UserID.FormattingEnabled = true;
            this.UserID.Location = new System.Drawing.Point(21, 62);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(255, 24);
            this.UserID.TabIndex = 0;
            // 
            // ShowTimeID
            // 
            this.ShowTimeID.FormattingEnabled = true;
            this.ShowTimeID.Location = new System.Drawing.Point(21, 146);
            this.ShowTimeID.Name = "ShowTimeID";
            this.ShowTimeID.Size = new System.Drawing.Size(255, 24);
            this.ShowTimeID.TabIndex = 1;
            // 
            // InsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 556);
            this.Controls.Add(this.ShowTimeID);
            this.Controls.Add(this.UserID);
            this.Name = "InsertForm";
            this.Text = "InsertForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox UserID;
        private System.Windows.Forms.ComboBox ShowTimeID;
    }
}