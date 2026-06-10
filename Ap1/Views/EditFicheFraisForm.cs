using System;
using GSB_demo.Manager;
using GSB_demo.Models;
using System.Windows.Forms;

namespace GSB_demo.Views
{
    public partial class EditFicheFraisForm : Form
    {
        private readonly FicheFrais ficheFrais;
        private readonly FicheFraisManager ficheFraisManager = new();
        private readonly UserManager userManager = new();
        private List<User> users = new();

        public EditFicheFraisForm(FicheFrais ficheFrais)
        {
            InitializeComponent();
            this.ficheFrais = ficheFrais;

            Load += EditFicheFraisForm_Load;
            UpdateFicheFraisBtn.Click += UpdateFicheFraisBtn_Click;
        }

        private void EditFicheFraisForm_Load(object? sender, EventArgs e)
        {
            users = userManager.GetAllUsers();

            NewUsercomboBox.DataSource = users;
            NewUsercomboBox.DisplayMember = nameof(User.NomComplet);
            NewUsercomboBox.ValueMember = nameof(User.IdUser);

            NewDatedateTimePicker.Value = ficheFrais.DateCreationFicheFrais == DateTime.MinValue
                ? DateTime.Today
                : ficheFrais.DateCreationFicheFrais;

            if (users.Count > 0)
            {
                NewUsercomboBox.SelectedValue = ficheFrais.IdUser;
            }
        }

        private void UpdateFicheFraisBtn_Click(object? sender, EventArgs e)
        {
            if (NewUsercomboBox.SelectedItem is not User selectedUser)
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool updated = ficheFraisManager.UpdateFicheFraisDetails(
                ficheFrais.IdFicheFrais,
                selectedUser.IdUser,
                NewDatedateTimePicker.Value.Date);

            if (updated)
            {
                MessageBox.Show("Fiche de frais mise à jour avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("La mise à jour de la fiche de frais a échoué.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
