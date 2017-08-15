using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Drag_Drop_CalibrunMicro.sampleDatas;
using Caliburn.Micro;
using System.Collections.ObjectModel;

namespace Drag_Drop_CalibrunMicro.ViewModels
{
    class DragDropViewModel : Screen
    {

        SampleData sd = new SampleData();


        public DragDropViewModel()
        {
            categoryCollectionViewSource = sd.GetCategoryDataSource();
            bookCollectionViewSource = sd.GetBookDataSource();
        }

        public ObservableCollection<Category> categoryCollectionViewSource
        {
            get { return _categoryCollectionViewSource; }
            set
            {
                this.Set(ref _categoryCollectionViewSource, value);
            }
        }
        public ObservableCollection<Book> bookCollectionViewSource
        {
            get { return _bookCollectionViewSource; }
            set
            {
                this.Set(ref _bookCollectionViewSource, value);
            }
        }

        private ObservableCollection<Category> _categoryCollectionViewSource;
        private ObservableCollection<Book> _bookCollectionViewSource;


    }
}