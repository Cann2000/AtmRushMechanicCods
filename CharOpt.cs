using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharOpt : MonoBehaviour
{
    public List<GameObject> moneys;
    public GameObject spawnpos;

    public float speed;


    // !!! PARALARIN SPAWNI IÇIN !!!

    private void Awake()
    {
        spawnpos = GameObject.FindGameObjectWithTag("spawnpos");
    }

    void Update()
    {
        float move = Input.GetAxis("Horizontal") * Time.deltaTime;

        transform.Translate(move * speed, 0, 0);
        
    }

    public void diz()
    {
        for (int i = 0; i < moneys.Count; i++)
        {
            moneyPos(moneys[i].transform, i * 8);
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("money"))
        {
            moneys.Add(other.gameObject);
            other.gameObject.transform.SetParent(spawnpos.transform);
            other.gameObject.AddComponent<MoneyMove>();
            other.gameObject.GetComponent<MoneyMove>().node = transform;
            diz();
        }
    }
}
