using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace echauffement
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Liste de chat */
            List<Chat> mesChats = new List<Chat>();
            ArrayList mesAnimaux = new ArrayList();

            /* Titre en bleu */
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("APPLICATION CHAT\n\n");
            Console.ResetColor();

            /* Création des objets chat */
            Chat vodka = new Chat("Vodka", 12, 4, true);
            Chat persia = new Chat("Persia", 12, 4, true);
            Chat prince = new Chat("Prince", 12, 4, true);
            Chat eimer = new Chat("Eimer", 12, 4, true);
            Chat racle = new Chat("Racle", 12, 4, true);
            /* Création des objets chien */
            Chien lucy = new Chien("Lucy", 12, 4, true);
            Chien lucy2 = new Chien("Lucy2", 12, 4, true);
            Chien lucy3 = new Chien("Lucy3", 12, 4, true);
            Chien lucy4 = new Chien("Lucy4", 12, 4, true);


            Persan persan1 = new Persan("rodolph");
            Chat persan2 = new Persan("lol");

            Console.WriteLine(persan1.nomChat + " \n" + persan2.queue);

            mesChats.Add(vodka);
            mesChats.Add(persia);
            mesChats.Add(prince);
            mesChats.Add(eimer);
            mesChats.Add(racle);

            mesAnimaux.Add(vodka);
            mesAnimaux.Add(lucy);


            /* Affichage de ma liste de chat */
            foreach (Chat unChat in mesChats)
            {
                Console.WriteLine(unChat.nomChat);
            }

            /* Changement du nom du chat */
            persia.changerDeNom("Persian");

            Console.WriteLine(persia.nomChat);

            foreach (Object unAnimal in mesAnimaux)
            {
                if (unAnimal is Chien)
                {
                    Console.WriteLine("C'est un chien");
                    Console.WriteLine(unAnimal);
                }

                else
                {
                    Console.WriteLine("C'est un chat");
                    Console.WriteLine(unAnimal);
                }


            }
            Console.ReadKey();
        }
    }
}
