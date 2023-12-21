using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasseVisiteur
{
    public class Region
    {
        //Définitions des variables :
        private String nomRegion;

        //Méthodes getteurs :
        public getNomRegion()
        {
            return this.nomRegion;
        }

        //Méthodes setteurs :
        public void setNomRegion(string nouveauNom)
        {
            this.nomRegion = nouveauNom;
        }

        public void ToString()
        {
            Console.WriteLine("Le nom du Rôle est : " + this.nomRegion);
        }
    }