using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1_W1_D1
{
    internal class Veicolo
    {
        private string _type;
        public string Type {
            get { return _type; }
            set { _type = value; }
        }

        private double _wheel;
        public double Wheel
        {
            get { return _wheel; }
            set { _wheel = value; }
        }

        private double _price;
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public void SchedaTecnica()
        {
            Console.WriteLine($"Veicolo tipo: {_type}, ruote:{_wheel}, prezzo: {_price}$");
        }

        public void Comprabile()
        {
            if (_price > 30000)
            {
             Console.WriteLine("Non puoi permetterti questo veicolo");
            }
            else
            {
              Console.WriteLine("Puoi permetterti di comprare questo veicolo");
            }
        }
    }
}
