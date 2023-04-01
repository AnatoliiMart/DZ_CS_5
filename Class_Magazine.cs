
namespace DZ_CS_5
{
    internal class Magazine
    {
        private string name;
        private string phoneNumber;
        private int yearOfFoundation;
        private string description;
        private string EMail;
        private int workersAmount = 0;

        public string Name        { get => name;          set => name          = value; }
        public string PhoneNumber { get => phoneNumber;   set => phoneNumber   = value; }
        public string Email       { get => EMail;         set => EMail         = value; }
        public int WorkersAmount  { get => workersAmount; set => workersAmount = value; }

        public Magazine()
        {
            name             = "noName";
            phoneNumber      = "+000000000000";
            description      = "noDescription";
            yearOfFoundation = 0;
            EMail            = "noEmail";
            workersAmount    = 0;
        }

        public Magazine(string Name, string PhoneNumber, string Description, int YearOfFoundation, string Email, int WorkersAmount)
        {
            name             = Name;
            phoneNumber      = PhoneNumber;
            description      = Description;
            yearOfFoundation = YearOfFoundation;
            EMail            = Email;
            workersAmount    = WorkersAmount;
        }

        public void InputData()
        {
            Console.Write("Enter name of magazine:\t");
            name = Console.ReadLine();

            Console.Write("Enter the year of magazine foundation:\t");
            yearOfFoundation = int.Parse(Console.ReadLine());

            Console.Write("Enter description of magazine:\t");
            description = Console.ReadLine();

            Console.Write("Enter phone number of magazine:\t");
            phoneNumber = Console.ReadLine();

            Console.Write("Enter the Email of magazine:\t");
            EMail = Console.ReadLine();

            Console.Write("Enter amount of workers:\t");
            workersAmount = int.Parse(Console.ReadLine());

        }
        public static bool operator <  (Magazine obj1, Magazine obj2)  => obj1.WorkersAmount <  obj2.WorkersAmount;                                                                                               
        public static bool operator >  (Magazine obj1, Magazine obj2)  => obj1.WorkersAmount >  obj2.WorkersAmount;
        public static bool operator == (Magazine obj1, Magazine obj2)  => obj1.WorkersAmount == obj2.WorkersAmount;
        public static bool operator != (Magazine obj1, Magazine obj2)  => obj1.WorkersAmount != obj2.WorkersAmount;
        public static int  operator +  (Magazine obj, int x)           => obj.WorkersAmount  +  x;                                                                     
        public static int  operator -  (Magazine obj, int x)           => obj.WorkersAmount  -  x;

        public override bool Equals(object? obj)
        {
            if (obj is Magazine && obj!=null)
            {
                Magazine tmp  = (Magazine)obj;
                return this.workersAmount == tmp.workersAmount;
            }
            return false;
        }
        public override string ToString()
        {
            return "Name:\t\t\t" + name + "\nYear of foundation:\t" + yearOfFoundation +
                   "\nDescription:\t\t" + description + "\nPhone number:\t\t" + phoneNumber +
                   "\nEmail:\t\t\t" + EMail + "\nAmount of workers:\t" + workersAmount;
        }
    }
}
