using System;
using CoreGraphics;
using Foundation;
using UIKit;
using Xamarin.Forms.Platform.iOS;

namespace ShellTabbarTest.iOS.CustomRenderer
{
    public class CustomShellSectionRootHeader : ShellSectionRootHeader
    {
        public CustomShellSectionRootHeader(IShellContext context) : base(context)
        {

        }

        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            var cell = base.GetCell(collectionView, indexPath) as ShellSectionHeaderCell;
            cell.Label.Font = UIFont.FromName("Roboto-Regular", 20.0F); // unselected
            return cell;
        }
    }
}
