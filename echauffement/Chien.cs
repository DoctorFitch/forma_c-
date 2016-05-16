using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace echauffement
{
    public class Chien
    {
        public string nomChien;
        public int age;
        public int pate;
        public bool queue;

        public Chien(string c_nomChat, int c_age, int c_pate, bool c_queue)
        {
            this.nomChien = c_nomChat;
            this.age = c_age;
            this.pate = c_pate;
            this.queue = c_queue;
        }
    }
}
