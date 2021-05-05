using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Syncfusion.UI.Xaml.Editors;

namespace CustomUI
{
    public class DateItemTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DefaultTemplate { get; set; }
        public DataTemplate BirthdayTemplate { get; set; }
        public DataTemplate GiftTemplate { get; set; }
        public DataTemplate AwardTemplate { get; set; }

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            DateTimeFieldItemInfo dateTimeField = item as DateTimeFieldItemInfo;
            if (dateTimeField.Field == DateTimeField.Day)
            {
                switch (dateTimeField.DateTime.Value.Day)
                {
                    case 2:
                        return BirthdayTemplate as DataTemplate;
                    case 7:
                        return GiftTemplate as DataTemplate;
                    case 12:
                        return AwardTemplate as DataTemplate;
                    case 17:
                        return BirthdayTemplate as DataTemplate;
                    case 20:
                        return GiftTemplate as DataTemplate;
                    case 26:
                        return AwardTemplate as DataTemplate;
                }
            }
            return base.SelectTemplateCore(item, container);
        }
    }
}
