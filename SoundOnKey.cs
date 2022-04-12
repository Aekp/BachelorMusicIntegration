using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnKey : MonoBehaviour
{
    public bool qKey, wKey,eKey = false;
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
    void Update()
    {
        OnKeyDown();
        OnKeyUp();
    }

    public void OnKeyDown()
    {
        if (qKey == true)
        {
            if (Input.GetKey(KeyCode.Q))
            {
                scriptFaust.setParameter(9, 0.2f);

                audioSource.enabled = true;
                if (!audioSource.isPlaying)
                {
                    audioSource.clip = glass;
                    audioSource.Play();
                }



            }
           
           


        }
        if (wKey == true)
        {
            if (Input.GetKey(KeyCode.W))
            {
                scriptFaust.setParameter(9, 0.2f);

                audioSource.enabled = true;
                if (!audioSource.isPlaying)
                {
                    audioSource.clip = glass;
                    audioSource.Play();
                }



            }

        }
        if (eKey == true)
        {
            if (Input.GetKey(KeyCode.E))
            {
                scriptFaust.setParameter(9, 0.2f);

                audioSource.enabled = true;
                if (!audioSource.isPlaying)
                {
                    audioSource.clip = glass;
                    audioSource.Play();
                }



            }

        }

    }
    public void OnKeyUp()
    {
        if (Input.GetKeyUp(KeyCode.Q))
        {
            scriptFaust.setParameter(9, 0.0f);
            
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            scriptFaust.setParameter(9, 0.0f);
           
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            scriptFaust.setParameter(9, 0.0f);
            
        }

    }
}
