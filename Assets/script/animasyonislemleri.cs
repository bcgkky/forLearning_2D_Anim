using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animasyonislemleri : MonoBehaviour
{
    Animator controlcubaba;

    void Start()
    {
        controlcubaba = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            //controlcubaba.SetTrigger("benim_t");
            controlcubaba.SetBool("benim_b", true);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            controlcubaba.SetBool("benim_b", false);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            controlcubaba.ResetTrigger("benim_t2");
            controlcubaba.SetTrigger("benim_t");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            controlcubaba.ResetTrigger("benim_t");
            controlcubaba.SetTrigger("benim_t2");
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            controlcubaba.SetInteger("benim_i", 2);
            controlcubaba.SetFloat("benim_f", 2);

        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            controlcubaba.SetTrigger("benim_t3");
            
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            controlcubaba.SetTrigger("benim_t4");
        }

    }

    /*private void OnAnimatorMove()
    {
        Vector3 poz = transform.position;
        poz.x += controlcubaba.GetFloat("benim_f") * Time.deltaTime;
        transform.position = poz;
    }*/

    public void Selamla(string deger)
    {
        print("Hello." + deger);
    }
}
