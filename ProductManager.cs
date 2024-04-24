using InventoryManagement.CustomExceptions;

namespace InventoryManagement
{
    public class ProductManager
    {
        private static List<Product> inventory = new List<Product>();

        public void AddProduct(Product product)
        {
            if (inventory.Any(p => p.Id == product.Id))
            {
                throw new DuplicateProductException("Product with the same ID already exists.");
            }
            if (product.Price < 0 || product.Quantity < 0)
            {
                throw new InvalidInputException("Price and quantity must be non-negative.");
            }
            inventory.Add(product);
        }

        public void UpdateProduct(int id, Product product)
        {
            var existingProduct = inventory.FirstOrDefault(p => p.Id == id);
            if (existingProduct == null)
            {
                throw new ProductNotFoundException("Product not found.");
            }
            if (product.Price < 0 || product.Quantity < 0)
            {
                throw new InvalidInputException("Price and quantity must be non-negative.");
            }
            existingProduct.Name = product.Name;
            existingProduct.Price = product.Price;
            existingProduct.Quantity = product.Quantity;
            existingProduct.Description = product.Description;
        }

        public void DeleteProduct(int id)
        {
            var existingProduct = inventory.FirstOrDefault(p => p.Id == id);
            if (existingProduct == null)
            {
                throw new ProductNotFoundException("Product not found.");
            }
            inventory.Remove(existingProduct);
        }

        public List<Product> GetAllProducts()
        {
            return inventory;
        }

        public void SellProduct(int productId, int quantity)
        {
            var product = inventory.FirstOrDefault(p => p.Id == productId);
            if (product == null)
            {
                throw new ProductNotFoundException("Product not found.");
            }

            if (product.Quantity < quantity)
            {
                throw new InsufficientQuantityException("Insufficient quantity at the moment.");
            }

            product.Quantity -= quantity;
        }

    }
}
