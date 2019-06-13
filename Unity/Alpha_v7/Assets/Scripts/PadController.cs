using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadController : MonoBehaviour {

    [Tooltip("Insert your clips")]
    public List<AudioClip> padClips;
    private AudioSource audioSrc;

	void Start () {
        audioSrc = GetComponent<AudioSource>();
	}

    // Joue le clip correspondant à l'identifiant
    public void playClip(int _id)
    {
        audioSrc.clip = padClips[_id]; // Récupère le clip en fonction de l'identifiant
        audioSrc.PlayOneShot(padClips[_id],0.7f); // Joue le clip
    }
}
