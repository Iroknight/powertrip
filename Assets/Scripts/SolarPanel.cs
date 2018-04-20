using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarPanel : MonoBehaviour {

    public float powerValue;
    public int baseValue = 10;
   

    


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (this.GetComponent<ComponentTile>().onMapTile == "desert")
        {
            powerValue = baseValue * 1.5f;

        }
        else
        {
            powerValue = baseValue;
        }
	}
}
