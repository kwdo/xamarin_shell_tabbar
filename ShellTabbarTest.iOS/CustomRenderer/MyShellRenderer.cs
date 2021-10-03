using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ShellTabbarTest.AppShell), typeof(ShellTabbarTest.iOS.CustomRenderer.MyShellRenderer))]
namespace ShellTabbarTest.iOS.CustomRenderer
{
    class MyShellRenderer : ShellRenderer
    {
        protected override IShellSectionRenderer CreateShellSectionRenderer(ShellSection shellSection)
        {
            var shellSectionRenderer = new CustomShellSectionRenderer(this);
            return shellSectionRenderer;
        }
    }
}