using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test20220207Mgr : MonoBehaviour
{
        [SerializeField] VideoMgr videoMgr;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnButton(string msg) {
        Debug.Log($"@OnButton(msg:{msg})");
        videoMgr.Play_Streaming_PFDemo();
    }
}
