using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Задан класс Building, который описывает здание. Класс содержит следующие элементы:

            адрес здания;
            длина здания;
            ширина здания;
            высота здания.
            В классе Building нужно реализовать следующие методы:

            конструктор с 4 параметрами;
            свойства get/set для доступа к полям класса;
            метод Print(), который выводит информацию о здании.
            Разработать класс MultiBuilding, который наследует возможности класса Building и добавляет поле этажность. В классе MultiBuilding реализовать следующие элементы:

            конструктор с 5 параметрами – реализует вызов конструктора базового класса;
            свойство get/set доступа к внутреннему полю класса;
            метод Print(), который обращается к методу Print() базового класса Building для вывода информации о всех полях класса.
            Класс MultiBuilding сделать таким, что не может быть унаследован.*/

            string address="ул. Родионова, д. 43";
            float length=50, width=15, height=54;
            int floors = 17;
            MultiBuilding building = new MultiBuilding(address, length, width, height, floors);
            building.Print();
            building.PrintYet();
            Console.ReadKey(); 
        }
    }
    class Building
    {
        string AddressBuilding { get; set; }
        float LengthBuilding { get; set; }
        float WidthBuilding { get; set; }
        float HeightBuilding { get; set; }
        public Building(string addressBuilding, float lengthBuilding, float widthBuilding, float heightBuilding)
        {
            AddressBuilding = addressBuilding;
            LengthBuilding = lengthBuilding;
            WidthBuilding = widthBuilding;
            HeightBuilding = heightBuilding;
        }
        public void Print()
        {
            Console.WriteLine("Здание {0}х{1} м., высотой {2} м. Находится по адресу: {3}",LengthBuilding,WidthBuilding,HeightBuilding,AddressBuilding);
        }
    }
    sealed class MultiBuilding:Building
    {
        int Floors { get; set; }
        public MultiBuilding(string addressBuilding, float lengthBuilding, float widthBuilding, float heightBuilding, int floors)
            :base(addressBuilding,lengthBuilding,widthBuilding,heightBuilding)
        {
            Floors = floors;
        }
        public void PrintYet()
        {
            Console.WriteLine("Число этажей {0}",Floors);
        }

    }
}
