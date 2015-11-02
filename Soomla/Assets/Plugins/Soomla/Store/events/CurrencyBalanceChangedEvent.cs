using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Soomla
{
    public class CurrencyBalanceChangedEvent : SoomlaEvent {
        private String mItemId;

        private int mBalance;

        private int mAmountAdded;

        public CurrencyBalanceChangedEvent(String itemId, int balance, int amountAdded) : base(null) {
            mItemId = itemId;
            mBalance = balance;
            mAmountAdded = amountAdded;
        }

        public CurrencyBalanceChangedEvent(String itemId, int balance, int amountAdded, Object sender) : base(null) {
            mItemId = itemId;
            mBalance = balance;
            mAmountAdded = amountAdded;
        }

        public String getCurrencyItemId() {
            return mItemId;
        }

        public int getBalance() {
            return mBalance;
        }

        public int getAmountAdded() {
            return mAmountAdded;
        }
    }
}
