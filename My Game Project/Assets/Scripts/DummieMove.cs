using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummieMove : MonoBehaviour
{
    [SerializeField]
    private float Speed = 1;
    void Awake()
    {
     
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var a = Input.GetAxis("Horizontal");
        var b = Input.GetAxis("Vertical");

        var direction = new Vector3(a, 0, b);

        transform.position = transform.position + Speed * direction * Time.deltaTime;
    }

    void FixedUpdate()
    {

    }

    void LateUpdate()
    {

    }

}
