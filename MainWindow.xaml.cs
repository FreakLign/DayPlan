using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace DayPlan
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        DataBinding dataBinding = new DataBinding();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = dataBinding;
            
        }
        public void AddNewPlanItem(string PlanHeader, string TimeAtPlan, string PlanInfo)
        {
            PlanQueen.Children.Add(new PlanItem(PlanHeader, PlanInfo, TimeAtPlan));
        }
        public class DataBinding : INotifyPropertyChanged
        {
            private string _backgroundPictureSource = @"/pic1.jpg";
            public string BackGoundPicture
            {
                get { return _backgroundPictureSource; }
                set
                {
                    _backgroundPictureSource = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged.Invoke(this, new PropertyChangedEventArgs("BackGoundPicture"));
                    }
                }
            }
            public event PropertyChangedEventHandler PropertyChanged;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddNewPlanItem("Item", DateTime.Now.ToString(), "详细阐述日行的功能");
        }
    }
}
