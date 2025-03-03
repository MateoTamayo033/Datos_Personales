namespace REGISTRO_Y_LOGIN
{
    partial class RYL
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
            this.Pprincipal = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnregistro = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnacceder = new System.Windows.Forms.Button();
            this.PContenedor = new System.Windows.Forms.Panel();
            this.PReg = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.pNombre = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcor = new System.Windows.Forms.TextBox();
            this.pcorreo = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.pusuario = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.pclave = new System.Windows.Forms.Panel();
            this.btnReg = new System.Windows.Forms.Button();
            this.pAcceder = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pclaveA = new System.Windows.Forms.Panel();
            this.pUserA = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Pprincipal.SuspendLayout();
            this.PContenedor.SuspendLayout();
            this.PReg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pAcceder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Pprincipal
            // 
            this.Pprincipal.BackColor = System.Drawing.Color.Black;
            this.Pprincipal.Controls.Add(this.btnacceder);
            this.Pprincipal.Controls.Add(this.label4);
            this.Pprincipal.Controls.Add(this.btnregistro);
            this.Pprincipal.Controls.Add(this.label3);
            this.Pprincipal.Controls.Add(this.label2);
            this.Pprincipal.Controls.Add(this.label1);
            this.Pprincipal.Location = new System.Drawing.Point(0, 40);
            this.Pprincipal.Name = "Pprincipal";
            this.Pprincipal.Size = new System.Drawing.Size(800, 370);
            this.Pprincipal.TabIndex = 0;
            this.Pprincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.Pprincipal_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(425, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aun no tienes una cuenta?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(523, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Registrate aqui";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnregistro
            // 
            this.btnregistro.BackColor = System.Drawing.Color.Transparent;
            this.btnregistro.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnregistro.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnregistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnregistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregistro.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistro.ForeColor = System.Drawing.Color.White;
            this.btnregistro.Location = new System.Drawing.Point(420, 233);
            this.btnregistro.Name = "btnregistro";
            this.btnregistro.Size = new System.Drawing.Size(331, 41);
            this.btnregistro.TabIndex = 1;
            this.btnregistro.Text = "REGISTRARSE";
            this.btnregistro.UseVisualStyleBackColor = false;
            this.btnregistro.Click += new System.EventHandler(this.btnregistro_Click);
            this.btnregistro.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btnregistro.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(51, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 45);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ya tienes un usuario?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(119, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Da click para acceder";
            // 
            // btnacceder
            // 
            this.btnacceder.BackColor = System.Drawing.Color.Transparent;
            this.btnacceder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnacceder.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnacceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnacceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnacceder.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnacceder.ForeColor = System.Drawing.Color.White;
            this.btnacceder.Location = new System.Drawing.Point(28, 233);
            this.btnacceder.Name = "btnacceder";
            this.btnacceder.Size = new System.Drawing.Size(331, 41);
            this.btnacceder.TabIndex = 1;
            this.btnacceder.Text = "ACCEDER";
            this.btnacceder.UseVisualStyleBackColor = false;
            this.btnacceder.Click += new System.EventHandler(this.btnacceder_Click);
            this.btnacceder.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btnacceder.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // PContenedor
            // 
            this.PContenedor.BackColor = System.Drawing.Color.White;
            this.PContenedor.Controls.Add(this.pAcceder);
            this.PContenedor.Controls.Add(this.PReg);
            this.PContenedor.Location = new System.Drawing.Point(0, 10);
            this.PContenedor.Name = "PContenedor";
            this.PContenedor.Size = new System.Drawing.Size(400, 430);
            this.PContenedor.TabIndex = 2;
            // 
            // PReg
            // 
            this.PReg.Controls.Add(this.btnReg);
            this.PReg.Controls.Add(this.pclave);
            this.PReg.Controls.Add(this.pusuario);
            this.PReg.Controls.Add(this.pcorreo);
            this.PReg.Controls.Add(this.pNombre);
            this.PReg.Controls.Add(this.txtclave);
            this.PReg.Controls.Add(this.txtuser);
            this.PReg.Controls.Add(this.txtcor);
            this.PReg.Controls.Add(this.label9);
            this.PReg.Controls.Add(this.label8);
            this.PReg.Controls.Add(this.label7);
            this.PReg.Controls.Add(this.txtnom);
            this.PReg.Controls.Add(this.label6);
            this.PReg.Controls.Add(this.label5);
            this.PReg.Controls.Add(this.pictureBox1);
            this.PReg.Location = new System.Drawing.Point(6, 5);
            this.PReg.Name = "PReg";
            this.PReg.Size = new System.Drawing.Size(390, 420);
            this.PReg.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::REGISTRO_Y_LOGIN.Properties.Resources.LOGO_CANAL__1_;
            this.pictureBox1.Location = new System.Drawing.Point(166, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(140, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 45);
            this.label5.TabIndex = 1;
            this.label5.Text = "Registro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 27);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nombre:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtnom
            // 
            this.txtnom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnom.Location = new System.Drawing.Point(6, 161);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(362, 19);
            this.txtnom.TabIndex = 3;
            this.txtnom.Tag = "Nombre";
            this.txtnom.Enter += new System.EventHandler(this.txtEnter);
            this.txtnom.Leave += new System.EventHandler(this.txtLeave);
            // 
            // pNombre
            // 
            this.pNombre.BackColor = System.Drawing.Color.Silver;
            this.pNombre.Location = new System.Drawing.Point(6, 179);
            this.pNombre.Name = "pNombre";
            this.pNombre.Size = new System.Drawing.Size(362, 3);
            this.pNombre.TabIndex = 4;
            this.pNombre.Paint += new System.Windows.Forms.PaintEventHandler(this.pNombre_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 27);
            this.label7.TabIndex = 2;
            this.label7.Text = "Correo:";
            this.label7.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtcor
            // 
            this.txtcor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcor.Location = new System.Drawing.Point(6, 225);
            this.txtcor.Name = "txtcor";
            this.txtcor.Size = new System.Drawing.Size(362, 19);
            this.txtcor.TabIndex = 3;
            this.txtcor.Tag = "Correo";
            this.txtcor.Enter += new System.EventHandler(this.txtEnter);
            this.txtcor.Leave += new System.EventHandler(this.txtLeave);
            // 
            // pcorreo
            // 
            this.pcorreo.BackColor = System.Drawing.Color.Silver;
            this.pcorreo.Location = new System.Drawing.Point(6, 243);
            this.pcorreo.Name = "pcorreo";
            this.pcorreo.Size = new System.Drawing.Size(362, 3);
            this.pcorreo.TabIndex = 4;
            this.pcorreo.Paint += new System.Windows.Forms.PaintEventHandler(this.pNombre_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 27);
            this.label8.TabIndex = 2;
            this.label8.Text = "Usuario:";
            this.label8.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtuser
            // 
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.Location = new System.Drawing.Point(6, 286);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(362, 19);
            this.txtuser.TabIndex = 3;
            this.txtuser.Tag = "Usuario";
            this.txtuser.Enter += new System.EventHandler(this.txtEnter);
            this.txtuser.Leave += new System.EventHandler(this.txtLeave);
            // 
            // pusuario
            // 
            this.pusuario.BackColor = System.Drawing.Color.Silver;
            this.pusuario.Location = new System.Drawing.Point(6, 304);
            this.pusuario.Name = "pusuario";
            this.pusuario.Size = new System.Drawing.Size(362, 3);
            this.pusuario.TabIndex = 4;
            this.pusuario.Paint += new System.Windows.Forms.PaintEventHandler(this.pNombre_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 27);
            this.label9.TabIndex = 2;
            this.label9.Text = "Clave:";
            this.label9.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtclave
            // 
            this.txtclave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtclave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclave.Location = new System.Drawing.Point(6, 343);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(362, 19);
            this.txtclave.TabIndex = 3;
            this.txtclave.Tag = "Clave";
            this.txtclave.Enter += new System.EventHandler(this.txtEnter);
            this.txtclave.Leave += new System.EventHandler(this.txtLeave);
            // 
            // pclave
            // 
            this.pclave.BackColor = System.Drawing.Color.Silver;
            this.pclave.Location = new System.Drawing.Point(6, 361);
            this.pclave.Name = "pclave";
            this.pclave.Size = new System.Drawing.Size(362, 3);
            this.pclave.TabIndex = 4;
            this.pclave.Paint += new System.Windows.Forms.PaintEventHandler(this.pNombre_Paint);
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.Black;
            this.btnReg.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReg.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnReg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg.ForeColor = System.Drawing.Color.White;
            this.btnReg.Location = new System.Drawing.Point(6, 370);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(362, 41);
            this.btnReg.TabIndex = 5;
            this.btnReg.Text = "Registrar";
            this.btnReg.UseVisualStyleBackColor = false;
            // 
            // pAcceder
            // 
            this.pAcceder.Controls.Add(this.button1);
            this.pAcceder.Controls.Add(this.pclaveA);
            this.pAcceder.Controls.Add(this.pUserA);
            this.pAcceder.Controls.Add(this.textBox1);
            this.pAcceder.Controls.Add(this.textBox2);
            this.pAcceder.Controls.Add(this.label10);
            this.pAcceder.Controls.Add(this.label11);
            this.pAcceder.Controls.Add(this.label14);
            this.pAcceder.Controls.Add(this.pictureBox2);
            this.pAcceder.Location = new System.Drawing.Point(6, 5);
            this.pAcceder.Name = "pAcceder";
            this.pAcceder.Size = new System.Drawing.Size(390, 420);
            this.pAcceder.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(18, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(362, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Acceder";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pclaveA
            // 
            this.pclaveA.BackColor = System.Drawing.Color.Silver;
            this.pclaveA.Location = new System.Drawing.Point(18, 251);
            this.pclaveA.Name = "pclaveA";
            this.pclaveA.Size = new System.Drawing.Size(362, 3);
            this.pclaveA.TabIndex = 4;
            this.pclaveA.Paint += new System.Windows.Forms.PaintEventHandler(this.pNombre_Paint);
            // 
            // pUserA
            // 
            this.pUserA.BackColor = System.Drawing.Color.Silver;
            this.pUserA.Location = new System.Drawing.Point(18, 194);
            this.pUserA.Name = "pUserA";
            this.pUserA.Size = new System.Drawing.Size(362, 3);
            this.pUserA.TabIndex = 4;
            this.pUserA.Paint += new System.Windows.Forms.PaintEventHandler(this.pNombre_Paint);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(18, 233);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(362, 19);
            this.textBox1.TabIndex = 3;
            this.textBox1.Tag = "ClaveA";
            this.textBox1.Enter += new System.EventHandler(this.txtEnter);
            this.textBox1.Leave += new System.EventHandler(this.txtLeave);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(18, 176);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(362, 19);
            this.textBox2.TabIndex = 3;
            this.textBox2.Tag = "UsuarioA";
            this.textBox2.Enter += new System.EventHandler(this.txtEnter);
            this.textBox2.Leave += new System.EventHandler(this.txtLeave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 27);
            this.label10.TabIndex = 2;
            this.label10.Text = "Clave:";
            this.label10.Click += new System.EventHandler(this.label6_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 27);
            this.label11.TabIndex = 2;
            this.label11.Text = "Usuario:";
            this.label11.Click += new System.EventHandler(this.label6_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(140, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 45);
            this.label14.TabIndex = 1;
            this.label14.Text = "Acceder";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::REGISTRO_Y_LOGIN.Properties.Resources.LOGO_CANAL__1_;
            this.pictureBox2.Location = new System.Drawing.Point(166, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RYL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(804, 536);
            this.Controls.Add(this.PContenedor);
            this.Controls.Add(this.Pprincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RYL";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.Load += new System.EventHandler(this.RYL_Load);
            this.Pprincipal.ResumeLayout(false);
            this.Pprincipal.PerformLayout();
            this.PContenedor.ResumeLayout(false);
            this.PReg.ResumeLayout(false);
            this.PReg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pAcceder.ResumeLayout(false);
            this.pAcceder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pprincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnregistro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnacceder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PContenedor;
        private System.Windows.Forms.Panel PReg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pNombre;
        private System.Windows.Forms.Panel pclave;
        private System.Windows.Forms.Panel pusuario;
        private System.Windows.Forms.Panel pcorreo;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtcor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Panel pAcceder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pclaveA;
        private System.Windows.Forms.Panel pUserA;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
    }
}

