using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasseVisiteur
{
    public class Region
    {
        //attributs
        private String nomRegion;
        //methodes

        //constructeurs

        public getNomRegion()
        {
            return this.nomRegion;
        }

        public void setNomRegion(string nouveauNom)
        {
            this.nomRegion = nouveauNom;
        }

        public void ToString()
        {
            Console.WriteLine("Le nom du Rôle est : " + this.nomRegion);
        }
    }