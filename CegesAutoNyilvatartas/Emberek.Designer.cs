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
            txtNev = new TextBox();
            txtOsztaly = new TextBox();
            btnMentes = new Button();
            label1 = new Label();
            label2 = new Label();
            lstEmberek = new ListBox();
            SuspendLayout();
            // 
            // txtNev
            // 
            txtNev.Location = new Point(492, 66);
            txtNev.Name = "txtNev";
            txtNev.Size = new Size(125, 27);
            txtNev.TabIndex = 0;
            // 
            // txtOsztaly
            // 
            txtOsztaly.Location = new Point(492, 133);
            txtOsztaly.Name = "txtOsztaly";
            txtOsztaly.Size = new Size(125, 27);
            txtOsztaly.TabIndex = 1;
            // 
            // btnMentes
            // 
            btnMentes.Location = new Point(492, 182);
            btnMentes.Name = "btnMentes";
            btnMentes.Size = new Size(94, 29);
            btnMentes.TabIndex = 2;
            btnMentes.Text = "Mentés";
            btnMentes.UseVisualStyleBackColor = true;
            btnMentes.Click += btnMentes_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(492, 43);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 3;
            label1.Text = "Név:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(492, 110);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 3;
            label2.Text = "Osztály:";
            // 
            // lstEmberek
            // 
            lstEmberek.FormattingEnabled = true;
            lstEmberek.Location = new Point(29, 22);
            lstEmberek.Name = "lstEmberek";
            lstEmberek.Size = new Size(355, 364);
            lstEmberek.TabIndex = 4;
            // 
            // Emberek
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstEmberek);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnMentes);
            Controls.Add(txtOsztaly);
            Controls.Add(txtNev);
            Name = "Emberek";
            Text = "Form2";
            Load += Emberek_Load;
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
    }
}