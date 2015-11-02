
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Soomla
{
    public class ItemPurchasedEvent : SoomlaEvent
    {
        private String mItemId;
        private String mPayload;

        public ItemPurchasedEvent(String itemId, String payload) : this(itemId, payload, null)
        {

        }

        public ItemPurchasedEvent(String itemId, String payload, Object sender) : base(sender)
        {
            mItemId = itemId;
            mPayload = payload;
        }

        public String getItemId()
        {
            return mItemId;
        }

        public String getPayload()
        {
            return mPayload;
        }

    }
}