using Projmvvm_FlowerOnline.Helpers;
using Projmvvm_FlowerOnline.Interface;
using Projmvvm_FlowerOnline.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Projmvvm_FlowerOnline.Repository
{
    public class LoaihoaRepository : ILoaihoaRepository 
    {
        Database db;
        public LoaihoaRepository()
        {
            db = new Database();
        }

        public bool Delete(Loaihoa loaihoa)
        {
            return db.DeleteLoaihoa(loaihoa);
        }

        public Loaihoa GetLoaihoaByid(int Maloai)
        {
            return db.GetLoaihoaByid(Maloai);
        }

        public ObservableCollection<Loaihoa> GetLoaihoas()
        {
            return new ObservableCollection<Loaihoa>(db.GetLoaihoas());
        }

        public bool Insert(Loaihoa loaihoa)
        {
            return db.InsertLoaihoa(loaihoa);
        }

        public bool Update(Loaihoa loaihoa)
        {
            return db.UpdateLoaihoa(loaihoa);
        }
    }
}