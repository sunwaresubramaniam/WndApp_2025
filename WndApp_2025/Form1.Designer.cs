namespace WndApp_2025
{
    partial class frmMTLSCertTesting
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
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmdFetch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtResult.Location = new System.Drawing.Point(0, 108);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(800, 342);
            this.txtResult.TabIndex = 0;
            this.txtResult.Text = "";
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(639, 10);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(126, 42);
            this.cmdClear.TabIndex = 1;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // cmdFetch
            // 
            this.cmdFetch.Location = new System.Drawing.Point(639, 58);
            this.cmdFetch.Name = "cmdFetch";
            this.cmdFetch.Size = new System.Drawing.Size(126, 42);
            this.cmdFetch.TabIndex = 2;
            this.cmdFetch.Text = "Go..";
            this.cmdFetch.UseVisualStyleBackColor = true;
            this.cmdFetch.Click += new System.EventHandler(this.cmdFetch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "API Url";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(28, 66);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(605, 26);
            this.txtUrl.TabIndex = 4;
            // 
            // frmMTLSCertTesting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdFetch);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.txtResult);
            this.MaximizeBox = false;
            this.Name = "frmMTLSCertTesting";
            this.ShowIcon = false;
            this.Text = "Request From MTLS Certificate Testing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Button cmdFetch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrl;
    }
}

