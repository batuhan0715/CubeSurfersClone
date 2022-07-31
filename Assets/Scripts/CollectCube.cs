using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCube : MonoBehaviour
{
    bool isCollected;
    int index;
    public Collecter collecter;


    void Start()
    {
        isCollected = false;
    }

    
    void Update()
    {
        if (transform.parent != null)
        {
            if (isCollected == true)
            {
                transform.localPosition = new Vector3(0, -index, 0);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Obstacle")
        {
            collecter.DecreaseHeight();
            transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }


    public bool GetIsCollected()
    {
        return isCollected;
    }

    public void Collected()
    {
        isCollected = true;
    }

    public void SetIndex(int index)
    {
        this.index = index;
    }
}
