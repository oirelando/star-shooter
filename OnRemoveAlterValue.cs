using UnityEngine;
using System.Collections;

public class OnRemoveAlterValue : MonoBehaviour {
	public GameObject Bullet;
	public float buffedspeed;

	// Use this for initialization
	void OnRemove () {
		Bullet.GetComponent<SpeedBuff> ().DoBuff();
		Bullet.GetComponent<SetMotion> ().speed = buffedspeed;

		Invoke ("NormalSpeed", 3);

	//	ShootingStar.getcomponent<SetMotion> ().Speed = 10;
	}
	
	// Update is called once per frame
	void Update () {
	//	OnCollision set ShootingStar.GetComponent<SetMotion> ().Speed = (buffedspeed);
	}

	void NormalSpeed () {
		Bullet.GetComponent<SetMotion> ().speed = 10;
		}
}
