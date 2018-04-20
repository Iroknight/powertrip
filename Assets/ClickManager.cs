using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour
{


    public Camera camera;
    public int startingMoney = 50; // set this per level
    public int currentMoney;
    public float levelGoal = 30; // set this per level
    public GameObject selectedObject; // set this when you click a component on the UI
    public bool delete = true;
    public int cost = 10;             // set this when you click a component on the UI

    public List<GameObject> componentList = new List<GameObject>();

    public List<List<GameObject>> grid = new List<List<GameObject>>();
    
    // Use this for initialization
    void Start()
    {
        currentMoney = startingMoney;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (checkIfWin(componentList))
        {
            Debug.Log("You won!");
        }
        RaycastHit hit;
        Ray ray;
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            ray = camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                Transform objectHit = hit.transform;

                if (objectHit.gameObject.layer == 8 && objectHit.GetComponent<MapTile>().type != "mountain")
                {// if objectHit == terrain
                    Debug.Log("Hit a map tile");
                    if (currentMoney >= cost)
                    {
                        GameObject go = Instantiate(selectedObject, new Vector3(objectHit.position.x,
                                                                           objectHit.position.y,
                                                                           objectHit.position.z - .5f), Quaternion.Euler(90, 180, 0));
                        go.GetComponent<ComponentTile>().value = cost;
                        go.GetComponent<ComponentTile>().onMapTile = objectHit.gameObject.GetComponent<MapTile>().type;
                        go.layer = 9;// instantiate selected component on layer 9
                        componentList.Add(go);
                        currentMoney = currentMoney - cost;
                        Debug.Log(currentMoney);



                        // add selected component to component grid at same position 
                    }
                }
                else if (objectHit.gameObject.layer == 9 && delete) 
                {
                    currentMoney += objectHit.GetComponent<ComponentTile>().value;
                    componentList.Remove(objectHit.gameObject);
                    Destroy(objectHit.gameObject);

                }
            }
        }
    }


    bool checkIfWin(List<GameObject> componentList)
    {
        float totalPower = 0;
        for (int i = 0; i < componentList.Count; i++) {
            float power = componentList[i].GetComponent<SolarPanel>().powerValue;
            totalPower += power;
        }
        if (totalPower >= levelGoal)
        {
            return true;
        } 

        return false;
    }
}
