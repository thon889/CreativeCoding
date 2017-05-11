using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sketch : MonoBehaviour {
    public GameObject myPreFab;  

	void Start () {

        int totalCubes = 6;
        int TotalDistance = 5;

        for (int i = 0; i < 6; i++)
        {
            float perc = i / (float)totalCubes;
            float x = perc * TotalDistance;
            float y = 5.0f;
            float z = 0.0f;
            var newCube = (GameObject)Instantiate(myPreFab, new Vector3(x, y, z), Quaternion.identity);
            newCube.GetComponent<CubeScript>().SetSize(1.0f - perc);
            newCube.GetComponent<CubeScript>().rotateSpeed = perc; //Random.value; 
        }	}
	
	void Update () {
		
	}
}
