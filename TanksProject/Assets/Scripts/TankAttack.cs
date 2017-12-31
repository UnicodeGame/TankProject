using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankAttack : MonoBehaviour {

    public GameObject shellPrefab;
    public KeyCode fireKey = KeyCode.Space;
    public float shellSpeed = 15;
    public AudioClip shotAudio;

    private Transform firePosition;
  
	// Use this for initialization
	void Start () {
        firePosition = transform.Find("FirePosition");
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(fireKey)){
            AudioSource.PlayClipAtPoint(shotAudio, transform.position);
            GameObject obj = GameObject.Instantiate(shellPrefab, firePosition.position, firePosition.rotation);
            obj.GetComponent<Rigidbody>().velocity = obj.transform.forward * shellSpeed;
        }
    }
    
}
