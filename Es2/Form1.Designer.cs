namespace Es2
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.tot = new System.Windows.Forms.Label();
            this.somma = new System.Windows.Forms.Button();
            this.lst = new System.Windows.Forms.ListBox();
            this.Add = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Total = new System.Windows.Forms.Button();
            this.totale = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.TextBox();
            this.opposto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(12, 18);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 0;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(12, 73);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 1;
            // 
            // tot
            // 
            this.tot.AutoSize = true;
            this.tot.Location = new System.Drawing.Point(38, 177);
            this.tot.Name = "tot";
            this.tot.Size = new System.Drawing.Size(37, 13);
            this.tot.TabIndex = 2;
            this.tot.Text = "Totale";
            // 
            // somma
            // 
            this.somma.Location = new System.Drawing.Point(23, 118);
            this.somma.Name = "somma";
            this.somma.Size = new System.Drawing.Size(75, 23);
            this.somma.TabIndex = 3;
            this.somma.Text = "somma";
            this.somma.UseVisualStyleBackColor = true;
            this.somma.Click += new System.EventHandler(this.somma_Click);
            // 
            // lst
            // 
            this.lst.FormattingEnabled = true;
            this.lst.Location = new System.Drawing.Point(668, 18);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(120, 95);
            this.lst.TabIndex = 4;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(566, 118);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 5;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(566, 147);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(566, 177);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(75, 23);
            this.Total.TabIndex = 7;
            this.Total.Text = "Totale";
            this.Total.UseVisualStyleBackColor = true;
            this.Total.Click += new System.EventHandler(this.Total_Click);
            // 
            // totale
            // 
            this.totale.Location = new System.Drawing.Point(541, 73);
            this.totale.Name = "totale";
            this.totale.Size = new System.Drawing.Size(100, 20);
            this.totale.TabIndex = 8;
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(541, 18);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(100, 20);
            this.txt.TabIndex = 9;
            // 
            // opposto
            // 
            this.opposto.Location = new System.Drawing.Point(421, 15);
            this.opposto.Name = "opposto";
            this.opposto.Size = new System.Drawing.Size(75, 23);
            this.opposto.TabIndex = 10;
            this.opposto.Text = "Opposto";
            this.opposto.UseVisualStyleBackColor = true;
            this.opposto.Click += new System.EventHandler(this.opposto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.opposto);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.totale);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.lst);
            this.Controls.Add(this.somma);
            this.Controls.Add(this.tot);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label tot;
        private System.Windows.Forms.Button somma;
        private System.Windows.Forms.ListBox lst;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Total;
        private System.Windows.Forms.TextBox totale;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button opposto;
    }
}

