# Vet'Lib 🐾

Vet'Lib est une application de gestion dédiée aux refuges animaliers. Elle permet de gérer les animaux, les adoptants et les adoptions via un espace administrateur, tout en offrant aux membres la possibilité de consulter les animaux disponibles à l’adoption au sein du refuge **Molly & Cie**.

---

## 🎯 Objectif du projet

L’objectif de Vet'Lib est de simplifier la gestion quotidienne d’un refuge animalier en centralisant toutes les informations essentielles :

* gestion des animaux,
* suivi des adoptants,
* historique des adoptions,
* association adoptant/animal via des dossiers complets et non supprimables.

---

## 🏠 Fonctionnalités

### Accueil

* Page de bienvenue
* Bouton de connexion vers l’espace administrateur

### Gestion des animaux

* Ajout, modification et suppression d’animaux
* Informations enregistrées :

  * nom
  * sexe (M / F)
  * type (chat, chien, furet, perroquet, lapin)
  * date de naissance
  * date d’arrivée
  * photo

### Gestion des adoptants

* Visualisation de tous les membres inscrits
* Informations affichées :

  * nom
  * email
  * mot de passe (haché)
  * date d’inscription

### Gestion des adoptions

* Visualisation des animaux adoptés
* Informations affichées :

  * nom de l’animal
  * nom de l’adoptant
  * date d’adoption

### Dossiers d’adoption

* Association complète entre un animal et un adoptant
* Les dossiers ne peuvent pas être supprimés afin de garantir la traçabilité

---

## 🔐 Espace administrateur

L’espace administrateur permet :

* la gestion complète des animaux,
* la consultation des membres,
* le suivi des adoptions et des dossiers.

---

## 🛠️ Technologies utilisées

* Langage : **C#**
* Interface : **Windows Forms**
* Framework : **.NET Framework**
* UI : **Guna UI**
* Base de données : **SQL Server**

---

## 🗄️ Structure de la base de données

### Admin

| Champ    | Description       |
| -------- | ----------------- |
| Id       | Identifiant       |
| Username | Nom d’utilisateur |
| Password | Mot de passe      |

### Membres

| Champ           | Description         |
| --------------- | ------------------- |
| Id              | Identifiant         |
| Nom             | Nom du membre       |
| Email           | Adresse email       |
| MotDePasse      | Mot de passe        |
| Telephone       | Numéro de téléphone |
| DateInscription | Date d’inscription  |

### Animaux

| Champ         | Description       |
| ------------- | ----------------- |
| Id            | Identifiant       |
| Type          | Type d’animal     |
| Sexe          | Sexe              |
| DateNaissance | Date de naissance |
| DateArrivee   | Date d’arrivée    |
| EstAdopte     | Statut d’adoption |
| Photo         | Image             |

### Adoptions

| Champ        | Description             |
| ------------ | ----------------------- |
| Id           | Identifiant             |
| IdMembre     | Identifiant du membre   |
| IdAnimal     | Identifiant de l’animal |
| DateAdoption | Date de l’adoption      |

---

## 📌 Contexte

Vet'Lib a été conçu dans un cadre pédagogique afin de mettre en pratique :

* la programmation orientée objet,
* la gestion d’une base de données relationnelle,
* la création d’interfaces utilisateur desktop.

---

## 📷 Aperçu
<img width="800" height="500" alt="image2" src="https://github.com/user-attachments/assets/565aa2d7-7a45-41df-ad78-890fba70a737" />
<img width="800" height="500" alt="image1" src="https://github.com/user-attachments/assets/8d3c2faf-b20e-4189-b596-2d17de6e78e3" />
<img width="800" height="500" alt="image" src="https://github.com/user-attachments/assets/2e7451dc-56d8-42bf-9012-0ab633b791ad" />


---

## ✨ Auteur

Projet réalisé par **Jenna Ben Hadj Amor**
