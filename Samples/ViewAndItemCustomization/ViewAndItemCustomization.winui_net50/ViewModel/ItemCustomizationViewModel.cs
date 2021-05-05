﻿using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls.Primitives;
using Syncfusion.UI.Xaml.Core;
using Syncfusion.UI.Xaml.Editors;
using System;

namespace ViewAndItemCustomization
{
    public class ItemCustomizationViewModel : NotificationObject
    {
        private int minItemWidth = 0;
        private int maxItemWidth = 300;
        private int itemWidth = 80;
        private int itemHeight = 40;
        private int dropDownHeight = 350;
        private string dropDownHeader = "Choose the date";
        private bool showDropDownButton = true;
        private bool showDropDownHeader = true;
        private bool showColumnHeaders = true;
        private bool showSubmitButtons = true;
        private FlowDirection flowDirection =  FlowDirection.LeftToRight ;
        private FlyoutPlacementMode dropDownPlacement = FlyoutPlacementMode.BottomEdgeAlignedRight;
        private DateTimeOffsetCollection blackoutDates;
        private DateTimeOffset selectedDate = new DateTimeOffset(new DateTime(2021, 1, 28));

        public FlyoutPlacementMode DropDownPlacement
        {
            get
            {
                return dropDownPlacement;
            }
            set
            {
                if (dropDownPlacement != value)
                {
                    dropDownPlacement = value;
                    this.RaisePropertyChanged(nameof(this.DropDownPlacement));
                }
            }
        }
        
        public FlowDirection FlowDirection
        {
            get
            {
                return flowDirection;
            }
            set
            {
                if (flowDirection != value)
                {
                    flowDirection = value;
                    this.RaisePropertyChanged(nameof(this.FlowDirection));
                }
            }
        }
        
        public string DropDownHeader
        {
            get
            {
                return dropDownHeader;
            }
            set
            {
                if (dropDownHeader != value)
                {
                    dropDownHeader = value;
                    this.RaisePropertyChanged(nameof(this.DropDownHeader));
                }
            }
        }
        
        public DateTimeOffsetCollection BlackoutDates
        {
            get
            {
                return blackoutDates;
            }
            set
            {
                if (blackoutDates != value)
                {
                    blackoutDates = value;
                    this.RaisePropertyChanged(nameof(this.BlackoutDates));
                }
            }
        }

        public DateTimeOffset SelectedDate
        {
            get
            {
                return selectedDate;
            }
            set
            {
                if (selectedDate != value)
                {
                    selectedDate = value;
                    this.RaisePropertyChanged(nameof(this.SelectedDate));
                }
            }
        }

        public bool ShowDropDownButton
        {
            get
            {
                return showDropDownButton;
            }
            set
            {
                if (showDropDownButton != value)
                {
                    showDropDownButton = value;
                    this.RaisePropertyChanged(nameof(this.ShowDropDownButton));
                }
            }
        }
         public bool ShowDropDownHeader
        {
            get
            {
                return showDropDownHeader;
            }
            set
            {
                if (showDropDownHeader != value)
                {
                    showDropDownHeader = value;
                    this.RaisePropertyChanged(nameof(this.ShowDropDownHeader));
                }
            }
        }
         public bool ShowColumnHeaders
        {
            get
            {
                return showColumnHeaders;
            }
            set
            {
                if (showColumnHeaders != value)
                {
                    showColumnHeaders = value;
                    this.RaisePropertyChanged(nameof(this.ShowColumnHeaders));
                }
            }
        }
        
        public bool ShowSubmitButtons
        {
            get
            {
                return showSubmitButtons;
            }
            set
            {
                if (showSubmitButtons != value)
                {
                    showSubmitButtons = value;
                    this.RaisePropertyChanged(nameof(this.ShowSubmitButtons));
                }
            }
        }
        
        public int MinItemWidth
        {
            get
            {
                return minItemWidth;
            }
            set
            {
                if (minItemWidth != value)
                {
                    minItemWidth = value;
                    this.RaisePropertyChanged(nameof(this.MinItemWidth));
                }
            }
        }

        public int MaxItemWidth
        {
            get
            {
                return maxItemWidth;
            }
            set
            {
                if (maxItemWidth != value)
                {
                    maxItemWidth = value;
                    this.RaisePropertyChanged(nameof(this.MaxItemWidth));
                }
            }
        }

        public int ItemWidth
        {
            get
            {
                return itemWidth;
            }
            set
            {
                if (itemWidth != value)
                {
                    itemWidth = value;
                    this.RaisePropertyChanged(nameof(this.ItemWidth));
                }
            }
        }

        public int ItemHeight
        {
            get
            {
                return itemHeight;
            }
            set
            {
                if (itemHeight != value)
                {
                    itemHeight = value;
                    this.RaisePropertyChanged(nameof(this.ItemHeight));
                }
            }
        }
        
        public int DropDownHeight
        {
            get
            {
                return dropDownHeight;
            }
            set
            {
                if (dropDownHeight != value)
                {
                    dropDownHeight = value;
                    this.RaisePropertyChanged(nameof(this.DropDownHeight));
                }
            }
        }

        public ItemCustomizationViewModel()
        {
            BlackoutDates = new DateTimeOffsetCollection();
            BlackoutDates.Add(new DateTimeOffset(new DateTime(2018, 1, 28)));
            BlackoutDates.Add(new DateTimeOffset(new DateTime(2021, 1, 26)));
            BlackoutDates.Add(new DateTimeOffset(new DateTime(2021, 1, 29)));
            BlackoutDates.Add(new DateTimeOffset(new DateTime(2021, 1, 31)));
            BlackoutDates.Add(new DateTimeOffset(new DateTime(2023, 1, 28)));
            BlackoutDates.Add(new DateTimeOffset(new DateTime(2024, 1, 28)));
        }

    }
}
