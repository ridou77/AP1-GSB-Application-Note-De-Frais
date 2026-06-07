namespace GSB_demo.Views
{
    partial class FraisForm
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
            LigneFraisForfaitDG = new DataGridView();
            btnAddFraisForfait = new Button();
            btn_AddFraisHF = new Button();
            ligneFraisHFDG = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            FraisForfaitStatus = new Label();
            TotalPriceFraisForfait = new Label();
            TotalPriceFraisHorsForfait = new Label();
            FraisHorsForfaitStatus = new Label();
            btn_deleteFF = new Button();
            btn_UpdateFF = new Button();
            btn_DeleteHF = new Button();
            btn_UpdateHF = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)LigneFraisForfaitDG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ligneFraisHFDG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(640, 21);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Fiche de frais";
            // 
            // LigneFraisForfaitDG
            // 
            LigneFraisForfaitDG.BackgroundColor = SystemColors.ActiveCaption;
            LigneFraisForfaitDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LigneFraisForfaitDG.Location = new Point(122, 83);
            LigneFraisForfaitDG.Margin = new Padding(3, 2, 3, 2);
            LigneFraisForfaitDG.Name = "LigneFraisForfaitDG";
            LigneFraisForfaitDG.RowHeadersVisible = false;
            LigneFraisForfaitDG.RowHeadersWidth = 51;
            LigneFraisForfaitDG.Size = new Size(408, 293);
            LigneFraisForfaitDG.TabIndex = 1;
            // 
            // btnAddFraisForfait
            // 
            btnAddFraisForfait.Location = new Point(269, 452);
            btnAddFraisForfait.Margin = new Padding(3, 2, 3, 2);
            btnAddFraisForfait.Name = "btnAddFraisForfait";
            btnAddFraisForfait.Size = new Size(120, 42);
            btnAddFraisForfait.TabIndex = 2;
            btnAddFraisForfait.Text = "Ajouter un frais forfait";
            btnAddFraisForfait.UseVisualStyleBackColor = true;
            btnAddFraisForfait.Click += btnAddFraisForfait_Click;
            // 
            // btn_AddFraisHF
            // 
            btn_AddFraisHF.Location = new Point(992, 452);
            btn_AddFraisHF.Margin = new Padding(3, 2, 3, 2);
            btn_AddFraisHF.Name = "btn_AddFraisHF";
            btn_AddFraisHF.Size = new Size(120, 42);
            btn_AddFraisHF.TabIndex = 3;
            btn_AddFraisHF.Text = "Ajouter un frais hors forfait";
            btn_AddFraisHF.UseVisualStyleBackColor = true;
            btn_AddFraisHF.Click += btn_AddFraisHF_Click;
            // 
            // ligneFraisHFDG
            // 
            ligneFraisHFDG.BackgroundColor = SystemColors.ActiveCaption;
            ligneFraisHFDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ligneFraisHFDG.Location = new Point(714, 87);
            ligneFraisHFDG.Margin = new Padding(3, 2, 3, 2);
            ligneFraisHFDG.Name = "ligneFraisHFDG";
            ligneFraisHFDG.RowHeadersVisible = false;
            ligneFraisHFDG.RowHeadersWidth = 51;
            ligneFraisHFDG.Size = new Size(651, 293);
            ligneFraisHFDG.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(269, 52);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 5;
            label2.Text = "Liste des frais forfait";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(956, 52);
            label3.Name = "label3";
            label3.Size = new Size(138, 15);
            label3.TabIndex = 6;
            label3.Text = "Liste des frais hors forfait";
            // 
            // FraisForfaitStatus
            // 
            FraisForfaitStatus.AutoSize = true;
            FraisForfaitStatus.Location = new Point(122, 404);
            FraisForfaitStatus.Name = "FraisForfaitStatus";
            FraisForfaitStatus.Size = new Size(47, 15);
            FraisForfaitStatus.TabIndex = 7;
            FraisForfaitStatus.Text = "Statut : ";
            // 
            // TotalPriceFraisForfait
            // 
            TotalPriceFraisForfait.AutoSize = true;
            TotalPriceFraisForfait.Location = new Point(122, 389);
            TotalPriceFraisForfait.Name = "TotalPriceFraisForfait";
            TotalPriceFraisForfait.Size = new Size(59, 15);
            TotalPriceFraisForfait.TabIndex = 8;
            TotalPriceFraisForfait.Text = "Prix total :";
            // 
            // TotalPriceFraisHorsForfait
            // 
            TotalPriceFraisHorsForfait.AutoSize = true;
            TotalPriceFraisHorsForfait.Location = new Point(714, 389);
            TotalPriceFraisHorsForfait.Name = "TotalPriceFraisHorsForfait";
            TotalPriceFraisHorsForfait.Size = new Size(59, 15);
            TotalPriceFraisHorsForfait.TabIndex = 10;
            TotalPriceFraisHorsForfait.Text = "Prix total :";
            // 
            // FraisHorsForfaitStatus
            // 
            FraisHorsForfaitStatus.AutoSize = true;
            FraisHorsForfaitStatus.Location = new Point(714, 407);
            FraisHorsForfaitStatus.Name = "FraisHorsForfaitStatus";
            FraisHorsForfaitStatus.Size = new Size(47, 15);
            FraisHorsForfaitStatus.TabIndex = 9;
            FraisHorsForfaitStatus.Text = "Statut : ";
            // 
            // btn_deleteFF
            // 
            btn_deleteFF.Location = new Point(308, 378);
            btn_deleteFF.Margin = new Padding(3, 2, 3, 2);
            btn_deleteFF.Name = "btn_deleteFF";
            btn_deleteFF.Size = new Size(221, 22);
            btn_deleteFF.TabIndex = 11;
            btn_deleteFF.Text = "Supprimer une ligne de frais forfait";
            btn_deleteFF.UseVisualStyleBackColor = true;
            btn_deleteFF.Click += btn_deleteFF_Click;
            // 
            // btn_UpdateFF
            // 
            btn_UpdateFF.Location = new Point(308, 400);
            btn_UpdateFF.Margin = new Padding(3, 2, 3, 2);
            btn_UpdateFF.Name = "btn_UpdateFF";
            btn_UpdateFF.Size = new Size(221, 22);
            btn_UpdateFF.TabIndex = 12;
            btn_UpdateFF.Text = "Modifier une ligne de frais forfait";
            btn_UpdateFF.UseVisualStyleBackColor = true;
            btn_UpdateFF.Click += btn_UpdateFF_Click;
            // 
            // btn_DeleteHF
            // 
            btn_DeleteHF.Location = new Point(1116, 385);
            btn_DeleteHF.Margin = new Padding(3, 2, 3, 2);
            btn_DeleteHF.Name = "btn_DeleteHF";
            btn_DeleteHF.Size = new Size(249, 22);
            btn_DeleteHF.TabIndex = 13;
            btn_DeleteHF.Text = "Supprimer une ligne de frais hors forfait";
            btn_DeleteHF.UseVisualStyleBackColor = true;
            btn_DeleteHF.Click += btn_DeleteHF_Click;
            // 
            // btn_UpdateHF
            // 
            btn_UpdateHF.Location = new Point(1116, 411);
            btn_UpdateHF.Margin = new Padding(3, 2, 3, 2);
            btn_UpdateHF.Name = "btn_UpdateHF";
            btn_UpdateHF.Size = new Size(249, 22);
            btn_UpdateHF.TabIndex = 14;
            btn_UpdateHF.Text = "Modifier une ligne de frais hors forfait";
            btn_UpdateHF.UseVisualStyleBackColor = true;
            btn_UpdateHF.Click += btn_UpdateHF_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.clouds_upright_2x1;
            pictureBox1.Location = new Point(1263, -11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 573);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.gsb_logo2;
            pictureBox2.Location = new Point(43, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(95, 56);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // FraisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(1423, 536);
            Controls.Add(pictureBox2);
            Controls.Add(ligneFraisHFDG);
            Controls.Add(btn_DeleteHF);
            Controls.Add(btn_UpdateHF);
            Controls.Add(pictureBox1);
            Controls.Add(btn_UpdateFF);
            Controls.Add(btn_deleteFF);
            Controls.Add(TotalPriceFraisHorsForfait);
            Controls.Add(FraisHorsForfaitStatus);
            Controls.Add(TotalPriceFraisForfait);
            Controls.Add(FraisForfaitStatus);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_AddFraisHF);
            Controls.Add(btnAddFraisForfait);
            Controls.Add(LigneFraisForfaitDG);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FraisForm";
            Text = "FraisForfaitForm";
            ((System.ComponentModel.ISupportInitialize)LigneFraisForfaitDG).EndInit();
            ((System.ComponentModel.ISupportInitialize)ligneFraisHFDG).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView LigneFraisForfaitDG;
        private Button btnAddFraisForfait;
        private Button btn_AddFraisHF;
        private DataGridView ligneFraisHFDG;
        private Label label2;
        private Label label3;
        private Label FraisForfaitStatus;
        private Label TotalPriceFraisForfait;
        private Label TotalPriceFraisHorsForfait;
        private Label FraisHorsForfaitStatus;
        private Button btn_deleteFF;
        private Button btn_UpdateFF;
        private Button btn_DeleteHF;
        private Button btn_UpdateHF;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}