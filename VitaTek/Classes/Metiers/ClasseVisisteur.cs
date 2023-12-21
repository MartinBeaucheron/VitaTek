using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasseVisiteur
{
	public class Visiteur
	{
<<<<<<< HEAD
		//attributs
		private String nomrôle;
	
		//methodes
=======
        //Définitions des variables :
        private String nomRole;
>>>>>>> 5b843e7458b168addad61c10c8b95037ea2a8fad

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