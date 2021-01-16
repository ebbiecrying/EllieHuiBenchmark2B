using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManagerScript : MonoBehaviour
{
    public float enemyTimer;

    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    public GameObject enemy5;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(enemy1);
        Instantiate(enemy2);
        Instantiate(enemy3);
        Instantiate(enemy4);
        Instantiate(enemy5);
    }

    // Update is called once per frame
    void Update()
    {
        enemyTimer += Time.deltaTime;

        if (enemyTimer >=3)
        {
            Instantiate(enemy1);
            Instantiate(enemy2);
            Instantiate(enemy3);
            Instantiate(enemy4);
            Instantiate(enemy5);

            enemyTimer = 0;
        }
    }
}
