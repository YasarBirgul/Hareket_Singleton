
using System;
using UnityEngine;

namespace observer
{ 
    public abstract class Observer : MonoBehaviour
    {
        public abstract void OnNotify(NotificationType notificationType);
        
    }

}
