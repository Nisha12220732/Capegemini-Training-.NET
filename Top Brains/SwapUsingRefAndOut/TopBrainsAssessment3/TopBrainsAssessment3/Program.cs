using TopBrainsAssessment3;

class Program
{
    public static void Main(string[] args)
    {
        Vehicle v1 = new TwoWheeler();
        Vehicle v2 = new HVM(6);
        Vehicle v3 = new HVM(8);

        v1.Drive();
        v2.Drive();
        v3.Drive();

    }
}