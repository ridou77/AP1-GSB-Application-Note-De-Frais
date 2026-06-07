namespace GSB_demo.Views
{
    partial class UpdateLigneFFForm
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
            comboBox_MajFF = new ComboBox();
            lbl_MajFF = new Label();
            numericUpDown_MajFF = new NumericUpDown();
            btn_MajFF = new Button();
            label1 = new Label();
            comboBox_StatusModif = new ComboBox();
            lbl_ModifStatut = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_MajFF).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBox_MajFF
            // 
            comboBox_MajFF.FormattingEnabled = true;
            comboBox_MajFF.Location = new Point(130, 122);
            comboBox_MajFF.Margin = new Padding(3, 2, 3, 2);
            comboBox_MajFF.Name = "comboBox_MajFF";
            comboBox_MajFF.Size = new Size(133, 23);
            comboBox_MajFF.TabIndex = 1;
            // 
            // lbl_MajFF
            // 
            lbl_MajFF.AutoSize = true;
            lbl_MajFF.Location = new Point(18, 124);
            lbl_MajFF.Name = "lbl_MajFF";
            lbl_MajFF.Size = new Size(95, 15);
            lbl_MajFF.TabIndex = 2;
            lbl_MajFF.Text = "Modifier le frais :";
            // 
            // numericUpDown_MajFF
            // 
            numericUpDown_MajFF.Location = new Point(276, 123);
            numericUpDown_MajFF.Margin = new Padding(3, 2, 3, 2);
            numericUpDown_MajFF.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numericUpDown_MajFF.Name = "numericUpDown_MajFF";
            numericUpDown_MajFF.Size = new Size(131, 23);
            numericUpDown_MajFF.TabIndex = 3;
            // 
            // btn_MajFF
            // 
            btn_MajFF.Location = new Point(286, 176);
            btn_MajFF.Margin = new Padding(3, 2, 3, 2);
            btn_MajFF.Name = "btn_MajFF";
            btn_MajFF.Size = new Size(109, 38);
            btn_MajFF.TabIndex = 4;
            btn_MajFF.Text = "Mettre à jour la ligne de frais forfait";
            btn_MajFF.UseVisualStyleBackColor = true;
            btn_MajFF.Click += btn_MajFF_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 25);
            label1.Name = "label1";
            label1.Size = new Size(152, 15);
            label1.TabIndex = 5;
            label1.Text = "Mise à jour d'un frais forfait";
            // 
            // comboBox_StatusModif
            // 
            comboBox_StatusModif.FormattingEnabled = true;
            comboBox_StatusModif.Location = new Point(130, 148);
            comboBox_StatusModif.Margin = new Padding(3, 2, 3, 2);
            comboBox_StatusModif.Name = "comboBox_StatusModif";
            comboBox_StatusModif.Size = new Size(133, 23);
            comboBox_StatusModif.TabIndex = 6;
            // 
            // lbl_ModifStatut
            // 
            lbl_ModifStatut.AutoSize = true;
            lbl_ModifStatut.Location = new Point(10, 150);
            lbl_ModifStatut.Name = "lbl_ModifStatut";
            lbl_ModifStatut.Size = new Size(103, 15);
            lbl_ModifStatut.TabIndex = 7;
            lbl_ModifStatut.Text = "Modifier le statut :";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.clouds_upright_2x1;
            pictureBox1.Location = new Point(317, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 257);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // UpdateLigneFFForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(438, 246);
            Controls.Add(lbl_ModifStatut);
            Controls.Add(comboBox_StatusModif);
            Controls.Add(label1);
            Controls.Add(btn_MajFF);
            Controls.Add(numericUpDown_MajFF);
            Controls.Add(lbl_MajFF);
            Controls.Add(comboBox_MajFF);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UpdateLigneFFForm";
            Text = "UpdateLigneFFForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_MajFF).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox_MajFF;
        private Label lbl_MajFF;
        private NumericUpDown numericUpDown_MajFF;
        private Button btn_MajFF;
        private Label label1;
        private ComboBox comboBox_StatusModif;
        private Label lbl_ModifStatut;
        private PictureBox pictureBox1;
    }
}