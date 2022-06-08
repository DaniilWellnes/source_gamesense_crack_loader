
namespace gamesense_crack
{
    partial class error
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(error));
            this.error_label = new System.Windows.Forms.Label();
            this.icon_error = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.icon_error)).BeginInit();
            this.SuspendLayout();
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(30)))));
            this.error_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F);
            this.error_label.ForeColor = System.Drawing.Color.White;
            this.error_label.Location = new System.Drawing.Point(74, 23);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(161, 20);
            this.error_label.TabIndex = 1;
            this.error_label.Text = "Process not found.";
            this.error_label.Click += new System.EventHandler(this.error_label_Click);
            // 
            // icon_error
            // 
            this.icon_error.BackColor = System.Drawing.Color.Transparent;
            this.icon_error.BaseColor = System.Drawing.Color.Black;
            this.icon_error.Image = ((System.Drawing.Image)(resources.GetObject("icon_error.Image")));
            this.icon_error.Location = new System.Drawing.Point(12, 12);
            this.icon_error.Name = "icon_error";
            this.icon_error.Size = new System.Drawing.Size(56, 43);
            this.icon_error.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_error.TabIndex = 3;
            this.icon_error.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(246, 68);
            this.Controls.Add(this.icon_error);
            this.Controls.Add(this.error_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "error";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gamesense: error";
            this.Load += new System.EventHandler(this.error_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icon_error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label error_label;
        private Guna.UI.WinForms.GunaTransfarantPictureBox icon_error;
        private System.Windows.Forms.Timer timer1;
    }
}