using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InfoTaskWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //private void PlayButton_Click(object sender, RoutedEventArgs e)
        //{
        //    PlayVideo("D:\\____Файли з диску\\C# Python\\Программирование\\WPF_Projects\\InfoTaskWPF\\InfoTaskWPF\\735126.mp4");
        //}
        //private void PlayVideo(string filePath)
        //{
        //    try
        //    {
        //        // Set the source of the MediaElement to the video file
        //        Television.Source = new Uri(filePath, UriKind.RelativeOrAbsolute);
        //        // Play the video
        //        Television.Play();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error: {ex.Message}");
        //    }
        //}

        private async void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            await PlayVideoAsync("D:\\____Файли з диску\\C# Python\\Программирование\\WPF_Projects\\InfoTaskWPF\\InfoTaskWPF\\735126.mp4", Television);

            await PlayVideoAsync("D:\\____Файли з диску\\C# Python\\Программирование\\WPF_Projects\\InfoTaskWPF\\InfoTaskWPF\\retra.mp4", Television2);

        }

        private async Task PlayVideoAsync(string filePath, MediaElement mediaElement)
        {
            try
            {
                mediaElement.Source = new Uri(filePath, UriKind.RelativeOrAbsolute);
                await Task.Delay(100); // Delay to ensure UI update
                mediaElement.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}