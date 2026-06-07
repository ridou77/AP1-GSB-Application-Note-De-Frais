namespace GSB_demo.Views
{
    partial class NewLigneFraisForfaitForm
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
            label1 = new Label();
            listeFraisDefini = new ComboBox();
            label2 = new Label();
            choixNombreFrais = new NumericUpDown();
            btnAddLigneFrais = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)choixNombreFrais).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 14);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 0;
            label1.Text = "Ajout de frais forfait ";
            // 
            // listeFraisDefini
            // 
            listeFraisDefini.FormattingEnabled = true;
            listeFraisDefini.Location = new Point(137, 78);
            listeFraisDefini.Margin = new Padding(3, 2, 3, 2);
            listeFraisDefini.Name = "listeFraisDefini";
            listeFraisDefini.Size = new Size(133, 23);
            listeFraisDefini.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 81);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 3;
            label2.Text = "Ajouter un frais :";
            // 
            // choixNombreFrais
            // 
            choixNombreFrais.DecimalPlaces = 2;
            choixNombreFrais.Location = new Point(293, 80);
            choixNombreFrais.Margin = new Padding(3, 2, 3, 2);
            choixNombreFrais.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            choixNombreFrais.Name = "choixNombreFrais";
            choixNombreFrais.Size = new Size(80, 23);
            choixNombreFrais.TabIndex = 4;
            // 
            // btnAddLigneFrais
            // 
            btnAddLigneFrais.Location = new Point(256, 144);
            btnAddLigneFrais.Margin = new Padding(3, 2, 3, 2);
            btnAddLigneFrais.Name = "btnAddLigneFrais";
            btnAddLigneFrais.Size = new Size(116, 37);
            btnAddLigneFrais.TabIndex = 5;
            btnAddLigneFrais.Text = "Ajouter à la fiche";
            btnAddLigneFrais.UseVisualStyleBackColor = true;
            btnAddLigneFrais.Click += btnAddLigneFrais_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.clouds_upright_2x1;
            pictureBox1.Location = new Point(293, -17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 298);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // NewLigneFraisForfaitForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(406, 205);
            Controls.Add(btnAddLigneFrais);
            Controls.Add(choixNombreFrais);
            Controls.Add(label2);
            Controls.Add(listeFraisDefini);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "NewLigneFraisForfaitForm";
            Text = "NewFicheFrais";
            ((System.ComponentModel.ISupportInitialize)choixNombreFrais).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox listeFraisDefini;
        private Label label2;
        private NumericUpDown choixNombreFrais;
        private Button btnAddLigneFrais;
        private PictureBox pictureBox1;
    }
}