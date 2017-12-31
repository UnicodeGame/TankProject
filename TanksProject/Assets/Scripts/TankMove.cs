using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMove : MonoBehaviour {

    public float speed = 5;
    public float angularSpeed = 2;
    public int number = 1;
    public AudioClip idleAudio;
    public AudioClip drivingAudio;

    private AudioSource audio;
    private Rigidbody rigidbody;

	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        float v = Input.GetAxis("VerticalPlayer" + number);
        float h = Input.GetAxis("HorizontalPlayer" + number);
        rigidbody.velocity = transform.forward * v * speed;
        rigidbody.angularVelocity = transform.up * h * angularSpeed;

        if (Mathf.Abs(h) > 0.1 || Mathf.Abs(v) > 0.1)
        {
            audio.clip = drivingAudio;
            if (!audio.isPlaying)
            {
                audio.Play();
            }
        }
        else {
            audio.clip = idleAudio;
            if (!audio.isPlaying)
            {
                audio.Play();
            }
        }
    }
}
