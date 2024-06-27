namespace Project{
    class Program{
        public static Tasks tasks = new();
        private static string Option(){
            Console.WriteLine("\nWelcome admin! choose an option from below:");

            Console.WriteLine("\t[1] List of Student");
            Console.WriteLine("\t[2] Adding/Dropping Course");
            Console.WriteLine("\t[3] New Student Enrollment");
            Console.WriteLine("\t[4] Suspend any student");
            Console.WriteLine("\t[5] About Student");
            Console.WriteLine("\t[X] Exit\n");

            Console.Write("Option: ");
            string option = Console.ReadLine().ToUpper();
            return option;
        }
        private static void List(){ //op 1
            Console.WriteLine("\nList of all students:");
            var list = tasks.List();

            if(list.Count == 0){
                Console.WriteLine("\nNo student Available.");
                return;
            }
            foreach(var item in list){
                var deleted = item.IsDeleted();
                Console.WriteLine($"ID {item.ID}: - {item.GetName()} - {(deleted ?"Drop out":"Running")}");
            }
        }
        private static void Suspend(){  //op 4
            Console.Write("ID of the student to suspend: ");
            string sus = Console.ReadLine();
            if(int.TryParse(sus, out int id)){
                var student = tasks.GetId(id);
                if(student != null){
                    tasks.Delete(id);
                    Console.WriteLine("Student Suspended Successfully.\n");
                }else{
                Console.WriteLine("\nNo Student Exist with that ID!");
            }
            }
        }
        private static void About(){    //op 5
            Console.Write("Enter the student ID: ");
            if(int.TryParse(Console.ReadLine(), out int value)){
                var info = tasks.GetId(value);
                if(info != null){
                    Console.WriteLine(info);
                }else{
                    Console.WriteLine("\nNo Student Exist with that ID!");
            }
                }
        }
        private static void AddStudent(){   //op 3
            Console.WriteLine("Insert new Student's info");
            foreach(int item in Enum.GetValues(typeof(Programs))){
                Console.WriteLine($"{item} - {(Programs)item}");
            }Console.Write("Assign Program: ");

            if(int.TryParse(Console.ReadLine(),out int value) && Enum.IsDefined(typeof(Programs),value)){
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Gender: ");
                string gender = Console.ReadLine();
                Console.Write("Admission Year: ");
                string date = Console.ReadLine();

                if(int.TryParse(date,out int d)){
                    Methods m = new(tasks.NextId(),name,d,(Programs)value,gender);
                    tasks.Add(m);
                    System.Console.WriteLine("\nNew Student Added Successfully.\n");
                }else{
                    System.Console.WriteLine("Invalid Inputs!\n");
                }
            }else{
                System.Console.WriteLine("Invalid Program!\n");
            }
        }
        static bool Login(){
            Console.Write("\n\tUsername: ");
            string uname = Console.ReadLine();
            Console.Write("\tPasscode: ");
            string pass = Console.ReadLine();

            return(uname=="admin" && pass=="admin");
        }
        public static void Main(string[] args){
            if(Login()){
            string option = Option();

            while(option.ToUpper() != "X"){
                switch(option){
                    case "1": List(); break;
                    case "2": break;
                    case "3": AddStudent(); break;
                    case "4": Suspend(); break;
                    case "5": About(); break;
                    //case "X": exit = true; break;

                    default: Console.WriteLine("\nInvalid option selected!\n"); break;
                }option = Option();
            }Console.WriteLine("Program End...");
        }else{
            Console.WriteLine("Invalid username or pass!");
        }
        }
        }
}