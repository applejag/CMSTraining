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
    }
}