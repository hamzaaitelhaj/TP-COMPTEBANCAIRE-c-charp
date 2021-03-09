using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Client
    {
        private string Nom_Cl;
        private string Prenom_Cl;
        private string Adresse_Cl;
        private string CIN_Cl;
        public Client()
        {
            this.Nom_Cl = "";
            this.Prenom_Cl = "";
            this.Adresse_Cl = "";
            this.CIN_Cl = "";

        }
        public Client(string nom , string prenom, string adresse , string CIN)
        {
            this.Nom_Cl = nom;
            this.Prenom_Cl = prenom;
            this.Adresse_Cl = adresse;
            this.CIN_Cl = CIN;
        }
       public Client(Client nv)
        {
            this.Nom_Cl = nv.Nom_Cl;// probleme de string.copy
            this.Prenom_Cl = nv.Prenom_Cl;
            this.Adresse_Cl = nv.Adresse_Cl;
            this.CIN_Cl = nv.CIN_Cl;
        }
        
        public  void afficheclient()
        {
            Console.WriteLine("CIN: "+this.CIN_Cl);
            Console.WriteLine("NOM: "+this.Nom_Cl);
            Console.WriteLine("PRENOM: "+this.Prenom_Cl);
            Console.WriteLine("ADRESSE: "+this.Adresse_Cl);
        }
    }
}
