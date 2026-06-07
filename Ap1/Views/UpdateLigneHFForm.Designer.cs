namespace GSB_demo.Views
{
    partial class UpdateLigneHFForm
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
            textBox_MajHF = new TextBox();
            lbl_MajHF = new Label();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            btn_MajHF = new Button();
            lbl_StatutHF = new Label();
            comboBox_StatutHF = new ComboBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox_MajHF
            // 
            textBox_MajHF.Location = new Point(207, 124);
            textBox_MajHF.Margin = new Padding(3, 2, 3, 2);
            textBox_MajHF.Name = "textBox_MajHF";
            textBox_MajHF.Size = new Size(110, 23);
            textBox_MajHF.TabIndex = 0;
            // 
            // lbl_MajHF
            // 
            lbl_MajHF.AutoSize = true;
            lbl_MajHF.Location = new Point(29, 126);
            lbl_MajHF.Name = "lbl_MajHF";
            lbl_MajHF.Size = new Size(156, 15);
            lbl_MajHF.TabIndex = 1;
            lbl_MajHF.Text = "Modifier le frais hors forfait :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(116, 34);
            label2.Name = "label2";
            label2.Size = new Size(229, 15);
            label2.TabIndex = 2;
            label2.Text = "Mise à jour d'une ligne de frais hors forfait";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(322, 124);
            numericUpDown1.Margin = new Padding(3, 2, 3, 2);
            numericUpDown1.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(131, 23);
            numericUpDown1.TabIndex = 3;
            // 
            // btn_MajHF
            // 
            btn_MajHF.Location = new Point(328, 191);
            btn_MajHF.Margin = new Padding(3, 2, 3, 2);
            btn_MajHF.Name = "btn_MajHF";
            btn_MajHF.Size = new Size(125, 49);
            btn_MajHF.TabIndex = 4;
            btn_MajHF.Text = "Mettre à jour le frais hors forfait";
            btn_MajHF.UseVisualStyleBackColor = true;
            btn_MajHF.Click += btn_MajHF_Click;
            // 
            // lbl_StatutHF
            // 
            lbl_StatutHF.AutoSize = true;
            lbl_StatutHF.Location = new Point(60, 148);
            lbl_StatutHF.Name = "lbl_StatutHF";
            lbl_StatutHF.Size = new Size(131, 15);
            lbl_StatutHF.TabIndex = 5;
            lbl_StatutHF.Text = "Modification du statut :";
            // 
            // comboBox_StatutHF
            // 
            comboBox_StatutHF.FormattingEnabled = true;
            comboBox_StatutHF.Location = new Point(207, 148);
            comboBox_StatutHF.Margin = new Padding(3, 2, 3, 2);
            comboBox_StatutHF.Name = "comboBox_StatutHF";
            comboBox_StatutHF.Size = new Size(133, 23);
            comboBox_StatutHF.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.clouds_upright_2x1;
            pictureBox1.Location = new Point(368, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 264);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // UpdateLigneHFForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(474, 249);
            Controls.Add(comboBox_StatutHF);
            Controls.Add(lbl_StatutHF);
            Controls.Add(btn_MajHF);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(lbl_MajHF);
            Controls.Add(textBox_MajHF);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UpdateLigneHFForm";
            Text = "UpdateLigneHFForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_MajHF;
        private Label lbl_MajHF;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Button btn_MajHF;
        private Label lbl_StatutHF;
        private ComboBox comboBox_StatutHF;
        private PictureBox pictureBox1;
    }
}