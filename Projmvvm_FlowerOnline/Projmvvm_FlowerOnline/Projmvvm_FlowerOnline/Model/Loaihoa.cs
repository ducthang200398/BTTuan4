using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Projmvvm_FlowerOnline.Model
{
    public class Loaihoa 
    {
        [PrimaryKey, AutoIncrement]
       
        public int Maloai { get; set; }
        public string Tenloai { get; set; }
    }
}