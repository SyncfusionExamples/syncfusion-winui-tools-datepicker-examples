using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Syncfusion.UI.Xaml.Editors;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Restriction
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DateRestrictionView : Page
    {
        public DateRestrictionView()
        {
            this.InitializeComponent();
        }

        private void SfDatePicker_DateFieldItemPrepared(object sender, DateTimeFieldItemPreparedEventArgs e)
        {
            //Restrict the weekend days
            if (e.ItemInfo != null && e.ItemInfo.DateTime != null)
            {
                if (e.ItemInfo.DateTime.Value.DayOfWeek == DayOfWeek.Saturday ||
                        e.ItemInfo.DateTime.Value.DayOfWeek == DayOfWeek.Sunday)
                {
                    e.ItemInfo.IsEnabled = false;
                }
            }
        }
    }
}
