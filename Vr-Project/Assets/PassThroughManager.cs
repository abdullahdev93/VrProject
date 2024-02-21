using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassThroughManager : MonoBehaviour
{
    public OVRManager ovrManager;
    // Start is called before the first frame update
    void Start()
    {
        ovrManager.isInsightPassthroughEnabled = true;
        RenderSettings.ambientMode = UnityEngine.Rendering.AmbientMode.Flat;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
