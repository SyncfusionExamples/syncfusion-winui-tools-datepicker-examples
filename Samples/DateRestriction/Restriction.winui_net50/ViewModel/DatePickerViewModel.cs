using Syncfusion.UI.Xaml.Core;
using Syncfusion.UI.Xaml.Editors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restriction
{
    public class DatePickerViewModel : NotificationObject
    {
        private int visibleItemsCount = 7;
        private bool allowNullValue = true;
        private DateTimeOffset minDate = new DateTimeOffset(new DateTime(2015, 1, 1));
        private DateTimeOffset maxDate = new DateTimeOffset(new DateTime(2025, 1, 1));
        private DateTimeEditMode editMode =  DateTimeEditMode.Mask;
        private string placeHolderText= "No Date is Selected";
        private string formatString="d";
        private string dropDownFormatString = "d";

        public DatePickerViewModel()
        {
            
        }

        public int VisibleItemsCount
        {
            get
            {
                return visibleItemsCount;
            }
            set
            {
                if (visibleItemsCount != value)
                {
                    visibleItemsCount = value;
                    this.RaisePropertyChanged(nameof(this.VisibleItemsCount));
                }
            }
        }
        public bool AllowNullValue
        {
            get
            {
                return allowNullValue;
            }
            set
            {
                if (allowNullValue != value)
                {
                    allowNullValue = value;
                    this.RaisePropertyChanged(nameof(this.AllowNullValue));
                }
            }
        }

        public string PlaceHolderText
        {
            get
            {
                return placeHolderText;
            }
            set
            {
                if (placeHolderText != value)
                {
                    placeHolderText = value;
                    this.RaisePropertyChanged(nameof(this.PlaceHolderText));
                }
            }
        }
        public string FormatString
        {
            get
            {
                return formatString;
            }
            set
            {
                if (formatString != value)
                {
                    formatString = value;
                    this.RaisePropertyChanged(nameof(this.FormatString));
                }
            }
        }
        
        public string DropDownFormatString
        {
            get
            {
                return dropDownFormatString;
            }
            set
            {
                if (dropDownFormatString != value)
                {
                    dropDownFormatString = value;
                    this.RaisePropertyChanged(nameof(this.DropDownFormatString));
                }
            }
        }

        public DateTimeEditMode EditMode
        {
            get
            {
                return editMode;
            }
            set
            {
                if (editMode != value)
                {
                    editMode = value;
                    this.RaisePropertyChanged(nameof(this.EditMode));
                }
            }
        }

        public DateTimeOffset MinDate
        {
            get
            {
                return minDate;
            }
            set
            {
                if (minDate != value)
                {
                    minDate = value;
                    this.RaisePropertyChanged(nameof(this.MinDate));
                }
            }
        }

        public DateTimeOffset MaxDate
        {
            get
            {
                return maxDate;
            }
            set
            {
                if (maxDate != value)
                {
                    maxDate = value;
                    this.RaisePropertyChanged(nameof(this.MaxDate));
                }
            }
        }

        
    }
}
