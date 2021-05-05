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

namespace DateFieldPrepared
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DateFieldPreparedView : Page
    {
        public DateFieldPreparedView()
        {
            this.InitializeComponent();
        }

        private void SfDatePicker_DateFieldPrepared(object sender, DateTimeFieldPreparedEventArgs e)
        {
            if (e.Column != null)
            {
                if (e.Column.Field == DateTimeField.Day)
                {
                    e.Column.Format = "ddd dd";
                    e.Column.ShowHeader = true;
                    e.Column.Header = "Day";
                    e.Column.ItemHeight = 60;
                    e.Column.ItemWidth = 100;
                    e.Column.ShouldLoop = true;
                }
                else if (e.Column.Field == DateTimeField.MonthName)
                {
                    e.Column.ShowHeader = true;
                    e.Column.Header = "Month";
                    e.Column.ItemHeight = 40;
                    e.Column.ItemWidth = 75;
                    e.Column.ShouldLoop = true;
                }
                else if (e.Column.Field == DateTimeField.Year)
                {
                    e.Column.Format = "yy";
                    e.Column.ShowHeader = true;
                    e.Column.Header = "Year";
                    e.Column.ItemHeight = 80;
                    e.Column.ItemWidth = 75;
                    e.Column.ShouldLoop = true;
                }
            }
        }
    }
}
