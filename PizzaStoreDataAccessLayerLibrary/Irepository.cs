namespace PizzaStoreDataAccessLayerLibrary;

public interface Irepository<K,T>
{
    //crud repos
    ICollection<T> GetAll();
    // List<T> GetAll();
    T GetById(K key);
    T Add(T item);
    T Update(T item);
    T Delete(K key);

}
