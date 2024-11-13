
namespace EDDemo.Estructuras_No_Lineales
{
    partial class frmArboles
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
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtArbol = new System.Windows.Forms.TextBox();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelPre = new System.Windows.Forms.Label();
            this.LabelIn = new System.Windows.Forms.Label();
            this.LabelPost = new System.Windows.Forms.Label();
            this.btnRandom = new System.Windows.Forms.Button();
            this.txtNodos = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGrafica = new System.Windows.Forms.Button();
            this.btnPodar = new System.Windows.Forms.Button();
            this.btnAltura = new System.Windows.Forms.Button();
            this.btnHojas = new System.Windows.Forms.Button();
            this.btnNodos = new System.Windows.Forms.Button();
            this.btnRecAmp = new System.Windows.Forms.Button();
            this.btnCompleto = new System.Windows.Forms.Button();
            this.btnLleno = new System.Windows.Forms.Button();
            this.radioPre = new System.Windows.Forms.RadioButton();
            this.radioSuce = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.lblRandom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDato
            // 
            this.txtDato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.txtDato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDato.Location = new System.Drawing.Point(35, 154);
            this.txtDato.Margin = new System.Windows.Forms.Padding(2);
            this.txtDato.Multiline = true;
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(64, 21);
            this.txtDato.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(15)))), ((int)(((byte)(56)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnAgregar.Location = new System.Drawing.Point(103, 152);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(58, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtArbol
            // 
            this.txtArbol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArbol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.txtArbol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArbol.Location = new System.Drawing.Point(22, 287);
            this.txtArbol.Margin = new System.Windows.Forms.Padding(2);
            this.txtArbol.Multiline = true;
            this.txtArbol.Name = "txtArbol";
            this.txtArbol.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtArbol.Size = new System.Drawing.Size(659, 145);
            this.txtArbol.TabIndex = 2;
            this.txtArbol.TextChanged += new System.EventHandler(this.txtArbol_TextChanged);
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(15)))), ((int)(((byte)(56)))));
            this.btnRecorrer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRecorrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecorrer.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnRecorrer.Location = new System.Drawing.Point(326, 95);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(65, 23);
            this.btnRecorrer.TabIndex = 3;
            this.btnRecorrer.Text = "Recorrer";
            this.btnRecorrer.UseVisualStyleBackColor = false;
            this.btnRecorrer.Click += new System.EventHandler(this.btnRecorrer_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(330, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pre Orden; ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(331, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "In Orden: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(330, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Post Orden: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // LabelPre
            // 
            this.LabelPre.AutoSize = true;
            this.LabelPre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelPre.Location = new System.Drawing.Point(397, 121);
            this.LabelPre.Name = "LabelPre";
            this.LabelPre.Size = new System.Drawing.Size(0, 15);
            this.LabelPre.TabIndex = 7;
            // 
            // LabelIn
            // 
            this.LabelIn.AutoSize = true;
            this.LabelIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelIn.Location = new System.Drawing.Point(389, 136);
            this.LabelIn.Name = "LabelIn";
            this.LabelIn.Size = new System.Drawing.Size(0, 15);
            this.LabelIn.TabIndex = 8;
            // 
            // LabelPost
            // 
            this.LabelPost.AutoSize = true;
            this.LabelPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPost.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelPost.Location = new System.Drawing.Point(397, 152);
            this.LabelPost.Name = "LabelPost";
            this.LabelPost.Size = new System.Drawing.Size(0, 15);
            this.LabelPost.TabIndex = 9;
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(15)))), ((int)(((byte)(56)))));
            this.btnRandom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandom.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnRandom.Location = new System.Drawing.Point(98, 97);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(84, 23);
            this.btnRandom.TabIndex = 11;
            this.btnRandom.Text = "Crear Arbol";
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click_1);
            // 
            // txtNodos
            // 
            this.txtNodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.txtNodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNodos.Location = new System.Drawing.Point(36, 97);
            this.txtNodos.Name = "txtNodos";
            this.txtNodos.Size = new System.Drawing.Size(56, 21);
            this.txtNodos.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(32, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ingresa un numero: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(33, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ingresa un numero de nodos: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(15)))), ((int)(((byte)(56)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label6.Location = new System.Drawing.Point(206, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "A R B O L E S";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(15)))), ((int)(((byte)(56)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnBuscar.Location = new System.Drawing.Point(166, 152);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(57, 23);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(15)))), ((int)(((byte)(56)))));
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(703, 44);
            this.flowLayoutPanel1.TabIndex = 17;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // btnGrafica
            // 
            this.btnGrafica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(15)))), ((int)(((byte)(56)))));
            this.btnGrafica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGrafica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrafica.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnGrafica.Location = new System.Drawing.Point(326, 259);
            this.btnGrafica.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrafica.Name = "btnGrafica";
            this.btnGrafica.Size = new System.Drawing.Size(60, 25);
            this.btnGrafica.TabIndex = 18;
            this.btnGrafica.Text = "Grafica";
            this.btnGrafica.UseVisualStyleBackColor = false;
            this.btnGrafica.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPodar
            // 
            this.btnPodar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(15)))), ((int)(((byte)(56)))));
            this.btnPodar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPodar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPodar.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnPodar.Location = new System.Drawing.Point(30, 259);
            this.btnPodar.Margin = new System.Windows.Forms.Padding(2);
            this.btnPodar.Name = "btnPodar";
            this.btnPodar.Size = new System.Drawing.Size(85, 25);
            this.btnPodar.TabIndex = 19;
            this.btnPodar.Text = "Podar Arbol";
            this.btnPodar.UseVisualStyleBackColor = false;
            this.btnPodar.Click += new System.EventHandler(this.btnPodar_Click);
            // 
            // btnAltura
            // 
            this.btnAltura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(15)))), ((int)(((byte)(56)))));
            this.btnAltura.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltura.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnAltura.Location = new System.Drawing.Point(400, 260);
            this.btnAltura.Margin = new System.Windows.Forms.Padding(2);
            this.btnAltura.Name = "btnAltura";
            this.btnAltura.Size = new System.Drawing.Size(58, 23);
            this.btnAltura.TabIndex = 22;
            this.btnAltura.Text = "Altura";
            this.btnAltura.UseVisualStyleBackColor = false;
            this.btnAltura.Click += new System.EventHandler(this.btnAltura_Click);
            // 
            // btnHojas
            // 
            this.btnHojas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(15)))), ((int)(((byte)(56)))));
            this.btnHojas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHojas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHojas.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnHojas.Location = new System.Drawing.Point(228, 259);
            this.btnHojas.Margin = new System.Windows.Forms.Padding(2);
            this.btnHojas.Name = "btnHojas";
            this.btnHojas.Size = new System.Drawing.Size(85, 25);
            this.btnHojas.TabIndex = 23;
            this.btnHojas.Text = "Contar hojas";
            this.btnHojas.UseVisualStyleBackColor = false;
            this.btnHojas.Click += new System.EventHandler(this.btnHojas_Click);
            // 
            // btnNodos
            // 
            this.btnNodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(15)))), ((int)(((byte)(56)))));
            this.btnNodos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNodos.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnNodos.Location = new System.Drawing.Point(126, 259);
            this.btnNodos.Margin = new System.Windows.Forms.Padding(2);
            this.btnNodos.Name = "btnNodos";
            this.btnNodos.Size = new System.Drawing.Size(92, 25);
            this.btnNodos.TabIndex = 24;
            this.btnNodos.Text = "Contar nodos";
            this.btnNodos.UseVisualStyleBackColor = false;
            this.btnNodos.Click += new System.EventHandler(this.btnNodos_Click);
            // 
            // btnRecAmp
            // 
            this.btnRecAmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(15)))), ((int)(((byte)(56)))));
            this.btnRecAmp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRecAmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecAmp.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnRecAmp.Location = new System.Drawing.Point(331, 179);
            this.btnRecAmp.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecAmp.Name = "btnRecAmp";
            this.btnRecAmp.Size = new System.Drawing.Size(149, 25);
            this.btnRecAmp.TabIndex = 25;
            this.btnRecAmp.Text = "Recorrido por amplitud";
            this.btnRecAmp.UseVisualStyleBackColor = false;
            this.btnRecAmp.Click += new System.EventHandler(this.btnRecAmp_Click);
            // 
            // btnCompleto
            // 
            this.btnCompleto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(15)))), ((int)(((byte)(56)))));
            this.btnCompleto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompleto.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnCompleto.Location = new System.Drawing.Point(567, 258);
            this.btnCompleto.Margin = new System.Windows.Forms.Padding(2);
            this.btnCompleto.Name = "btnCompleto";
            this.btnCompleto.Size = new System.Drawing.Size(99, 25);
            this.btnCompleto.TabIndex = 26;
            this.btnCompleto.Text = "Es completo";
            this.btnCompleto.UseVisualStyleBackColor = false;
            this.btnCompleto.Click += new System.EventHandler(this.btnCompleto_Click);
            // 
            // btnLleno
            // 
            this.btnLleno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(15)))), ((int)(((byte)(56)))));
            this.btnLleno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLleno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLleno.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnLleno.Location = new System.Drawing.Point(475, 258);
            this.btnLleno.Margin = new System.Windows.Forms.Padding(2);
            this.btnLleno.Name = "btnLleno";
            this.btnLleno.Size = new System.Drawing.Size(79, 25);
            this.btnLleno.TabIndex = 27;
            this.btnLleno.Text = "Es lleno";
            this.btnLleno.UseVisualStyleBackColor = false;
            this.btnLleno.Click += new System.EventHandler(this.btnLleno_Click);
            // 
            // radioPre
            // 
            this.radioPre.AutoSize = true;
            this.radioPre.Location = new System.Drawing.Point(35, 200);
            this.radioPre.Name = "radioPre";
            this.radioPre.Size = new System.Drawing.Size(76, 17);
            this.radioPre.TabIndex = 28;
            this.radioPre.TabStop = true;
            this.radioPre.Text = "Pedecesor";
            this.radioPre.UseVisualStyleBackColor = true;
            this.radioPre.CheckedChanged += new System.EventHandler(this.radioPre_CheckedChanged);
            // 
            // radioSuce
            // 
            this.radioSuce.AutoSize = true;
            this.radioSuce.Location = new System.Drawing.Point(36, 223);
            this.radioSuce.Name = "radioSuce";
            this.radioSuce.Size = new System.Drawing.Size(64, 17);
            this.radioSuce.TabIndex = 29;
            this.radioSuce.TabStop = true;
            this.radioSuce.Text = "Sucesor";
            this.radioSuce.UseVisualStyleBackColor = true;
            this.radioSuce.CheckedChanged += new System.EventHandler(this.radioSuce_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(32, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 15);
            this.label7.TabIndex = 31;
            this.label7.Text = "Eliminar:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblRandom
            // 
            this.lblRandom.AutoSize = true;
            this.lblRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRandom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRandom.Location = new System.Drawing.Point(32, 65);
            this.lblRandom.Name = "lblRandom";
            this.lblRandom.Size = new System.Drawing.Size(180, 15);
            this.lblRandom.TabIndex = 32;
            this.lblRandom.Text = "Crear arbol aleatoriamente";
            // 
            // frmArboles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(701, 433);
            this.Controls.Add(this.lblRandom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.radioSuce);
            this.Controls.Add(this.radioPre);
            this.Controls.Add(this.btnLleno);
            this.Controls.Add(this.btnCompleto);
            this.Controls.Add(this.btnRecAmp);
            this.Controls.Add(this.btnNodos);
            this.Controls.Add(this.btnHojas);
            this.Controls.Add(this.btnAltura);
            this.Controls.Add(this.btnPodar);
            this.Controls.Add(this.btnGrafica);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNodos);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.LabelPost);
            this.Controls.Add(this.LabelIn);
            this.Controls.Add(this.LabelPre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRecorrer);
            this.Controls.Add(this.txtArbol);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmArboles";
            this.Text = "frmArboles";
            this.Load += new System.EventHandler(this.frmArboles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion



        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtArbol;
        private System.Windows.Forms.Button btnRecorrer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelPre;
        private System.Windows.Forms.Label LabelIn;
        private System.Windows.Forms.Label LabelPost;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.NumericUpDown txtNodos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnGrafica;
        private System.Windows.Forms.Button btnPodar;
        private System.Windows.Forms.Button btnAltura;
        private System.Windows.Forms.Button btnHojas;
        private System.Windows.Forms.Button btnNodos;
        private System.Windows.Forms.Button btnRecAmp;
        private System.Windows.Forms.Button btnCompleto;
        private System.Windows.Forms.Button btnLleno;
        private System.Windows.Forms.RadioButton radioPre;
        private System.Windows.Forms.RadioButton radioSuce;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblRandom;
    }
}