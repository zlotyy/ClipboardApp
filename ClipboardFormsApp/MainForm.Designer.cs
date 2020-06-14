namespace ClipboardFormsApp
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
            this.Btn_ReloadClipboardFile = new System.Windows.Forms.Button();
            this.Lbl_MinimizeThisApp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_ReloadClipboardFile
            // 
            this.Btn_ReloadClipboardFile.Location = new System.Drawing.Point(46, 129);
            this.Btn_ReloadClipboardFile.Name = "Btn_ReloadClipboardFile";
            this.Btn_ReloadClipboardFile.Size = new System.Drawing.Size(242, 32);
            this.Btn_ReloadClipboardFile.TabIndex = 0;
            this.Btn_ReloadClipboardFile.Text = "Załaduj ponownie plik ze skrótami";
            this.Btn_ReloadClipboardFile.UseVisualStyleBackColor = true;
            this.Btn_ReloadClipboardFile.Click += new System.EventHandler(this.Btn_ReloadClipboardFile_Click);
            // 
            // Lbl_MinimizeThisApp
            // 
            this.Lbl_MinimizeThisApp.AutoSize = true;
            this.Lbl_MinimizeThisApp.Location = new System.Drawing.Point(43, 31);
            this.Lbl_MinimizeThisApp.Name = "Lbl_MinimizeThisApp";
            this.Lbl_MinimizeThisApp.Size = new System.Drawing.Size(350, 17);
            this.Lbl_MinimizeThisApp.TabIndex = 1;
            this.Lbl_MinimizeThisApp.Text = "Zminimalizuj sobie tą aplikacje żeby nie przeszkadzała";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zmień skróty w pliku Skroty.txt i kliknij ten przycisk żeby przeładować plik";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 205);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_MinimizeThisApp);
            this.Controls.Add(this.Btn_ReloadClipboardFile);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_ReloadClipboardFile;
        private System.Windows.Forms.Label Lbl_MinimizeThisApp;
        private System.Windows.Forms.Label label1;
    }
}

