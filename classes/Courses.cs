namespace Project{
    class Management{
        public string CourseName{get; set;}
        public Management(string CourseName){
            this.CourseName=CourseName;
        }
        List<Management> course = new(){
            new Management("Object Oriented Programming - 1"),
            new Management("Accounting"),
            new Management("English - 1"),
            new Management("Data Structure"),
            new Management("Algorithms"),
        };
    }
}