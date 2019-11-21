using Projmvvm_FlowerOnline.Interface;
using Projmvvm_FlowerOnline.Model;
using Projmvvm_FlowerOnline.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Projmvvm_FlowerOnline.ViewModel
{
    public class LoaihoaViewModel : INotifyPropertyChanged
    {

        private Loaihoa loaihoa;
        public ILoaihoaRepository loaihoaRepository;
        public ICommand AddLoaiHoa { get; private set; }
        public ICommand UpdateLoaiHoa { get; private set; }
        public ICommand DeleteLoaiHoa { get; private set; }
        public LoaihoaViewModel()
        {
            loaihoaRepository = new LoaihoaRepository();
            LoadLoaihao();
            AddLoaiHoa = new Command(Insert);
            UpdateLoaiHoa = new Command(Update, CanExe);
            DeleteLoaiHoa = new Command(Delete, CanExe);
            loaihoa = new Loaihoa();
        }

        private void Delete(object obj)
        {
            loaihoaRepository.Delete(loaihoa);
            LoadLoaihao();
        }

        private bool CanExe(object arg)
        {
            if (loaihoa == null || loaihoa.Maloai == 0)
                return false;
            else
                return true;
        }
        public Loaihoa Loaihoa
        {
            get { return loaihoa; }
            set { loaihoa = value;
                RaisePropertyChanged("Loaihoa");
                ((Command)UpdateLoaiHoa).ChangeCanExecute();
            }
        }
        private void Update(object obj)
        {
            loaihoaRepository.Update(loaihoa);
            LoadLoaihao();
        }

        private void Insert(object obj)
        {
            loaihoaRepository.Insert(loaihoa);
            LoadLoaihao();
        }
        public int  MaLoai
        { 
            get { return loaihoa.Maloai; }
            set
            {
                loaihoa.Maloai = value;
                RaisePropertyChanged("Loaihoa");
            }
        }
            public string Tenloai
        {
            get { return loaihoa.Tenloai; }
            set
            {
                loaihoa.Tenloai = value;
                RaisePropertyChanged("Tenloai");
            }
        }
        ObservableCollection<Loaihoa> loaihoalist;

        public ObservableCollection<Loaihoa> Loaihoalist
        {
            get { return loaihoalist; }
            set
            {
                loaihoalist = value;
                RaisePropertyChanged("Loaihoalist");
            }
        }
        void LoadLoaihao()
        {
            Loaihoalist = loaihoaRepository.GetLoaihoas();
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string PropertyName)
        {
        if (PropertyChanged != null)
            PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}