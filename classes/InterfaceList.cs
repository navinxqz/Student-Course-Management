namespace Project{
    public interface Iface<T>{
        List<T> List();
        T GetId(int id);
        void Add(T entity);
        void Delete(int id);
        int NextId();
    }
}