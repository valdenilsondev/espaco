using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;


public class TempoAcao : MonoBehaviour {


	public Image imgTime;
	public float timeTotal;
	public float timeCorrent;
	public bool isEnable;
	public UnityEvent[] timeEvents;
	public int idEvents;

	void Start () {
		TimeExit();
	}
	
	// Update is called once per frame
	void Update () {
		Timer();
	}
	private void Timer()
    {
        if (isEnable)
        {
			timeCorrent += Time.deltaTime;
			imgTime.fillAmount = timeCorrent / timeTotal;

			if(timeCorrent >= timeTotal)
            {
				isEnable = false;
				timeEvents[idEvents].Invoke();

            }
        }

    }

	public void TimeEnter(int _ID)
    {
		isEnable = true;
		idEvents = _ID;
    }

	public void TimeExit()
	{
		isEnable = false;
		imgTime.fillAmount = 0;
		timeCorrent = 0;
	}
}
