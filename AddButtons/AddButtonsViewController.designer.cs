// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//

using Foundation;
using UIKit;

namespace AddButtons
{
    [Register("AddButtonsViewController")]
    partial class AddButtonsViewController
    {
        [Outlet]
        UIScrollView uiScrollView { get; set; }

        void ReleaseDesignerOutlets()
        {
            if (uiScrollView != null)
            {
                uiScrollView.Dispose();
                uiScrollView = null;
            }
        }
    }
}
