using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidFall : MonoBehaviour
{

    public float moveSpeed = 5;
    public float deadZone = -45;
    public GameObject Ass_Steroid;

    // Start is called before the first frame update
    void Start()
    {
        spawnAss_Steroids();      
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.right * moveSpeed) * Time.deltaTime;
        transform.position = transform.position + (Vector3.down * moveSpeed) * Time.deltaTime;
    }

    void spawnAss_Steroids()
    {
        Instantiate(Ass_S)
    }
}
