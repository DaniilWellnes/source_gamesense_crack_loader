
namespace gamesense_crack
{
    partial class correct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(correct));
            this.label1 = new System.Windows.Forms.Label();
            this.inject_correct = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.inject_correct)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(30)))));
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inject!";
            // 
            // inject_correct
            // 
            this.inject_correct.BackColor = System.Drawing.Color.Transparent;
            this.inject_correct.BaseColor = System.Drawing.Color.Black;
            this.inject_correct.Image = global::gamesense_crack.Properties.Resources.correct;
            this.inject_correct.Location = new System.Drawing.Point(12, 13);
            this.inject_correct.Name = "inject_correct";
            this.inject_correct.Size = new System.Drawing.Size(56, 43);
            this.inject_correct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inject_correct.TabIndex = 1;
            this.inject_correct.TabStop = false;
            this.inject_correct.Click += new System.EventHandler(this.inject_correct_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // correct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(145, 68);
            this.Controls.Add(this.inject_correct);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "correct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gamesense: inject";
            this.Load += new System.EventHandler(this.other_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inject_correct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTransfarantPictureBox inject_correct;
        private System.Windows.Forms.Timer timer1;
    }
}