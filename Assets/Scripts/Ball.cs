using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody rb;

    public float jumpForce;

    public GameObject splashPrefab;

    private GameManeger gm;
    void Start()
    {
        gm = GameObject.FindObjectOfType<GameManeger>();
    }

 
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        rb.AddForce(Vector3.up * jumpForce);

        GameObject splash = Instantiate(splashPrefab,transform.position+new Vector3(0f,-0.2f,0),transform.rotation);

        splash.transform.SetParent(collision.gameObject.transform);
        string metarialName = collision.gameObject.GetComponent<MeshRenderer>().material.name;
        Debug.Log(metarialName);
        if (metarialName=="SafeColor (Instance)")
        {

        }
        else if (metarialName== "UnsafeColor (Instance)")
        {
            gm.RestartGame();
        }
        else if (metarialName== "LastRing (Instance)")
        {
            Debug.Log("Next Level");
        }
    }
}
