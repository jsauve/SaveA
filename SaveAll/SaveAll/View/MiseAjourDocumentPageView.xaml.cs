﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Pages;
using SaveAll.ViewModel.ViewModelDocument;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SaveAll.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MiseAjourDocumentPageView : PopupPage
    {
        public MiseAjourDocumentPageView(int documentID)
        {
            InitializeComponent();
            this.BindingContext = new MiseAjourDocumentViewModel(Navigation, documentID);

        }

        void ActivationDuChamps(object sender, ToggledEventArgs e)
        {
            DateExpiration.IsEnabled = !DateExpiration.IsEnabled;
            if (DateExpiration.IsEnabled)
            {
                ExpirationDate.TextColor = Color.Black;
                ExpirationLabel.TextColor = Color.Black;


            }
            else
            {
                ExpirationDate.TextColor = Color.FromHex("#bababa");
                ExpirationLabel.TextColor = Color.FromHex("#bababa");


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
