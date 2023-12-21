using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasseVisiteur
{
	public class Visiteur
	{
        //Définitions des variables :
        private String nomRole;

        //Méthodes getteurs :
        public getNomRôle()
		{
			return this.nomRole;
		}

        //Méthodes setteurs :
        public void setNomRole(string nouveauNom)
		{
			this.nomRole = nouveauNom;
		}

		public void ToString()
		{
			Console.WriteLine("Le nom du Rôle est : " + this.nomRole);
		}
	}
}