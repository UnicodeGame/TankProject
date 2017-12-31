using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour {

    public GameObject shellExplosionPrefab;
    public AudioClip shellTriggerAudio;

    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter(Collider other)
    {
        AudioSource.PlayClipAtPoint(shellTriggerAudio, transform.position);
        GameObject.Instantiate(shellExplosionPrefab, transform.position, transform.rotation);
        GameObject.Destroy(this.gameObject);

        if (other.tag == "Tank") {
            other.SendMessage("TakeDamage");
        }
    }
}
