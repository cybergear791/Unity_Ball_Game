using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strobe2 : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		Renderer rend = GetComponent<Renderer>();
		StartCoroutine (TriggerTheLight (rend));

	}
	

	IEnumerator TriggerTheLight(Renderer rend)
	{
		rend.material.color = Color.cyan;
		yield return new WaitForSeconds(.1f);
		rend.material.color = Color.magenta;
		yield return new WaitForSeconds(.1f);
        /*
		rend.material.color = Color.yellow;
		yield return new WaitForSeconds(.1f);
		rend.material.color = Color.red;
        yield return new WaitForSeconds(.1f);
        */
        StartCoroutine(TriggerTheLight (rend));

	}
}
