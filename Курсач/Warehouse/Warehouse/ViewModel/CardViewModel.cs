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
    class CardViewModel
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
            Merchandise n = new Merchandise()
            {
                brand = MerchendiseWindowViewModel.AddItem.Name.Text,
                consignment = decimal.Parse(MerchendiseWindowViewModel.AddItem.txtConsignment.Text),
                arrived = MerchendiseWindowViewModel.AddItem.chkArrived.IsEnabled,
                count_booked = decimal.Parse(MerchendiseWindowViewModel.AddItem.txtCountBooked.Text),
                count_stored = decimal.Parse(MerchendiseWindowViewModel.AddItem.txtCountStored.Text),
                count_order = decimal.Parse(MerchendiseWindowViewModel.AddItem.txtCountOrder.Text),
                count_send = decimal.Parse(MerchendiseWindowViewModel.AddItem.txtCountSend.Text),
                specif_n = MerchendiseWindowViewModel.AddItem.Descr.Text,
                cost = decimal.Parse(MerchendiseWindowViewModel.AddItem.txtCost.Text),
                id_type = ((Types) MerchendiseWindowViewModel.AddItem.comboType.SelectedValue).id_type,
                margin = decimal.Parse(MerchendiseWindowViewModel.AddItem.txtCost.Text)
            };
            context.Merchandise.Add(n);

            context.SaveChanges();}

        private void exit() {
            MerchendiseWindowViewModel.AddItem.Close();
        }

        public static List<Types> Types
        {
            get { return getTypes(); }
        }

        private static List<Types> getTypes()
        {
            var context = new WarehouseEntities();
            var listOfTypes = context.Types.ToList();
            return listOfTypes;
        }

    }
}
