using System;
using System.Collections.Generic;
using UnityEngine;

namespace observer
{ 
    public class ObserverManager : MonoBehaviour
    {
        #region Singleton

        private static ObserverManager _instance = null;

        public static ObserverManager instance = _instance;

        #endregion

        private List<Subject> _subjects = null;

        public void RegisterSubject(Subject subject) 
        {
            if (_subjects == null)
                _subjects = new List<Subject>();
            
            _subjects.Add(subject);
        }
        private void Awake()
        {
            _instance = this;
        }

        public void RegisterObserver(Observer observer,SubjectType subjectType)
        {
            foreach (var subject in _subjects)
            {
                if (subject.SubjectType == subjectType)
                {
                    subject.RegisterObserver(observer);
                }
            }
            
        }
    }

    
    
    public enum NotificationType
    {
        ForwardButton,
        BackButton,
        LeftButton,
        RightButton
        
    }
    
    public enum SubjectType
    {
        MovementPanel
    }
}
