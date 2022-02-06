using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDummies : MonoBehaviour
{
    [SerializeField]
    private GameObject objectToClone;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.K))
        {
            Instantiate(objectToClone);
        }

        if (Input.GetKey(KeyCode.B))
        {
            Destroy(objectToClone);
        }
    }
}
