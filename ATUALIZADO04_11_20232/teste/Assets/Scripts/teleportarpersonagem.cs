using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class teleportarpersonagem : MonoBehaviour {

	#region Singleton

	private static teleportarpersonagem instance;

	public static teleportarpersonagem Instance
	{
		get
		{
			if (instance == null)
			{
				instance = new teleportarpersonagem();
			}
			return instance;
		}
	}
	#endregion


	public Image imgFade;
	[Range(0, 1)] public float timeTeleport = 0.5f;
	public Transform player;
	private float playerGroundPos;

	private void Awake()
    {
		if(instance == null)
        {
			instance = this;
        }
        else
        {
			Destroy(gameObject);
        }
    }
	
	// Use this for initialization
	void Start()
	{

		playerGroundPos = player.position.y;
		Fade(true);
	}

	// Update is called once per frame
	public void Fade(bool isFadeIn)
	{
		if (isFadeIn)
		{
			imgFade.CrossFadeAlpha(0, timeTeleport, true);

		}
		else
		{
			imgFade.CrossFadeAlpha(1, timeTeleport, true);
		}
	}

	public void teleport(Vector3 _newPos)
	{
		StartCoroutine("movePosition", _newPos);
	}

	IEnumerator movePosition(Vector3 newPos)
	{
		Fade(false);
		yield return new WaitForSeconds(timeTeleport);
		player.position = new Vector3(newPos.x, newPos.y, newPos.z);
		yield return new WaitForSeconds(timeTeleport);
		Fade(true);

	}
}
