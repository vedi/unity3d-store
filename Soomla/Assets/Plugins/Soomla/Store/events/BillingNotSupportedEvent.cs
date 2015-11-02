using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Soomla
{
    public class BillingNotSupportedEvent : SoomlaEvent
    {
        public BillingNotSupportedEvent(): this(null)
        {

        }

        public BillingNotSupportedEvent(Object sender) : base(sender)
        {

        }
    }
}
