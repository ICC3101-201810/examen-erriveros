namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pacmanRight = new System.Windows.Forms.PictureBox();
            this.fantasmaRojo = new System.Windows.Forms.PictureBox();
            this.fantasmaRosado = new System.Windows.Forms.PictureBox();
            this.cherry = new System.Windows.Forms.PictureBox();
            this.pacmanDown = new System.Windows.Forms.PictureBox();
            this.uva = new System.Windows.Forms.PictureBox();
            this.pacmanUp = new System.Windows.Forms.PictureBox();
            this.pacmanLeft = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pacmanRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fantasmaRojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fantasmaRosado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cherry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacmanDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacmanUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacmanLeft)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pacmanRight
            // 
            this.pacmanRight.Image = ((System.Drawing.Image)(resources.GetObject("pacmanRight.Image")));
            this.pacmanRight.Location = new System.Drawing.Point(300, 300);
            this.pacmanRight.Name = "pacmanRight";
            this.pacmanRight.Size = new System.Drawing.Size(40, 40);
            this.pacmanRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pacmanRight.TabIndex = 0;
            this.pacmanRight.TabStop = false;
            // 
            // fantasmaRojo
            // 
            this.fantasmaRojo.Image = ((System.Drawing.Image)(resources.GetObject("fantasmaRojo.Image")));
            this.fantasmaRojo.Location = new System.Drawing.Point(32, 94);
            this.fantasmaRojo.Name = "fantasmaRojo";
            this.fantasmaRojo.Size = new System.Drawing.Size(36, 38);
            this.fantasmaRojo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fantasmaRojo.TabIndex = 2;
            this.fantasmaRojo.TabStop = false;
            this.fantasmaRojo.Tag = "fantasma";
            // 
            // fantasmaRosado
            // 
            this.fantasmaRosado.Image = ((System.Drawing.Image)(resources.GetObject("fantasmaRosado.Image")));
            this.fantasmaRosado.Location = new System.Drawing.Point(2, 230);
            this.fantasmaRosado.Name = "fantasmaRosado";
            this.fantasmaRosado.Size = new System.Drawing.Size(36, 38);
            this.fantasmaRosado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fantasmaRosado.TabIndex = 3;
            this.fantasmaRosado.TabStop = false;
            this.fantasmaRosado.Tag = "fantasma";
            // 
            // cherry
            // 
            this.cherry.Image = ((System.Drawing.Image)(resources.GetObject("cherry.Image")));
            this.cherry.Location = new System.Drawing.Point(59, 302);
            this.cherry.Name = "cherry";
            this.cherry.Size = new System.Drawing.Size(20, 20);
            this.cherry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cherry.TabIndex = 4;
            this.cherry.TabStop = false;
            this.cherry.Tag = "cherry";
            // 
            // pacmanDown
            // 
            this.pacmanDown.Image = ((System.Drawing.Image)(resources.GetObject("pacmanDown.Image")));
            this.pacmanDown.Location = new System.Drawing.Point(300, 300);
            this.pacmanDown.Name = "pacmanDown";
            this.pacmanDown.Size = new System.Drawing.Size(40, 40);
            this.pacmanDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pacmanDown.TabIndex = 5;
            this.pacmanDown.TabStop = false;
            // 
            // uva
            // 
            this.uva.Image = ((System.Drawing.Image)(resources.GetObject("uva.Image")));
            this.uva.Location = new System.Drawing.Point(59, 250);
            this.uva.Name = "uva";
            this.uva.Size = new System.Drawing.Size(20, 20);
            this.uva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uva.TabIndex = 6;
            this.uva.TabStop = false;
            this.uva.Tag = "uva";
            // 
            // pacmanUp
            // 
            this.pacmanUp.Image = ((System.Drawing.Image)(resources.GetObject("pacmanUp.Image")));
            this.pacmanUp.Location = new System.Drawing.Point(300, 300);
            this.pacmanUp.Name = "pacmanUp";
            this.pacmanUp.Size = new System.Drawing.Size(40, 40);
            this.pacmanUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pacmanUp.TabIndex = 7;
            this.pacmanUp.TabStop = false;
            // 
            // pacmanLeft
            // 
            this.pacmanLeft.Image = ((System.Drawing.Image)(resources.GetObject("pacmanLeft.Image")));
            this.pacmanLeft.Location = new System.Drawing.Point(300, 300);
            this.pacmanLeft.Name = "pacmanLeft";
            this.pacmanLeft.Size = new System.Drawing.Size(40, 40);
            this.pacmanLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pacmanLeft.TabIndex = 8;
            this.pacmanLeft.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(718, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 600);
            this.panel3.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "JUGAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ingrese su nombre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(258, 238);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(222, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "BIENVENIDO";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.panel2.Location = new System.Drawing.Point(495, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 600);
            this.panel2.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(217, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 51);
            this.button2.TabIndex = 13;
            this.button2.Text = "JUGAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 31);
            this.label5.TabIndex = 12;
            this.label5.Text = "HIGHSCORES";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(217, 201);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 52);
            this.listBox1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label2.Location = new System.Drawing.Point(179, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 46);
            this.label2.TabIndex = 10;
            this.label2.Text = "GAME OVER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pacmanUp);
            this.Controls.Add(this.pacmanDown);
            this.Controls.Add(this.pacmanRight);
            this.Controls.Add(this.pacmanLeft);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.fantasmaRojo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cherry);
            this.Controls.Add(this.uva);
            this.Controls.Add(this.fantasmaRosado);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pacmanRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fantasmaRojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fantasmaRosado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cherry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacmanDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacmanUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacmanLeft)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pacmanRight;
        private System.Windows.Forms.PictureBox fantasmaRojo;
        private System.Windows.Forms.PictureBox fantasmaRosado;
        private System.Windows.Forms.PictureBox cherry;
        private System.Windows.Forms.PictureBox pacmanDown;
        private System.Windows.Forms.PictureBox uva;
        private System.Windows.Forms.PictureBox pacmanUp;
        private System.Windows.Forms.PictureBox pacmanLeft;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}

