using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_2
{
    //все конструкторы публичные
    public class Cat
    {

        private string _name;//с нижним подчеркиванием в начале
        private double _weight;
        private bool _sex;

        public string Name {  
            get { return _name; } //геттер
        
            set { 
               if( value != null)
                {
                    _name = value;
                }
                else
                {
                    _name = "Кот";
                }
            }//сеттер
        
        }

        public string Color { get; set; }//геттер и сеттер

        //если не написать про конструктор по умолчанию, то его не будет

        public Cat() { }
        public Cat(string name) : this(name, 0, true)
        {

        }
        public Cat(string name, double weight):this(name,weight,false)
        {

        }

        public Cat(string name, double weight, bool sex) {

            _name = name;
            _weight = weight;
            _sex = sex;
             
        
        }
        public void Meow()
        {
            Console.WriteLine("Мяу");
        }

        public string GetInfo() {
            var sex = _sex ? "Мальчик" : "Девочка";//сначала всегда true

            return $"Кличка кота: {_name}, Вес:{_weight}, " +
                $"Пол: {sex}";
        
        
        
        }


    }
}
