
/*ArrayMin*/


internal class Program
{
    private static void Main(string[] args)
    {

        Console.Write("Sheno madhesine e Array: ");
        int arrLength = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[arrLength];

        for (int i = 0; i < arrLength; i++)
        {
            Console.Write($"Sheno numrin ne index {i}: ");
            int num = Convert.ToInt32(Console.ReadLine());
            arr[i] = num;
        }


        var arrayMin = new ArrayMin(arr);

        int minValue = 0;

        try
        {
            minValue = arrayMin.Min();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine($"Numri me i vogel eshte: {minValue}");





        /*LlogaritPagen*/

        Zhvillues zhvillues = new(321, "Test", "puntor", 63000);

        Menaxher menaxher = new(111, "Eriona", "menaxher", 368000);

        Admin admin = new(123, "Genc", "admin", 720000);

        Console.WriteLine($"ID: {zhvillues.Id}, Emri: {zhvillues.Emri}, Pozita: {zhvillues.Pozita}, Rroga: {zhvillues.Rroga}, Bonusi: {zhvillues.CalculateBonus(zhvillues.Rroga)}");
        Console.WriteLine($"ID: {menaxher.Id}, Emri: {menaxher.Emri}, Pozita: {menaxher.Pozita}, Rroga: {menaxher.Rroga}, Bonusi: {menaxher.CalculateBonus(menaxher.Rroga)}");
        Console.WriteLine($"ID: {admin.Id}, Emri: {admin.Emri}, Pozita: {admin.Pozita}, Rroga: {admin.Rroga}, Bonusi: {admin.CalculateBonus(admin.Rroga)}");
    }

    class ArrayMin
    {
        public int[] Array;

        public ArrayMin(int[] array)
        {
            this.Array = array;
        }



        public int Min()
        {
            if (Array is null)
            {
                throw new Exception("Array is empty");
            }

            var minValue = Array[0];

            for (var i = 1; i < Array.Length; i++)
            {
                if (minValue > Array[i])
                {
                    minValue = Array[i];
                }
            }

            return minValue;

        }
    }
    class Employee
    {
        public int Id;
        public string Emri;
        public string Pozita;

        public double Rroga;

        public Employee(int id, string emri, string pozita, double rroga)
        {
            Id = id;
            Emri = emri;
            Pozita = pozita;
            Rroga = rroga;
        }

        public virtual double CalculateBonus(double rroga)
        {                                                            //override/mujm me ndryshu metoden nsubklasa tjera//
            return 0;
        }

    }
    class Menaxher : Employee
    {
        public Menaxher(int id, string emri, string pozita, double rroga) : base(id, emri, pozita, rroga)
        {

        }

        public override double CalculateBonus(double rroga)
        {
            double bonus = rroga * 0.25;

            if (bonus < 50000)
            {
                return 50000;
            }

            return bonus;
        }
    }
    class Zhvillues : Employee
    {
        public Zhvillues(int id, string emri, string pozita, double rroga) : base(id, emri, pozita, rroga)
        {

        }

        public override double CalculateBonus(double rroga)
        {
            double bonus = rroga * 0.2;

            if (bonus < 50000)
            {
                return 50000;
            }

            return bonus;

        }
    }
    class Admin : Employee
    {
        public Admin(int id, string emri, string pozita, double rroga) : base(id, emri, pozita, rroga)
        {

        }

        public override double CalculateBonus(double rroga)
        {
            return 50000;
        }
    }
}