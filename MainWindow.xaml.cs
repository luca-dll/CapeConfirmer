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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace Cape_Confirmer
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StreamReader reader = new StreamReader(File.OpenRead($"C:/Users/{Environment.UserName}/AppData/Roaming/.minecraft/optionsof.txt"));

            string fileContent = reader.ReadToEnd();

            reader.Close();

            fileContent = fileContent.Replace("ofShowCapes:false", "ofShowCapes:true");

            StreamWriter writer = new StreamWriter(File.OpenWrite($"C:/Users/{Environment.UserName}/AppData/Roaming/.minecraft/optionsof.txt"));

            writer.Write(fileContent);

            writer.Close();

            // placeholder for other chunk of minecraft video settings code (not optifine txt file)

            StreamReader readerr = new StreamReader(File.OpenRead($"C:/Users/{Environment.UserName}/AppData/Roaming/.minecraft/options.txt"));

            string fileContentt = readerr.ReadToEnd();

            readerr.Close();

            fileContentt = fileContentt.Replace("showCape:false", "showCape:true");

            StreamWriter writerr = new StreamWriter(File.OpenWrite($"C:/Users/{Environment.UserName}/AppData/Roaming/.minecraft/options.txt"));

            writerr.Write(fileContentt);

            writerr.Close();

            MessageBox.Show("Cape Confirmer has run successfully! - luca-dll#9326");

        }
    }
}
