# FORMA
Application Windows permettant l'interaction avec une base de données externe

## Interface de connexion

Interface de connexion simple permettant la saisie de l'identifiant (e-amil) et mot de passe de l'utilisateur.
Le mot de passe utilise le protocole de cryptage **SHA1**.

![alt tag](https://i.gyazo.com/237036d09241140568bb9d4a5da53156.png)

## Menu

Cette application dispose d'un menu après connexion, permettant à l'utilisateur de choisir l'action attendue.
L'utilisateur a le choix entre consulter les *stages de formations à venir* ou bien *consulter toutes les formations* disponibles.

## Formations à venir

L'utilisateur connecté peut consulter les stages de formations à venir par défaut d'une date allant du jour J au jour J+7.

![alt tag](https://i.gyazo.com/aa883b48ef15125857bc458b00d271d0.png)

Afin de permettre la recherche de stages de formations par date, l'utilisateur dispose d'une fonction de **recherche avancée**.
Celle-ci fonctionne au travers de différent élément clé tel qu'une fourchette de date ou autre, recupéré afin de composer une requete SQL permettant son affichage filtré à l'aide de la fonction suivante : 

```
dbConnect.listViewStagesFormations(query, listViewStagesFormations);
```
