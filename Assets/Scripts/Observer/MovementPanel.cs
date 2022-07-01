using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace observer
{
  public class MovementPanel : MonoBehaviour
  {
   // public static event Action OnforwardButtonClicked;
   // public static event Action OnBackButtonClicked;
   // public static event Action OnRightButtonClicked;
   // public static event Action OnLeftButtonClicked;
   
   public static event Action<Vector3> OnbuttonClicked;
    public void ForwardOnclick()
    {
     // OnforwardButtonClicked?.Invoke();
     OnbuttonClicked?.Invoke(Vector3.forward);
    }
    public void BackOnclick()
    {
      // OnBackButtonClicked?.Invoke();
      OnbuttonClicked?.Invoke(Vector3.back);
    }
    public void RightOnclick()
    {
      // OnRightButtonClicked?.Invoke();
      OnbuttonClicked?.Invoke(Vector3.right);
    }
    public void LeftOnclick()
    {
      // OnLeftButtonClicked?.Invoke();
      OnbuttonClicked?.Invoke(Vector3.left);
    }
 
  }
}

