using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepDrumController : MonoBehaviour {
    [Tooltip("Drag the AudioSource of the drum")]
    public LibPdInstance pdPatch;

    [Tooltip("Enter the number of this step")]
    public int idStep; // From 0 to 8

    public enum drumTypes{Kick, Snare, Hat};
    [Tooltip("Enter the type of the drum")]
    public drumTypes thisDrumType;
	private int drumId;

	private bool isSelected;
	private Renderer rend;
	
	void Start () {
		isSelected = false;
		rend = GetComponent<Renderer>(); // Récupération du composant Render de la sphère
		drumId = ((int)thisDrumType)+1; // On incrémente de 1 l'id car commence à 0 dans enum
	}	
	void Update () {
		
	}

    /**
     * Méthode appelée lorsque l'utilisateur touche la sphère.
     * Va modifier renvoyer un feedback visuel et envoyer l'information
     * au patch PD
     */
	public void ChangeState()
    { 
		isSelected = !isSelected; // Définit si la sphère est dans l'état "sélectionné" ou non
		if (isSelected)
		{
			rend.material.SetColor("_Color", Color.green); // Si on sélectionne, la sphère devient verte
			pdPatch.SendBang("seq"+drumId+"_toggle_"+idStep); // Et on prévient le patch PD
		}
		if (!isSelected)
		{
			rend.material.SetColor("_Color", Color.white); // Si on déselectionne, la sphère redevient blanche
			pdPatch.SendBang("seq"+drumId+"_toggle_"+idStep); // Et on prévient le patch PD
		}
	}
	public bool GetState()
	{
		return isSelected;
	}
	public int GetIdStep()
	{
		return idStep;
	}
}
