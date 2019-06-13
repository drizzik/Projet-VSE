using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeadNoteController : MonoBehaviour {

	public LibPdInstance pdPatch;
	public int idNote;

	private Renderer rend;

	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void NoteIsPlaying()
	{
		rend.material.SetColor("_Color", Color.red);
		StartCoroutine(PlayNote());
	}
	IEnumerator PlayNote()
	{
		
		pdPatch.SendBang("lead"+idNote);
		yield return new WaitForSeconds(2f);
		rend.material.SetColor("_Color", Color.white);
	}
}
