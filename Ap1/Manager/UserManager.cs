using GSB_demo.Models;
using GSB_demo.Utils;
using MySql.Data.MySqlClient;

namespace GSB_demo.Manager;

public class UserManager
{
    public List<User> GetAllUsers()
    {
        var users = new List<User>();

        try
        {
            using var connection = DatabaseConnection.GetConnection();
            connection.Open();

            const string query = @"SELECT id_user, id_role, nom, prenom, email, login, motdepasse_hash, actif, user_creation_date
                                   FROM users
                                   ORDER BY prenom, nom";

            using var cmd = new MySqlCommand(query, connection);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                users.Add(new User
                {
                    IdUser = reader.GetInt32("id_user"),
                    Role = (User.RoleUser)reader.GetInt32("id_role"),
                    Nom = reader.GetString("nom"),
                    Prenom = reader.GetString("prenom"),
                    Email = reader.IsDBNull(reader.GetOrdinal("email")) ? string.Empty : reader.GetString("email"),
                    Login = reader.GetString("login"),
                    Mdp = reader.IsDBNull(reader.GetOrdinal("motdepasse_hash")) ? string.Empty : reader.GetString("motdepasse_hash"),
                    Actif = reader.GetBoolean("actif"),
                    UserCreationDate = reader.GetDateTime("user_creation_date")
                });
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erreur lors du chargement des utilisateurs : {ex.Message}",
                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        return users;
    }
}
