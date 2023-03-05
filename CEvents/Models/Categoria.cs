using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CEvents.Models
{
    public class Categoria
    {
        public bool[] categ = new bool[9];
        public Categoria()
        {
            for (int i = 0; i < 9; categ[i] = false, i++) ;
        }

        public bool Children
        {
            get => categ[0]; set => categ[0] = value;
        }

        public bool Sport
        {
            get => categ[1]; set => categ[1] = value;
        }

        public bool Cultur
        {
            get => categ[2]; set => categ[2] = value;
        }

        public bool Excursion
        {
            get => categ[3]; set => categ[3] = value;
        }

        public bool Lifestyle
        {
            get => categ[4]; set => categ[4] = value;
        }

        public bool Party
        {
            get => categ[5]; set => categ[5] = value;
        }

        public bool Education
        {
            get => categ[6];
            set => categ[6] = value;
        }

        public bool Online
        {
            get => categ[7];
            set => categ[7] = value;
        }

        public bool Show
        {
            get => categ[8];
            set => categ[8] = value;
        }
    }
}