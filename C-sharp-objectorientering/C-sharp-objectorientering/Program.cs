
namespace C_sharp_objectorientering
{
    class Program
    {
        static void Main(string[] args)
        {
            var object1 = new Place("Stavern", "Larvik", "Vestfold");
            var object2 = new Place("Vetikke", "Trondheim", "TrønderLag");
            object1.ShowPlace();
            object2.ShowPlace();
        }
    }
}
