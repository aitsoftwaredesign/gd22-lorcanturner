using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class soundFX : MonoBehaviour
{
    public static AudioClip cannonShoot;
    public static AudioClip cannonImpact;
    public static AudioClip driving;
    static AudioSource audioSource;

    public void Start()
    {
        cannonShoot = Resources.Load < AudioClip > ("cannon");
        cannonImpact = Resources.Load<AudioClip>("impact");
        driving = Resources.Load<AudioClip>("tank moving");

        audioSource = GetComponent<AudioSource>();
        
    }

    void Update()
    {

    }

    public static void playSound(string clip)
    {
        switch(clip)
        {
            case "cannon":
                audioSource.PlayOneShot(cannonShoot);
                break;
            case "impact":
                audioSource.PlayOneShot(cannonImpact);
                break;
            case "driving":
                audioSource.PlayOneShot(driving);
                break;
        }
    }

    public static void stopSound(string clip)
    {
        switch(clip)
        {
            case "cannon":
                audioSource.Stop();
                break;
        }
    }
}
