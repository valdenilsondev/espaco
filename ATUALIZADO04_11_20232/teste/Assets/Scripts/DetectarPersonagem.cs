using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectarPersonagem : MonoBehaviour {

	public GameObject reflexoPersonagem;
	void Start () {
		reflexoPersonagem.SetActive(false);
	}
	private void OnTriggerEnter(Collider other)
	{
		
		if(other.gameObject.tag == "campoVisao")
        {
			reflexoPersonagem.SetActive(true);
        }
	}
	private void OnTriggerExit(Collider other)
	{

		if (other.gameObject.tag == "campoVisao")
		{
			reflexoPersonagem.SetActive(false);
		}
	}
}
