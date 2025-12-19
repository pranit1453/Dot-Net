namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Db choice. 1. MySql Server, 2.Sql Server");
            int dbChoice=Convert.ToInt32(Console.ReadLine());

            DataBaseFactory factory = new DataBaseFactory();
            Database someDatabaseObject = factory.GetSomeDatabase(dbChoice);
            Console.WriteLine("Enter db operation choice : 1. Insert, 2. Update");
            int opChoice = Convert.ToInt32(Console.ReadLine());
            switch (opChoice)
            {
                case 1:
                    someDatabaseObject.insert();
                    break;
                    case 2:
                    someDatabaseObject.update();
                    break;
                default:
                    break;
            }
        }
    }
}
