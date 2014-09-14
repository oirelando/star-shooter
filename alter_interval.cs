using UnityEngine;
using System.Collections;

public class alter_interval : MonoBehaviour {
	[HideInInspector]
	public float interval;
	// Use this for initialization
	void Start () {
		interval = GetComponent<AutoSpawner> ().timing.interval;
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<AutoSpawner> ().timing.interval = interval;
	}
}
