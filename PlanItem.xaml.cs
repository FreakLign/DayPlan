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
    /// PlanItem.xaml 的交互逻辑
    /// </summary>
    public partial class PlanItem : UserControl
    {
        PlanItemContent _content = new PlanItemContent();
        public PlanItem()
        {
            InitializeComponent();
            this.DataContext = _content;
        }
        public PlanItem(string HeadText, string MoreInfo, string Date)
        {
            InitializeComponent();
            this.DataContext = _content;
            _content.PlanItemHeader = HeadText;
            _content.MoreInfo = MoreInfo;
            _content.PlanTime = Date;
        }
        public class PlanItemContent : INotifyPropertyChanged
        {
            private string _planItemContent;
            private string _planTime;
            private string _moreInfo;
            public string PlanItemHeader
            {
                get { return _planItemContent; }
                set
                {
                    _planItemContent = value;
                    if (PropertyChanged != null) PropertyChanged.Invoke(this, new PropertyChangedEventArgs("PlanItemContent"));
                }
            }
            public string PlanTime
            {
                get { return _planTime; }
                set
                {
                    _planTime = value;
                    if (PropertyChanged != null) PropertyChanged.Invoke(this, new PropertyChangedEventArgs("PlanTime"));
                }
            }
            public string MoreInfo
            {
                get { return _moreInfo; }
                set
                {
                    _moreInfo = value;
                    if (PropertyChanged != null) PropertyChanged.Invoke(this, new PropertyChangedEventArgs("MoreInfo"));
                }
            }
            public event PropertyChangedEventHandler PropertyChanged;
        }
    }
}
