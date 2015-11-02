using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Soomla
{
    public class SoomlaStoreInitializedEvent : SoomlaEvent
    {
        public SoomlaStoreInitializedEvent() : this(null)
        {
        }

        public SoomlaStoreInitializedEvent(Object sender) : base(sender)
        {

        }
    }
}
