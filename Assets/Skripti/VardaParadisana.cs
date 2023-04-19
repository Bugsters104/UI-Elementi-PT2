using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VardaParadisana : MonoBehaviour {
	public int kadruSk = 0;

	void Start () {
		Debug.Log("Uzsākta programma! Tu esi "
			+kadruSk+" kadrā");
	}
	
	void Update () {
		Debug.Log("Kadrs: "+kadruSk);
		kadruSk++;
	}
}
