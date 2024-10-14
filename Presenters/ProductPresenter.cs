using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Presenters
{
    internal class ProductPresenter
    {
        private ProductView view;
        private ProductRepository repository;
        private BindingSource productBindingSource;
        private IEnumerable<ProductModel> productList;

        public ProductPresenter(ProductView view, ProductRepository repository)
        {
            this.productBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchProduct;
            this.view.AddNewEvent += AddNewEventProduct;
            this.view.EditEvent += LoadSelectedProductToEdit;
            this.view.DeleteEvent += DeleteSelectedProduct;
            this.view.SaveEvent += SaveProduct;
            this.view.CancelEvent += CancelAction;

            this.view.SetProductListBindingSource(productBindingSource);
            LoadAllProductList();
            this.view.Show();
        }

        private void LoadAllProductList()
        {
            productList = repository.GetAll();
            productBindingSource.DataSource = productList;
        }

        private void AddNewEventProduct(object? sender, EventArgs e)
        {
            view.IsEdit = false;
            CleanViewFields();
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveProduct(object? sender, EventArgs e)
        {
            var product = new ProductModel
            {
                Id = Convert.ToInt32(view.ProductId),
                Name = view.ProductName,
                Price = Convert.ToInt32(view.ProductPrice),
                Stock = Convert.ToInt32(view.ProductStock)
            };

            try
            {
                new Common.ModelDataValidation().Validate(product);
                if (view.IsEdit)
                {
                    repository.Edit(product);
                    view.Message = "Product edited successfully";
                }
                else
                {
                    repository.Add(product);
                    view.Message = "Product added successfully";
                }
                view.IsSuccessful = true;
                LoadAllProductList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.ProductId = "0";
            view.ProductName = "";
            view.ProductPrice = "";
            view.ProductStock = "";
        }

        private void DeleteSelectedProduct(object? sender, EventArgs e)
        {
            try
            {
                var product = (ProductModel)productBindingSource.Current;
                repository.Delete(product.Id);
                view.IsSuccessful = true;
                view.Message = "Product deleted successfully";
                LoadAllProductList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error occurred, couldn't delete product";
            }
        }

        private void LoadSelectedProductToEdit(object? sender, EventArgs e)
        {
            var product = (ProductModel)productBindingSource.Current;

            view.ProductId = product.Id.ToString();
            view.ProductName = product.Name;
            view.ProductPrice = product.Price.ToString();
            view.ProductStock = product.Stock.ToString();

            view.IsEdit = true;
        }

        private void SearchProduct(object? sender, EventArgs e)
        {
            bool emptyValue = String.IsNullOrWhiteSpace(this.view.SearchValue);
            if (!emptyValue)
            {
                productList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                productList = repository.GetAll();
            }

            productBindingSource.DataSource = productList;
        }
    }
}
