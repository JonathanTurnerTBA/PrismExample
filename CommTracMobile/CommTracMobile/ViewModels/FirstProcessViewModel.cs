using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace CommTracMobile.ViewModels
{
    public class FirstProcessViewModel : BaseViewModel
    {
        public FirstProcessViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "FirstProcess";
        }
    }
}
