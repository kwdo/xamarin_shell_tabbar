using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace ShellTabbarTest.iOS.CustomRenderer
{
    public class CustomShellSectionRootRenderer : ShellSectionRootRenderer
    {
        public CustomShellSectionRootRenderer(ShellSection section, IShellContext context) : base(section, context)
        { }

        protected override IShellSectionRootHeader CreateShellSectionRootHeader(IShellContext shellContext)
        {
            var renderer = new CustomShellSectionRootHeader(shellContext);
            return renderer;
        }
    }
}
