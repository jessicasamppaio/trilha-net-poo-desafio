using DesafioPOO.Models;

    class Program
    {
        static void Main()
        {
           
            Nokia nokia = new Nokia("1111", "nokia 3", "2222", 64);
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("Instagram");


            Iphone iphone = new Iphone("2222", "iPhone 11", "3333", 128);
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("TikTok");
        }
    }
