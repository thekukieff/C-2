using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_2
{
    public struct People
    {
        //сначала поля, потом конструкторы, потом методы
        //ВСЕГДА УКАЗЫВАЕМ МОДИФИКАТОР ДОСТУПА
        public string name;
        public string surname;
        public string patronymic;//отчество 


        public People(string name, string surname, string patronymic)
        {
            this.name = name;
            this.surname = surname;
            this.patronymic = patronymic;

        }
        public string FIO()
        {
            return $"Фамилия: {surname}, Имя: {name}, Отчество: {patronymic}";
        }

       

    }
}
