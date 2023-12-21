using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClasseForceDeVente;
namespace ClasseDirecteurRegional;

public class DirecteurRegional : ForceDeVente

{
    //Définitions des variables :
    private String nomRole;

    //Méthodes getteurs :
    public getnomRole()
    {
        return nomRole;
    }

    //Méthodes setteurs :
    public setnomRole()
    {
        nomRole = this.nomRole;
    }

    //Méthodes toString :
    public string toString()
    {
        return "Le nom du rôle est :" + this.nomRole;
    }
}