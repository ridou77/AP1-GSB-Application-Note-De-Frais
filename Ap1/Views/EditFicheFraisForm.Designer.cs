namespace GSB_demo.Views
{
    partial class EditFicheFraisForm
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
            UpdateFicheFraisBtn = new Button();
            pictureBox1 = new PictureBox();
            NewDatedateTimePicker = new DateTimePicker();
            NewDatelbl = new Label();
            NewUsercomboBox = new ComboBox();
            NewUserlbl = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // UpdateFicheFraisBtn
            // 
            UpdateFicheFraisBtn.Location = new Point(316, 130);
            UpdateFicheFraisBtn.Name = "UpdateFicheFraisBtn";
            UpdateFicheFraisBtn.Size = new Size(108, 37);
            UpdateFicheFraisBtn.TabIndex = 0;
            UpdateFicheFraisBtn.Text = "Sauvegarder";
            UpdateFicheFraisBtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.clouds_upright_2x1;
            pictureBox1.Location = new Point(390, -41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 236);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // NewDatedateTimePicker
            // 
            NewDatedateTimePicker.Location = new Point(220, 71);
            NewDatedateTimePicker.Name = "NewDatedateTimePicker";
            NewDatedateTimePicker.Size = new Size(204, 23);
            NewDatedateTimePicker.TabIndex = 14;
            // 
            // NewDatelbl
            // 
            NewDatelbl.AutoSize = true;
            NewDatelbl.Location = new Point(220, 53);
            NewDatelbl.Name = "NewDatelbl";
            NewDatelbl.Size = new Size(80, 15);
            NewDatelbl.TabIndex = 0;
            NewDatelbl.Text = "Nouvelle date";
            // 
            // NewUsercomboBox
            // 
            NewUsercomboBox.FormattingEnabled = true;
            NewUsercomboBox.Location = new Point(32, 71);
            NewUsercomboBox.Name = "NewUsercomboBox";
            NewUsercomboBox.Size = new Size(121, 23);
            NewUsercomboBox.TabIndex = 15;
            // 
            // NewUserlbl
            // 
            NewUserlbl.AutoSize = true;
            NewUserlbl.Location = new Point(32, 53);
            NewUserlbl.Name = "NewUserlbl";
            NewUserlbl.Size = new Size(101, 15);
            NewUserlbl.TabIndex = 16;
            NewUserlbl.Text = "Nouvel Utilisateur";
            // 
            // EditFicheFraisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(457, 179);
            Controls.Add(NewUserlbl);
            Controls.Add(NewUsercomboBox);
            Controls.Add(NewDatelbl);
            Controls.Add(NewDatedateTimePicker);
            Controls.Add(UpdateFicheFraisBtn);
            Controls.Add(pictureBox1);
            Name = "EditFicheFraisForm";
            Text = "EditFicheFraisForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button UpdateFicheFraisBtn;
        private PictureBox pictureBox1;
        private DateTimePicker NewDatedateTimePicker;
        private Label NewDatelbl;
        private ComboBox NewUsercomboBox;
        private Label NewUserlbl;
    }
}