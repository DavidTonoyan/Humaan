using System;

namespace End
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Husband Armen = new Husband();
            Wife Mane = new Wife();
            Child Vache = new Child();
            Armen.Cry();
            Mane.Cry();
            Vache.Cry();
            Armen.Fight();
            Vache.Fight();
            Mane.Fight();
        }
    }
    class Human
    {
         public virtual void Cry()
        {

        }

        public virtual void Fight()
        {

        }
    }
    class Husband : Human
    {
         public override void Cry()
        {
            Console.WriteLine("Hayry tuny nstac er)))");
        }
        public override void Fight()
        {
            Console.WriteLine("Hayriky asec vor qo texy chi!!!");
        }
    }
    class Wife : Human
    {
         public override void Cry()
        {
            Console.WriteLine("Mayry asec amusnun,vor petq e gnan cnundi!");
        }
        public override void Fight()
        {
            Console.WriteLine("Kiny asec vor amusiny mtaci erexayin tanen te voch?");
        }
    }
    class Child : Human
    {
      public override void Cry()
        {
            Console.WriteLine("Erexan lsec uraxacav!!!");
        }
        public override void Fight()
        {
            Console.WriteLine("Erexen lacelov gnac(((");
        }
    }
}