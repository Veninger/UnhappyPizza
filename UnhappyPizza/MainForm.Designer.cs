namespace UnhappyPizza
{
    partial class MainForm
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
            this.btnStart = new System.Windows.Forms.Button();
            this.tbMain = new System.Windows.Forms.TextBox();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.btnFeck = new System.Windows.Forms.Button();
            this.btnLucky = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(522, 13);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "meflu";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbMain
            // 
            this.tbMain.Location = new System.Drawing.Point(12, 42);
            this.tbMain.Multiline = true;
            this.tbMain.Name = "tbMain";
            this.tbMain.Size = new System.Drawing.Size(748, 462);
            this.tbMain.TabIndex = 1;
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(12, 6);
            this.tbUrl.Multiline = true;
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(231, 30);
            this.tbUrl.TabIndex = 2;
            this.tbUrl.Text = "http://fasz/";
            // 
            // btnFeck
            // 
            this.btnFeck.Location = new System.Drawing.Point(603, 13);
            this.btnFeck.Name = "btnFeck";
            this.btnFeck.Size = new System.Drawing.Size(75, 23);
            this.btnFeck.TabIndex = 3;
            this.btnFeck.Text = "plo";
            this.btnFeck.UseVisualStyleBackColor = true;
            this.btnFeck.Click += new System.EventHandler(this.btnFeck_Click);
            // 
            // btnLucky
            // 
            this.btnLucky.Location = new System.Drawing.Point(685, 13);
            this.btnLucky.Name = "btnLucky";
            this.btnLucky.Size = new System.Drawing.Size(75, 23);
            this.btnLucky.TabIndex = 4;
            this.btnLucky.Text = "I feel lucky";
            this.btnLucky.UseVisualStyleBackColor = true;
            this.btnLucky.Click += new System.EventHandler(this.btnLucky_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 510);
            this.Controls.Add(this.btnLucky);
            this.Controls.Add(this.btnFeck);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.tbMain);
            this.Controls.Add(this.btnStart);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbMain;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Button btnFeck;
        private System.Windows.Forms.Button btnLucky;
    }
}

