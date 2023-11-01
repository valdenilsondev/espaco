using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsarEPIS : MonoBehaviour {

	
	public GameObject[] capacete;
	public GameObject[] cilindro;
	public GameObject[] cinto;
	public GameObject[] luvas;
	public GameObject[] mascara;

	public GameObject[] botas;
	public GameObject[] detectorGas;
	public GameObject[] radioComunidador;
	public GameObject[] talabarte;
	private TempoAcao _tempoAcao;

	public int quantEPIS;
	// Use this for initialization

	void Start () {
		 _tempoAcao = FindObjectOfType(typeof(TempoAcao)) as TempoAcao;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void capacetePersonagem()
    {
		Destroy(capacete[0].gameObject);

		_tempoAcao.imgTime.fillAmount = 0;
		_tempoAcao.timeCorrent = 0;
		_tempoAcao.isEnable = false;
		
		capacete[1].SetActive(true);

		quantEPIS++;

	}

	public void cilindroOxigenioPersonagem()
	{
		Destroy(cilindro[0].gameObject);
		_tempoAcao.imgTime.fillAmount = 0;
		_tempoAcao.timeCorrent = 0;
		_tempoAcao.isEnable = false;

		cilindro[1].SetActive(true);
		quantEPIS++;
	}

	public void cintoPersonagem()
	{
		Destroy(cinto[0].gameObject);
		_tempoAcao.imgTime.fillAmount = 0;
		_tempoAcao.timeCorrent = 0;
		_tempoAcao.isEnable = false;

		cinto[1].SetActive(true);
		quantEPIS++;
	}

	public void luvasPersonagem()
	{
		Destroy(luvas[0].gameObject);
		_tempoAcao.imgTime.fillAmount = 0;
		_tempoAcao.timeCorrent = 0;
		_tempoAcao.isEnable = false;

		luvas[1].SetActive(true);
		quantEPIS++;
	}

	public void mascaraPersonagem()
	{
		Destroy(mascara[0].gameObject);
		_tempoAcao.imgTime.fillAmount = 0;
		_tempoAcao.timeCorrent = 0;
		_tempoAcao.isEnable = false;

		mascara[1].SetActive(true);
		quantEPIS++;

	}

	public void botasPersonagem()
	{
		Destroy(botas[0].gameObject);
		_tempoAcao.imgTime.fillAmount = 0;
		_tempoAcao.timeCorrent = 0;
		_tempoAcao.isEnable = false;
		quantEPIS++;

	}


	public void detectorGasPersonagem()
	{
		detectorGas[0].SetActive(false);
		_tempoAcao.imgTime.fillAmount = 0;
		_tempoAcao.timeCorrent = 0;
		_tempoAcao.isEnable = false;
		quantEPIS++;
	}

	public void radioComunicadorPersonagem()
	{
		radioComunidador[0].SetActive(false);
		_tempoAcao.imgTime.fillAmount = 0;
		_tempoAcao.timeCorrent = 0;
		_tempoAcao.isEnable = false;
		quantEPIS++;
	}

	public void talabartePrersonagem()
	{
		talabarte[0].SetActive(false);
		_tempoAcao.imgTime.fillAmount = 0;
		_tempoAcao.timeCorrent = 0;
		_tempoAcao.isEnable = false;
		quantEPIS++;
	}




}
