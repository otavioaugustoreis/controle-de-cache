namespace AprendendoUsoDoCache.Entity
{
    public class ProdutoEntity
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public ProdutoEntity(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
