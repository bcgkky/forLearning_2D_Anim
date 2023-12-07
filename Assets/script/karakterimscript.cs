using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakterimscript : MonoBehaviour
{
    Animator animatorum;

    void Start()
    {
        animatorum = GetComponent<Animator>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            animatorum.SetBool("yurusun_mu", true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            animatorum.SetBool("yurusun_mu", false); 
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            animatorum.SetBool("normalkossun_mu", true);
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            animatorum.SetBool("normalkossun_mu", false);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            animatorum.SetBool("hizlikossun_mu", true);
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            animatorum.SetBool("hizlikossun_mu", false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animatorum.SetTrigger("ziplasin_mi");
        }
            
    }
}
