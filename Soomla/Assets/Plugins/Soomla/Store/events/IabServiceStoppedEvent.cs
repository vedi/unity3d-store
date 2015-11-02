using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Soomla
{
    public class IabServiceStoppedEvent : SoomlaEvent
    {

        public IabServiceStoppedEvent() : this(null)
        {

        }

        public IabServiceStoppedEvent(Object sender) : base(sender)
        {
        }
    }
}