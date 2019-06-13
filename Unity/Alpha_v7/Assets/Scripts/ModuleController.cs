using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModuleController : MonoBehaviour {

	[Header("Link your modules here and check IDs for each object (OnPress function)")]
	public List<GameObject> modules;

	void Start () {
		
	}
	
	void Update () {
		
	}
    /**
     * Lorsque l'utilisateur appuie sur un bouton de module, cette fonction est appelée.
     * Elle va alors afficher le module avec l'ID correspondant à l'argument.
     */ 
	public void toggleDisplayModule(int _id)
	{
		StartCoroutine(toggleDisplayCoroutine(_id));
		
	}

	IEnumerator toggleDisplayCoroutine(int _id)
	{
        for (int i = 0; i < modules.Count; i++)
        {
            if (i != _id)
            {
                modules[i].SetActive(false);
            }
            else
                modules[i].SetActive(true);
        }
		
		yield return new WaitForSeconds(1f);
	}
}
