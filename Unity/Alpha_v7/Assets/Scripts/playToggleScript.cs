using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playToggleScript : MonoBehaviour {

    public LibPdInstance pdPatch;
    public int drumId; // 1 KICK 2 SNARE 3 HAT

    //public masterVolumeController volume;

    private void Start()
    {
    }

    public void playSample()
    {
        //volume.isPlaying(true);
        //volume.resendVolume();

        string name = "vol" + drumId.ToString() + "stop";
        Debug.Log(name);
        pdPatch.SendFloat(name, 127);
    }
    public void stopSample()
    {
        //volume.isPlaying(false);
        //volume.resendVolume();

        string name = "vol" + drumId.ToString() + "stop";
        Debug.Log(name);
        pdPatch.SendFloat(name, 0);
    }
}
