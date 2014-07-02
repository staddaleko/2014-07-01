namespace BazyKontaktow
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonZapiszDane = new System.Windows.Forms.Button();
            this.buttonAkceptuj = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(526, 299);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(579, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "&Zapisz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonZapiszDane
            // 
            this.buttonZapiszDane.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonZapiszDane.Location = new System.Drawing.Point(0, 374);
            this.buttonZapiszDane.Name = "buttonZapiszDane";
            this.buttonZapiszDane.Size = new System.Drawing.Size(579, 23);
            this.buttonZapiszDane.TabIndex = 2;
            this.buttonZapiszDane.Text = "Zapisz &dane";
            this.buttonZapiszDane.UseVisualStyleBackColor = true;
            this.buttonZapiszDane.Click += new System.EventHandler(this.buttonZapiszDane_Click);
            // 
            // buttonAkceptuj
            // 
            this.buttonAkceptuj.BackColor = System.Drawing.SystemColors.Info;
            this.buttonAkceptuj.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.buttonAkceptuj.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonAkceptuj.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAkceptuj.Location = new System.Drawing.Point(0, 351);
            this.buttonAkceptuj.Name = "buttonAkceptuj";
            this.buttonAkceptuj.Size = new System.Drawing.Size(579, 23);
            this.buttonAkceptuj.TabIndex = 3;
            this.buttonAkceptuj.Text = "&Akceptuj";
            this.buttonAkceptuj.UseVisualStyleBackColor = false;
            this.buttonAkceptuj.Click += new System.EventHandler(this.buttonAkceptuj_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.Location = new System.Drawing.Point(0, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(579, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "&Zapisz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(579, 420);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonAkceptuj);
            this.Controls.Add(this.buttonZapiszDane);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonZapiszDane;
        private System.Windows.Forms.Button buttonAkceptuj;
        private System.Windows.Forms.Button button2;
    }
}

