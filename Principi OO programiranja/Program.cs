using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principi_OO_programiranja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kugla x = new Kugla(523, 314);
            Kvadar y = new Kvadar(60, 94);
            Kocka z = new Kocka(125, 150);

            Console.WriteLine(x.ToString());
            Console.WriteLine(y.ToString());
            Console.WriteLine(z.ToString());

            
            Console.WriteLine("Ima " + GeometrijskoTijelo.BrojacTijela + " geometriskih tijela");

            Console.ReadKey();

        }
    }
    class GeometrijskoTijelo
    {
        public double Volumen, Oplosje;
        public static int BrojacTijela = 0;

        public double Volumen1 { get => Volumen; set => Volumen = value; }
        public double Oplosje1 { get => Oplosje; set => Oplosje = value; }
        public static int BrojacTijela1 { get => BrojacTijela; set => BrojacTijela = value; }

        public override string ToString()
        {
            return "Volumen tijela je " + this.Volumen1 + ", a oplošje mu je " + this.Oplosje1;
        }

        public GeometrijskoTijelo()
        {

        }

        public GeometrijskoTijelo(double Volumen, double Oplosje)
        {
            this.Volumen = Volumen;
            this.Oplosje = Oplosje;
            BrojacTijela++;

        }
    }
    class Kugla : GeometrijskoTijelo
    {
        public override string ToString()
        {
            return "Volumen kugle je " + this.Volumen1 + ", a oplošje mu je " + this.Oplosje1;
        }
        public Kugla(double Volumen, double Oplosje) : base(Volumen, Oplosje)
        {

        }
    }
    class Kvadar : GeometrijskoTijelo
    {
        public override string ToString()
        {
            return "Volumen kvadra je " + this.Volumen1 + ", a oplošje mu je " + this.Oplosje1;
        }
        public Kvadar(double Volumen, double Oplosje) : base(Volumen, Oplosje)
        {

        }
    }
    class Kocka : Kvadar
    {
        public override string ToString()
        {
            return "Volumen kocke je " + this.Volumen1 + ", a oplošje mu je " + this.Oplosje1;
        }
        public Kocka(double Volumen, double Oplosje) : base(Volumen, Oplosje)
        {

        }
    }
}