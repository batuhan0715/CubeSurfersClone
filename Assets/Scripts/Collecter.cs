using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collecter : MonoBehaviour
{
    GameObject mainCube;
    int height;



    void Start()
    {
        mainCube = GameObject.Find("MainCube");
    }

    
    void Update()
    {
        mainCube.transform.position = new Vector3(transform.position.x, height + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -height, 0);
    }

    public void DecreaseHeight()
    {
        height--;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collect" && other.gameObject.GetComponent<CollectCube>().GetIsCollected()==false)
        {

            height += 1;
            other.gameObject.GetComponent <CollectCube> ().Collected();
            other.gameObject.GetComponent<CollectCube>().SetIndex(height);
            other.gameObject.transform.parent = mainCube.transform;
        }
    }
}
