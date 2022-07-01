using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace observer
{ 
   public abstract class Subject : MonoBehaviour
   {
      private List<Observer> _observers = null;

      [SerializeField] private SubjectType _subjectType;

      public SubjectType SubjectType => _subjectType;
      
      public void RegisterObserver(Observer observer)
      {
         if (_observers == null)
            _observers = new List<Observer>();
         
            _observers.Add(observer);
      }

      private void Start()
      {
         ObserverManager.instance.RegisterSubject(this);
      }

      public void Notify(NotificationType notificationType)
      {
         foreach (var observer in _observers)
         {
            observer.OnNotify(notificationType);
         }
      }
   }
}

