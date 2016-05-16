using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace echauffement
{
    public class Chat
    {
        public string nomChat;
        public int age;
        public int pate;
        public bool queue;
        private string c_nomChat;

        public Chat(string c_nomChat, int c_age, int c_pate, bool c_queue)
        {
            this.nomChat = c_nomChat;
            this.age = c_age;
            this.pate = c_pate;
            this.queue = c_queue;
        }

        public Chat(string c_nomChat)
        {
            this.c_nomChat = c_nomChat;
        }

        public void changerDeNom(string p_nom)
        {
            nomChat = p_nom;
        }
    }
}
