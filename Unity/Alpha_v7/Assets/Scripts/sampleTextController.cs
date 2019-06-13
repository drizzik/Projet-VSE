using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sampleTextController : MonoBehaviour {

	private TextMesh thisText;
	public Color normallyColor = Color.white;
    public Color isPlayingColor = Color.green;

	void Start () {
		thisText = GetComponent<TextMesh>();
		thisText.color = normallyColor;
	}

	public void ChangeTextColor(bool isPlaying)
	{
		if (isPlaying)
		{
			thisText.color = isPlayingColor;
		}
		else
		{
			thisText.color = normallyColor;
		}

	}
}
