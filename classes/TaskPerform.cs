namespace Project{
    public class Task : Iface<Methods>{
        private List<Methods> stulist = new();

        public List<Methods> List(){
            return new List<Methods>(stulist);
        }
        public void Add(Methods m){
            stulist.Add(m);
        }
        public Methods GetId(int id){
            return stulist.Find(s => s.ID == id);
        }
        public void Delete(int id){
            Methods methods= stulist.Find(s => s.GetId()== id);
            if(methods!=null){
                methods.Delete();
            }else{
                Console.WriteLine("Invalid Student ID!\n");
            }
        }public int NextId(){return stulist.Count+1;}
    }
}