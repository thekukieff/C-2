using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_2
{
    public struct Car
    {
        public int vinNomber, year;
        public string color, marka, model;

        public string Info
        {
            get { return $"Vin - номер:{vinNomber}, Марка {marka}, Цвет {color}, год выпуска {year}, Модель {model} "; }
        }


        public Car(int vinNomber, int year, string color, string marka, string model)
        {
            this.vinNomber = vinNomber;
            this.year = year;   
            this.color = color;
            this.marka = marka;
            this.model = model;

        }

        public void Compraision(int vinNomber)
        {
            var compr =  vinNomber == this.vinNomber ? "равен" : "не равен";
            Console.WriteLine($"VIN-номер {compr}");
            

        }


    }
}
