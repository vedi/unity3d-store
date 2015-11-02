using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Soomla
{
    public class MarketItemsRefreshStartedEvent : SoomlaEvent
    {
        public MarketItemsRefreshStartedEvent() : this(null)
        {
        }

        public MarketItemsRefreshStartedEvent(Object sender) : base(sender)
        {

        }
    }
}