
namespace DZ_CS_5
{
    internal class Shop
    {
        private string name;
        private string phoneNumber;
        private string EMail;
        private string description;
        private string adress;
        private int area;

        public string Name        { get => name;        set => name        = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email       { get => EMail;       set => EMail       = value; }
        public int Area           { get => area;        set => area        = value; }

        public Shop()
        {
            name = "noName";
            phoneNumber = "+000000000000";
            description = "noDescription";
            adress = "noAdress";
            EMail = "noEmail";
            area = 0;
        }

        public Shop(string Name, string PhoneNumber, string Description, string Adress, string Email, int Area)
        {
            name        = Name;
            phoneNumber = PhoneNumber;
            description = Description;
            adress      = Adress;
            EMail       = Email;
            area        = Area;
            
        }

        public void InputData()
        {
            Console.Write("Enter name of shop:\t");
            name = Console.ReadLine();

            Console.Write("Enter the adress of shop:\t");
            adress = Console.ReadLine();

            Console.Write("Enter description of shop:\t");
            description = Console.ReadLine();

            Console.Write("Enter phone number of shop:\t");
            phoneNumber = Console.ReadLine();

            Console.Write("Enter the Email of shop:\t");
            EMail = Console.ReadLine();

            Console.Write("Enter the area of shop:\t");
            area = int.Parse(Console.ReadLine());
        }
        public static bool operator < (Shop obj1, Shop obj2) => obj1.Area <  obj2.Area;
        public static bool operator > (Shop obj1, Shop obj2) => obj1.Area >  obj2.Area;
        public static bool operator ==(Shop obj1, Shop obj2) => obj1.Area == obj2.Area;
        public static bool operator !=(Shop obj1, Shop obj2) => obj1.Area != obj2.Area;
        public static int operator  + (Shop obj, int x)      => obj.Area  +  x;
        public static int operator  - (Shop obj, int x)      => obj.Area  -  x;
        public override bool Equals(object? obj)
        {
            if (obj is Shop && obj != null)
            {
                Shop tmp = (Shop)obj;
                return this.area == tmp.area;
            }
            return false;
        }
        public override string ToString()
        {
            return "Name:\t\t" + name + "\nAdress:\t" + adress +
                   "\nDescription:\t" + description + "\nPhone number:\t" + phoneNumber +
                   "\nEmail:\t\t" + EMail + "\nArea:\t" + area;
        }
    }
}
