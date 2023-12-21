using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasseSecteur
{
    public class Secteur
    {
        //Définitions des variables :
        private String nomSecteur;

        //Méthodes getteurs :
        public getNomSecteur()
        {
            return this.nomSecteur;
        }

        //Méthodes setteurs :
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