using System.ComponentModel;

namespace AvaloniaCommandSample
{
    public class Counter : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }


        #region Count Property
        private int _count = 1;
        public int Count
        {
            get
            {
                return this._count;
            }
            set
            {
                if (this._count == value)
                {
                    return;
                }

                this._count = value;
                this.OnPropertyChanged(nameof(Count));
                this.OnPropertyChanged(nameof(CanIncreaseCount));
            }
        }
        #endregion Count Property


        public bool CanIncreaseCount =>
            Count < 10;


        public void IncreaseCount()
        {
            Count++;
        }

        public Counter()
        {
            this.OnPropertyChanged(nameof(CanIncreaseCount));
        }
    }
}
