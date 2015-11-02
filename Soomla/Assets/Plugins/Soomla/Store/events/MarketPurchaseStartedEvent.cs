using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Soomla
{
    public class MarketPurchaseStartedEvent : SoomlaEvent
    {
        private PurchasableVirtualItem mPurchasableVirtualItem;
        private boolean mFraudProtection;

        public MarketPurchaseStartedEvent(PurchasableVirtualItem purchasableVirtualItem) : this(purchasableVirtualItem, false, null)
        {
        }

        public MarketPurchaseStartedEvent(PurchasableVirtualItem purchasableVirtualItem, boolean fraudProtection) : this(purchasableVirtualItem, fraudProtection, null)
        {
        }

        public MarketPurchaseStartedEvent(PurchasableVirtualItem purchasableVirtualItem, Object sender) : this(purchasableVirtualItem, false, sender)
        {
        }

        public MarketPurchaseStartedEvent(PurchasableVirtualItem purchasableVirtualItem, boolean fraudProtection, Object sender) : base(sender)
        {
            mPurchasableVirtualItem = purchasableVirtualItem;
            mFraudProtection = fraudProtection;
        }

        public PurchasableVirtualItem getPurchasableVirtualItem()
        {
            return mPurchasableVirtualItem;
        }

        public boolean isFraudProtection()
        {
            return mFraudProtection;
        }
    }
}