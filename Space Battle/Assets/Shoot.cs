using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    private bool cooldown;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (cooldown == false)
        {
            StartCoroutine("fire");
        }
    }

    void Bullet()
    {
        Instantiate(bullet, this.transform.position, Quaternion.identity);

    }

    IEnumerator fire()
    {
        cooldown = true;
        Bullet();
        yield return new WaitForSeconds(4);
       
        cooldown = false;
    }
}
