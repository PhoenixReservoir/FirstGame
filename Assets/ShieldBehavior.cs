using UnityEngine;
using System.Collections;

public class ShieldBehavior : MonoBehaviour {
	public float deathTimer;
	// Use this for initialization
	void Start () {
		Destroy (this.gameObject, deathTimer);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
