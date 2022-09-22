﻿using AmazonAPI.Models;
using Microsoft.AspNetCore.JsonPatch;

namespace AmazonAPI.Repository
{
    public interface IProductRepository
    {
        Task<Product> AddProduct(Product product);
        Task<Product> EditProduct(Product product);
        Task DeleteProduct(int productId);
        Task<List<Product>> GetAllProduct();
        Task<Product> GetProductById(int ProductId);
        Task PatchProduct( JsonPatchDocument product,  int id);

    }
}
