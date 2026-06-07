using GSB_demo.Manager;

namespace GSB_demo.Views
{
    public partial class AddTypeFraisForm : Form
    {
        private TextBox txtLibelle;
        private NumericUpDown numTarif;
        private Button btnAdd;
        private Label labelLibelle;
        private Label labelTarif;
        private PictureBox pictureBox1;
        private Button btnCancel;

        public AddTypeFraisForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            txtLibelle = new TextBox();
            numTarif = new NumericUpDown();
            btnAdd = new Button();
            btnCancel = new Button();
            labelLibelle = new Label();
            labelTarif = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numTarif).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtLibelle
            // 
            txtLibelle.Location = new Point(12, 33);
            txtLibelle.Name = "txtLibelle";
            txtLibelle.Size = new Size(260, 23);
            txtLibelle.TabIndex = 4;
            // 
            // numTarif
            // 
            numTarif.DecimalPlaces = 2;
            numTarif.Location = new Point(12, 86);
            numTarif.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numTarif.Name = "numTarif";
            numTarif.Size = new Size(120, 23);
            numTarif.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(116, 128);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 27);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Ajouter";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(197, 128);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 27);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Annuler";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // labelLibelle
            // 
            labelLibelle.AutoSize = true;
            labelLibelle.Location = new Point(12, 15);
            labelLibelle.Name = "labelLibelle";
            labelLibelle.Size = new Size(41, 15);
            labelLibelle.TabIndex = 5;
            labelLibelle.Text = "Libellé";
            // 
            // labelTarif
            // 
            labelTarif.AutoSize = true;
            labelTarif.Location = new Point(12, 68);
            labelTarif.Name = "labelTarif";
            labelTarif.Size = new Size(30, 15);
            labelTarif.TabIndex = 3;
            labelTarif.Text = "Tarif";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.clouds_upright_2x1;
            pictureBox1.Location = new Point(216, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 195);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // AddTypeFraisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(284, 171);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(numTarif);
            Controls.Add(labelTarif);
            Controls.Add(txtLibelle);
            Controls.Add(labelLibelle);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddTypeFraisForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ajouter un type de frais";
            ((System.ComponentModel.ISupportInitialize)numTarif).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string libelle = txtLibelle.Text.Trim();
            decimal tarif = numTarif.Value;

            if (string.IsNullOrWhiteSpace(libelle))
            {
                MessageBox.Show("Veuillez saisir un libellé.",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var manager = new TypeFraisManager();
            if (manager.AddTypeFrais(libelle, tarif))
            {
                MessageBox.Show("Type de frais ajouté avec succès.",
                    "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Erreur lors de l'ajout du type de frais.",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
