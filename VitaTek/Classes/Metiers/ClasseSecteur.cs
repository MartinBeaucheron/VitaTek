using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasseSecteur
{
    public class Secteur
    {
        //D�finitions des variables :
        private String nomSecteur;

        //M�thodes getteurs :
        public getNomSecteur()
        {
            return this.nomSecteur;
        }

        //M�thodes setteurs :
        public void setNomSecteur(string nouveauNom)
        {
            this.setNomSecteur = nouveauNom;
        }

        public void ToString()
        {
            Console.WriteLine("Le nom du R�le est : " + this.nomSecteur);
        }
    }
}