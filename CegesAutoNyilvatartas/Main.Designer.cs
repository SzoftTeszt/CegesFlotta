namespace CegesAutoNyilvatartas
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnEmberek = new Button();
            btnAutok = new Button();
            btnNyilvantartas = new Button();
            btnImportExport = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(43, 26);
            label1.Name = "label1";
            label1.Size = new Size(309, 32);
            label1.TabIndex = 0;
            label1.Text = "Céges autó nyilvántartása";
            // 
            // btnEmberek
            // 
            btnEmberek.Location = new Point(103, 74);
            btnEmberek.Margin = new Padding(3, 2, 3, 2);
            btnEmberek.Name = "btnEmberek";
            btnEmberek.Size = new Size(199, 34);
            btnEmberek.TabIndex = 1;
            btnEmberek.Text = "Emberek kezelése";
            btnEmberek.UseVisualStyleBackColor = true;
            btnEmberek.Click += btnEmberek_Click;
            // 
            // btnAutok
            // 
            btnAutok.Location = new Point(103, 121);
            btnAutok.Margin = new Padding(3, 2, 3, 2);
            btnAutok.Name = "btnAutok";
            btnAutok.Size = new Size(199, 34);
            btnAutok.TabIndex = 1;
            btnAutok.Text = "Autók kezelése";
            btnAutok.UseVisualStyleBackColor = true;
            btnAutok.Click += btnAutok_Click;
            // 
            // btnNyilvantartas
            // 
            btnNyilvantartas.Location = new Point(103, 168);
            btnNyilvantartas.Margin = new Padding(3, 2, 3, 2);
            btnNyilvantartas.Name = "btnNyilvantartas";
            btnNyilvantartas.Size = new Size(199, 34);
            btnNyilvantartas.TabIndex = 1;
            btnNyilvantartas.Text = "Hozzárendelések / nyilvántartás";
            btnNyilvantartas.UseVisualStyleBackColor = true;
            // 
            // btnImportExport
            // 
            btnImportExport.Location = new Point(103, 214);
            btnImportExport.Margin = new Padding(3, 2, 3, 2);
            btnImportExport.Name = "btnImportExport";
            btnImportExport.Size = new Size(199, 34);
            btnImportExport.TabIndex = 1;
            btnImportExport.Text = "Import / Expoert";
            btnImportExport.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 288);
            Controls.Add(btnImportExport);
            Controls.Add(btnNyilvantartas);
            Controls.Add(btnAutok);
            Controls.Add(btnEmberek);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Main";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnEmberek;
        private Button btnAutok;
        private Button btnNyilvantartas;
        private Button btnImportExport;
    }
}
