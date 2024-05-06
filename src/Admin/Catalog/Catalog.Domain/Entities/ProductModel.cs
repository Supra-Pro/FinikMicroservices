namespace Catalog.Domain.Entities
{
    public class ProductModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        // Picture qowadga joyi
        public string Model { get; set; }
        public bool IsOnSale { get; set; }
        public int Price { get; set; }
        public string TypeMontage { get; set; }
        public string IP { get; set; }
        public string Potok { get; set; }
        public int Power { get; set; }
        public int Temperature { get; set; }
        public string EmergencyBlock { get; set; }
        public string Management { get; set; }
        public string CRI { get; set; }
        public int CatalogId { get; set; }
        public int CategoryId { get; set; }
    }
}
