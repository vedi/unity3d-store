using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Soomla
{
    public class RestoreTransactionsFinishedEvent : SoomlaEvent
    {
        private boolean mSuccess;

        public RestoreTransactionsFinishedEvent(boolean success)
        {
            this(success, null);
        }

        public RestoreTransactionsFinishedEvent(boolean success, Object sender)
        {
            super(sender);
            mSuccess = success;
        }

        public boolean isSuccess()
        {
            return mSuccess;
        }
    }
}
