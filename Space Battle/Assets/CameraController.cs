using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour
{

    public GameObject Cam1, Cam2, Cam3, Cam4, Cam5, boom, song;
    public Image Black;
    bool end = false;
    //public AudioSource song;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("transitions");
    }

    // Update is called once per frame
    void Update()
    {
        if(end == true)
        {
            var tempVariable = Black.color;
            tempVariable.a += Time.deltaTime / 2.5f;
            Black.color = tempVariable;
        }
    }

    IEnumerator transitions()
    {
        yield return new WaitForSeconds(17);

        Cam1.SetActive(false);
        Cam2.SetActive(true);

        yield return new WaitForSeconds(10);

        Cam2.SetActive(false);
        Cam3.SetActive(true);

        yield return new WaitForSeconds(6);

        Cam3.SetActive(false);
        Cam4.SetActive(true);

        yield return new WaitForSeconds(6);

        Cam4.SetActive(false);
        Cam1.SetActive(true);

        yield return new WaitForSeconds(6);

        Cam1.SetActive(false);
        Cam5.SetActive(true);

        yield return new WaitForSeconds(10);
        end = true;

        yield return new WaitForSeconds(5);
        song.SetActive(false);
        boom.SetActive(true);
        
        //Cam5.SetActive(false);
    }
}




