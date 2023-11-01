using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VRLookAT : MonoBehaviour {


	public Transform vrCamera;
	public float targetAngle =15.0f;
	public float speed =2.0f;
	public bool moveFoward;
	private RaycastHit hit;
	

	private CharacterController controller;

	public Camera cameraRayCast;
	public int distanceToMove = 10;

	public Image imgGaze;
	public float totalTime = 2;
	public float gvrTime;
	public bool gvrStatus;

	public Transform direcaoDireita;
	public Transform esquedaDireita;
	public Transform frente;
	public Transform fundo;


	private bool isDireita;
	private bool isEsquerda;
	bool isFrente;
	bool isTras;
	public bool limiteFrente;
	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController>();

	}
	
	// Update is called once per frame
	void Update () {

		if (gvrStatus)
		{
			gvrTime += Time.deltaTime;

			imgGaze.fillAmount = gvrTime / totalTime;


		}

		Ray ray = cameraRayCast.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));

		Debug.DrawRay(ray.origin, ray.direction * distanceToMove, Color.red, 1);

		if (Physics.Raycast(ray, out hit, distanceToMove))
		{

			
			if (hit.transform.tag == "direcional")
			{
				moveFoward = true;
				Debug.Log("Direção");
			}
			else
            {
				moveFoward = false;
            }

			if (hit.transform.tag == "direita")
			{
				isDireita = true;
				Debug.Log("Direita");
			}
			else
			{
				isDireita = false;
			}
			if (hit.transform.tag == "esquerda")
			{
				isEsquerda = true;
				Debug.Log("Direita");
			}
			else
			{
				isEsquerda = false;
			}
			if (hit.transform.tag == "tras")
			{
				isTras = true;
				Debug.Log("Direita");
			}
			else
			{
				isTras = false;
			}
			if (hit.transform.tag == "frente")
			{
				isFrente = true;
				Debug.Log("Direita");
			}
			else
			{
				isFrente = false;
			}
		}


		if (isDireita)
		{
			Vector3 forward = vrCamera.TransformDirection(direcaoDireita.forward);

			controller.Move(forward * speed * Time.deltaTime);
		}


		if (isEsquerda )
		{
			Vector3 forward = vrCamera.TransformDirection(esquedaDireita.forward);

		
			controller.Move(forward * speed * Time.deltaTime);
		}


		if (isTras)
		{
			Vector3 forward = vrCamera.TransformDirection(fundo.forward);


			controller.Move(forward * speed * Time.deltaTime);
		}
		if (isFrente && limiteFrente ==false)
		{
			
			Vector3 forward = vrCamera.TransformDirection(frente.forward);


			controller.Move(forward * speed * Time.deltaTime);

		}

		if (moveFoward) {

			//Vector3 forward = vrCamera.TransformDirection(Vector3.forward);
		

			Vector3 forward = vrCamera.TransformDirection(Vector3.forward);

			//controller.SimpleMove(forward *speed) ;
			controller.Move( forward * speed * Time.deltaTime);
        }

			


	}
}
