using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Editors.Settings;
using DevExpress.Xpf.Grid;
using DEVExpressDemo.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
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

namespace DEVExpressDemo
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Person person = new Person();
            property.SelectedObject = person;
        }

        private void ButtonEditSettings_DefaultButtonClick(object sender, RoutedEventArgs e)
        {
            WindowDialog dialog = new WindowDialog();
            if ((bool)dialog.ShowDialog())
            {
                Button button = sender as Button;
                Label label = button.Tag as Label;
                CustModel model = label.Tag as CustModel;
                //反射获取属性
                PropertyInfo[] propertyInfos = property.SelectedObject.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
                PropertyInfo modelInfo = null;

                foreach (var item in propertyInfos)
                {
                    if (item.GetValue(property.SelectedObject)== model)
                    {
                        modelInfo = item;
                    }
                }
                if (model != null && model != null && label != null&& modelInfo!=null)
                {
                    model.Name = dialog.GetText();
                    label.Content = model.Name;
                    modelInfo.SetValue(property.SelectedObject, model);
                }
            }
        }

        private void property_CellValueChanged(object sender, DevExpress.Xpf.PropertyGrid.CellValueChangedEventArgs args)
        {

        }
    }
}
