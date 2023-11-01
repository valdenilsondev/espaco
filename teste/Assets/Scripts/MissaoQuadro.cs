using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MissaoQuadro : MonoBehaviour {


	public GameObject Cadeado;

	public GameObject CadeadoSeguranca;

	public GameObject posicaoAlicate;

	public GameObject posicaoCadeadoSegurancao;

	public GameObject retornarPosicaoInicial;

	// Use this for initialization
	void Start () {
		retornarPosicaoInicial.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

		if(CadeadoSeguranca.transform.position == posicaoAlicate.transform.position && Cadeado.transform.position == posicaoCadeadoSegurancao.transform.position)
        {
			//retornarPosicaoInicial.SetActive(true);
        }
		
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Cadeado")
		{

			CadeadoSeguranca.transform.position = posicaoAlicate.transform.position;

		}

		if (other.gameObject.tag == "cadeadoSeguranca")
		{

			Cadeado.transform.position = posicaoCadeadoSegurancao.transform.position;

		}

		if (other.gameObject.tag == "retornarSuperior")
		{

			//SceneManager.LoadScene("projetoThuane");


		}


	}

}
