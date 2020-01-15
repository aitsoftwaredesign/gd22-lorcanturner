using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{ 
    AudioSource audioSource;
    public AudioClip impact;
   

    Animator animator;
    public GameObject youDied, retry;


    // Start is called before the first frame update
    void Start()
    {


        audioSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        youDied.SetActive(false);
        retry.SetActive(false);
    }

  

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Obsticle"))
        {
            youDied.SetActive(true);
            retry.SetActive(true);
            animator.Play("playerDie");
            audioSource.Play();
            PlayerControler cc = GetComponent(typeof(PlayerControler)) as PlayerControler;
            cc.enabled = false;

           
            ScoreScript.playing = false;
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
