class program
{
    class HaloGeneric
    {
        public static void SapaUser<X>(X Input)
        {
            Console.WriteLine("Halo User " + Input);
        }
    }
    
    private static void Main(string[] args)
    {
        HaloGeneric.SapaUser("QQ");
    }
}