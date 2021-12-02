using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SZAttack : MonoBehaviour
{
    public Animator aniController;
    public AudioSource audioPersonaje;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (aniController.GetCurrentAnimatorClipInfo(0)[0].clip.name == "Ataque")
        {
            if (!audioPersonaje.isPlaying)
            {
                audioPersonaje.Play();
            }
        }
    }
}
