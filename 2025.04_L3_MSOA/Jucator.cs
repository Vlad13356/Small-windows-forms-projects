using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2025._04_L3_MSOA
{
    internal class Jucator
    {
        string nume;
        string cnp;
        Post post;
        public Jucator(string cnp, string nume, Post post)
        {
            this.nume = nume;   
            this.cnp = cnp;
            this.post = post;
        }

        public string CNP
        {
            get { return cnp; }
            set { cnp = value; }
        }

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }

        public Post Post
        {
            get { return post; }
            set { post = value; }
        }
    }

    public enum Post
    {
        Portar,
        Fundas,
        Mijlocas,
        Atacant
    }
}
