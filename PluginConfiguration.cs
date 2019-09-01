#region Configuration
using Rocket.API;
using System.Collections.Generic;

namespace ItemRestrictorAdvanced
{
    public class PluginConfiguration : IRocketPluginConfiguration
    {
        public bool Enabled;
        public List<Group> Groups;
        public void LoadDefaults()
        {
            Groups = new List<Group>
            {
                new Group()
                {
                    GroupID = "default",
                    BoxLimit = 3
                },
                new Group()
                {
                    GroupID = "vip",
                    BoxLimit = 5
                },
            };
            Enabled = true;
        }
    }
}
#endregion Configuration
