﻿using System;
using System.Windows.Input;
using Prism.Navigation;
using Xamarin.Forms;

namespace News.Client.ViewModels
{
    public class AboutViewModel// : BaseViewModel
    {
        public AboutViewModel()
        {
            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));

        }
       

        public ICommand OpenWebCommand { get; }
    }
}