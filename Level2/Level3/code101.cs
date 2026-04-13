class Test
{
    static void Main()
    {
        Test obj = new Test();
        obj = null; // object becomes eligible for GC
    }
}