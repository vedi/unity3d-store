using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Soomla
{
    public class ItemPurchaseStartedEvent : SoomlaEvent
    {
        private String mItemId;

        public ItemPurchaseStartedEvent(String itemId) : this(itemId, null)
        {

        }

        public ItemPurchaseStartedEvent(String itemId, Object sender) : base(sender)
        {
            mItemId = itemId;
        }

        public String getItemId()
        {
            return mItemId;
        }

    }
}
