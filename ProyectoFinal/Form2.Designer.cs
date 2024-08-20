namespace ProyectoFinal
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            timerJuego = new System.Windows.Forms.Timer(components);
            circuloIzq = new System.Windows.Forms.PictureBox();
            cuadradoIzq = new System.Windows.Forms.PictureBox();
            circuloDch = new System.Windows.Forms.PictureBox();
            cuadradoDch = new System.Windows.Forms.PictureBox();
            puntaje = new System.Windows.Forms.Label();
            timer2 = new System.Windows.Forms.Timer(components);
            Invisible2 = new System.Windows.Forms.PictureBox();
            Pausa = new System.Windows.Forms.Label();
            escape = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)circuloIzq).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cuadradoIzq).BeginInit();
            ((System.ComponentModel.ISupportInitialize)circuloDch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cuadradoDch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Invisible2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.CocheRojo_PhotoRoom_png_PhotoRoom;
            pictureBox1.Location = new System.Drawing.Point(12, 465);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(72, 80);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // timerJuego
            // 
            timerJuego.Enabled = true;
            timerJuego.Interval = 20;
            timerJuego.Tick += juegoTimer;
            // 
            // circuloIzq
            // 
            circuloIzq.BackColor = System.Drawing.Color.Transparent;
            circuloIzq.Image = Properties.Resources.circulo_removebg_preview;
            circuloIzq.Location = new System.Drawing.Point(17, 49);
            circuloIzq.Name = "circuloIzq";
            circuloIzq.Size = new System.Drawing.Size(61, 52);
            circuloIzq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            circuloIzq.TabIndex = 1;
            circuloIzq.TabStop = false;
            circuloIzq.Click += circuloIzq_Click;
            // 
            // cuadradoIzq
            // 
            cuadradoIzq.BackColor = System.Drawing.Color.Transparent;
            cuadradoIzq.Image = Properties.Resources.cuadrado;
            cuadradoIzq.Location = new System.Drawing.Point(17, 222);
            cuadradoIzq.Name = "cuadradoIzq";
            cuadradoIzq.Size = new System.Drawing.Size(57, 57);
            cuadradoIzq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            cuadradoIzq.TabIndex = 2;
            cuadradoIzq.TabStop = false;
            cuadradoIzq.Click += cuadradoIzq_Click;
            // 
            // circuloDch
            // 
            circuloDch.BackColor = System.Drawing.Color.Transparent;
            circuloDch.Image = Properties.Resources.circulo_removebg_preview;
            circuloDch.Location = new System.Drawing.Point(100, 134);
            circuloDch.Name = "circuloDch";
            circuloDch.Size = new System.Drawing.Size(61, 52);
            circuloDch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            circuloDch.TabIndex = 3;
            circuloDch.TabStop = false;
            // 
            // cuadradoDch
            // 
            cuadradoDch.BackColor = System.Drawing.Color.Transparent;
            cuadradoDch.Image = Properties.Resources.cuadrado;
            cuadradoDch.Location = new System.Drawing.Point(100, 423);
            cuadradoDch.Name = "cuadradoDch";
            cuadradoDch.Size = new System.Drawing.Size(57, 57);
            cuadradoDch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            cuadradoDch.TabIndex = 4;
            cuadradoDch.TabStop = false;
            // 
            // puntaje
            // 
            puntaje.AutoSize = true;
            puntaje.BackColor = System.Drawing.Color.Transparent;
            puntaje.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            puntaje.Location = new System.Drawing.Point(17, 23);
            puntaje.Name = "puntaje";
            puntaje.Size = new System.Drawing.Size(23, 23);
            puntaje.TabIndex = 5;
            puntaje.Text = "0";
            puntaje.Click += puntaje_Click;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 80;
            timer2.Tick += timer2_Tick;
            // 
            // Invisible2
            // 
            Invisible2.BackColor = System.Drawing.Color.Transparent;
            Invisible2.Location = new System.Drawing.Point(12, 551);
            Invisible2.Name = "Invisible2";
            Invisible2.Size = new System.Drawing.Size(166, 15);
            Invisible2.TabIndex = 6;
            Invisible2.TabStop = false;
            Invisible2.Click += pictureBox2_Click_1;
            // 
            // Pausa
            // 
            Pausa.AutoSize = true;
            Pausa.BackColor = System.Drawing.Color.Transparent;
            Pausa.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            Pausa.ForeColor = System.Drawing.Color.Red;
            Pausa.Location = new System.Drawing.Point(39, 282);
            Pausa.Name = "Pausa";
            Pausa.Size = new System.Drawing.Size(107, 35);
            Pausa.TabIndex = 7;
            Pausa.Text = "PAUSA";
            // 
            // escape
            // 
            escape.AutoSize = true;
            escape.BackColor = System.Drawing.Color.Transparent;
            escape.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            escape.ForeColor = System.Drawing.Color.Purple;
            escape.Location = new System.Drawing.Point(9, 331);
            escape.Name = "escape";
            escape.Size = new System.Drawing.Size(169, 21);
            escape.TabIndex = 8;
            escape.Text = "press esc to out";
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.viaProyecto;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(180, 578);
            Controls.Add(escape);
            Controls.Add(Pausa);
            Controls.Add(puntaje);
            Controls.Add(cuadradoDch);
            Controls.Add(circuloDch);
            Controls.Add(cuadradoIzq);
            Controls.Add(circuloIzq);
            Controls.Add(pictureBox1);
            Controls.Add(Invisible2);
            DoubleBuffered = true;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            KeyDown += Form2_KeyDown;
            KeyPress += Form2_KeyPress;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)circuloIzq).EndInit();
            ((System.ComponentModel.ISupportInitialize)cuadradoIzq).EndInit();
            ((System.ComponentModel.ISupportInitialize)circuloDch).EndInit();
            ((System.ComponentModel.ISupportInitialize)cuadradoDch).EndInit();
            ((System.ComponentModel.ISupportInitialize)Invisible2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerJuego;
        private System.Windows.Forms.PictureBox circuloIzq;
        private System.Windows.Forms.PictureBox cuadradoIzq;
        private System.Windows.Forms.PictureBox circuloDch;
        private System.Windows.Forms.PictureBox cuadradoDch;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox Invisible2;
        private System.Windows.Forms.Label Pausa;
        public System.Windows.Forms.Label puntaje;
        private System.Windows.Forms.Label escape;
    }
}