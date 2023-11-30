using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClasseForceDeVente;

namespace ClasseDirecteurRegional
{
	public class DirecteurRegional : ForceDeVente

    {
		//attributs
		private String nomDirecteur;

        //methodes

        private String nomDirecteur;

        //constructeurs
        public getNomDirecteur()
        {
            return this.nomDirecteur;
        }

        public void setNomDirecteur(string nouveauNom)
        {
            this.setNomDirecteur = nouveauNom;
        }

        public void ToString()
        {
            Console.WriteLine("Le nom du Rôle est : " + this.nomDirecteur);
        }
    }
}