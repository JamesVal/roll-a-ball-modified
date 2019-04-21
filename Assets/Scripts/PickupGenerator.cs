using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupGenerator : MonoBehaviour
{
    public GameObject gObj;

    // Start is called before the first frame update
    void Start()
    {
        this.createNewGObj();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void createNewGObj()
    {
        Vector3 randomCoords = this.getRandomCoordinates();
        Instantiate(gObj, randomCoords, Quaternion.identity);
    }

    Vector3 getRandomCoordinates()
    {
        System.Random rd = new System.Random();

        int x = rd.Next(-40,40);
        int z = rd.Next(-40,40);
        
        Vector3 newCoord = new Vector3(x, 2.5f, z);

        return newCoord;
    }
}
