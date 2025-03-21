using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_2
{
    public class Laptop
    {
        private string _model;
        private int  _volumeOperative, _valumeDisk;
        private double _frequency;

        public Laptop() { }
        public Laptop(string model, double frequency, int volumeOperative, int valumeDisk)
        {
            _model = model;
            _frequency = frequency;
            _volumeOperative = volumeOperative;
            _valumeDisk = valumeDisk;

        }    

        public string Info()
        {
            return $"Ноутбук: {_model}, Объем жесткого диска: {_valumeDisk}ГБ, Объем оперативной памяти: {_volumeOperative}ГБ, Тактовая частота: {_frequency}ГГц";
        }


    }
}
