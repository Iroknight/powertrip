using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Level1 : MonoBehaviour {

    public GameObject[] gamegrid = new GameObject[26];
    
    int k = 0;
    public Material mat;
    public GameObject mapTile;
    
    //public Button lvl1;

    // Use this for initialization
    void Start () {
//        Button btn = lvl1.GetComponent<Button>(); //Get button ready for when it is pressed
//        btn.onClick.AddListener(LevelOne);
	}
	
	// Update is called once per frame
	void Update () {
		if (GridMap.L1 == 1) {
            for (int i = 0; i < 5; i++) {
                for (int j = 0; j < 5; j++) {
                    if ((j == 1 && i == 2) || (j == 2 && (i > 0 && i < 4)) || (j == 3 && i == 2)) {
                        GameObject go = GameObject.Instantiate(mapTile);
                        go.layer = 8;
                        go.transform.position = new Vector3(i, j, 0.0f);
                        go.name = "Tile (" + i + "," + j + ")";
                        go.GetComponent<MapTile>().type = "grass";
                        go.GetComponent<Renderer>().material.color = Color.green;
                        gamegrid[k] = go;
                        k++;
                    }
                    else if (j == 2 && i == 4)
                    {
                        GameObject go = GameObject.Instantiate(mapTile);
                        go.layer = 8;
                        go.transform.position = new Vector3(i, j, 0.0f);
                        go.name = "Tile (" + i + "," + j + ")";
                        go.GetComponent<MapTile>().type = "city";
                        go.GetComponent<Renderer>().material = mat;
                        gamegrid[k] = go;
                        k++;
                    }
                    else {
                        GameObject go = GameObject.Instantiate(mapTile);
                        go.layer = 8;
                        go.transform.position = new Vector3(i, j, 0.0f);
                        go.name = "Tile (" + i + "," + j + ")";
                        go.GetComponent<MapTile>().type = "mountain";
                        go.GetComponent<Renderer>().material.color = new Color(0.5f, 0.4f, 0.1f);
                        gamegrid[k] = go;
                        k++;
                    }
                }
            }
        }
	}
}
