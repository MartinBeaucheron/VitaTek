using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasseVisiteur
{
	public class Visiteur
	{
        //D�finitions des variables :
        private String nomRole;

        //M�thodes getteurs :
        public getNomR�le()
		{
			return this.nomRole;
		}

        //M�thodes setteurs :
        public void setNomRole(string nouveauNom)
		{
			this.nomRole = nouveauNom;
		}

		public void ToString()
		{
			Console.WriteLine("Le nom du R�le est : " + this.nomRole);
		}
	}
}