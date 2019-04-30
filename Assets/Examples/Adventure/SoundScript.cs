using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{

    public AudioClip collisionSound;

    public AudioSource mySource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collisionSound == null) {
            Debug.Log("No sound file found!");

        }
        else {
            mySource.PlayOneShot(collisionSound);
        }
    }

}
