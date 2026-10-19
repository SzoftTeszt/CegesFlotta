namespace CegesAutoNyilvatartas
{
    partial class Emberek
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
            txtNev = new TextBox();
            txtOsztaly = new TextBox();
            btnMentes = new Button();
            label1 = new Label();
            label2 = new Label();
            lstEmberek = new ListBox();
            btnModositas = new Button();
            btnTorles = new Button();
            btnMegse = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtNev
            // 
            txtNev.Location = new Point(235, 97);
            txtNev.Margin = new Padding(3, 2, 3, 2);
            txtNev.Name = "txtNev";
            txtNev.Size = new Size(163, 23);
            txtNev.TabIndex = 0;
            // 
            // txtOsztaly
            // 
            txtOsztaly.Location = new Point(235, 147);
            txtOsztaly.Margin = new Padding(3, 2, 3, 2);
            txtOsztaly.Name = "txtOsztaly";
            txtOsztaly.Size = new Size(163, 23);
            txtOsztaly.TabIndex = 1;
            // 
            // btnMentes
            // 
            btnMentes.Location = new Point(235, 222);
            btnMentes.Margin = new Padding(3, 2, 3, 2);
            btnMentes.Name = "btnMentes";
            btnMentes.Size = new Size(82, 22);
            btnMentes.TabIndex = 2;
            btnMentes.Text = "Mentés";
            btnMentes.UseVisualStyleBackColor = true;
            btnMentes.Click += btnMentes_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(235, 79);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 3;
            label1.Text = "Név:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(235, 129);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 3;
            label2.Text = "Osztály:";
            // 
            // lstEmberek
            // 
            lstEmberek.FormattingEnabled = true;
            lstEmberek.Location = new Point(25, 76);
            lstEmberek.Margin = new Padding(3, 2, 3, 2);
            lstEmberek.Name = "lstEmberek";
            lstEmberek.Size = new Size(185, 214);
            lstEmberek.TabIndex = 4;
            lstEmberek.SelectedIndexChanged += lstEmberek_SelectedIndexChanged;
            // 
            // btnModositas
            // 
            btnModositas.Location = new Point(323, 221);
            btnModositas.Name = "btnModositas";
            btnModositas.Size = new Size(75, 23);
            btnModositas.TabIndex = 5;
            btnModositas.Text = "Módosítás";
            btnModositas.UseVisualStyleBackColor = true;
            btnModositas.Click += btnModositas_Click;
            // 
            // btnTorles
            // 
            btnTorles.Location = new Point(235, 265);
            btnTorles.Name = "btnTorles";
            btnTorles.Size = new Size(82, 23);
            btnTorles.TabIndex = 5;
            btnTorles.Text = "Törlés";
            btnTorles.UseVisualStyleBackColor = true;
            btnTorles.Click += btnTorles_Click;
            // 
            // btnMegse
            // 
            btnMegse.Location = new Point(323, 265);
            btnMegse.Name = "btnMegse";
            btnMegse.Size = new Size(75, 23);
            btnMegse.TabIndex = 5;
            btnMegse.Text = "Mégse";
            btnMegse.UseVisualStyleBackColor = true;
            btnMegse.Click += btnMegse_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(25, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 23);
            textBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 28);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 7;
            label3.Text = "Keresés név alapján:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Emberek
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 317);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(btnMegse);
            Controls.Add(btnTorles);
            Controls.Add(btnModositas);
            Controls.Add(lstEmberek);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnMentes);
            Controls.Add(txtOsztaly);
            Controls.Add(txtNev);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Emberek";
            Text = "Emberek kezelése";
            Load += Emberek_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNev;
        private TextBox txtOsztaly;
        private Button btnMentes;
        private Label label1;
        private Label label2;
        private ListBox lstEmberek;
        private Button btnModositas;
        private Button btnTorles;
        private Button btnMegse;
        private TextBox textBox1;
        private Label label3;
        private ErrorProvider errorProvider1;
    }
}