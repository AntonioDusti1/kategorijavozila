namespace kategorijavozila
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
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtBrojKotaca = new System.Windows.Forms.TextBox();
            this.txtGodinaProizvodnje = new System.Windows.Forms.TextBox();
            this.txtIspis = new System.Windows.Forms.TextBox();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.btnObradi = new System.Windows.Forms.Button();
            this.btnIspis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(79, 82);
            this.txtModel.Multiline = true;
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(218, 26);
            this.txtModel.TabIndex = 0;
            // 
            // txtBrojKotaca
            // 
            this.txtBrojKotaca.Location = new System.Drawing.Point(79, 139);
            this.txtBrojKotaca.Multiline = true;
            this.txtBrojKotaca.Name = "txtBrojKotaca";
            this.txtBrojKotaca.Size = new System.Drawing.Size(218, 26);
            this.txtBrojKotaca.TabIndex = 1;
            // 
            // txtGodinaProizvodnje
            // 
            this.txtGodinaProizvodnje.Location = new System.Drawing.Point(79, 212);
            this.txtGodinaProizvodnje.Multiline = true;
            this.txtGodinaProizvodnje.Name = "txtGodinaProizvodnje";
            this.txtGodinaProizvodnje.Size = new System.Drawing.Size(218, 26);
            this.txtGodinaProizvodnje.TabIndex = 2;
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(414, 82);
            this.txtIspis.Multiline = true;
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.Size = new System.Drawing.Size(300, 181);
            this.txtIspis.TabIndex = 3;
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(166, 315);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(107, 52);
            this.btnUnesi.TabIndex = 4;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // btnObradi
            // 
            this.btnObradi.Location = new System.Drawing.Point(365, 315);
            this.btnObradi.Name = "btnObradi";
            this.btnObradi.Size = new System.Drawing.Size(98, 51);
            this.btnObradi.TabIndex = 5;
            this.btnObradi.Text = "Obradi";
            this.btnObradi.UseVisualStyleBackColor = true;
            this.btnObradi.Click += new System.EventHandler(this.btnObradi_Click);
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(586, 315);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(96, 52);
            this.btnIspis.TabIndex = 6;
            this.btnIspis.Text = "Ispis";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Model vozila";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Broj Kotača";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Godina Proizvodnje";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.btnObradi);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.txtIspis);
            this.Controls.Add(this.txtGodinaProizvodnje);
            this.Controls.Add(this.txtBrojKotaca);
            this.Controls.Add(this.txtModel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtBrojKotaca;
        private System.Windows.Forms.TextBox txtGodinaProizvodnje;
        private System.Windows.Forms.TextBox txtIspis;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Button btnObradi;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

