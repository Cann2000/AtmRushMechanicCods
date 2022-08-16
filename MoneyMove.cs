using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyMove : MonoBehaviour
{

    // !!! PARALARIN GECIKMELI HAREKETI VE SPAWNI I�IN !!!

    Options chropt;

    public Transform node;

    public float nodespeed = 20;

    void Update()
    {
        
        chropt = GameObject.FindGameObjectWithTag("character").GetComponent<Options>();

        transform.position = new Vector3(Mathf.Lerp(transform.position.x, node.position.x, Time.deltaTime * nodespeed), 5, transform.position.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("money"))
        {
            Destroy(other.gameObject);
            chropt.karakterYarat(transform);
            
        }
        if (other.transform.CompareTag("Tuzak"))
        {
            chropt.destroyMoney();
            chropt.diz();
        }
    }

}