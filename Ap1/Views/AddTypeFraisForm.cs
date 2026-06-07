using GSB_demo.Manager;

namespace GSB_demo.Views
{
    public partial class AddTypeFraisForm : Form
    {
        private TextBox txtLibelle;
        private NumericUpDown numTarif;
        private Button btnAdd;
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
            var labelLibelle = new Label();
            var labelTarif = new Label();

            SuspendLayout();

            labelLibelle.AutoSize = true;
            labelLibelle.Location = new Point(12, 15);
            labelLibelle.Name = "labelLibelle";
            labelLibelle.Size = new Size(49, 15);
            labelLibelle.Text = "Libellé";

            txtLibelle.Location = new Point(12, 33);
            txtLibelle.Name = "txtLibelle";
            txtLibelle.Size = new Size(260, 23);

            labelTarif.AutoSize = true;
            labelTarif.Location = new Point(12, 68);
            labelTarif.Name = "labelTarif";
            labelTarif.Size = new Size(33, 15);
            labelTarif.Text = "Tarif";

            numTarif.Location = new Point(12, 86);
            numTarif.Name = "numTarif";
            numTarif.Size = new Size(120, 23);
            numTarif.DecimalPlaces = 2;
            numTarif.Maximum = 100000;

            btnAdd.Location = new Point(116, 128);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 27);
            btnAdd.Text = "Ajouter";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;

            btnCancel.Location = new Point(197, 128);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 27);
            btnCancel.Text = "Annuler";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 171);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(numTarif);
            Controls.Add(labelTarif);
            Controls.Add(txtLibelle);
            Controls.Add(labelLibelle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddTypeFraisForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ajouter un type de frais";
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
