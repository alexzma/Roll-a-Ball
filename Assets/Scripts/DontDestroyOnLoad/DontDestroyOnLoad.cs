using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour {

    bool created = false;

    private void Awake()
    {
        if (!created){
            DontDestroyOnLoad(this.gameObject);
            created = true;
        }
    }

}
