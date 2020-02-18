﻿using System;
using System.ComponentModel;
using CoreGraphics;
using SaveAll.Controls;
using SaveAll.iOS.controlsIos;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(DatePicker), typeof(EntryRendererDatePickerIos))]
namespace SaveAll.iOS.controlsIos
{
    public class EntryRendererDatePickerIos : DatePickerRenderer
    {
        public new static void Init() { }
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (Control != null)
            {

                Control.Layer.BorderWidth = 0;
                Control.BorderStyle = UITextBorderStyle.None;

            }

        }
    }
}