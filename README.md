# FORMA
Application pour les employés de la maison des ligues permettant la gestion et l'affichage de l'espace de formation.
Cette application a pour titre de faciliter l'affichage et le listage des stages de formations sur une période de temps (planning).

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

``` c#
dbConnect.listViewStagesFormations(query, listViewStagesFormations);
```

Affichage du code de la fonction permettant le remplissage d'une ListView en fonction d'une requête SQL : 
``` c#
public void listViewStagesFormations(string query, ListView p_listView)
        {
            // allow reload without superposition
            p_listView.Items.Clear();
            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    ListViewItem item = new ListViewItem(dataReader["formations_intitule"].ToString());
                    item.SubItems.Add(dataReader["associations_nom"].ToString());
                    item.SubItems.Add(dataReader["salles_nom"].ToString());
                    item.SubItems.Add(dataReader["stages_formations_prix"].ToString());
                    item.SubItems.Add(dataReader["stages_formations_placeRestantes"].ToString());
                    item.SubItems.Add(dataReader["stages_formations_date"].ToString());

                    p_listView.Items.Add(item);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

            }
            else
            {
                MessageBox.Show("Une erreur est survenue");
            }
        }
```

