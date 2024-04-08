using Microsoft.Web.WebView2.Core;
using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            browser.Source = new Uri(@"C:\Users\lenovo\source\repos\WpfApp19\WpfApp1\index.html");
            InitializeAsync();
        }
        // Shared object between .NET and JavaScript
        public Sample _sample { get; set; } = new Sample();


        //protected override async void OnSourceInitialized(EventArgs e)
        //{
        //await   browser.EnsureCoreWebView2Async(null);
        //    browser.CoreWebView2.AddHostObjectToScript("dot", new DomManipulationDotnetInterop());
        //  //  browser.CoreWebView2.WebMessageReceived += MessageReceived;
        //    // browser.Source = new Uri("index.html");
        //}
        DomManipulationDotnetInterop DotnetInterop = new DomManipulationDotnetInterop();
        async void InitializeAsync()
        {
            await browser.EnsureCoreWebView2Async(null);
            browser.CoreWebView2.WebMessageReceived += MessageReceived;
            browser.CoreWebView2.AddHostObjectToScript("dotnet", new DomManipulationDotnetInterop());
        }
        void MessageReceived(object sender, CoreWebView2WebMessageReceivedEventArgs args)
        {

           // browser.get
            Console.WriteLine(args.TryGetWebMessageAsString());
        }
    }
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ComVisible(true)]
    public class DomManipulationDotnetInterop
    {
        public string Name { get; set; } = "Rick";
        public string Message { get; set; } = "Hello {0} from .NET. Time is: {1}";

        public string SayHello(string name)
        {
            string msg = string.Format(Message, name, DateTime.Now.ToString("t"));

            MessageBox.Show(msg, "WPF Message from JavaScript",
                            MessageBoxButton.OK, MessageBoxImage.Information);
            return msg;
        }
    }
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ComVisible(true)]
    public class Example
    {

        // Sample property.
        public string Prop { get; set; } = "example";
    }
    // Type must be public and ComVisible
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ComVisible(true)]
    public class Sample
    {
        public string Name { get; set; } = "meziantou";

        public int ClickCount { get; private set; }

        // Use [IndexerName] if you want to use an indexer from JavaScript
        [System.Runtime.CompilerServices.IndexerName("Items")]
        public int this[int index] => index;

        // Public methods are accessible from JS
        public void OnClick() { ClickCount++; Console.WriteLine(ClickCount); }
        // Public methods are accessible from JS
        public void click() { ClickCount++; Console.WriteLine(ClickCount); }

        // Task is not supported as return type. You need to use Task<T>. Otherwise, you get errors such as:
        // 'System.Threading.Tasks.VoidTaskResult' cannot be marshalled to a Variant.
        public async Task<int> DelayAsync(int milliseconds)
        {
            return 0;
        }
    }
}
