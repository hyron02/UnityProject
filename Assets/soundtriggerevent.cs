using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundtriggerevent : MonoBehaviour
{
    public AudioClip triggerSound;
    AudioSource audioSource;
     public bool alreadyPlayed = false;
    [TextArea]
    public string description;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!alreadyPlayed)
        {
            audioSource.PlayOneShot(triggerSound, 0.7f);
            alreadyPlayed = true;


        }
    }
}