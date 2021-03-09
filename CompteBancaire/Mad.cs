using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Mad
    {
        private string type;
        private double solde;

        public Mad(double solde)
        {
            this.solde = solde;
            this.type = "MAD";
        }
        public void ConsulteSolde()
        {
            Console.WriteLine("Solde: "+this.solde + this.type);
        }
        public static  Mad operator+( Mad solde1 ,  Mad solde2)
        {
            Mad res = new Mad(solde1.solde + solde2.solde);
            return res;
        }
        public static Mad operator -(Mad solde1, Mad solde2)
        {

            Mad res = new Mad(solde1.solde-solde2.solde);
            return res;
        }
        public static bool operator<(Mad solde1, Mad solde2)
        {
            if (solde1.solde < solde2.solde)
                return true;
            else
                return false;
           
        }
        public static bool operator>(Mad solde1, Mad solde2)
        {
            if (solde1.solde > solde2.solde)
                return true;
            else
                return false;


        }

    }
   
}
