using InventoryManagement.CustomExceptions;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InventoryManagementController : ControllerBase
    {
        private ProductManager productManager = new ProductManager();

        [HttpPost]
        public object AddProduct(Product product)
        {
            try
            {
                productManager.AddProduct(product);
                return Ok("Product added successfully.");
            }
            catch (DuplicateProductException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (InvalidInputException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public object UpdateProduct(int id, Product product)
        {
            try
            {
                productManager.UpdateProduct(id, product);
                return Ok("Product updated successfully.");
            }
            catch (InvalidInputException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (ProductNotFoundException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public object DeleteProduct(int id)
        {
            try
            {
                productManager.DeleteProduct(id);
                return Ok("Product deleted successfully.");
            }
            catch (ProductNotFoundException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public object GetAllProducts()
        {
            try
            {
            return Ok(productManager.GetAllProducts());
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("api/sell")]
        public object SellProduct(int productId, int quantity)
        {
            try
            {
                productManager.SellProduct(productId, quantity);
                return Ok("Product sold successfully.");
            }
            catch (ProductNotFoundException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (InsufficientQuantityException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}