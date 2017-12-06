using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace CommTracMobile.ViewModels
{
    public class ProcessListPageViewModel : BaseViewModel
    {
        public ProcessListPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Process List";
        }

    }
}
