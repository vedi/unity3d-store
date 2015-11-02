using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Soomla
{
    public class GoodEquippedEvent : SoomlaEvent
    {
        private String mItemId;

        public GoodEquippedEvent(String itemId) : base(null)
        {
            mItemId = itemId;
        }

        public GoodEquippedEvent(String itemId, Object sender) : base(sender)
        {
            mItemId = itemId;
        }

        public String getGoodItemId()
        {
            return mItemId;
        }

    }
}
