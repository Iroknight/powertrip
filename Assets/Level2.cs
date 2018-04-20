using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2 : MonoBehaviour {

    public GameObject[] gamegrid = new GameObject[37];
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
		if (GridMap.L2 == 1) {
            for (int i = 0; i < 6; i++) {
                for (int j = 0; j < 6; j++) {
                    if (i >= 2 && i <= 3 && j >= 4 && j <=5) {
                        GameObject go = GameObject.Instantiate(mapTile);
                        go.layer = 8;
                        go.transform.position = new Vector3(i, j, 0.0f);
                        go.name = "Tile (" + i + "," + j + ")";
                        go.GetComponent<MapTile>().type = "mountain";
                        go.GetComponent<Renderer>().material.color = new Color(0.5f, 0.4f, 0.1f);
                        gamegrid[k] = go;
                        k++;
                    }
                    else if (j == 3 && i == 2) {
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
                        go.GetComponent<MapTile>().type = "desert";
                        go.GetComponent<Renderer>().material.color = Color.yellow;
                        gamegrid[k] = go;
                        k++;
                    }
                }
            }
        }
	}
}