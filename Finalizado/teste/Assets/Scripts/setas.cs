using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setas : MonoBehaviour {


	public GameObject[] setasTotal;


void Start () {
		StartCoroutine(setasIntanciar());
	}
	
	// Update is called once per frame
	void Update () {
		

	}

	IEnumerator setasIntanciar()
    {
		yield return new WaitForSeconds(0.2f);
		setasTotal[0].SetActive(true);
		yield return new WaitForSeconds(0.2f);
		setasTotal[1].SetActive(true);
		yield return new WaitForSeconds(0.2f);
		setasTotal[2].SetActive(true);
		yield return new WaitForSeconds(0.2f);
		setasTotal[3].SetActive(true);
		yield return new WaitForSeconds(0.2f);
		setasTotal[4].SetActive(true);
		yield return new WaitForSeconds(0.2f);
		setasTotal[0].SetActive(false);
		yield return new WaitForSeconds(0.2f);
		setasTotal[1].SetActive(false);
		yield return new WaitForSeconds(0.2f);
		setasTotal[2].SetActive(false);
		yield return new WaitForSeconds(0.2f);
		setasTotal[3].SetActive(false);
		yield return new WaitForSeconds(0.2f);
		setasTotal[4].SetActive(false);

		StartCoroutine(setasIntanciar());

	} 
}
