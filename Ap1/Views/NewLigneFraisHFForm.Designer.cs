namespace GSB_demo.Views
{
    partial class NewLigneFraisHFForm
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
            lbl_LigneFraisHorsForfait = new Label();
            Btn_AddLigneFraisHF = new Button();
            PriceNumericUpDown = new NumericUpDown();
            PriceLbl = new Label();
            NameLigneFraisHFTxtBox = new TextBox();
            lbl_NameFraisHF = new Label();
            dtp_NewLigneFraisHF = new DateTimePicker();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PriceNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_LigneFraisHorsForfait
            // 
            lbl_LigneFraisHorsForfait.AutoSize = true;
            lbl_LigneFraisHorsForfait.Location = new Point(134, 27);
            lbl_LigneFraisHorsForfait.Name = "lbl_LigneFraisHorsForfait";
            lbl_LigneFraisHorsForfait.Size = new Size(141, 15);
            lbl_LigneFraisHorsForfait.TabIndex = 0;
            lbl_LigneFraisHorsForfait.Text = "Nouveau frais hors forfait";
            // 
            // Btn_AddLigneFraisHF
            // 
            Btn_AddLigneFraisHF.Location = new Point(274, 135);
            Btn_AddLigneFraisHF.Margin = new Padding(3, 2, 3, 2);
            Btn_AddLigneFraisHF.Name = "Btn_AddLigneFraisHF";
            Btn_AddLigneFraisHF.Size = new Size(124, 43);
            Btn_AddLigneFraisHF.TabIndex = 1;
            Btn_AddLigneFraisHF.Text = "Ajouter un frais hors forfait";
            Btn_AddLigneFraisHF.UseVisualStyleBackColor = true;
            Btn_AddLigneFraisHF.Click += Btn_AddLigneFraisHF_Click;
            // 
            // PriceNumericUpDown
            // 
            PriceNumericUpDown.DecimalPlaces = 2;
            PriceNumericUpDown.Location = new Point(294, 82);
            PriceNumericUpDown.Margin = new Padding(3, 2, 3, 2);
            PriceNumericUpDown.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            PriceNumericUpDown.Name = "PriceNumericUpDown";
            PriceNumericUpDown.Size = new Size(84, 23);
            PriceNumericUpDown.TabIndex = 2;
            // 
            // PriceLbl
            // 
            PriceLbl.AutoSize = true;
            PriceLbl.Location = new Point(383, 84);
            PriceLbl.Name = "PriceLbl";
            PriceLbl.Size = new Size(13, 15);
            PriceLbl.TabIndex = 3;
            PriceLbl.Text = "€";
            // 
            // NameLigneFraisHFTxtBox
            // 
            NameLigneFraisHFTxtBox.Location = new Point(179, 82);
            NameLigneFraisHFTxtBox.Margin = new Padding(3, 2, 3, 2);
            NameLigneFraisHFTxtBox.Name = "NameLigneFraisHFTxtBox";
            NameLigneFraisHFTxtBox.Size = new Size(110, 23);
            NameLigneFraisHFTxtBox.TabIndex = 4;
            // 
            // lbl_NameFraisHF
            // 
            lbl_NameFraisHF.AutoSize = true;
            lbl_NameFraisHF.Location = new Point(18, 84);
            lbl_NameFraisHF.Name = "lbl_NameFraisHF";
            lbl_NameFraisHF.Size = new Size(143, 15);
            lbl_NameFraisHF.TabIndex = 5;
            lbl_NameFraisHF.Text = "Nom du frais hors forfait :";
            // 
            // dtp_NewLigneFraisHF
            // 
            dtp_NewLigneFraisHF.Location = new Point(179, 56);
            dtp_NewLigneFraisHF.Margin = new Padding(3, 2, 3, 2);
            dtp_NewLigneFraisHF.Name = "dtp_NewLigneFraisHF";
            dtp_NewLigneFraisHF.Size = new Size(219, 23);
            dtp_NewLigneFraisHF.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 60);
            label1.Name = "label1";
            label1.Size = new Size(132, 15);
            label1.TabIndex = 7;
            label1.Text = "Ajouter la date du frais :";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.clouds_upright_2x1;
            pictureBox1.Location = new Point(310, -91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 301);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // NewLigneFraisHFForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(427, 206);
            Controls.Add(label1);
            Controls.Add(dtp_NewLigneFraisHF);
            Controls.Add(lbl_NameFraisHF);
            Controls.Add(NameLigneFraisHFTxtBox);
            Controls.Add(PriceLbl);
            Controls.Add(PriceNumericUpDown);
            Controls.Add(Btn_AddLigneFraisHF);
            Controls.Add(lbl_LigneFraisHorsForfait);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "NewLigneFraisHFForm";
            Text = "NewLigneFraisHFForm";
            ((System.ComponentModel.ISupportInitialize)PriceNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_LigneFraisHorsForfait;
        private Button Btn_AddLigneFraisHF;
        private NumericUpDown PriceNumericUpDown;
        private Label PriceLbl;
        private TextBox NameLigneFraisHFTxtBox;
        private Label lbl_NameFraisHF;
        private DateTimePicker dtp_NewLigneFraisHF;
        private Label label1;
        private PictureBox pictureBox1;
    }
}