﻿using Prism;
using Prism.Autofac;
using Prism.Ioc;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsFoundationSolution.ViewModels;
using XamarinFormsFoundationSolution.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace XamarinFormsFoundationSolution
{
    public partial class App : PrismApplication
    {
        public App()
            : this(null)
        {

        }

        public App(IPlatformInitializer initializer)
                    : base(initializer)
        {

        }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("Nav/Sample");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>("Nav");
            containerRegistry.RegisterForNavigation<SampleView, SampleViewModel>("Sample");
        }
    }
}
