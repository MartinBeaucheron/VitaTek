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
		public getNomR�le()
		{
			return this.nomRole;
		}

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