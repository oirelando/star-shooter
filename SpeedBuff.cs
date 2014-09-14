using UnityEngine;
using System.Collections;

public class SpeedBuff : MonoBehaviour {
	public float buffedspeed;
	public float BuffLength;
	// Use this for initialization
	void Start () {
	
	}
	void NormalSpeed () {
		GetComponent<SetMotion> ().speed = 10;
	}
	// Update is called once per frame
	void Update () {
	
	}
	public void DoBuff () {
		GetComponent<SetMotion> ().speed = buffedspeed;
		
		Invoke ("NormalSpeed",  BuffLength);
		}
}
