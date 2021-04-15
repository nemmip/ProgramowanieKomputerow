using System;

namespace cw06
{
    class Kot:Zwierz
    {
        public string JakPije { get; set; }
        //public void miaucz()
        public override void glos()
        {
            // w elementach pochodnych z klasy bazowej można uzywać elementów tej klasy bazowej
            Console.WriteLine($"Miauczy {Imie}: Miau, miau! Chciał {JakPije} mleczka.");
        }

        public void rysuj()
        {
            Console.WriteLine(",_     _\n" +
                              " |\\_,-~/\n" +
                              " / _  _ |    ,--.\n" +
                              "(  @  @ )   / ,-'\n" +
                              " \\  _T_/-._( (\n" +
                              " /         `. \\\n" +
                              "|         _  \\ |\n" +
                              " \\ \\ ,  /      |\n" +
                              "  || |-_\\__   /\n" +
                              " ((_/`(____,-'");
        }
    }
}