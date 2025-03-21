using Engine.Render;

namespace C_2
{
    internal class Program// internal - доступно внутри проекта, но недоступно в других, практически не используется
        //protected - то же что и с++

    {
        static void Main(string[] args)
        {
            //People people = new People("Игорь","Кукиев","Константинович");
            //Console.WriteLine(people.FIO());

            //Cat cat = new Cat("Боня",3.8,true);
            ////Console.WriteLine(cat.GetInfo());
            ////cat.Meow();
            ////cat.Color = "Жёлтый";
            ////Console.WriteLine(cat.Color);

            //cat.Name = null;
            //Console.WriteLine(cat.Name);

            //int a = 1;

            //ClassA classA = new ClassA();
            //classA.Add(ref a);//ref - ссылка
            //Console.WriteLine(a);

            //Engine.Physics.Vector3D vector3D = new Engine.Physics.Vector3D();
            //Vector3D secVector3D = new Vector3D();


            Laptop laptop = new Laptop("Apple", 1.1,8,256);
            Console.WriteLine(laptop.Info());

            Car car = new Car(5634809,2026,"Красный","Opel", "vector");
            Console.WriteLine(car.Info);
            car.Compraision(623847);
            

        }
    }
}


///класс - ссылочный тип данных
///структуры - значимый
/// 
/// [Модификатор доступа], struct[Название]{} создавать в отдельнх файлах
/// наследуются от интерфейсов
/// структуры нужны для малого количества данных
/// 
/// 