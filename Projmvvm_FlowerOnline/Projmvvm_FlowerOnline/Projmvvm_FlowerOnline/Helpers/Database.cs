using Projmvvm_FlowerOnline.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Projmvvm_FlowerOnline.Helpers
{
    public class Database
    {
        string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        public Database() 
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder
                             , "qlhoa.db")))
                {
                    connection.CreateTable<Loaihoa>();
                    connection.CreateTable<Hoa>();
                }
            }
            catch 
            { }
            
        }
        public List<Loaihoa> GetLoaihoas()
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder
                             , "qlhoa.db")))
                {
                    return connection.Table<Loaihoa>().ToList();
                }
            }
            catch (SQLiteException ex)
            {
                return null;
            }
        }
        public Loaihoa GetLoaihoaByid(int Maloai)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder
                             , "qlhoa.db")))
                {
                    var dsh = from lhs in connection.Table<Loaihoa>().ToList()
                             where lhs.Maloai == Maloai
                             select lhs;
                    return dsh.ToList<Loaihoa>().FirstOrDefault();
                }
            }
            catch (SQLiteException ex)
            {
                return null;
            }
        }

        public bool InsertLoaihoa(Loaihoa loai)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder
                             , "qlhoa.db")))
                {
                    connection.Insert(loai);
                    return true;

                }
            }
            catch (SQLiteException ex)
            {
                return false;
            }
        }
        public bool UpdateLoaihoa(Loaihoa loai)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder
                             , "qlhoa.db")))
                {
                    connection.Update(loai);
                    return true;

                }
            }
            catch (SQLiteException ex)
            {
                return false;
            }
        }
        public bool DeleteLoaihoa(Loaihoa loai)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder
                             , "qlhoa.db")))
                {
                    connection.Delete(loai);
                    return true;

                }
            }
            catch (SQLiteException ex)
            {
                return false;
            }
        }
    }

}