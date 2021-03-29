using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MCDSaveEdit
{
    /// <summary>
    /// Interaction logic for AesKeyWindow.xaml
    /// </summary>
    public partial class AesKeyWindow : Window
    {
        public enum AesKeyWindowResult
        {
            changeFilesPath,
            tryAgain,
            skip
        }

        public AesKeyWindowResult result;

        public AesKeyWindow()
        {
            InitializeComponent();
        }
        private void changeFilesPathButton_Click(object sender, RoutedEventArgs e)
        {
            result = AesKeyWindowResult.changeFilesPath;
            this.Close();
        }

        private void tryAgainButton_Click(object sender, RoutedEventArgs e)
        {
            Secrets.SetAesKey(keyTextBox.Text);
            result = AesKeyWindowResult.tryAgain;
            this.Close();
        }

        private void skipButton_Click(object sender, RoutedEventArgs e)
        {
            result = AesKeyWindowResult.skip;
            this.Close();
        }

    }
}
