using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GridMap : MonoBehaviour {
    public Button start, exit, credits, mainMenu, lvl1, lvl2, lvl3, lvl4, lvl5, lvl6;
    public Material mat, lockmat;
    public Text title, creds;
    int k = 0; //used to keep track of grid
    public GameObject[] gamegrid = new GameObject[900];
    public static int L1 = 0;
    public static int L2 = 0;
    public static int L3 = 0;
    public static int L4 = 0;
    public static int L5 = 0;
    public static int L6 = 0;

    public static string type;


    // Use this for initialization
    void Start () {

        Button btn1 = start.GetComponent<Button>(); //Get button ready for when it is pressed
        btn1.onClick.AddListener(StartButton);
        Button btn2 = exit.GetComponent<Button>(); //Get button ready for when it is pressed
        btn2.onClick.AddListener(ExitButton);
        Button btn3 = credits.GetComponent<Button>(); //Get button ready for when it is pressed
        btn3.onClick.AddListener(CreditsButton);
        Button btn4 = mainMenu.GetComponent<Button>(); //Get button ready for when it is pressed
        btn4.onClick.AddListener(BackButton);
        Button l1 = lvl1.GetComponent<Button>(); //Get button ready for when it is pressed
        l1.onClick.AddListener(FirstLevel);
        Button l2 = lvl2.GetComponent<Button>(); //Get button ready for when it is pressed
        l2.onClick.AddListener(SecondLevel);
        Button l3 = lvl3.GetComponent<Button>(); //Get button ready for when it is pressed
        l3.onClick.AddListener(ThirdLevel);
        Button l4 = lvl4.GetComponent<Button>(); //Get button ready for when it is pressed
        l4.onClick.AddListener(FourthLevel);
        Button l5 = lvl5.GetComponent<Button>(); //Get button ready for when it is pressed
        l5.onClick.AddListener(FifthLevel);
        Button l6 = lvl6.GetComponent<Button>(); //Get button ready for when it is pressed
        l6.onClick.AddListener(SixthLevel);

        title.enabled = true;
        creds.enabled = false;

        mainMenu.gameObject.SetActive(false);
        lvl1.gameObject.SetActive(false);
        lvl2.gameObject.SetActive(false);
        lvl3.gameObject.SetActive(false);
        lvl4.gameObject.SetActive(false);
        lvl5.gameObject.SetActive(false);
        lvl6.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void StartButton() {
        mainMenu.gameObject.SetActive(true);
        start.gameObject.SetActive(false);
        exit.gameObject.SetActive(false);
        credits.gameObject.SetActive(false);

        lvl1.gameObject.SetActive(true);
        lvl2.gameObject.SetActive(true);
        lvl3.gameObject.SetActive(true);
        lvl4.gameObject.SetActive(true);
        lvl5.gameObject.SetActive(true);
        lvl6.gameObject.SetActive(true);
    }

    void ExitButton() {
        //Debug.Log("Pressed Exit");
        start.gameObject.SetActive(false);
        exit.gameObject.SetActive(false);
        credits.gameObject.SetActive(false);
    }

    void CreditsButton() {
        creds.enabled = true;
        mainMenu.enabled = true;
        mainMenu.gameObject.SetActive(true);
        start.gameObject.SetActive(false);
        exit.gameObject.SetActive(false);
        credits.gameObject.SetActive(false);
        //Debug.Log("Pressed Credits");
    }

    void BackButton() {
        if (k == 1) {
            k = 0;
            for (int i = 0; i < 30; i++) {
                for(int j = 0; j < 30; j++) {
                    Destroy(gamegrid[k]);
                    k++;
                }
            }
            k = 0;
        }
        mainMenu.gameObject.SetActive(false);
        start.gameObject.SetActive(true);
        exit.gameObject.SetActive(true);
        credits.gameObject.SetActive(true);
        creds.enabled = false;
        title.enabled = true;
        lvl1.gameObject.SetActive(false);
        lvl2.gameObject.SetActive(false);
        lvl3.gameObject.SetActive(false);
        lvl4.gameObject.SetActive(false);
        lvl5.gameObject.SetActive(false);
        lvl6.gameObject.SetActive(false);
    }

    void FirstLevel() {
        lvl1.gameObject.SetActive(false);
        lvl2.gameObject.SetActive(false);
        lvl3.gameObject.SetActive(false);
        lvl4.gameObject.SetActive(false);
        lvl5.gameObject.SetActive(false);
        lvl6.gameObject.SetActive(false);
        /*
        if (k == 0) {
            for (int i = 0; i < 10; i++) {
                for (int j = 0; j < 10; j++) {

                    if ((i > 5 && i < 8) && (j > 5 && j < 8)) {
                        GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        go.transform.position = new Vector3(i, j, 0.0f);
                        go.name = "Tile (" + i + "," + j + ")";
                        go.GetComponent<Renderer>().material = mat;
                        go.GetComponent<Renderer>().material.color = Color.cyan;
                        gamegrid[k] = go;
                        k++;
                    }
                    else if (i == 10 && (j > 3 && j < 12)) {
                        GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        go.transform.position = new Vector3(i, j, 0.0f);
                        go.name = "Tile (" + i + "," + j + ")";
                        go.GetComponent<Renderer>().material = mat;
                        go.GetComponent<Renderer>().material.color = Color.gray;
                        gamegrid[k] = go;
                        k++;
                    }
                    else if (i == 4 && j == 4)
                    {
                        GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        go.transform.position = new Vector3(i, j, 0.0f);
                        go.name = "Tile (" + i + "," + j + ")";
                        go.GetComponent<Renderer>().material = mat;
                        go.GetComponent<Renderer>().material.color = Color.yellow;
                        gamegrid[k] = go;
                        k++;
                    }
                    else {
                        GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        go.transform.position = new Vector3(i, j, 0.0f);
                        go.name = "Tile (" + i + "," + j + ")";
                        go.GetComponent<Renderer>().material = mat;
                        gamegrid[k] = go;
                        k++;
                    }
                }
            }
            k = 1;
        }*/
        mainMenu.gameObject.SetActive(true);
        title.enabled = false;
        SceneManager.LoadScene("Level1", LoadSceneMode.Single);
        L1 = 1;
        
    }

    void SecondLevel() {
        lvl1.gameObject.SetActive(false);
        lvl2.gameObject.SetActive(false);
        lvl3.gameObject.SetActive(false);
        lvl4.gameObject.SetActive(false);
        lvl5.gameObject.SetActive(false);
        lvl6.gameObject.SetActive(false);
        mainMenu.gameObject.SetActive(true);
        title.enabled = false;
        SceneManager.LoadScene("Level2", LoadSceneMode.Single);
        L2 = 1;
    }

    void ThirdLevel() {
        lvl1.gameObject.SetActive(false);
        lvl2.gameObject.SetActive(false);
        lvl3.gameObject.SetActive(false);
        lvl4.gameObject.SetActive(false);
        lvl5.gameObject.SetActive(false);
        lvl6.gameObject.SetActive(false);
        mainMenu.gameObject.SetActive(true);
        title.enabled = false;
        SceneManager.LoadScene("Level3", LoadSceneMode.Single);
        L3 = 1;
    }

    void FourthLevel() {
        lvl1.gameObject.SetActive(false);
        lvl2.gameObject.SetActive(false);
        lvl3.gameObject.SetActive(false);
        lvl4.gameObject.SetActive(false);
        lvl5.gameObject.SetActive(false);
        lvl6.gameObject.SetActive(false);
        mainMenu.gameObject.SetActive(true);
        title.enabled = false;
        SceneManager.LoadScene("Level4", LoadSceneMode.Single);
        L4 = 1;
    }

    void FifthLevel() {
        lvl1.gameObject.SetActive(false);
        lvl2.gameObject.SetActive(false);
        lvl3.gameObject.SetActive(false);
        lvl4.gameObject.SetActive(false);
        lvl5.gameObject.SetActive(false);
        lvl6.gameObject.SetActive(false);
        mainMenu.gameObject.SetActive(true);
        title.enabled = false;
        SceneManager.LoadScene("Level5", LoadSceneMode.Single);
        L5 = 1;
    }

    void SixthLevel() {
        lvl1.gameObject.SetActive(false);
        lvl2.gameObject.SetActive(false);
        lvl3.gameObject.SetActive(false);
        lvl4.gameObject.SetActive(false);
        lvl5.gameObject.SetActive(false);
        lvl6.gameObject.SetActive(false);
        mainMenu.gameObject.SetActive(true);
        title.enabled = false;
        SceneManager.LoadScene("Level6", LoadSceneMode.Single);
        L6 = 1;
    }
}