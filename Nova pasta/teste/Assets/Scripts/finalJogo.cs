using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalJogo : MonoBehaviour {


	private UsarEPIS _usarEPIS;
	private bool fim;

	// Use this for initialization
	void Start () {

		_usarEPIS = FindObjectOfType(typeof(UsarEPIS)) as UsarEPIS;

	}

	void Update()
	{
		if(fim == true)
        {
			_usarEPIS.sons.PlayOneShot(_usarEPIS.clip[7]);
        }
	}


	private void OnTriggerEnter(Collider other)
	{

		if (other.gameObject.tag == "Player")
		{
			fim = true;
		}
	}


}
