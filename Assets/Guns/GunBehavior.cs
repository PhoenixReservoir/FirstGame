using UnityEngine;
using System.Collections;

public class GunBehavior : MonoBehaviour {
	public GameObject projectilePrefab;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.U)) {
			//GameObject.Instantiate (projectilePrefab, 
			//	transform.position + Vector3.back * 3f, Quaternion.identity);
			GameObject.Instantiate (projectilePrefab, GameObject.Find("Player").transform.position, Quaternion.identity);
		}
	}
}
