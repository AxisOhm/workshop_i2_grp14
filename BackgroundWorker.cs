using Blazor.BrowserExtension;
using System.Threading.Tasks;

namespace workshop_i1_grp14
{
    public partial class BackgroundWorker : BackgroundWorkerBase
    {
        [BackgroundWorkerMain]
        public override void Main()
        {
            WebExtensions.Runtime.OnInstalled.AddListener(OnInstalled);
        }

        async Task OnInstalled()
        {
            var indexPageUrl = WebExtensions.Runtime.GetURL("index.html");
            await WebExtensions.Tabs.Create(new()
            {
                Url = indexPageUrl
            });
        }
    }
}
