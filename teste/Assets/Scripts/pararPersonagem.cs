using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pararPersonagem : MonoBehaviour {

	private VRLookAT _lookAT;

	void Start () {

		_lookAT = FindObjectOfType(typeof(VRLookAT)) as VRLookAT;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other)
	{

		if (other.gameObject.tag == "limites")
		{
			_lookAT.limiteFrente = true;
		}
	}
}
