using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Valve.VR;
using Valve.VR.InteractionSystem;

[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(Interactable))]


public class SoundOnHover : MonoBehaviour
{
    public AudioClip glass;
    private AudioSource audioSource;
    public FaustPlugin_glassHarmonica scriptFaust;

    //Haptic feedback
    //public bool vibrotactileFeedback = false;
    public SteamVR_Action_Vibration hapticAction;
    

   

    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        scriptFaust = this.transform.GetComponent<FaustPlugin_glassHarmonica>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
       
    

    protected virtual void OnHandHoverBegin(Hand hand)
    {
        scriptFaust.setParameter(7, 0.2f);
        scriptFaust.setParameter(9, 0.1f);

        audioSource.enabled = true;
        if (!audioSource.isPlaying)
        {
            audioSource.clip = glass;
            audioSource.Play();
        }

        //if(vibrotactileFeedback==true)
        //{
        //    Pulse(100, 80, 5, SteamVR_Input_Sources.RightHand);
        //}
        

    }

    protected virtual void OnHandHoverEnd(Hand hand)
    {

        scriptFaust.setParameter(7, 1.0f);
        scriptFaust.setParameter(9, 0.0f);
       
    }

    // Method for creating the vibrotactile feedback
  //public void Pulse(float duration, float frequency, float amplitude, SteamVR_Input_Sources source)
  //  {
  //      hapticAction.Execute(0, duration, frequency, amplitude, source);
  //  }

    
  }
