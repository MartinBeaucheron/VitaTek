using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClasseForceDeVente;
namespace ClasseDirecteurRegional;

public class DirecteurRegional : ForceDeVente

{
    //D�finitions des variables :
    private String nomRole;

    //M�thodes getteurs :
    public getnomRole()
    {
        return nomRole;
    }

    //M�thodes setteurs :
    public setnomRole()
    {
        nomRole = this.nomRole;
    }

    //M�thodes toString :
    public string toString()
    {
        return "Le nom du r�le est :" + this.nomRole;
    }
}