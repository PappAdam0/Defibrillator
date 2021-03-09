namespace Defi
{
    partial class foForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mTBX = new System.Windows.Forms.MaskedTextBox();
            this.mTBY = new System.Windows.Forms.MaskedTextBox();
            this.btAdatok = new System.Windows.Forms.Button();
            this.lBKiiras = new System.Windows.Forms.ListBox();
            this.btnUjAdat = new System.Windows.Forms.Button();
            this.btnKilepes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "X Koordinata";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y Koordinata";
            // 
            // mTBX
            // 
            this.mTBX.Location = new System.Drawing.Point(220, 21);
            this.mTBX.Name = "mTBX";
            this.mTBX.Size = new System.Drawing.Size(100, 26);
            this.mTBX.TabIndex = 2;
            // 
            // mTBY
            // 
            this.mTBY.Location = new System.Drawing.Point(220, 63);
            this.mTBY.Name = "mTBY";
            this.mTBY.Size = new System.Drawing.Size(100, 26);
            this.mTBY.TabIndex = 3;
            // 
            // btAdatok
            // 
            this.btAdatok.Location = new System.Drawing.Point(134, 95);
            this.btAdatok.Name = "btAdatok";
            this.btAdatok.Size = new System.Drawing.Size(162, 30);
            this.btAdatok.TabIndex = 4;
            this.btAdatok.Text = "Adatok lekérdezése";
            this.btAdatok.UseVisualStyleBackColor = true;
            this.btAdatok.Click += new System.EventHandler(this.btAdatok_Click);
            // 
            // lBKiiras
            // 
            this.lBKiiras.FormattingEnabled = true;
            this.lBKiiras.ItemHeight = 20;
            this.lBKiiras.Location = new System.Drawing.Point(60, 146);
            this.lBKiiras.Name = "lBKiiras";
            this.lBKiiras.Size = new System.Drawing.Size(302, 244);
            this.lBKiiras.TabIndex = 5;
            // 
            // btnUjAdat
            // 
            this.btnUjAdat.Location = new System.Drawing.Point(12, 436);
            this.btnUjAdat.Name = "btnUjAdat";
            this.btnUjAdat.Size = new System.Drawing.Size(162, 30);
            this.btnUjAdat.TabIndex = 6;
            this.btnUjAdat.Text = "Új adat lekérdezése";
            this.btnUjAdat.UseVisualStyleBackColor = true;
            this.btnUjAdat.Click += new System.EventHandler(this.btnUjAdat_Click);
            // 
            // btnKilepes
            // 
            this.btnKilepes.Location = new System.Drawing.Point(269, 436);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(162, 30);
            this.btnKilepes.TabIndex = 7;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = true;
            this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
            // 
            // foForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 478);
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.btnUjAdat);
            this.Controls.Add(this.lBKiiras);
            this.Controls.Add(this.btAdatok);
            this.Controls.Add(this.mTBY);
            this.Controls.Add(this.mTBX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "foForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mTBX;
        private System.Windows.Forms.MaskedTextBox mTBY;
        private System.Windows.Forms.Button btAdatok;
        private System.Windows.Forms.ListBox lBKiiras;
        private System.Windows.Forms.Button btnUjAdat;
        private System.Windows.Forms.Button btnKilepes;
    }
}

