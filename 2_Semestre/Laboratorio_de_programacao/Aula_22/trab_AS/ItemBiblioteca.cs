abstract class ItemBiblioteca
{
    public int id;
    public string titulo;
    public string descricaoInterna { get; set; }

    public ItemBiblioteca(int id, string titulo)
    {
        this.id = id;
        this.titulo = titulo;
        this.descricaoInterna = "descrição padrão";
    }
}