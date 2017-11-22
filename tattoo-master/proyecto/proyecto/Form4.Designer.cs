namespace proyecto
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nombreus = new System.Windows.Forms.TextBox();
            this.apellidous = new System.Windows.Forms.TextBox();
            this.passus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nickus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pass2us = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.telefonous = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.direccionus = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label = new System.Windows.Forms.Label();
            this.cius = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 21);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Firebrick;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(200, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(543, 21);
            this.panel4.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Firebrick;
            this.panel3.Controls.Add(this.bunifuImageButton2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(743, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(55, 21);
            this.panel3.TabIndex = 7;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Black;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.ImageActive")));
            this.bunifuImageButton2.Location = new System.Drawing.Point(34, 0);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(18, 18);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 3;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 21);
            this.panel2.TabIndex = 6;
            // 
            // nombreus
            // 
            this.nombreus.Location = new System.Drawing.Point(21, 68);
            this.nombreus.Name = "nombreus";
            this.nombreus.Size = new System.Drawing.Size(325, 20);
            this.nombreus.TabIndex = 1;
            this.nombreus.TextChanged += new System.EventHandler(this.nombreus_TextChanged);
            this.nombreus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombreus_KeyPress);
            // 
            // apellidous
            // 
            this.apellidous.Location = new System.Drawing.Point(21, 135);
            this.apellidous.Name = "apellidous";
            this.apellidous.Size = new System.Drawing.Size(325, 20);
            this.apellidous.TabIndex = 2;
            this.apellidous.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.apellidous_KeyPress);
            // 
            // passus
            // 
            this.passus.Location = new System.Drawing.Point(409, 135);
            this.passus.Name = "passus";
            this.passus.PasswordChar = '*';
            this.passus.Size = new System.Drawing.Size(297, 20);
            this.passus.TabIndex = 3;
            this.passus.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(18, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombres :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(21, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellidos :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(409, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contraseña :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(409, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nombre de usuario :";
            // 
            // nickus
            // 
            this.nickus.Location = new System.Drawing.Point(409, 73);
            this.nickus.Name = "nickus";
            this.nickus.Size = new System.Drawing.Size(297, 20);
            this.nickus.TabIndex = 7;
            this.nickus.TextChanged += new System.EventHandler(this.nickus_TextChanged);
            this.nickus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nickus_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(409, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Confirmar contraseña :";
            // 
            // pass2us
            // 
            this.pass2us.Location = new System.Drawing.Point(409, 210);
            this.pass2us.Name = "pass2us";
            this.pass2us.PasswordChar = '*';
            this.pass2us.Size = new System.Drawing.Size(297, 20);
            this.pass2us.TabIndex = 9;
            this.pass2us.TextChanged += new System.EventHandler(this.pass2us_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(18, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Telefono";
            // 
            // telefonous
            // 
            this.telefonous.Location = new System.Drawing.Point(21, 249);
            this.telefonous.Name = "telefonous";
            this.telefonous.Size = new System.Drawing.Size(179, 20);
            this.telefonous.TabIndex = 11;
            this.telefonous.TextChanged += new System.EventHandler(this.telefonous_TextChanged);
            this.telefonous.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telefonous_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(21, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Direccion";
            // 
            // direccionus
            // 
            this.direccionus.Location = new System.Drawing.Point(21, 298);
            this.direccionus.Name = "direccionus";
            this.direccionus.Size = new System.Drawing.Size(347, 20);
            this.direccionus.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(426, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 38);
            this.button1.TabIndex = 15;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(625, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 38);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel4;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.panel2;
            this.bunifuDragControl2.Vertical = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label.Location = new System.Drawing.Point(18, 167);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(23, 13);
            this.label.TabIndex = 18;
            this.label.Text = "C.I.";
            // 
            // cius
            // 
            this.cius.Location = new System.Drawing.Point(21, 194);
            this.cius.Name = "cius";
            this.cius.Size = new System.Drawing.Size(179, 20);
            this.cius.TabIndex = 17;
            this.cius.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.cius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(90)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(798, 417);
            this.Controls.Add(this.label);
            this.Controls.Add(this.cius);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.direccionus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.telefonous);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pass2us);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nickus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passus);
            this.Controls.Add(this.apellidous);
            this.Controls.Add(this.nombreus);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.Text = "Contraseña :";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nickus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passus;
        private System.Windows.Forms.TextBox apellidous;
        private System.Windows.Forms.TextBox nombreus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox direccionus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox telefonous;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pass2us;
        private System.Windows.Forms.Button button2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox cius;
    }
}