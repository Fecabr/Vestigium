using System;
using UnityEngine;
using UnityEngine.Events;

public class TouchableObject : MonoBehaviour {

    [Serializable]
    public class TouchEvent : UnityEvent { }

    [SerializeField]
    private TouchEvent OnTouch = new TouchEvent();

    public TouchEvent OnTouchEvent
    {
        get
        {
            return OnTouch;
        }
        set
        {
            OnTouch = value;
        }
    }

    public void Touch()
    {
        OnTouch.Invoke();
    }
}
