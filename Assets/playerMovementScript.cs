using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovementScript : MonoBehaviour
{
    public Vector3 leftDirection;
    public Vector3 rightDirection;

    public GameObject bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Transform>().position += leftDirection;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Transform>().position += rightDirection;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, GetComponent<Transform>().position, Quaternion.identity);
        }
    }
}
