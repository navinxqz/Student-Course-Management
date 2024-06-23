namespace Project{
    public abstract class Abstruct{
        public abstract int ID{get; protected set;}
    }
    public enum Programs{
        ComputerScience = 1, BBA = 2, Law = 3,
        CyberSecurity = 4,DataScience = 5,
        Architecture = 6,Robotics = 7,ElectricalScience = 8
    }
    public class Methods : Abstruct{
        private string Name{get; set;}
        private int AddDate{get; set;}
        private Programs program{get; set;}
        private string gender{get; set;}

        public Methods(int id,string Name, int AddDate,Programs program,string gender){
            this.Deleted = false;
            this.ID = id;
            this.Name = Name;
            this.AddDate = AddDate;
            this.program = program;
            this.gender = gender;
        }
        public void Delete(){
            this.Deleted = true;
        }
        public override string ToString(){
            string s = "";
            s += $"Name: {this.Name}\n";
            s += $"ID: {this.ID}\n";
            s += $"Sex: {this.gender}\n";
            s += $"Dept: {this.program}\n";
            s += $"Admission Date: {this.AddDate}\n";
            return s;
        }
        public string GetName(){return Name;}
        public int GetID(){return ID;}
        public bool IsDeleted(){return Deleted;}
    }
}