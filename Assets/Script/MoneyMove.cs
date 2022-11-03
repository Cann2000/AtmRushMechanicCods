using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyMove : MonoBehaviour
{

    // !!! PARALARIN GECIKMELI HAREKETI VE SPAWNI IÇIN !!!

    MoneyOptions moneyopt;

    public Transform node;

    public float nodespeed = 3f;

    void Update()
    {

        moneyopt = GameObject.FindGameObjectWithTag("character").GetComponent<MoneyOptions>();

        transform.position = new Vector3(Mathf.Lerp(transform.position.x, node.position.x, Time.deltaTime * nodespeed), 5, transform.position.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("money"))
        {
            moneyopt.MoneyCreate(transform);
            Destroy(other.gameObject);            
        }
        if (other.transform.CompareTag("Trap"))
        {
            moneyopt.destroyMoney();
        }
    }

}
