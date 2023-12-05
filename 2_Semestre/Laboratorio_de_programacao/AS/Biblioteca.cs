public class Biblioteca
{
    private List<ItemBiblioteca> c1 = new List<ItemBiblioteca>();
    
    public void AdicionarItem(ItemBiblioteca item){
        c1.Add(item);
        Console.WriteLine($"O livro {item.titulo} foi adicionado na biblioteca!");
    }
    public void RemoverItem(ItemBiblioteca item){
        c1.Remove(item);
        Console.WriteLine($"O livro {item.titulo} foi removido da biblioteca!");
    }
    public ItemBiblioteca? BuscarItem(string titulo){
        return c1.Find(item => item.titulo == titulo);
    }
    
    public ItemBiblioteca? BuscarItem(int id){
        return c1.Find(item => item.id == id);
    }
}