using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strobe1 : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		Renderer rend = GetComponent<Renderer>();
		StartCoroutine (TriggerTheLight (rend));

	}
	

	IEnumerator TriggerTheLight(Renderer rend)
	{
		rend.material.color = Color.red;
		yield return new WaitForSeconds(.1f);
		rend.material.color = Color.blue;
		yield return new WaitForSeconds(.1f);
		rend.material.color = Color.green;
		yield return new WaitForSeconds(.1f);
		rend.material.color = Color.yellow;
        yield return new WaitForSeconds(.1f);
        StartCoroutine(TriggerTheLight (rend));

	}
}
