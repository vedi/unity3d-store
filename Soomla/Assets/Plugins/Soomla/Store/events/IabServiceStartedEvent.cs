using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Soomla
{
    public class IabServiceStartedEvent : SoomlaEvent
    {

        public IabServiceStartedEvent() : this(null)
        {

        }

        public IabServiceStartedEvent(Object sender) : base(sender)
        {
        }
    }
}