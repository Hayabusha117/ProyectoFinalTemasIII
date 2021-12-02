using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mandar : MonoBehaviour
{
    public Animator aniController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (aniController.GetCurrentAnimatorClipInfo(0)[0].clip.name == "Idle")
        {
            SceneManager.LoadScene("Fin");
        }
        
    }
}
