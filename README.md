# How to validate the controls in Xamarin.Forms

If any user interface enterprise application receives the input, our common requirement will be to validate the provided information (such as Email address, password, phone number) whether it satisfies the desired format and range for further processing. You can validate the data in user interface control by using the built-in validations such as `INotifyDataErrorInfo` and Data annotation while following the MVVM pattern.

## Requirements to run the sample

This section describes the system requirements of Syncfusion® Xamarin Controls for development.

* Windows 10 & later
* Android 4.1 & later
* iOS 9 & later
* macOS 10.11 and later versions
* Visual Studio 2022: Xamarin support was included in Visual Studio 2022 (version 17.0 and later) and Visual Studio 2022 for Mac (version 17.0 and later).

Refer to the following link for more details - [System Requirements](https://help.syncfusion.com/xamarin/system-requirements)

## How to run the sample

1. Clone the sample and open it in Visual Studio.

   *Note: If you download the sample using the "Download ZIP" option, right-click it, select Properties, and then select Unblock.*

2. Register your license key in the App.cs file as demonstrated in the following code.

    public App()
    {
        //Register Syncfusion<sup>®</sup> license
        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY");

        InitializeComponent();

        MainPage = new App1.MainPage();
    }

    Refer to this [link](https://help.syncfusion.com/xamarin/licensing/overview) for more details.

3. Clean and build the application.

4. Run the application.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.