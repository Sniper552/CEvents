using Avalonia.Controls.Primitives;
using DynamicData.Binding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CEvents.Models
{
    public class EventC: AbstractNotifyPropertyChanged
    {
        private string header = "";
        private string image = "";
        private string date = "";
        private Categoria category;
        private decimal price = 0;
        public string Header
        {
            get => header; 
            set => SetAndRaise(ref header, value);
        }

        public string Image
        {
            get => image; set => SetAndRaise(ref image, value);
        }

        public string Date
        {
            get => date; set => SetAndRaise(ref date, value);
        }

        public Categoria Category
        {
            get => category; set => SetAndRaise(ref category, value);
        }

        public decimal Price
        {
            get => price; set => SetAndRaise(ref price, value);
        }
    }
}