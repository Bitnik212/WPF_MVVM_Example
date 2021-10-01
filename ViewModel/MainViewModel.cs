
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_MVVM_Example.ViewModel
{
    public class MainViewModel : ViewModelBase
    {

        private int _Clicks;
        public int Clicks
        {
            get { return _Clicks; }
            set
            {
                _Clicks = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddClick
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    Clicks++;
                }, o => _Clicks < 10);
            }
        }

    }
}