using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Options : MonoBehaviour
{
    public List<GameObject> moneys;
    public GameObject spawnpos;

    public GameObject Money;

    public float speed;


    //  // *!!!* INSIDE THE CHARACTER *!!!*


    private void Start()
    {
        spawnpos = GameObject.FindGameObjectWithTag("spawnpos");

    }

    void Update()
    {
        float move = Input.GetAxis("Horizontal") * Time.deltaTime;

        transform.Translate(move * speed, 0, 0);
        
    }

    public void MoneyCreate(Transform nodedegeri)
    {
        GameObject moneyClone = Instantiate(Money);
        moneyClone.transform.SetParent(spawnpos.transform);
        moneys.Add(moneyClone);
        moneyClone.AddComponent<MoneyMove>();
        moneyClone.GetComponent<MoneyMove>().node = nodedegeri;
        MoneyAlign();
    }

    public void MoneyAlign()
    {
        for (int i = 0; i < moneys.Count; i++)
        {
            moneyPos(moneys[i].transform, i * 15);
        }
    }

    void moneyPos(Transform objectTransform,float Pos)
    {
        Vector3 pos = Vector3.zero;

        pos.x = 0;
        pos.y = 1;
        pos.z = Pos;

        objectTransform.localPosition = pos;
    }

    public void destroyMoney()
    {
        for (int i = moneys.Count-1; i < moneys.Count; i++)
        {
            Destroy(moneys[i].gameObject);
            moneys.RemoveAt(i);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("money"))
        {
            moneys.Add(other.gameObject);
            other.gameObject.transform.SetParent(spawnpos.transform);
            other.transform.gameObject.AddComponent<MoneyMove>();
            other.gameObject.GetComponent<MoneyMove>().node = transform;
            MoneyAlign();
        }
    }
}
