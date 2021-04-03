using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyController : MonoBehaviour
{
    public GameObject unityChan;

    // Start is called before the first frame update
    void Start()
    {
        //シーン中のunitychanオブジェクトを取得
        this.unityChan = GameObject.Find("unitychan");
    }

    // Update is called once per frame
    void Update()
    {
        float dis = unityChan.transform.position.z - gameObject.transform.position.z;
        Debug.Log("dis:" + dis);

        if(dis > 10)
        {
            Destroy(gameObject);
        }
    }
}
