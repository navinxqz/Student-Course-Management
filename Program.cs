namespace Project{
    class Program{
        public static Task task = new();
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
            var list = task.List();

            if(list.Count == 0){
                Console.WriteLine("\nNo student Available.\n");
                return;
            }
            foreach(var item in list){
                var deleted = item.IsDeleted();
                Console.WriteLine($"ID {item.GetId}: - {item.GetName} - {(deleted ?"Drop out":"Running")}");
            }
        }
        private static void Suspend(){  //op 4
            Console.Write("ID of the student to suspend: ");
            string sus = Console.ReadLine();
            if(int.TryParse(sus, out int id)){
                var student = task.GetId(id);
                if(student != null){
                    task.Delete(id);
                    Console.WriteLine("Student Suspended Successfully.\n");
                }
            }else{
                Console.WriteLine("Invalid ID!\n");
            }
        }
        private static void About(){    //op 5
            Console.Write("Enter the student ID: ");
            if(int.TryParse(Console.ReadLine(), out int value)){
                var info = task.GetId(value);
                if(info != null){
                    Console.WriteLine(info);
                }else{
                    Console.WriteLine("\nInvalid ID!\n");
                }
            }
        }
        private static void AddStudent(){
            Console.WriteLine("Insert new Student's info");
            foreach(int item in Enum.GetValues(typeof(Programs))){
                Console.WriteLine($"{item} - {(Programs)item}");
            }Console.Write("Assign Program: ");

            if(int.TryParse(Console.ReadLine(),out int value) && Enum.IsDefined(typeof(Programs),value)){
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Gender: ");
                string gender = Console.ReadLine();
                Console.Write("Admission Date: ");
                string date = Console.ReadLine();

                Methods newMe = new(task.NextId(),(Programs)value,name,gender,date);
                task.Add(newMe);
            }
        }
        }
}