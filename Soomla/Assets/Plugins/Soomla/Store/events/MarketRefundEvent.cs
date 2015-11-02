using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Soomla
{
    public class MarketRefundEvent : SoomlaEvent
    {

        private PurchasableVirtualItem mPurchasableVirtualItem;

        private String mPayload;

        public MarketRefundEvent(PurchasableVirtualItem purchasableVirtualItem, String payload): this(purchasableVirtualItem, payload, null)
        {
        }

        public MarketRefundEvent(PurchasableVirtualItem purchasableVirtualItem, String payload, Object sender):base(sender)
        {
            mPurchasableVirtualItem = purchasableVirtualItem;
            mPayload = payload;
        }

        public PurchasableVirtualItem getPurchasableVirtualItem()
        {
            return mPurchasableVirtualItem;
        }

        public String getPayload()
        {
            return mPayload;
        }
    }
}