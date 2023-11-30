using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasseVisiteur
{
	public class Visiteur
	{
		//attributs
		private String nomRole;

		//constructeurs
		public getNomRôle()
		{
			return this.nomRole;
		}

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