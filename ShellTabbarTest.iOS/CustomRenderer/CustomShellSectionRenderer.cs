using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace ShellTabbarTest.iOS.CustomRenderer
{
    public class CustomShellSectionRenderer : ShellSectionRenderer
    {

        public CustomShellSectionRenderer(IShellContext context) : base(context)
        { }

        protected override IShellSectionRootRenderer CreateShellSectionRootRenderer(ShellSection shellSection, IShellContext shellContext)
        {
            var renderer = new CustomShellSectionRootRenderer(shellSection, shellContext);

            return renderer;
        }
    }
}