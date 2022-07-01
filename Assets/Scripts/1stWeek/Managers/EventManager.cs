using System;
using UnityEngine.Events;
public class EventManager : MonoSingleton<EventManager>
{
  //  #region Singleton
//
  //  public static EventManager Instance;
//
  //  private void Awake()
  //  {
  //      if (Instance != null && Instance != this)
  //      {
  //          Destroy(gameObject);
  //          return;
  //      }
  //      Instance = this;
  //  }
  //  #endregion

  public UnityAction<InputParams> onInputDragged = delegate {  };
  public UnityAction<InputParamaters> onInputDrag = delegate {  };
  
  public UnityAction<int> onDoorwayTriggerEnter = delegate { };
  public UnityAction<int> onDoorwayTriggerExit = delegate { };
  // public UnityAction onObjeTemasEdince;

}
