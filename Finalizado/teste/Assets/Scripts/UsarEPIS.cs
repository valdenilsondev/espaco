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
	public GameObject SetaIndicativaMissao;
	public GameObject acessoEspacoConfinadoFechado;
	public GameObject acessoEspacoConfinadoAberto;
	public GameObject painelVideo;
	public bool ativarVideo;
	public GameObject verificarDirecao;
	public GameObject continuar;

	public GameObject travaSeguranca;
	public GameObject travaSegurancaSensor;
	public GameObject cadeado;
	public GameObject cadeadoSensor;
	public GameObject placaSinalizadora;
	public GameObject placaSinalizadoraSensor;
	public GameObject sinalizacaoSair;
	public int quantMissaoCompleta;
	public GameObject pontoSaida;
	// Use this for initialization

	public AudioSource sons;

	public AudioClip[] clip;

	public float tamanhoClip;
	public bool acionarClip;
	public float tamanhoClip1;
	public bool acionarClip1;
	public bool acionarClip2;
	public bool acionarClip3;
	public bool acionarClip4;
	public bool inicarTempoMissao;
	public float tamanhoClipMissao;
	public GameObject instrucaoMissao;
	public bool acionarClip5;
	public float tamanhoClipFimMissao;
	public bool iniciouClipFim;
	public GameObject novoAudio;
	public float tempoIniciarBotao;
	public GameObject novoAudioMissao;
	public GameObject missaoEspacoConfinado;
	public GameObject instrucaoSairEspacoConfinado;
	public float teste01;
	public bool inicioMis;
	public GameObject teleporPoint;
	public GameObject setaPoint;
	public GameObject respiracaoEspacoConfinado;
	public GameObject somEspacoConfinado;

	[Header("Config Menu")]
	public GameObject Menu;
	public GameObject menuAcesso;
	public GameObject creditos;
	public GameObject instrucoes;
	
	public GameObject setasDirecioanais;
	public bool isInicirJogo;
	public float distancia;
	public GameObject playerPosicao;
	public GameObject posicaoIniciarInteracao;
	public GameObject clipIniciarJogo;
	

	void Awake()
    {
		StartCoroutine(iniciarClip());
		tamanhoClip1 = clip[2].length;
	}

	void Start () {

		_tempoAcao = FindObjectOfType(typeof(TempoAcao)) as TempoAcao;
		acessoEspacoConfinadoAberto.SetActive(false);
		painelVideo.SetActive(false);
		verificarDirecao.SetActive(false);
		continuar.SetActive(false);
		detectorGas[1].SetActive(false);
		radioComunidador[1].SetActive(false);
		travaSeguranca.SetActive(false);
		cadeado.SetActive(false);
		placaSinalizadora.SetActive(false);
		pontoSaida.SetActive(false);

		cadeadoSensor.gameObject.GetComponent<BoxCollider>().enabled = false;
		placaSinalizadoraSensor.gameObject.GetComponent<BoxCollider>().enabled = false;
		travaSegurancaSensor.gameObject.GetComponent<BoxCollider>().enabled = false;
		sinalizacaoSair.SetActive(false);

		novoAudio.SetActive(false);
		novoAudioMissao.SetActive(false);
		missaoEspacoConfinado.SetActive(false);
		instrucaoSairEspacoConfinado.SetActive(false);
		respiracaoEspacoConfinado.SetActive(false);
		somEspacoConfinado.SetActive(false);
		
		//Paineis Menu iniciam desligados
		Menu.SetActive(false);
		creditos.SetActive(false);
		instrucoes.SetActive(false);
		isInicirJogo = false;
		setasDirecioanais.SetActive(false);
		clipIniciarJogo.SetActive(false);

		
	}
	void Update () {



		if (isInicirJogo)
		{

			//sons.PlayOneShot(clip[0], 0.8f);
			clipIniciarJogo.SetActive(true);

			distancia = Vector3.Distance(playerPosicao.transform.position, posicaoIniciarInteracao.transform.position);

			if (distancia < 1.8f)
			{
				posicaoIniciarInteracao.SetActive(false);
			}

			if (quantEPIS >= 9)
			{
				novoAudio.SetActive(true);
				ativarVideo = true;
				acionarClip2 = true;
				tempoIniciarBotao += Time.deltaTime;
				tamanhoClip1 += Time.deltaTime;
				
			}
			if (tempoIniciarBotao >= 8.088f)
			{
				verificarDirecao.SetActive(true);
			}
			if (tamanhoClipFimMissao >= 15.384f)
			{
				sinalizacaoSair.SetActive(true);
				pontoSaida.SetActive(true);
			}

			tamanhoClip += Time.deltaTime;

			if (tamanhoClip >= 8.976f && acionarClip == false)
			{
				sons.PlayOneShot(clip[1], 0.8f);
				acionarClip = true;
				acionarClip1 = true;
				tamanhoClip = 0;

			}
			else if (tamanhoClip >= 8.088f && acionarClip1 == true)
			{
				sons.PlayOneShot(clip[2], 0.8f);
				tamanhoClip = 0;
				acionarClip1 = false;

			}
			else if(tamanhoClip >= 13.008f)
            {
				setasDirecioanais.SetActive(true);

			}
			else if (inicarTempoMissao == true)
			{
				tamanhoClip = 0;
				inicarTempoMissao = false;
				inicioMis = true;
			}
			else if (tamanhoClip >= 13.008f && inicioMis == true)
			{
				travaSegurancaSensor.gameObject.GetComponent<BoxCollider>().enabled = true;
			}
			if (acionarClip3 == true)
			{
				novoAudioMissao.SetActive(true);
			}
		}
	}

	//Funções define mecânicas do jogo
	#region
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
		detectorGas[1].SetActive(true);
		_tempoAcao.imgTime.fillAmount = 0;
		_tempoAcao.timeCorrent = 0;
		_tempoAcao.isEnable = false;
		quantEPIS++;
	}
	public void radioComunicadorPersonagem()
	{
		radioComunidador[0].SetActive(false);
		radioComunidador[1].SetActive(true);
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
	public void verificarInformacoes()
    {
		

		StartCoroutine(tempoVideo());

 		
		_tempoAcao.imgTime.fillAmount = 0;
		_tempoAcao.timeCorrent = 0;
		_tempoAcao.isEnable = false;



	}
	public void continuarMissao()
    {

		novoAudioMissao.SetActive(true);
		acessoEspacoConfinadoAberto.SetActive(true);
		acessoEspacoConfinadoFechado.SetActive(false);
		SetaIndicativaMissao.SetActive(true);
		continuar.SetActive(false);
		_tempoAcao.imgTime.fillAmount = 0;
		_tempoAcao.timeCorrent = 0;
		_tempoAcao.isEnable = false;

	}
	public void trava()
    {
		quantMissaoCompleta++;
		travaSeguranca.SetActive(true);
		travaSegurancaSensor.SetActive(false);
		cadeadoSensor.gameObject.GetComponent<BoxCollider>().enabled = true;
		_tempoAcao.imgTime.fillAmount = 0;
		_tempoAcao.timeCorrent = 0;
		_tempoAcao.isEnable = false;
		
	}
	public void cadeadoSeguranca()
    {
		quantMissaoCompleta++;
		cadeado.SetActive(true);
		cadeadoSensor.SetActive(false);
		placaSinalizadoraSensor.gameObject.GetComponent<BoxCollider>().enabled = true;
		_tempoAcao.imgTime.fillAmount = 0;

		_tempoAcao.timeCorrent = 0;
		_tempoAcao.isEnable = false;
		
	}
	public void placaSinalizadoraF()
    {
		quantMissaoCompleta++;
		StartCoroutine(habilitarSaida());
		placaSinalizadora.SetActive(true);
		placaSinalizadoraSensor.SetActive(false);
		_tempoAcao.imgTime.fillAmount = 0;
		_tempoAcao.timeCorrent = 0;
		_tempoAcao.isEnable = false;
		

	}
	public void sensorTravaSeguranca()
    {
		inicarTempoMissao = true;
		StartCoroutine(colisorTrava());
		missaoEspacoConfinado.SetActive(true);

		
		_tempoAcao.imgTime.fillAmount = 0;
		_tempoAcao.timeCorrent = 0;
		_tempoAcao.isEnable = false;
		//instrucaoMissao.SetActive(false);
		Destroy(instrucaoMissao.gameObject,2);

	}
	public void somEspacoConfig()
    {
		respiracaoEspacoConfinado.SetActive(true);
		somEspacoConfinado.SetActive(true);
    }
	public void somSairEspacoConfig()
	{
		respiracaoEspacoConfinado.SetActive(false);
		somEspacoConfinado.SetActive(false);
	}

	IEnumerator tempoVideo()
    {
		verificarDirecao.SetActive(false);
		Destroy(verificarDirecao.gameObject);

		if (ativarVideo == true)
        {

			painelVideo.SetActive(true);
			yield return new WaitForSeconds(156);
			painelVideo.SetActive(false);
			ativarVideo = false;
			
			continuar.SetActive(true);
		}
		
    }
	IEnumerator colisorTrava()
    {
		yield return new WaitForSeconds(7);
		travaSegurancaSensor.gameObject.GetComponent<BoxCollider>().enabled = true;
		setaPoint.SetActive(false);
		teleporPoint.SetActive(false);
	}
	IEnumerator habilitarSaida()
    {
		yield return new WaitForSeconds(2);
		if (quantMissaoCompleta == 3)
		{
			
			instrucaoSairEspacoConfinado.SetActive(true);
			pontoSaida.SetActive(true);

		}
		yield return new WaitForSeconds(6);
		sinalizacaoSair.SetActive(true);

	}
    #endregion 

	public void abrirMenu()
    {
		Menu.SetActive(true);
		
		menuAcesso.SetActive(false);
		_tempoAcao.imgTime.fillAmount = 0;
		_tempoAcao.timeCorrent = 0;
		_tempoAcao.isEnable = false;

	}

	public void fecharMenu()
	{
		Menu.SetActive(false);

		menuAcesso.SetActive(true);
		_tempoAcao.imgTime.fillAmount = 0;
		_tempoAcao.timeCorrent = 0;
		_tempoAcao.isEnable = false;

	}

	public void abrirInstrucoes()
    {
		instrucoes.SetActive(true);
		Menu.SetActive(false);
		_tempoAcao.imgTime.fillAmount = 0;
		_tempoAcao.timeCorrent = 0;
		_tempoAcao.isEnable = false;
	}

	public void abrirCreditos()
	{
		creditos.SetActive(true);
		Menu.SetActive(false);
		
		_tempoAcao.imgTime.fillAmount = 0;
		_tempoAcao.timeCorrent = 0;
		_tempoAcao.isEnable = false;
	}



	public void fecharCreditos()
	{
		creditos.SetActive(false);
		Menu.SetActive(true);
		_tempoAcao.imgTime.fillAmount = 0;
		_tempoAcao.timeCorrent = 0;
		_tempoAcao.isEnable = false;
	}

	public void fecharInstrucoes()
	{
		instrucoes.SetActive(false);
		Menu.SetActive(true);
		_tempoAcao.imgTime.fillAmount = 0;
		_tempoAcao.timeCorrent = 0;
		_tempoAcao.isEnable = false;
	}

	public void sairJogos()
    {
		Application.Quit();
    }

	public void IniciarJogo()
    {
		//setasDirecioanais.SetActive(true);
		isInicirJogo = true;
		menuAcesso.SetActive(true);
		Menu.SetActive(false);
		//setasDirecioanais.SetActive(true);
		_tempoAcao.imgTime.fillAmount = 0;
		_tempoAcao.timeCorrent = 0;
		_tempoAcao.isEnable = false;
	}
	IEnumerator iniciarClip()
    {

        //if (isInicirJogo) { sons.PlayOneShot(clip[0], 0.8f); }
		yield return new WaitForSeconds(1);
		

	}
}
