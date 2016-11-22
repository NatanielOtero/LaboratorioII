namespace pelotita_3
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCrearPelotita = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDestruir = new System.Windows.Forms.Button();
            this.btnReanudar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 233);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnCrearPelotita
            // 
            this.btnCrearPelotita.Location = new System.Drawing.Point(6, 238);
            this.btnCrearPelotita.Name = "btnCrearPelotita";
            this.btnCrearPelotita.Size = new System.Drawing.Size(80, 23);
            this.btnCrearPelotita.TabIndex = 1;
            this.btnCrearPelotita.Text = "Crear Pelotita";
            this.btnCrearPelotita.UseVisualStyleBackColor = true;
            this.btnCrearPelotita.Click += new System.EventHandler(this.btnCrearPelotita_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "pausar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDestruir
            // 
            this.btnDestruir.Location = new System.Drawing.Point(12, 275);
            this.btnDestruir.Name = "btnDestruir";
            this.btnDestruir.Size = new System.Drawing.Size(69, 23);
            this.btnDestruir.TabIndex = 3;
            this.btnDestruir.Text = "destruir";
            this.btnDestruir.UseVisualStyleBackColor = true;
            this.btnDestruir.Click += new System.EventHandler(this.btnDestruir_Click);
            // 
            // btnReanudar
            // 
            this.btnReanudar.Location = new System.Drawing.Point(183, 238);
            this.btnReanudar.Name = "btnReanudar";
            this.btnReanudar.Size = new System.Drawing.Size(78, 23);
            this.btnReanudar.TabIndex = 4;
            this.btnReanudar.Text = "Reanudar";
            this.btnReanudar.UseVisualStyleBackColor = true;
            this.btnReanudar.Click += new System.EventHandler(this.btnReanudar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 310);
            this.Controls.Add(this.btnReanudar);
            this.Controls.Add(this.btnDestruir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCrearPelotita);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCrearPelotita;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDestruir;
        private System.Windows.Forms.Button btnReanudar;
    }
}

