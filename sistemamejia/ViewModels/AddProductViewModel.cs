using Prism.Mvvm;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Variedades.Business;

namespace Variedades.ViewModels
{
    class AddProductViewModel : BindableBase
    {
        private readonly BusinessContext context;

        //Form properties
        private string _MarcaBox;
        public string MarcaBox
        {
            get { return _MarcaBox; }
            set { SetProperty(ref _MarcaBox, value); }
        }

        private string _ModeloBox;
        public string ModeloBox
        {
            get { return _ModeloBox; }
            set { SetProperty(ref _ModeloBox, value); }
        }

        private string _PrecioVentaBox;
        public string PrecioVentaBox
        {
            get { return _PrecioVentaBox; }
            set { SetProperty(ref _PrecioVentaBox, value); }
        }

        public AddProductViewModel()
        {
        }
    }
}
