using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeadNoteController : MonoBehaviour {

    [Tooltip("Drag the audiosource of the lead")]
	public LibPdInstance pdPatch;
    [Tooltip ("Note number")]
	public int idNote;

	private Renderer rend;

    // Récupération du composant Renderer dans lequel 
    // se trouve le materiau de l'objet
	void Start () {
		rend = GetComponent<Renderer>();
	}

    // Méthode appelée lorsque la sphère est touchée
	public void NoteIsPlaying()
	{
        // Son joué = Sphère rouge
        rend.material.SetColor("_Color", Color.red);
        // Démarrage de la coroutine pour permettre un délai
        StartCoroutine(PlayNote()); 
	}
	IEnumerator PlayNote()
	{
        // Envoie du bang au patch PD pour le lancer
        pdPatch.SendBang("lead"+idNote);
        // Attente de 2 secondes
        yield return new WaitForSeconds(2f);
        // On remet la couleur de l'objet en blanc une fois le son terminé
        rend.material.SetColor("_Color", Color.white); 
	}
}
