using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyMove : MonoBehaviour
{

    // !!! PARALARIN GECIKMELI HAREKETI VE SPAWNI IÇIN !!!

    Options chropt;

    public Transform node;

<<<<<<< HEAD
    public float nodespeed = 3f;
=======
    public float nodespeed = 3;
>>>>>>> 05f20d6a276856756f816b9e7b5478f894d9cdd7

    void Update()
    {
        
        chropt = GameObject.FindGameObjectWithTag("character").GetComponent<Options>();

        transform.position = new Vector3(Mathf.Lerp(transform.position.x, node.position.x, Time.deltaTime * nodespeed), 5, transform.position.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("money"))
        {
            chropt.MoneyCreate(transform);
            Destroy(other.gameObject);            
        }
        if (other.transform.CompareTag("Trap"))
        {
            chropt.destroyMoney();
        }
    }

}
