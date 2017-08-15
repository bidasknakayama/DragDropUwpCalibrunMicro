using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drag_Drop_CalibrunMicro.sampleDatas
{
    public class Category
    {
        public Category()
        {
            BookList = new ObservableCollection<Book>();
        }

        public string Name { get; set; }
        public ObservableCollection<Book> BookList { get; set; }
    }
}
