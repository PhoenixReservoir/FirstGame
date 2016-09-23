using UnityEngine;
using System.Collections;

public class ObstacleBehavior : MonoBehaviour {
	public float deathTimer;
	public float speed;
	// Use this for initialization
	void Start () {
		Destroy (gameObject, deathTimer);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.down * speed);
	}
}
