
namespace Savas2
{
    partial class AnaForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.bilgiPanel = new System.Windows.Forms.Panel();
            this.skorlbl = new System.Windows.Forms.Label();
            this.sureLabel = new System.Windows.Forms.Label();
            this.bilgiLabel = new System.Windows.Forms.Label();
            this.savasAlaniPanel = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ucaksavarPanel = new System.Windows.Forms.Panel();
            this.bilgiPanel.SuspendLayout();
            this.savasAlaniPanel.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // bilgiPanel
            // 
            this.bilgiPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.bilgiPanel.Controls.Add(this.skorlbl);
            this.bilgiPanel.Controls.Add(this.sureLabel);
            this.bilgiPanel.Controls.Add(this.bilgiLabel);
            this.bilgiPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bilgiPanel.Location = new System.Drawing.Point(0, 0);
            this.bilgiPanel.Name = "bilgiPanel";
            this.bilgiPanel.Size = new System.Drawing.Size(1368, 104);
            this.bilgiPanel.TabIndex = 0;
            // 
            // skorlbl
            // 
            this.skorlbl.AutoSize = true;
            this.skorlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skorlbl.ForeColor = System.Drawing.Color.White;
            this.skorlbl.Location = new System.Drawing.Point(831, 11);
            this.skorlbl.Name = "skorlbl";
            this.skorlbl.Size = new System.Drawing.Size(36, 39);
            this.skorlbl.TabIndex = 2;
            this.skorlbl.Text = "0";
            // 
            // sureLabel
            // 
            this.sureLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sureLabel.ForeColor = System.Drawing.Color.White;
            this.sureLabel.Location = new System.Drawing.Point(1152, 11);
            this.sureLabel.Name = "sureLabel";
            this.sureLabel.Size = new System.Drawing.Size(204, 82);
            this.sureLabel.TabIndex = 1;
            this.sureLabel.Text = "0:00";
            this.sureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sureLabel.Click += new System.EventHandler(this.sureLabel_Click);
            // 
            // bilgiLabel
            // 
            this.bilgiLabel.AutoSize = true;
            this.bilgiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilgiLabel.ForeColor = System.Drawing.Color.White;
            this.bilgiLabel.Location = new System.Drawing.Point(3, 0);
            this.bilgiLabel.Name = "bilgiLabel";
            this.bilgiLabel.Size = new System.Drawing.Size(767, 93);
            this.bilgiLabel.TabIndex = 0;
            this.bilgiLabel.Text = "Oyunu başlatmak için ENTER tuşuna basın.\r\nUçaksavarı hareket ettirmek için SAĞ/SO" +
    "L yön tuşlarına basın.\r\nAteş etmek için BOŞLUK tuşuna basın.\r\n";
            // 
            // savasAlaniPanel
            // 
            this.savasAlaniPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.savasAlaniPanel.Controls.Add(this.menu);
            this.savasAlaniPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.savasAlaniPanel.Location = new System.Drawing.Point(0, 104);
            this.savasAlaniPanel.Name = "savasAlaniPanel";
            this.savasAlaniPanel.Size = new System.Drawing.Size(1368, 493);
            this.savasAlaniPanel.TabIndex = 1;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.SlateGray;
            this.menu.Controls.Add(this.button1);
            this.menu.Controls.Add(this.label1);
            this.menu.Location = new System.Drawing.Point(603, 117);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(200, 200);
            this.menu.TabIndex = 0;
            this.menu.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(34, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Continue";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pause";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucaksavarPanel
            // 
            this.ucaksavarPanel.BackColor = System.Drawing.Color.Teal;
            this.ucaksavarPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucaksavarPanel.Location = new System.Drawing.Point(0, 547);
            this.ucaksavarPanel.Name = "ucaksavarPanel";
            this.ucaksavarPanel.Size = new System.Drawing.Size(1368, 50);
            this.ucaksavarPanel.TabIndex = 2;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 597);
            this.Controls.Add(this.ucaksavarPanel);
            this.Controls.Add(this.savasAlaniPanel);
            this.Controls.Add(this.bilgiPanel);
            this.Name = "AnaForm";
            this.Text = "Savaş Oyunu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnaForm_KeyDown);
            this.bilgiPanel.ResumeLayout(false);
            this.bilgiPanel.PerformLayout();
            this.savasAlaniPanel.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bilgiPanel;
        private System.Windows.Forms.Label sureLabel;
        private System.Windows.Forms.Label bilgiLabel;
        private System.Windows.Forms.Panel savasAlaniPanel;
        private System.Windows.Forms.Panel ucaksavarPanel;
        private System.Windows.Forms.Label skorlbl;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

