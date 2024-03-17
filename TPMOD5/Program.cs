class program
{
    class HaloGeneric
    {
        public static void SapaUser<X>(X Input)
        {
            Console.WriteLine("Halo User " + Input);
        }
    }


    class DataGeneric<Generic>
    {
        private Generic data;

        public DataGeneric(Generic input)
        {
            this.data = input;
        }
        public void Printdata()
        {
            Console.WriteLine("Data yang tersimpan adalah " + data);
        }

    }
    private static void Main(string[] args)
    {
        HaloGeneric.SapaUser("QQ");
        DataGeneric<string> N = new DataGeneric<string>("1302223028");
        N.Printdata();
    }
}