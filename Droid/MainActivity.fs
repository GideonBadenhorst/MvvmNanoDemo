﻿namespace MvvmNanoDemo.Droid
open System

open Android.App
open Android.Content
open Android.Content.PM
open Android.Runtime
open Android.Views
open Android.Widget
open Android.OS

[<Activity (Label = "MvvmNanoDemo.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = (ConfigChanges.ScreenSize ||| ConfigChanges.Orientation))>]
type MainActivity() =
    inherit Xamarin.Forms.Platform.Android.FormsApplicationActivity()
    override this.OnCreate (bundle: Bundle) =
        base.OnCreate (bundle)

        Xamarin.Forms.Forms.Init (this, bundle)

        this.LoadApplication (new MvvmNanoDemo.App ())

