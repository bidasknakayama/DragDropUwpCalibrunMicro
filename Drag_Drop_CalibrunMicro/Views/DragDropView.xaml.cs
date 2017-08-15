using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

using Caliburn.Micro;
using Drag_Drop_CalibrunMicro.sampleDatas;
using Windows.ApplicationModel.DataTransfer;

// 空白ページの項目テンプレートについては、https://go.microsoft.com/fwlink/?LinkId=234238 を参照してください

namespace Drag_Drop_CalibrunMicro.Views
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class DragDropView : UserControl
    {

        Book draggedItem;

        public DragDropView()
        {
            this.InitializeComponent();
        }

        public void ItemsByCategory_DragItemsStarting(object sender, DragItemsStartingEventArgs e)
        {
            draggedItem = e.Items[0] as Book;
            e.Data.RequestedOperation = DataPackageOperation.Move;
        }
        public void VariableSizedWrapGrid_Drop(object sender, DragEventArgs e)
        {
            try
            {
                if (draggedItem != null)
                {
                    var sourceCategory = draggedItem.Cate;
                    var child = (((VariableSizedWrapGrid)sender).Children[0] as GridViewItem).Content as Book;
                    draggedItem.Cate = child.Cate;

                    child.Cate.BookList.Add(draggedItem);
                    sourceCategory.BookList.Remove(draggedItem);
                    draggedItem = null;
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void VariableSizedWrapGrid_DragOver(object sender, DragEventArgs e)
        {
            e.AcceptedOperation = Windows.ApplicationModel.DataTransfer.DataPackageOperation.Move;
        }
    }
}
