using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Views;
using Supermarket_mvp.Models;

namespace Supermarket_mvp.Presenters
{
    internal class PayModePresenter
    {
        private IPayModeView view;
        private IPayModeRepository repository;
        private BindingSource payModeBidingSource;
        private IEnumerable<PayModeModel> payModeList;
        

        public PayModePresenter(IPayModeView view, IPayModeRepository repository)
        {
            this.payModeBidingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchPayMode;
            this.view.AddNewEvent += AddNewEventPayMode;
            this.view.EditEvent += LoadSelectPayModeToEdit;
            this.view.DeleteEvent += DeleteSelectedPayMode;
            this.view.SaveEvent += SavePayMode;
            this.view.CancelEvent += CancelAction;

            this.view.SetPayModeListBildingSource(payModeBidingSource);
            loadAllPayModeList();
            this.view.Show();
        }

        private void loadAllPayModeList()
        {
            payModeList = repository.GetAll();
            payModeBidingSource.DataSource = payModeList;
        }

        private void AddNewPayMode(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SavePayMode(object? sender, EventArgs e)
        {
            var payMode = new PayModeModel();
            payMode.Id = Convert.ToInt32(view.PayModeId);
            payMode.Name = view.PayModeName;
            payMode.Description = view.PayModeObservation;

            try
            {
                new Common.ModelDataValidation().Validate(payMode);
                if(view.IsEdit)
                {
                    repository.Edit(payMode);
                    view.Message = "Pay Mode edited successfuly";
                }
                else
                {
                    repository.Add(payMode);
                    view.Message = "Pay Mode added successfuly";
                }
                view.IsSuccessful = true;
                loadAllPayModeList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                //Si ocurre una execption se configura IsSuccesful en false
                //Y a la propiedad Message de la vista se asigna el mensaje de la exception
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.PayModeId = "0";
            view.PayModeName = "";
            view.PayModeObservation = "";
        }

        private void DeleteSelectedPayMode(object? sender, EventArgs e)
        {
            try
            {
                //Se recupera el objeto de la fila seleccionada del dataGriedview
                var payMode = (PayModeModel)payModeBidingSource.Current;
                //Se invoca el metodo delete del repositorio pasandole el Id del pay mode
                repository.Delete(payMode.Id);
                view.IsSuccessful = true;
                view.Message = "Pay Mode deleted succesfully";
                loadAllPayModeList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful= false;
                view.Message = "An error ocurred, couldnt delete pay mode";
            }
        }

        private void LoadSelectPayModeToEdit(object? sender, EventArgs e)
        {
            //Se obtiene el objeto del datagridView que se encuentra seleccionado
            var PayMode = (PayModeModel) payModeBidingSource.Current;

            //se cambia el contenido de las cajas de texto por el objeto recuperado del data gried
            view.PayModeId = PayMode.Id.ToString();
            view.PayModeName = PayMode.Name;
            view.PayModeObservation = PayMode.Description;

            //Se establece el modo como edicion
            view.IsEdit = true;
        }

        private void AddNewEventPayMode(object? sender, EventArgs e)
        {
            MessageBox.Show("Hizo click en el botono nuevo");
        }

        private void SearchPayMode(object? sender, EventArgs e)
        {
            bool emptyValue = String.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                payModeList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                payModeList = repository.GetAll();
            }

            payModeBidingSource.DataSource = payModeList;
        }
    }
}
