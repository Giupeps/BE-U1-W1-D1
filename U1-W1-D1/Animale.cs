using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace U1_W1_D1
{
    internal class Animale
    {

		private string _race;

		public string Race
		{
			get { return _race; }
			set { _race = value; }
		}


		private string _place;

		public string Place
		{
			get { return _place; }
			set { _place = value; }
		}

		public void Caratteristiche()
		{
			Console.WriteLine($"Animale: {_race},  luogo dove trovarlo: {_place}");
		}
	}
}
