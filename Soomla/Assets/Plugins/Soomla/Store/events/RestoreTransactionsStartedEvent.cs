using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Soomla
{
    public class RestoreTransactionsStartedEvent : SoomlaEvent
    {

        public RestoreTransactionsStartedEvent() : this(null)
        {

        }

        public RestoreTransactionsStartedEvent(Object sender) : base(sender)
        {

        }
    }
}
