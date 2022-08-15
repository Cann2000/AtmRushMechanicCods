using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyMove : MonoBehaviour
{

    // !!! PARALARIN GECIKMELI HAREKETI VE SPAWNI IÇIN !!!

    public GameObject spawnpos;
    public CharOpt chropt;

    public Transform node;
    public float nodespeed = 5;

    void Update()
    {
        chropt = GameObject.FindGameObjectWithTag("character").GetComponent<CharOpt>();
        spawnpos = GameObject.FindGameObjectWithTag("spawnpos");

        transform.position = new Vector3(Mathf.Lerp(transform.position.x, node.position.x, Time.deltaTime * nodespeed), 5, transform.position.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("money"))
        {
            chropt.moneys.Add(other.gameObject);
            other.gameObject.transform.SetParent(spawnpos.transform);
            other.gameObject.AddComponent<MoneyMove>();
            other.gameObject.GetComponent<MoneyMove>().node = transform;
            chropt.diz();
        }
    }
}
