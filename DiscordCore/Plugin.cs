using FizzyUtils;
using IPA;

namespace DiscordCore
{
    [Plugin(RuntimeOptions.SingleStartInit)]
    public class Plugin
    {
        internal const string Name = "DiscordCore";
        internal static IPA.Logging.Logger log;

        UsageTracker.UsageTrackerUser usageTrackerUser;

        [Init]
        public void Init(IPA.Logging.Logger log)
        {
            Plugin.log = log;
            DiscordManager manager = DiscordManager.instance;

            usageTrackerUser = Utils.usageTracker.AddUser(Name);
        }

        [OnEnable, OnDisable]
        public void OnState() { /* On State */ }
    }
}
