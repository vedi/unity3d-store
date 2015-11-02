using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Soomla
{
    public class GoodUpgradeEvent : SoomlaEvent
    {
        private String mItemId;

        private String mCurrentUpgradeItemId;

        public GoodUpgradeEvent(String itemId, String upgradeVGItemId) : this(itemId, upgradeVGItemId, null)
        {

        }

        public GoodUpgradeEvent(String itemId, String upgradeVGItemId, Object sender) : base(sender)
        {
            mItemId = itemId;
            mCurrentUpgradeItemId = upgradeVGItemId;
        }

        public String getGoodItemId()
        {
            return mItemId;
        }

        public String getCurrentUpgrade()
        {
            return mCurrentUpgradeItemId;
        }
    }
}
