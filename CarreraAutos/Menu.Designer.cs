namespace CarreraAutos
{
    partial class Menu1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Dificil = new System.Windows.Forms.Button();
            this.Medio = new System.Windows.Forms.Button();
            this.Facil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Jugar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(237, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "Coches";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(12, 427);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(237, 41);
            this.button4.TabIndex = 3;
            this.button4.Text = "Salir";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Dificil
            // 
            this.Dificil.BackColor = System.Drawing.Color.Black;
            this.Dificil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Dificil.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dificil.ForeColor = System.Drawing.Color.White;
            this.Dificil.Location = new System.Drawing.Point(255, 379);
            this.Dificil.Name = "Dificil";
            this.Dificil.Size = new System.Drawing.Size(167, 41);
            this.Dificil.TabIndex = 6;
            this.Dificil.Text = "DIFICIL";
            this.Dificil.UseVisualStyleBackColor = false;
            this.Dificil.Visible = false;
            this.Dificil.Click += new System.EventHandler(this.Dificil_Click);
            // 
            // Medio
            // 
            this.Medio.BackColor = System.Drawing.Color.Black;
            this.Medio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Medio.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medio.ForeColor = System.Drawing.Color.White;
            this.Medio.Location = new System.Drawing.Point(255, 333);
            this.Medio.Name = "Medio";
            this.Medio.Size = new System.Drawing.Size(167, 41);
            this.Medio.TabIndex = 5;
            this.Medio.Text = "Medio";
            this.Medio.UseVisualStyleBackColor = false;
            this.Medio.Visible = false;
            this.Medio.Click += new System.EventHandler(this.Medio_Click);
            // 
            // Facil
            // 
            this.Facil.BackColor = System.Drawing.Color.Black;
            this.Facil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Facil.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Facil.ForeColor = System.Drawing.Color.White;
            this.Facil.Location = new System.Drawing.Point(255, 289);
            this.Facil.Name = "Facil";
            this.Facil.Size = new System.Drawing.Size(167, 41);
            this.Facil.TabIndex = 4;
            this.Facil.Text = "Facil";
            this.Facil.UseVisualStyleBackColor = false;
            this.Facil.Visible = false;
            this.Facil.Click += new System.EventHandler(this.Facil_Click);
            // 
            // Menu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(731, 472);
            this.Controls.Add(this.Dificil);
            this.Controls.Add(this.Medio);
            this.Controls.Add(this.Facil);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Menu1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Dificil;
        private System.Windows.Forms.Button Medio;
        private System.Windows.Forms.Button Facil;

    }
}