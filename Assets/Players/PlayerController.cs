using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
	public float sensitivity;
	public GameObject shieldPrefab;
	public float backVec;
	public float upVec;
	public float leftVec;
	public float angleY;
	public float angleZ;
	public float angleX;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.W)) {
			GetComponent<Rigidbody> ().AddForce (Vector3.up * 5, ForceMode.VelocityChange);
		} else if (Input.GetKeyDown (KeyCode.S)) {
			GetComponent<Rigidbody> ().AddForce (Vector3.down * 5, ForceMode.VelocityChange);
		} else if (Input.GetKeyDown (KeyCode.D)) {
			GetComponent<Rigidbody> ().AddForce (Vector3.right * 5, ForceMode.VelocityChange);
		} else if (Input.GetKeyDown (KeyCode.A)) {
			GetComponent<Rigidbody> ().AddForce (Vector3.left * 5, ForceMode.VelocityChange);
		} else if (Input.GetKeyDown (KeyCode.K)) {
			GameObject.Instantiate (shieldPrefab, 
				transform.position + Vector3.back * 5f + Vector3.left * -1.5f + Vector3.up * -1f, 
				Quaternion.AngleAxis (90f, Vector3.forward));
		} else if (Input.GetKeyDown (KeyCode.J)) {
			GameObject.Instantiate (shieldPrefab, 
				transform.position + Vector3.back * 5f + Vector3.left * 1f + Vector3.up * -1.5f, 
				Quaternion.AngleAxis (0, Vector3.up));

		} else if (Input.GetKeyDown (KeyCode.L)) {
			GameObject.Instantiate (shieldPrefab, 
				transform.position + Vector3.back * 5f + Vector3.left * -1f + Vector3.up * -1.5f, 
				Quaternion.AngleAxis (0, Vector3.up));

		} else if (Input.GetKeyDown (KeyCode.I)) {
			GameObject.Instantiate (shieldPrefab,
				transform.position + Vector3.back * 4.5f + Vector3.left * -1.5f + Vector3.up * 1f, 
				Quaternion.AngleAxis (90, Vector3.forward));
		} else if (Input.GetKeyDown (KeyCode.Q)) {
			GetComponent<Rigidbody> ().AddTorque (Vector3.forward * sensitivity, ForceMode.VelocityChange);
		} else if (Input.GetKeyDown (KeyCode.E)) {
			GetComponent<Rigidbody> ().AddTorque (Vector3.back * sensitivity, ForceMode.VelocityChange);
		}

		var pos = GameObject.Find("Player").transform.rotation.eulerAngles.z;
		Debug.Log (pos);
	}


	void onCollisionEnter(Collision other) {
		//Debug.Log ("Read Collision");

		if (other.gameObject.tag.Equals ("Respawn")) {
			SceneManager.LoadScene(0);
		}
	}
}