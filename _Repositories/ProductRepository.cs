using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using Supermarket_mvp.Models;
using System.Data;


namespace Supermarket_mvp._Repositories
{
    internal class ProductRepository : BaseRepository
{
    public ProductRepository(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public void Add(ProductModel productModel)
    {
        using (var connection = new SqlConnection(connectionString))
        using (var command = new SqlCommand())
        {
            connection.Open();
            command.Connection = connection;
            command.CommandText = "INSERT INTO Product (ProductName, ProductPrice, ProductStock) VALUES (@name, @price, @stock)";
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productModel.Name;
            command.Parameters.Add("@price", SqlDbType.Decimal).Value = productModel.Price;
            command.Parameters.Add("@stock", SqlDbType.Int).Value = productModel.Stock;
            command.ExecuteNonQuery();
        }
    }

    public void Delete(int id)
    {
        using (var connection = new SqlConnection(connectionString))
        using (var command = new SqlCommand())
        {
            connection.Open();
            command.Connection = connection;
            command.CommandText = "DELETE FROM Product WHERE ProductId = @id";
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.ExecuteNonQuery();
        }
    }

    public void Edit(ProductModel productModel)
    {
        using (var connection = new SqlConnection(connectionString))
        using (var command = new SqlCommand())
        {
            connection.Open();
            command.Connection = connection;
            command.CommandText = @"UPDATE Product
                                    SET ProductName = @name,
                                        ProductPrice = @price,
                                        ProductStock = @stock
                                    WHERE ProductId = @id";
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productModel.Name;
            command.Parameters.Add("@price", SqlDbType.Decimal).Value = productModel.Price;
            command.Parameters.Add("@stock", SqlDbType.Int).Value = productModel.Stock;
            command.Parameters.Add("@id", SqlDbType.Int).Value = productModel.Id;
            command.ExecuteNonQuery();
        }
    }

    public IEnumerable<ProductModel> GetAll()
    {
        var productList = new List<ProductModel>();
        using (var connection = new SqlConnection(connectionString))
        using (var command = new SqlCommand())
        {
            connection.Open();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM Product ORDER BY ProductId DESC";
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var productModel = new ProductModel
                    {
                        Id = (int)reader["ProductId"],
                        Name = reader["ProductName"].ToString(),
                        Price = Convert.ToInt32(reader["ProductPrice"]),
                        Stock = (int)reader["ProductStock"]
                    };
                    productList.Add(productModel);
                }
            }
        }
        return productList;
    }

    public IEnumerable<ProductModel> GetByValue(string value)
    {
        var productList = new List<ProductModel>();
        int productId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
        string productName = value;
        using (var connection = new SqlConnection(connectionString))
        using (var command = new SqlCommand())
        {
            connection.Open();
            command.Connection = connection;
            command.CommandText = @"SELECT * FROM Product
                                    WHERE ProductId = @id OR ProductName LIKE @name + '%'
                                    ORDER BY ProductId DESC";
            command.Parameters.Add("@id", SqlDbType.Int).Value = productId;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productName;
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var productModel = new ProductModel
                    {
                        Id = (int)reader["ProductId"],
                        Name = reader["ProductName"].ToString(),
                        Price = Convert.ToInt32(reader["ProductPrice"]),
                        Stock = (int)reader["ProductStock"]
                    };
                    productList.Add(productModel);
                }
            }
        }
        return productList;
    }
}
}

