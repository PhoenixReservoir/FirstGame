using UnityEngine;
using System.Collections;

public class ProjectileBehavior : MonoBehaviour {
	public float speed;
	private Vector3 vec;

	// Use this for initialization
	void Start () {
		Destroy (gameObject, 1f);
		var pos = GameObject.Find ("Player").transform.rotation.eulerAngles.z;
		var y = Mathf.Sin(pos);
		var x = Mathf.Cos(pos);
		vec = new Vector3 (x, y, 0);

	}

	// Update is called once per frame
	void Update () {
		transform.Translate (vec * speed);
	}
		
}
