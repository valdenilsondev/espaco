using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public Image ImgFade;
	// Use this for initialization
	void Start () {
		Invoke("fade", 1);
	}
	
	// Update is called once per frame
	public void fade()
    {
		ImgFade.CrossFadeAlpha(0, 2, true);
    }
}
