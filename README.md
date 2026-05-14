# 🚀 Déploiement — GSB Application Note de Frais

> **Dépôt GitHub :** [AP1-GSB-Application-Note-De-Frais](https://github.com/ridou77/AP1-GSB-Application-Note-De-Frais)

---

## 📐 Architecture générale

```
┌─────────────────────┐         Internet (port 3306)        ┌───────────────────────┐
│  Application client │  ─────────────────────────────────► │  VPS (Serveur)        │
│  WinForms (.exe)    │                                      │  Docker + MariaDB     │
└─────────────────────┘                                      └───────────────────────┘
```

L'architecture repose sur deux composants distincts :

- **Le serveur (VPS)** : héberge la base de données MariaDB dans un conteneur Docker. Il centralise toutes les données de l'application (utilisateurs, rôles, fiches de frais, etc.) et est accessible depuis Internet via le port **3306**.
- **Le client (WinForms)** : application portable qui se connecte à distance au serveur pour lire et écrire les données. Aucune installation côté client n'est nécessaire.

---

## 🖥️ Configuration du serveur (VPS)

### Docker & MariaDB

Le VPS utilise **Docker** pour exécuter la base de données dans un conteneur isolé. Cette approche facilite la gestion, le démarrage et l'arrêt du service de base de données.

La base de données **MariaDB** stocke l'ensemble des informations nécessaires au fonctionnement de l'application :
- Comptes utilisateurs et rôles
- Fiches de frais
- Données métier associées

### Accès réseau

Le port **3306** (port standard MySQL/MariaDB) est ouvert sur le VPS pour permettre à l'application cliente de se connecter à distance via Internet.

### Sécurité des mots de passe

Les mots de passe des utilisateurs sont stockés de manière hachée en **SHA256** afin de ne pas conserver les mots de passe en clair dans la base de données.

---

## 🔗 Chaîne de connexion à la base de données

La chaîne de connexion utilisée par l'application pour joindre le serveur MariaDB est visible directement dans le dépôt GitHub (fichier de configuration du projet). Elle suit le format standard suivant :

```
Server=<IP_VPS>;Port=3306;Database=<nom_bdd>;User=<utilisateur>;Password=<mot_de_passe>;
```

> **Remarque :** Pour cette épreuve, la chaîne de connexion est incluse en clair dans le dépôt pour faciliter l'évaluation. Voir la section [⚠️ Avertissement de sécurité](#️-avertissement-de-sécurité--contexte-dépreuve) ci-dessous.

---

## 🔑 Identifiants de connexion à l'application

Pour tester l'application lors de l'épreuve, utiliser les identifiants suivants :

| Champ          | Valeur      |
|----------------|-------------|
| **Identifiant** | `Jdoe`     |
| **Mot de passe** | `test_mdp` |

---

## 📥 Installation & Lancement

1. **Télécharger** l'exécutable depuis la section **Releases** du dépôt GitHub :
   👉 [https://github.com/ridou77/AP1-GSB-Application-Note-De-Frais/releases](https://github.com/ridou77/AP1-GSB-Application-Note-De-Frais/releases)

2. **Exécuter** directement le fichier `.exe` téléchargé.

L'application est **portable** : aucune installation préalable n'est requise. Tout est intégré dans l'exécutable, prêt à l'emploi.

---

## ⚠️ Avertissement de sécurité — Contexte d'épreuve

> **Ce déploiement est réalisé dans un cadre strictement pédagogique (épreuve BTS - E6) et ne reflète pas les bonnes pratiques d'un environnement de production.**

Les points suivants représentent des risques de sécurité importants, acceptés ici uniquement pour des raisons pratiques liées à l'évaluation :

| Risque | Description |
|--------|-------------|
| 🔴 **Port 3306 exposé sur Internet** | Exposer directement le port de la base de données est une pratique dangereuse. Un attaquant peut tenter des connexions par force brute ou exploiter des vulnérabilités de MariaDB. |
| 🔴 **Chaîne de connexion en clair dans le dépôt** | Les identifiants de la base de données sont visibles par quiconque accède au code source. |
| 🟠 **Identifiants partagés publiquement** | Les identifiants de test (`Jdoe` / `test_mdp`) sont diffusés dans ce README pour faciliter l'évaluation. |

### ✅ Ce qui serait fait en conditions réelles

En environnement de production, les pratiques suivantes seraient appliquées :

- **VPN ou tunnel SSH** pour accéder à la base de données sans exposer le port 3306 sur Internet
- **Fichiers de configuration chiffrés** ou variables d'environnement pour stocker les identifiants (jamais en clair dans le dépôt)
- **Principe du moindre privilège** : l'utilisateur de la BDD n'aurait accès qu'aux tables strictement nécessaires
- **Pare-feu applicatif** et restrictions d'IP pour limiter les connexions autorisées
- **Rotation régulière des mots de passe** et journalisation des accès

---

*Ce projet a été réalisé dans le cadre du BTS SIO — Épreuve - E6 : Conception et développement
d'applications.*
