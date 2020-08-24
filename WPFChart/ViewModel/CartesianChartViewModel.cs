using LiveCharts;
using LiveCharts.Wpf;

namespace WPFChart.ViewModel
{
    public class CartesianChartViewModel:ViewModelBase
    {
        #region Declarations
        private SeriesCollection _Data;
        #endregion

        #region Property
        public SeriesCollection Data
        {
            get
            {
                return _Data;
            }
            set
            {
                _Data = value;
            }
        }
        #endregion

        #region Memberfunction
        public CartesianChartViewModel()
        {
            Data = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<double> { 3, 5, 7, 4 }
                },
                new ColumnSeries                
                {
                    Values = new ChartValues<decimal> { 5, 6, 2, 7 }
                }
            };
        }
        #endregion
    }
}