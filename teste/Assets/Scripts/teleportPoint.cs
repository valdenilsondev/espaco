using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportPoint : MonoBehaviour {


 
	
	public void Teleport()
    {

        teleportarpersonagem.Instance.teleport(transform.position);


    }
}
