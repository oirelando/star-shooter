﻿using UnityEngine;
using System.Collections;

public class GridSpawner : MonoBehaviour {

	public GameObject gridobject;

	// Use this for initialization
	void Start () {
		for (float i = 0; i < 8; i=i + 1)     {
			for ( float j = 0; j < 4; j +=1) {
		GameObject spawned = stTools.Spawn (gridobject);
		spawned.transform.position = new Vector2(transform.position.x + i,
			                                          transform.position.y + j);
		

			}
			}
			}
	
	// Update is called once per frame
	void Update () {
	
	}
}
