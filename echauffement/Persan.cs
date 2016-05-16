using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace echauffement
{
    public class Persan : Chat
    {
        public Persan(string c_nomChat)
            : base(c_nomChat)
            
        {
            this.nomChat = c_nomChat;
            this.pate = 4;
            this.queue = false;
        }
  
    }
}
