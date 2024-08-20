namespace ProyectoFinal
{
    partial class Form3
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
            label1 = new System.Windows.Forms.Label();
            PuntajeMayor = new System.Windows.Forms.Label();
            PuntajeActual = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            PuntosPartida = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(334, 102);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(0, 20);
            label1.TabIndex = 0;
            // 
            // PuntajeMayor
            // 
            PuntajeMayor.AutoSize = true;
            PuntajeMayor.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            PuntajeMayor.Location = new System.Drawing.Point(111, 55);
            PuntajeMayor.Name = "PuntajeMayor";
            PuntajeMayor.Size = new System.Drawing.Size(0, 35);
            PuntajeMayor.TabIndex = 4;
            // 
            // PuntajeActual
            // 
            PuntajeActual.AutoSize = true;
            PuntajeActual.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            PuntajeActual.Location = new System.Drawing.Point(144, 197);
            PuntajeActual.Name = "PuntajeActual";
            PuntajeActual.Size = new System.Drawing.Size(0, 35);
            PuntajeActual.TabIndex = 5;
            PuntajeActual.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.Red;
            label4.Location = new System.Drawing.Point(500, 81);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(119, 29);
            label4.TabIndex = 6;
            label4.Text = "Ranking";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Showcard Gothic", 19.8000011F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.Red;
            label5.Location = new System.Drawing.Point(269, 32);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(215, 43);
            label5.TabIndex = 7;
            label5.Text = "Game Over";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.Red;
            label6.Location = new System.Drawing.Point(114, 144);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(0, 29);
            label6.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Transparent;
            button1.Font = new System.Drawing.Font("Showcard Gothic", 19.8000011F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            button1.ForeColor = System.Drawing.Color.Chartreuse;
            button1.Location = new System.Drawing.Point(31, 176);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(250, 57);
            button1.TabIndex = 9;
            button1.Text = "Reintentar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.Transparent;
            button2.Font = new System.Drawing.Font("Showcard Gothic", 19.8000011F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            button2.ForeColor = System.Drawing.Color.Red;
            button2.Location = new System.Drawing.Point(103, 309);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(178, 57);
            button2.TabIndex = 10;
            button2.Text = "SALIR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // PuntosPartida
            // 
            PuntosPartida.AutoSize = true;
            PuntosPartida.Location = new System.Drawing.Point(782, -1);
            PuntosPartida.Name = "PuntosPartida";
            PuntosPartida.Size = new System.Drawing.Size(17, 20);
            PuntosPartida.TabIndex = 11;
            PuntosPartida.Text = "0";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(395, 125);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new System.Drawing.Size(300, 313);
            dataGridView1.TabIndex = 12;
            // 
            // Form3
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.imagenMenu;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(PuntosPartida);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(PuntajeActual);
            Controls.Add(PuntajeMayor);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PuntajeMayor;
        private System.Windows.Forms.Label PuntajeActual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label PuntosPartida;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}