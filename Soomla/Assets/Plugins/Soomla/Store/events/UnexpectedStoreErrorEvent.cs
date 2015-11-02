using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Soomla
{
    public class UnexpectedStoreErrorEvent : SoomlaEvent
    {
        public enum ErrorCode
        {
            GENERAL,
            VERIFICATION_TIMEOUT,
            VERIFICATION_FAIL,
            PURCHASE_FAIL
        }
        private readonly ErrorCode errorCode;

        public UnexpectedStoreErrorEvent(ErrorCode errorCode) : this(errorCode, null)
        {
        }

        public UnexpectedStoreErrorEvent() : this(ErrorCode.GENERAL, null)
        {
        }

        public UnexpectedStoreErrorEvent(ErrorCode errorCode, Object sender) : base(sender)
        {
            this.errorCode = errorCode;
        }

        public ErrorCode getErrorCode()
        {
            return errorCode;
        }
    }
}
