using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Soomla
{
    public class GoodBalanceChangedEvent : SoomlaEvent
    {

        private String mItemId;

        private int mBalance;

        private int mAmountAdded;

        public GoodBalanceChangedEvent(String itemId, int balance, int amountAdded) : base(null)
        {
            mItemId = itemId;
            mBalance = balance;
            mAmountAdded = amountAdded;
        }

        public GoodBalanceChangedEvent(String itemId, int balance, int amountAdded, Object sender) : base(null)
        {
            mItemId = itemId;
            mBalance = balance;
            mAmountAdded = amountAdded;
        }

        public String getGoodItemId()
        {
            return mItemId;
        }

        public int getBalance()
        {
            return mBalance;
        }

        public int getAmountAdded()
        {
            return mAmountAdded;
        }

    }
}
