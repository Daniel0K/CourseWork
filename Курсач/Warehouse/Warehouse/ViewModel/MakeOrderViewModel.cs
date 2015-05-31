using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using DevExpress.Xpf.Bars;
using DevExpress.Xpf.Mvvm;
using DevExpress.XtraPrinting.Native;
using Warehouse.Model;
using Warehouse.View;

namespace Warehouse.ViewModel
{
    class MakeOrderViewModel
    {
        public ICommand AddItem
        {
            get
            {
                return new DelegateCommand(addItem);
            }
        }

        public ICommand Exit
        {
            get
            {
                return new DelegateCommand(exit);
            }
        }

        private void addItem()
        {
            var context = new WarehouseEntities();
            Order n = new Order()
            {            
                id_contractor = decimal.Parse(OrderWindowViewModel.AddItem.txtIdContractor.Text),
                summ = decimal.Parse(OrderWindowViewModel.AddItem.txtSumm.Text),
                date_order = DateTime.Parse(OrderWindowViewModel.AddItem.txtDateOrder.Text),
                date_import = DateTime.Parse(OrderWindowViewModel.AddItem.txtDateImport.Text),
                //id_user = decimal.Parse(TextAlignment())
            };
            context.Order.Add(n);

            context.SaveChanges();
        }

        private void exit()
        {
            OrderWindowViewModel.AddItem.Close();
        }

       /* public static List<Types> Types
        {
            get { return getTypes(); }
        }

        private static List<Types> getTypes()
        {
            var context = new WarehouseEntities();
            var listOfTypes = context.Types.ToList();
            return listOfTypes;
        }*/

    }
}
