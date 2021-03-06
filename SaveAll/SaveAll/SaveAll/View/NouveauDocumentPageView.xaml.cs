﻿using System;
using System.Collections.Generic;
using Rg.Plugins.Popup.Extensions;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rg.Plugins.Popup.Services;
using SaveAll.Interfaces;
using SaveAll.ViewModel.ViewModelDocument;
using Plugin.FilePicker;

namespace SaveAll.View
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NouveauDocumentPageView : PopupPage
    {
        public NouveauDocumentPageView()
        {
            InitializeComponent();
            BindingContext = new EnregistrementDocumentViewModel(Navigation);
        }




        void ActivationDuChamps(object sender, ToggledEventArgs e)
        {
            DateExpiration.IsEnabled = !DateExpiration.IsEnabled;
            DateExpiration2.IsEnabled = !DateExpiration2.IsEnabled;
            if (DateExpiration.IsEnabled == true & DateExpiration2.IsEnabled == true)
            {
                ExpirationDate.TextColor = Color.Black;
                ExpirationLabel.TextColor = Color.Black;
                ExpirationLabelheure.TextColor = Color.Black;
                HeureExpiration.TextColor = Color.Black;
            }
            else
            {
                ExpirationDate.TextColor = Color.FromHex("#bababa");
                ExpirationLabel.TextColor = Color.FromHex("#bababa");
                ExpirationLabelheure.TextColor = Color.FromHex("#bababa");
                HeureExpiration.TextColor = Color.FromHex("#bababa");

            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }





        // ### Methods for supporting animations in your popup page ###

        // Invoked before an animation appearing
        protected override void OnAppearingAnimationBegin()
        {
            base.OnAppearingAnimationBegin();
        }

        // Invoked after an animation appearing
        protected override void OnAppearingAnimationEnd()
        {
            base.OnAppearingAnimationEnd();
        }

        // Invoked before an animation disappearing
        protected override void OnDisappearingAnimationBegin()
        {
            base.OnDisappearingAnimationBegin();
        }

        // Invoked after an animation disappearing
        protected override void OnDisappearingAnimationEnd()
        {
            base.OnDisappearingAnimationEnd();
        }

        protected override Task OnAppearingAnimationBeginAsync()
        {
            return base.OnAppearingAnimationBeginAsync();
        }

        protected override Task OnAppearingAnimationEndAsync()
        {
            return base.OnAppearingAnimationEndAsync();
        }

        protected override Task OnDisappearingAnimationBeginAsync()
        {
            return base.OnDisappearingAnimationBeginAsync();
        }

        protected override Task OnDisappearingAnimationEndAsync()
        {
            return base.OnDisappearingAnimationEndAsync();
        }

        // ### Overrided methods which can prevent closing a popup page ###

        // Invoked when a hardware back button is pressed
        protected override bool OnBackButtonPressed()
        {
            // Return true if you don't want to close this popup page when a back button is pressed
            return base.OnBackButtonPressed();
        }

        // Invoked when background is clicked
        protected override bool OnBackgroundClicked()
        {
            // Return false if you don't want to close this popup page when a background of the popup page is clicked
            return base.OnBackgroundClicked();
        }

        
       

        
    }
}
