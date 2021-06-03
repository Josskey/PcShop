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
using System.ComponentModel;

namespace PcShop
{
    /// <summary>
    /// Логика взаимодействия для ProgressBar.xaml
    /// </summary>
    public partial class ProgressBar : Window, INotifyPropertyChanged
    {
        private BackgroundWorker _bgdWorker = new BackgroundWorker();

        private int _workerState;

        public event PropertyChangedEventHandler PropertyChanged;

        public int WorkerState
        {
            get { return _workerState; }
            set
            {
                _workerState = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("WorkerState"));
            }
        }
        public ProgressBar()
        {
            InitializeComponent();

            DataContext = this;

            _bgdWorker.DoWork += (s, e) =>
                {
                  for (int i = 0; i <= 100;i++)
                    {
                        System.Threading.Thread.Sleep(30);
                        WorkerState = i;
                    }

                    Dispatcher.Invoke(() => {
                        PcShop.Reg r = new PcShop.Reg();
                        r.Show();
                        this.Close();
                    });
                };

            _bgdWorker.RunWorkerAsync();
        }
    }
}
