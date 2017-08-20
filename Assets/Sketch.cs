using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sketch : MonoBehaviour {

	public GameObject myPrefab;

	void Start () {

		int totalCubes = 30;

		float totalDistance = 2.9f;

		for ( int i = 0; i < totalCubes; i++)
		{
			float perc = i / (float)totalCubes;
			float sin = Mathf.Sin(perc * Mathf.PI/2);

			float x = 1.8f + sin * totalDistance;
			float y = 5.0f;
			float z = 0.0f;

			var newCube = (GameObject)Instantiate(myPrefab, new Vector3(x, y, z), Quaternion.identity);

			newCube.GetComponent<myCubeScript>().SetSize(.45f * (1.0f - perc));
			newCube.GetComponent<myCubeScript>().rotateSpeed = .2f + perc * 4.0f;
		}

	}

	void Update () {
		
	}
}
