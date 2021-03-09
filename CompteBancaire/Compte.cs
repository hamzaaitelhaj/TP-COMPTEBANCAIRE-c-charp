using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp1
{

    public class Compte
    {
        private static uint cmp = 0;
        private uint Num_C;
        private Client Cl_C;
        private Mad Solde_C;



        public Compte()
        {
            this.Num_C = 0;
            this.Cl_C = new Client();
            this.Solde_C = new Mad(0);

        }
        public Compte(Client cl, Mad solde)
        {
            this.Num_C = ++cmp;
            this.Cl_C = new Client(cl);
            this.Solde_C = solde;

        }
        public void affiche()
        {
            Console.WriteLine("NUM COMPTE: " + this.Num_C);
            this.Cl_C.afficheclient();
            this.Solde_C.ConsulteSolde();

        }
        public void Credite(Mad solde_Credite)
        {
            this.Solde_C += solde_Credite;
        }
        public bool Debiter(Mad solde_Debiter)
        {
            if (solde_Debiter > this.Solde_C)
            {
                return false;
            }

            else
                this.Solde_C -= solde_Debiter;
                return true;

        }
        public void virement(Compte compte_Debiter, Mad solde)
        {
            if (this.Debiter(solde))
            {
                Console.WriteLine("l'operation a ete effectue avec succes.");
                compte_Debiter.Credite(solde);
            }
            else
                Console.WriteLine("l'operation n'a pas effectue.");
        }
    }
}
