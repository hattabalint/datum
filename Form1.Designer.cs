namespace jatekadatumokkal
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtkSzam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnapSzul = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnapSzamaEvben = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnapokSzKesobb = new System.Windows.Forms.TextBox();
            this.txtnapokSz = new System.Windows.Forms.TextBox();
            this.btnKiiras = new System.Windows.Forms.Button();
            this.btnTorles = new System.Windows.Forms.Button();
            this.btnZar = new System.Windows.Forms.Button();
            this.IbIDatum = new System.Windows.Forms.Label();
            this.IbIGratulacio = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mskdTxtSzulD = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "pontos datum, ido:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "szuletesi datum: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "a korod:";
            // 
            // txtkSzam
            // 
            this.txtkSzam.Location = new System.Drawing.Point(199, 169);
            this.txtkSzam.Name = "txtkSzam";
            this.txtkSzam.Size = new System.Drawing.Size(100, 20);
            this.txtkSzam.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "ezen a napon szulettel:";
            // 
            // txtnapSzul
            // 
            this.txtnapSzul.Location = new System.Drawing.Point(635, 172);
            this.txtnapSzul.Name = "txtnapSzul";
            this.txtnapSzul.Size = new System.Drawing.Size(100, 20);
            this.txtnapSzul.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "tetszoleges datum:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(75, 358);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(484, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "ez a nap az ev ennyiedik napja:";
            // 
            // txtnapSzamaEvben
            // 
            this.txtnapSzamaEvben.Location = new System.Drawing.Point(635, 322);
            this.txtnapSzamaEvben.Name = "txtnapSzamaEvben";
            this.txtnapSzamaEvben.Size = new System.Drawing.Size(100, 20);
            this.txtnapSzamaEvben.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(487, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "nappal kesobb levo datum";
            // 
            // txtnapokSzKesobb
            // 
            this.txtnapokSzKesobb.Location = new System.Drawing.Point(635, 379);
            this.txtnapokSzKesobb.Name = "txtnapokSzKesobb";
            this.txtnapokSzKesobb.Size = new System.Drawing.Size(100, 20);
            this.txtnapokSzKesobb.TabIndex = 12;
            // 
            // txtnapokSz
            // 
            this.txtnapokSz.Location = new System.Drawing.Point(432, 379);
            this.txtnapokSz.Name = "txtnapokSz";
            this.txtnapokSz.Size = new System.Drawing.Size(49, 20);
            this.txtnapokSz.TabIndex = 13;
            this.txtnapokSz.TextChanged += new System.EventHandler(this.txtNapSzam_TextChanged);
            // 
            // btnKiiras
            // 
            this.btnKiiras.Location = new System.Drawing.Point(173, 415);
            this.btnKiiras.Name = "btnKiiras";
            this.btnKiiras.Size = new System.Drawing.Size(75, 23);
            this.btnKiiras.TabIndex = 14;
            this.btnKiiras.Text = "Kiír";
            this.btnKiiras.UseVisualStyleBackColor = true;
            this.btnKiiras.Click += new System.EventHandler(this.btnKiir_Click);
            // 
            // btnTorles
            // 
            this.btnTorles.Location = new System.Drawing.Point(386, 415);
            this.btnTorles.Name = "btnTorles";
            this.btnTorles.Size = new System.Drawing.Size(75, 23);
            this.btnTorles.TabIndex = 15;
            this.btnTorles.Text = "Töröl";
            this.btnTorles.UseVisualStyleBackColor = true;
            this.btnTorles.Click += new System.EventHandler(this.btnTorol_Click);
            // 
            // btnZar
            // 
            this.btnZar.Location = new System.Drawing.Point(599, 415);
            this.btnZar.Name = "btnZar";
            this.btnZar.Size = new System.Drawing.Size(75, 23);
            this.btnZar.TabIndex = 16;
            this.btnZar.Text = "Bezár";
            this.btnZar.UseVisualStyleBackColor = true;
            this.btnZar.Click += new System.EventHandler(this.btnBezár_Click);
            // 
            // IbIDatum
            // 
            this.IbIDatum.AutoSize = true;
            this.IbIDatum.Location = new System.Drawing.Point(300, 43);
            this.IbIDatum.Name = "IbIDatum";
            this.IbIDatum.Size = new System.Drawing.Size(10, 13);
            this.IbIDatum.TabIndex = 17;
            this.IbIDatum.Text = ".";
            this.IbIDatum.Click += new System.EventHandler(this.IbIDatum_Click);
            // 
            // IbIGratulacio
            // 
            this.IbIGratulacio.AutoSize = true;
            this.IbIGratulacio.Location = new System.Drawing.Point(386, 251);
            this.IbIGratulacio.Name = "IbIGratulacio";
            this.IbIGratulacio.Size = new System.Drawing.Size(10, 13);
            this.IbIGratulacio.TabIndex = 18;
            this.IbIGratulacio.Text = ".";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mskdTxtSzulD
            // 
            this.mskdTxtSzulD.Location = new System.Drawing.Point(199, 106);
            this.mskdTxtSzulD.Mask = "0000.00.00";
            this.mskdTxtSzulD.Name = "mskdTxtSzulD";
            this.mskdTxtSzulD.Size = new System.Drawing.Size(100, 20);
            this.mskdTxtSzulD.TabIndex = 19;
            this.mskdTxtSzulD.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskdTxtSzulDatum_MaskInputRejected);
            this.mskdTxtSzulD.Leave += new System.EventHandler(this.maskedTextBox1_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mskdTxtSzulD);
            this.Controls.Add(this.IbIGratulacio);
            this.Controls.Add(this.IbIDatum);
            this.Controls.Add(this.btnZar);
            this.Controls.Add(this.btnTorles);
            this.Controls.Add(this.btnKiiras);
            this.Controls.Add(this.txtnapokSz);
            this.Controls.Add(this.txtnapokSzKesobb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtnapSzamaEvben);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtnapSzul);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtkSzam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Dátum és idő kezelése";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtkSzam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnapSzul;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnapSzamaEvben;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnapokSzKesobb;
        private System.Windows.Forms.TextBox txtnapokSz;
        private System.Windows.Forms.Button btnKiiras;
        private System.Windows.Forms.Button btnTorles;
        private System.Windows.Forms.Button btnZar;
        private System.Windows.Forms.Label IbIDatum;
        private System.Windows.Forms.Label IbIGratulacio;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MaskedTextBox mskdTxtSzulD;
    }
}

