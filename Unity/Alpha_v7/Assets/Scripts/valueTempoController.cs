using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class valueTempoController : MonoBehaviour {

    public LibPdInstance pdPatch;
    private TextMesh thisText;
    public Leap.Unity.Interaction.InteractionSlider slider;

    // Use this for initialization
    void Start () {
        thisText = GetComponent<TextMesh>() as TextMesh;
        pdPatch.SendFloat("tempo", 90.0f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void updateTextTempo()
    {
        thisText.text = Mathf.RoundToInt(slider.HorizontalSliderValue).ToString();
        pdPatch.SendFloat("tempo", slider.HorizontalSliderValue);
    }
}
