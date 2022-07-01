using System;
using UnityEngine;

namespace Singleton
{
    public class Singleton : MonoBehaviour
    {
        private static Singleton instance = null;

        private string text;

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GameObject("Single").AddComponent<Singleton>();
                }
                
                return instance;
            }
        }
        private void OnEnable()
        {
            instance = this;
        }
        
    }
}
