
# WebviewApp

WebviewApp is a cross-platform mobile application developed using Xamarin.Forms. This app demonstrates how to load and display local HTML content within a WebView. It supports the inclusion of CSS styles and JavaScript scripts to enrich the web content presented to the user.

## Features

- **Load Local HTML** : The app can load and display HTML files stored locally within the application's resources.
- **Support for CSS and JavaScript** : Along with HTML, the app supports CSS for styling and JavaScript for interactive functionality, enhancing the user experience.
- **Cross-Platform** : Built with Xamarin.Forms, the app runs on both Android and iOS platforms.
## Use Cases

- **Educational Purposes** : Ideal for learning how to integrate WebView in Xamarin.Forms and how to load local HTML content.
- **Content Display** : Suitable for apps that need to display static web content, such as help pages, tutorials, or offline documentation.
- **Prototyping** : Useful for rapidly prototyping web-based UI designs within a mobile app framework.

## Requirements

- Visual Studio with Xamarin support.
- Android SDK and emulator or physical device for testing.

## Project Structure

```
Webview/
├── Webview.sln
├── Webview/
│   ├── App.xaml
│   ├── App.xaml.cs
│   ├── MainPage.xaml
│   ├── MainPage.xaml.cs
│   ├── IBaseUrl.cs
│   └── Resources/
│       ├── index.html
│       ├── styles.css
│       └── script.js
├── Webview.Android/
    ├── Assets/
    └── BaseUrl_Android.cs
```

## Getting Started

Follow these instructions to get a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

- Visual Studio with Xamarin installed.
- Android SDK.
- An Android emulator or a physical Android device.

### Installing

1. **Clone the repository:**

   ```sh
   git clone https://github.com/bumbitzu/WebviewApp.git
   cd WebviewApp
   ```

2. **Open the solution:**

   Open `Webview.sln` in Visual Studio.

3. **Build the project:**

   Build the solution to restore the necessary NuGet packages.

4. **Run the project:**

   Select the Android project as the startup project and run it on an emulator or physical device.

## Contributing

Please read [CONTRIBUTING.md](https://github.com/bumbitzu/WebviewApp/blob/master/CONTRIBUTING.md) for details on our code of conduct, and the process for submitting pull requests to us.

## Authors

   - *Initial work* - [bumbitzu](https://github.com/bumbitzu)

See also the list of [contributors](https://github.com/bumbitzu/WebviewApp/contributors) who participated in this project.

## License

This project is licensed under the MIT License - see the [LICENSE.txt](LICENSE.txt) file for details.

## Screenshots
![Alt text](https://raw.githubusercontent.com/bumbitzu/WebviewApp/master/Capture.png)
