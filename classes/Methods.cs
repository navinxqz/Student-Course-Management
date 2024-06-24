namespace Project{
    public abstract class Abstruct{
        public int ID{get; protected set;}
    }
    public enum Programs{
        ComputerScience = 1, CyberSecurity,DataScience,
        Architecture,Robotics,ElectricalScience,BBA,Law,
    }
    public class Methods : Abstruct{
        private string Name{get; set;}
        private int AddDate{get; set;}
        private Programs program{get; set;}
        private string gender{get; set;}
        private bool Deleted{get; set;}

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
        public int GetId(){return ID;}
        public bool IsDeleted(){return Deleted;}
    }
}