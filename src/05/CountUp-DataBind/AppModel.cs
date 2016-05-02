using System.ComponentModel;

namespace CountUp
{
    public class AppModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int currentValue;

        /// <summary>
        /// 現在値。
        /// </summary>
        public int CurrentValue {
            get
            {
                return currentValue;
            }
            set
            {
                if (currentValue != value)
                {
                    currentValue = value;

                    PropertyChanged?.Invoke(
                        this,
                        new PropertyChangedEventArgs(nameof(CurrentValue))
                        );
                }
            }
        }

        /// <summary>
        /// AppModelクラスの新しいインスタンスを初期化します。
        /// </summary>
        /// <param name="initialValue">初期値。</param>
        public AppModel(int initialValue)
        {
            CurrentValue = initialValue;
        }
    }
}
