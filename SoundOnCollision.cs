using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]

public class SoundOnCollision : MonoBehaviour
{
    public AudioClip glass;
    private AudioSource audioSource;
    public FaustPlugin_glassHarmonica scriptFaust;

    

    //public WaterTimer waterTimer;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        scriptFaust = this.transform.GetComponent<FaustPlugin_glassHarmonica>();
       // waterTimer = FindObjectOfType<WaterTimer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseOver()
    {
       // if(waterTimer.isWet == true){
            scriptFaust.setParameter(7, 0.6f);
            scriptFaust.setParameter(9, 0.2f);

            audioSource.enabled = true;
            if (!audioSource.isPlaying)
            {
                audioSource.clip = glass;
                audioSource.Play();
            }
            
        //}
       
    }

    public void OnMouseExit()
    {
        scriptFaust.setParameter(7, 1.0f);
        scriptFaust.setParameter(9, 0.0f);
    }


}
