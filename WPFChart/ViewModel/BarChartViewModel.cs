using System.Collections.Generic;

namespace WPFChart.ViewModel
{
    public class BarChartViewModel:ViewModelBase
    {
        private List<DataModel> _DataCollection = new List<DataModel>();

        public BarChartViewModel()
        {
            DataCollection.Add(new DataModel(){ Key = "C#", Value = 50});
            DataCollection.Add(new DataModel(){ Key = "Python", Value = 20});
            DataCollection.Add(new DataModel(){ Key = "SQL", Value = 30});
        }

        public List<DataModel> DataCollection
        {
            get
            {
                return _DataCollection;
            }
            set
            {
                _DataCollection = value;
                OnPropertyChanged();
            }
        }

    }

    public class DataModel
    {
        public string Key { get; set; }
        public int Value { get; set; }
    }
}