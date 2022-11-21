using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1_W1_D1
{
    internal class Program
    {
        static void Main(string[] args)
        {

        Atleta a1= new Atleta();
            a1.Name = "Usain";
            a1.Surname = "Bolt";
            a1.Age = 30;
            a1.Height = 200;
            a1.Weight= 100;
            a1.Anagrafica();
            Console.WriteLine($"All'atleta rimangono {a1.anniDalRitiro(40)} anni di carriera");


        Animale tigre = new Animale();
            tigre.Race = "Tigre Siberiana";
            tigre.Place = "Siberia";
            tigre.Caratteristiche();

        Animale leone = new Animale();
            leone.Race= "Leone";
            leone.Place = "Savana";
            leone.Caratteristiche();

        Veicolo moto = new Veicolo();
            moto.Type = "Moto da cross";
            moto.Wheel = 2;
            moto.Price = 15000;
            moto.SchedaTecnica();
            moto.Comprabile();

        Veicolo automobile = new Veicolo();
            automobile.Type = "Macchina";
            automobile.Wheel = 4;
            automobile.Price= 45000;
            automobile.SchedaTecnica();
            automobile.Comprabile();

        }
    }
}
