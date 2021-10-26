using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SingletonOnDemand<T> : MonoBehaviour where T : MonoBehaviour
{
  private static T instance;
  private static bool singletonIsDestroyed = false;
  public static T Instance
  {
    get
    {
      if (singletonIsDestroyed)
      {
        return null;
      }

      if (!instance)
      {
        new GameObject(typeof(T).ToString()).AddComponent<T>();
      }

      return instance;
    }
  }
  protected void Awake()
  {
    if (instance == null && !singletonIsDestroyed)
    {
      instance = this as T;
    }
    else if (instance != this)
    {
      Destroy(this);
    }
  }

  protected void OnDestroy()
  {
    if (instance != this)
    {
      return;
    }
    singletonIsDestroyed = true;
    instance = null;
  }
}
