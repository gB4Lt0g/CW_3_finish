﻿using System.Windows.Controls;
using CW_v3.ViewModels.Base;

namespace CW_v3.Views.UserControls
{
    public partial class LocationTypeUS : UserControl
    {
        public LocationTypeUS(ViewModel dataContext)
        {
            InitializeComponent();
            DataContext = dataContext;
        }
    }
}