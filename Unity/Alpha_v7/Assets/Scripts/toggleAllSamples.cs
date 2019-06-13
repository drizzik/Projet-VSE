using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleAllSamples : MonoBehaviour {
    static bool isStarted;

    public LibPdInstance pdPatch;

    private void Start()
    {
        isStarted = false;
    }

    public void toggleMusic()
    {
        if (!isStarted)
        {
            pdPatch.SendBang("playToggle");
            isStarted = true;
        }
    }
}
