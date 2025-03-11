namespace VarlıkZimmetDepoYonetimi.UI
{
    partial class FrmUrunEkleSecim
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
            RbtnBarkodluUrun = new RadioButton();
            RbtnBarkodsuzUrun = new RadioButton();
            BtnSec = new Button();
            label1 = new Label();
            rbtnZimmetAtama = new RadioButton();
            SuspendLayout();
            // 
            // RbtnBarkodluUrun
            // 
            RbtnBarkodluUrun.Location = new Point(12, 127);
            RbtnBarkodluUrun.Name = "RbtnBarkodluUrun";
            RbtnBarkodluUrun.Size = new Size(186, 52);
            RbtnBarkodluUrun.TabIndex = 0;
            RbtnBarkodluUrun.TabStop = true;
            RbtnBarkodluUrun.Text = "Barkodlu Ürün Ekle";
            RbtnBarkodluUrun.UseVisualStyleBackColor = true;
            // 
            // RbtnBarkodsuzUrun
            // 
            RbtnBarkodsuzUrun.Location = new Point(12, 52);
            RbtnBarkodsuzUrun.Name = "RbtnBarkodsuzUrun";
            RbtnBarkodsuzUrun.Size = new Size(267, 47);
            RbtnBarkodsuzUrun.TabIndex = 0;
            RbtnBarkodsuzUrun.TabStop = true;
            RbtnBarkodsuzUrun.Text = "Barkodsuz Ürün Ekle";
            RbtnBarkodsuzUrun.UseVisualStyleBackColor = true;
            // 
            // BtnSec
            // 
            BtnSec.BackColor = Color.IndianRed;
            BtnSec.Location = new Point(12, 196);
            BtnSec.Name = "BtnSec";
            BtnSec.Size = new Size(386, 23);
            BtnSec.TabIndex = 1;
            BtnSec.Text = ">>>>>>>>>>>>>>>>>>>>>>>>>>>SEÇİM";
            BtnSec.UseVisualStyleBackColor = false;
            BtnSec.Click += BtnSec_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(255, 192, 192);
            label1.Location = new Point(48, 9);
            label1.Name = "label1";
            label1.Size = new Size(325, 23);
            label1.TabIndex = 2;
            label1.Text = "<<<<<<<<<<<<<<SEÇENEKLER>>>>>>>>>>>\r\n";
            // 
            // rbtnZimmetAtama
            // 
            rbtnZimmetAtama.AutoSize = true;
            rbtnZimmetAtama.Location = new Point(195, 66);
            rbtnZimmetAtama.Name = "rbtnZimmetAtama";
            rbtnZimmetAtama.Size = new Size(86, 19);
            rbtnZimmetAtama.TabIndex = 3;
            rbtnZimmetAtama.TabStop = true;
            rbtnZimmetAtama.Text = "Zimmet ata";
            rbtnZimmetAtama.UseVisualStyleBackColor = true;
            // 
            // FrmUrunEkleSecim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 231);
            Controls.Add(rbtnZimmetAtama);
            Controls.Add(label1);
            Controls.Add(BtnSec);
            Controls.Add(RbtnBarkodsuzUrun);
            Controls.Add(RbtnBarkodluUrun);
            Name = "FrmUrunEkleSecim";
            Text = "FrmUrunEkleSecim";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton RbtnBarkodluUrun;
        private RadioButton RbtnBarkodsuzUrun;
        private Button BtnSec;
        private Label label1;
        private RadioButton rbtnZimmetAtama;
    }
}