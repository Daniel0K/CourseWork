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
    class OrderWindowViewModel
    {
        private static MakeOrder addItem;


        public static MakeOrder AddItem
        {
            get { return addItem; }
        }

        public ICommand CreateOrder
        {
            get { return new DelegateCommand(createOrder); }
        }

        private void createOrder()
        {
            addItem = new MakeOrder();
            addItem.Show();

        }

        public static List<Order> Orders
        {
            get { return orders(); }
        }

        private static List<Order> orders()
        {
            var context = new WarehouseEntities();
            var listOforders = context.Order.ToList();
            return listOforders;
        }
    }
}
