using UnityEngine;
using System.Collections;

public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T> {

    private static T instance;
    public static T Instance {
        get {
            if (instance == null) {
                instance = (T)FindObjectOfType (typeof(T));
            }
            return instance;
        }
    }

    protected void Awake()
    {
        CheckInstance();
    }

    protected bool CheckInstance()
    {
        if( this == Instance){ return true; }
        Destroy(this);
        return false;
    }
}
