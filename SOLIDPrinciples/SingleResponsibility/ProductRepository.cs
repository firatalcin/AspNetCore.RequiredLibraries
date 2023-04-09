namespace SingleResponsibility
{
    public class ProductRepository
    {
        private static List<Product> productList = new List<Product>();

        public ProductRepository()
        {
            productList = new()
        {
            new(){Id=1, Name="Kalem 1"},
            new(){Id=2, Name="Kalem 2"},
            new(){Id=3, Name="Kalem 3"},
            new(){Id=4, Name="Kalem 4"},
            new(){Id=5, Name="Kalem 5"}
        };
        }

        public List<Product> GetProducts()
        {
            return productList;
        }
      
        public void SaveOrUpdate(Product product)
        {
            var hasProduct = productList.Any(p => p.Id == product.Id);
            if (hasProduct is false)
                productList.Add(product);

            var index = productList.FindIndex(x => x.Id.Equals(product.Id));
            productList[index] = product;
        }

        public void Delete(int id)
        {
            var hasProduct = productList.Find(x => x.Id.Equals(id));

            if (hasProduct is null)
                throw new Exception("Ürün bulunamadı");

            productList.Remove(hasProduct);
        }
    }
}
