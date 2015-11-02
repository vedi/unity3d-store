using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Soomla
{
    public class GoodUnEquippedEvent : SoomlaEvent
    {
        private String mItemId;

        public GoodUnEquippedEvent(String itemId) : this(itemId, null)
        {
        }

        public GoodUnEquippedEvent(String itemId, Object sender) : base(sender)
        {
            mItemId = itemId;
        }

        public String getGoodItemId()
        {
            return mItemId;
        }

    }
}
