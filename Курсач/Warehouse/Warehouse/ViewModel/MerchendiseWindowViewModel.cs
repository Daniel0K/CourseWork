using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DevExpress.Xpf.Mvvm;
using Warehouse.Model;
using Warehouse.View;

namespace Warehouse.ViewModel
{
    class MerchendiseWindowViewModel
    {
        private static Card addItem;
        

        public static Card AddItem
        {
            get { return addItem; }
        }

        public ICommand CreateCard
        {
            get { return new DelegateCommand(createCard);}
        }

        private void createCard()
        {
            addItem = new Card();
            addItem.Show();

        }

        public static List<Merchandise> Merchandises
        {
            get { return merchandises(); }
        }


        private static List<Merchandise> merchandises()
        {
            var context = new WarehouseEntities();
            var listOfMerchandise = context.Merchandise.ToList();
            return listOfMerchandise;
        }

    }
}
