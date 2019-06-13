using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class masterVolumeController : MonoBehaviour {

    [Tooltip("For Drums, Bass and Master")]
    public LibPdInstance pdPatch;

    [Tooltip("For Lead")]
    public AudioSource src;

    public enum masterType {Kick, Snare, Hat, Bass, Master, Lead};

    [Tooltip("Enter the type of the drum")]
    public masterType thisVolumeType;

    public Leap.Unity.Interaction.InteractionSlider slider;

    private int volumeId;

    //private bool sampleIsPlaying;

    // Use this for initialization
    void Start()
    {
        volumeId = ((int)thisVolumeType) + 1;
        //sampleIsPlaying = false;
        //src.volume = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateVolume()
    {
        //if (sampleIsPlaying)
        //{
            if (volumeId == 6)
            {
                src.volume = slider.HorizontalSliderValue;
            }
            else
            {
                string pdString = "vol" + volumeId.ToString();
                Debug.Log(pdString);
                pdPatch.SendFloat(pdString, slider.HorizontalSliderValue);
            }
       // }
        
    }

    //public void isPlaying(bool var)
    //{
    //    sampleIsPlaying = var;
    //}

    //public void resendVolume()
    //{
    //    if (sampleIsPlaying)
    //    {
    //        string pdString = "vol" + (volumeId+1).ToString();
    //        pdPatch.SendFloat(pdString, slider.HorizontalSliderValue);
    //    }
    //    else
    //    {
    //        string pdString = "vol" + (volumeId+1).ToString();
    //        pdPatch.SendFloat(pdString, 0.0f);
    //    }
    //}
}
