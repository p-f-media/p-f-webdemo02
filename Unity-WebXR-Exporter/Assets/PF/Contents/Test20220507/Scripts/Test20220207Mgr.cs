using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test20220207Mgr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButton(string msg) {
        Debug.Log($"@OnButton(msg:{msg})");
    }
}
