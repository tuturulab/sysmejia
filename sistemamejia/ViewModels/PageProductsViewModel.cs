﻿using Prism.Mvvm;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Variedades.Business;
using Variedades.Models;
using System.Collections.ObjectModel;

namespace Variedades.ViewModels
{
    class PageProductsViewModel : BindableBase
    {
        /// <summary>
        /// Business Context
        /// </summary>
        private readonly BusinessContext context;


        private ObservableCollection<Producto> _ProductosCollection;
        public ObservableCollection<Producto> ProductosCollection
        {
            get { return _ProductosCollection; }
            set { SetProperty(ref _ProductosCollection, value); }
        }

        private Producto _SelectedProduct;
        public Producto SelectedProduct
        {
            get { return _SelectedProduct; }
            set { SetProperty(ref _SelectedProduct, value); }
        }

        #region Actions

        public Action OpenAddProductAction { get; set; }

        #endregion

        #region Commands

        public DelegateCommand OpenAddProductWindowCommand { get; set; }

        #endregion


        public PageProductsViewModel()
        {
            //Init main context
            context = new BusinessContext();

            //Load main Data
            LoadData();


            //Init commands
            OpenAddProductWindowCommand = new DelegateCommand(OpenAddWindow);
        }

        public void OpenAddWindow()
        {
            OpenAddProductAction?.Invoke();
        }

        public void LoadData()
        { 
            ProductosCollection = new ObservableCollection<Producto>(context.GetAllProducts());
        }
    }
}
