public abstract class ItemBiblioteca
{
    public int id { get; set; } 
    public string titulo { get; set; } 
    protected string descricaoInterna { get; set; }
    public ItemBiblioteca(int id, string titulo){
        this.id = id;
        this.titulo = titulo;
        descricaoInterna = "Descrição padrão";
    }
}