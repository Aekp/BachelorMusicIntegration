using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]

public class SoundOnMouseDown : MonoBehaviour
{
    public AudioClip glass;
    private AudioSource audioSource;
   

   

    public FaustPlugin_glassHarmonica scriptFaust;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        scriptFaust = this.transform.GetComponent<FaustPlugin_glassHarmonica>();

    }

    // Update is called once per frame
    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Set bowpressure to 0.5
            scriptFaust.setParameter(9, 0.2f);
           
            audioSource.enabled = true;
            if (!audioSource.isPlaying)
            {
                audioSource.clip = glass;
                audioSource.Play();
            }
            else
            {
                
            }
        }
        
    }

    private void OnMouseUp()
    {
        //audioSource.enabled = false;
        //audioSource.Stop();
        // Set bowpressure to 1
        scriptFaust.setParameter(9, 0.0f);

        
    }
}
