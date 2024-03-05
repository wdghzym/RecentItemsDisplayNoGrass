using Modding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.IO.LowLevel.Unsafe;

namespace RecentItemsDisplayNoGrass
{
    public class RecentItemsDisplayNoGrass:Mod
    {
        public RecentItemsDisplayNoGrass() { }
        public override string GetVersion()
        {
            return GetType().Assembly.GetName().Version.ToString();
        }
        public override int LoadPriority() => 5;
        public override void Initialize()
        {

            base.Initialize();
            RecentItemsDisplay.Events.ModifyDisplayItem += Events_ModifyDisplayItem;
        }

        private void Events_ModifyDisplayItem(RecentItemsDisplay.ItemDisplayArgs obj)
        {
            if (obj != null)
                if (obj.DisplayName=="Grass")
                    obj.IgnoreItem = true;
        }
    }
}
