using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client("aitelhaj","hamza","casa","BK2332");
            Compte compte1 = new Compte(client1, new Mad(10));
            Client client2 = new Client("aitelhaj", "hamza", "casa", "BK2332");
            Compte compte2 = new Compte(client2, new Mad(100.0));
            compte1.virement(compte2, new Mad(50));
            compte1.affiche();
            compte2.affiche();
        }
    }
}
