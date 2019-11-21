using Projmvvm_FlowerOnline.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Projmvvm_FlowerOnline.Interface
{
    public interface ILoaihoaRepository
    {
        ObservableCollection<Loaihoa> GetLoaihoas();
        Loaihoa GetLoaihoaByid(int Maloai);
        bool Insert(Loaihoa loaihoa);
        bool Delete(Loaihoa loaihoa);
        bool Update(Loaihoa loaihoa);
    }
}