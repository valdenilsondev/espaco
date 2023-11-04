using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalJogo : MonoBehaviour {


	public GameObject fimJogo;

	// Use this for initialization
	void Start () {

		fimJogo.SetActive(false);

	}

	void Update()
	{
		
	}


	private void OnTriggerEnter(Collider other)
	{

		if (other.gameObject.tag == "Player")
		{
			StartCoroutine(MensagemFinal());
		}
	}
	IEnumerator MensagemFinal()
    {
		yield return new WaitForSeconds(3f);
		fimJogo.SetActive(true);
	}
}
