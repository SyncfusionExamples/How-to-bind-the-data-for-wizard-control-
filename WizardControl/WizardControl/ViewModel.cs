using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizardControl
{
    public class ViewModel : NotificationObject
    {
        private ObservableCollection<Model> pageitems;
        public ObservableCollection<Model> PageItems
        {
            get
            {
                return pageitems;
            }
            set
            {
                pageitems = value;
                RaisePropertyChanged("PageItems");
            }
        }

        public ViewModel()
        {
            pageitems = new ObservableCollection<Model>();
            PopulatePageItems();
        }

        private void PopulatePageItems()
        {
            pageitems.Add(new Model { Title = "Wizard Control", Content = "The WPF Wizard is a tool for building dialogs with multiple pages that guide your end-users through a specific process." });
            pageitems.Add(new Model { Title = "Pages", Content = "The Wizard control provides pages of three types - start page, regular page and finish (completion) page." });
            pageitems.Add(new Model { Title = "Button", Content = "Wizard pages can display four buttons - Back, Next, Finish and Cancel. In this article, you will learn how to display the required buttons for each individual page." });
            pageitems.Add(new Model { Title = "Navigation", Content = "This article demonstrates how the Wizard navigates from one page to another in a simplest scenario, when one page follows another in a strict order." });
        }
    }
}
