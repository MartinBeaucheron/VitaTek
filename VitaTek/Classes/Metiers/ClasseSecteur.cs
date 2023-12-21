using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasseSecteur
{
    public class Secteur
    {
        //attributs
        private String nomSecteur;
        //methodes

        //constructeurs
        public getNomSecteur()
        {
            return this.nomSecteur;
        }

        public void setNomSecteur(string nouveauNom)
        {
            this.setNomSecteur = nouveauNom;
        }

        public void ToString()
        {
            Console.WriteLine("Le nom du Rôle est : " + this.nomSecteur);
        }
    }
}