using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFX : MonoBehaviour
{
    public static AudioClip skate, hurt;
    static AudioSource audioSrc;


    // Start is called before the first frame update
    void Start()
    {
        skate = Resources.Load<AudioClip>("rollerskatingsoundfx");
        hurt = Resources.Load<AudioClip>("hurtfx");

        audioSrc = GetComponent<AudioSource>();
    }

    public static void PlaySound(string clip)
    {
        switch(clip)
        {
            case "rollesSkatingsoundfx" : audioSrc.PlayOneShot(skate);
            break;
            case "hurtfx": audioSrc.PlayOneShot(hurt);
            break;


        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
