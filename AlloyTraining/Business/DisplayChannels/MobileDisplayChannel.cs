using System.Web;
using EPiServer.Framework.Web;
using EPiServer.Web;

namespace AlloyTraining.Business.DisplayChannels
{
    public class MobileDisplayChannel : DisplayChannel
    {
        public override bool IsActive(HttpContextBase context)
        {
            return context.Request.Browser.IsMobileDevice;
        }

        public override string ChannelName => RenderingTags.Mobile;

        public override string ResolutionId => IPhone5.ResolutionId;
    }

    // ReSharper disable once InconsistentNaming
    public class IPhone5 : IDisplayResolution
    {
        public const string ResolutionId = "iphone5";

        public string Id => ResolutionId;
        public string Name => "iPhone 5 (320 x 568)";
        public int Width => 320;
        public int Height => 568;
    }

    // ReSharper disable once InconsistentNaming
    public class IPhone4 : IDisplayResolution
    {
        public const string ResolutionId = "iphone4";

        public string Id => ResolutionId;
        public string Name => "iPhone 4 (320 x 480)";
        public int Width => 320;
        public int Height => 480;
    }
}