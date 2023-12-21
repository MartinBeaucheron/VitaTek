using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClasseVisiteur;

namespace ClassePasserelle
{
    public class passerelle
    {
        string apiUrl = "https://s5-5127.nuage-peda.fr/VitaTek/api.php?id=1";
        

        using (HttpClient client = new HttpClient())
        {
            
            HttpResponseMessage reponseAPI = await client.GetAsync(apiUrl);

            if (reponseAPI.IsSuccessStatusCode)
            {
                string responseData = await response.Content.ReadAsStringAsync();
                Console.WriteLine("Réponse de l'API PHP : " + responseData);
            }
            else
            {
                Console.WriteLine("Erreur lors de la requête : " + reponseAPI.StatusCode);
            }

List<Visiteur> visiteurs = new List<Visiteur>();
        //attributs

        //methodes

        //constructeurs

        //methodes accès varibles privées
    }
}