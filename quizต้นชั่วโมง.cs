using System;
using System.Collections.Generic;

namespace ConsoleApp86
{
    class Program
    {
        static void Main(string[] args)
        {
            Flower flower = new Flower(1,"PlantName","Plantdescription",2,"Height","Cirumference");
            Rose RoSe = new Rose(1, "ดอกกุหลายสีขาว", "สวยงามมาก", int.Parse(Console.ReadLine()), "10.5","6") ;
            Rose RoSE = new Rose(1, "ดอกกุหลายสีแดง", "สวยงามมาก", 2, "10.5", "6");
            Sunflower sunFloWer = new Sunflower(1, "ดอกทานตะวันเล็ก", "สวยงาม", int.Parse(Console.ReadLine()), "2.0", "2.0");
            Sunflower sunFloWeR = new Sunflower(1, "ดอกทานตะวันใหญ่", "สวยงาม", 2, "2.0", "2.0");
            flower.AddList(RoSe);
            flower.addList(sunFloWer);
            flower.GetList();
            flower.getList();
            Console.ReadLine();

            //จอสรุป
            Console.Clear();
            Console.WriteLine(RoSe.Plantname);
            Console.WriteLine(RoSE.Plantname);
            Console.WriteLine(sunFloWer.Plantname);
            Console.WriteLine(sunFloWeR.Plantname);

        }
    }
}
class Rose : Flower
{
    
    public Rose(int valueId,string valuePlantName,string valuePlantDescription,int valueAmount,string valueHeight,string valueCircumFerence) : base(valueId, valuePlantName, valuePlantDescription, valueAmount, valueHeight, valueCircumFerence)
    {
        ID = valueId;
        Plantname = valuePlantName;
        Plantdescription = valuePlantDescription;
        Amount = valueAmount;
        Height = valueHeight;
        Circumference = valueCircumFerence;
    }


}
class Sunflower : Flower
{

    public Sunflower(int valueId, string valuePlantName, string valuePlantDescription, int valueAmount, string valueHeight, string valueCircumFerence) : base (valueId,valuePlantName,valuePlantDescription,valueAmount,valueHeight,valueCircumFerence)
    {
        ID = valueId;
        Plantname = valuePlantName;
        Plantdescription = valuePlantDescription;
        Amount = valueAmount;
        Height = valueHeight;
        Circumference = valueCircumFerence;
    }
}
class Flower
{
    private List<Rose> rose;
    private List<Sunflower> sunflower;
    public int ID;
    public string Plantname;
    public string Plantdescription;
    public int Amount;
    public string Height;
    public string Circumference;

    public Flower(int valueId, string valuePlantName, string valuePlantDescription, int valueAmount, string valueHeight, string valueCircumFerence)
    {
        rose = new List<Rose>();
        ID = valueId;
        Plantname = valuePlantName;
        Plantdescription = valuePlantDescription;
        Amount = valueAmount;
        Height = valueHeight;
        Circumference = valueCircumFerence;

        sunflower = new List<Sunflower>();
        ID = valueId;
        Plantname = valuePlantName;
        Plantdescription = valuePlantDescription;
        Amount = valueAmount;
        Height = valueHeight;
        Circumference = valueCircumFerence;
    }

    public void AddList(Rose roSe)
    {
        rose.Add(roSe);
    }
    public void GetList()
    {
        foreach (Rose roSe in rose)
        {
            Console.WriteLine(roSe.ID);
            Console.WriteLine(roSe.Plantname);
            Console.WriteLine(roSe.Plantdescription);
            Console.WriteLine(roSe.Amount);
            Console.WriteLine(roSe.Height);
            Console.WriteLine(roSe.Circumference);
        }
    }
    public void addList(Sunflower sunFlower)
    {
        sunflower.Add(sunFlower);
    }
    public void getList()
    {
        foreach (Sunflower sunFlower in sunflower)
        {
            Console.WriteLine(sunFlower.ID);
            Console.WriteLine(sunFlower.Plantname);
            Console.WriteLine(sunFlower.Plantdescription);
            Console.WriteLine(sunFlower.Amount);
            Console.WriteLine(sunFlower.Height);
            Console.WriteLine(sunFlower.Circumference);
        }
    }
}
     

    

    
