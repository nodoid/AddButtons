using System.Drawing;
using Foundation;
using UIKit;

namespace AddButtons
{
    public partial class AddButtonsViewController : UIViewController
    {
        public AddButtonsViewController() : base("AddButtonsViewController", null)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            AddButtons();
            AddActionSheet();
        }

        private void AddButtons()
        {
            UIView temp = new UIView(new RectangleF(0, 0, (5 * 75), 60));
            for (int i = 0; i < 5; ++i)
            {

                UIButton btn = new UIButton(new RectangleF(0 + (75 * i), 0, 75, 60))
                {
                    BackgroundColor = UIColor.Blue,
                };
                btn.Layer.BorderWidth = 2.0f;
                btn.Layer.BorderColor = UIColor.Green.CGColor;

                btn.SetTitle("Button " + i.ToString(), UIControlState.Normal);
                using (NSAutoreleasePool pool = new NSAutoreleasePool())
                {
                    InvokeOnMainThread(() =>
                    {
                        temp.AddSubview(btn);
                    });
                }
            }
            uiScrollView.ContentSize = temp.Frame.Size;
            uiScrollView.IndicatorStyle = UIScrollViewIndicatorStyle.White;
            uiScrollView.AddSubview(temp);
        }

        private void AddActionSheet()
        {
            UIActionSheet sheet = new UIActionSheet(new RectangleF(0, 350, 320, 50))
            {
                BackgroundColor = UIColor.White,
            };
            UITabBar tabBar = new UITabBar(new Rectangle(0, 0, 320, 49));
            sheet.AddSubview(tabBar);
            View.AddSubview(sheet);
        }
    }
}

