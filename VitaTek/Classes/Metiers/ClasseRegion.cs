using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasseVisiteur
{
    public class Region
    {
        //D�finitions des variables :
        private String nomRegion;

        //M�thodes getteurs :
        public getNomRegion()
        {
            return this.nomRegion;
        }

        //M�thodes setteurs :
        public void setNomRegion(string nouveauNom)
        {
            this.nomRegion = nouveauNom;
        }

        public void ToString()
        {
            Console.WriteLine("Le nom du R�le est : " + this.nomRegion);
        }
    }