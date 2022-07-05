using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    // we want to spawn pipes in the same x axis, but change the y
    private float maxTime = 1;
    private float timer = 0;
    // SFIELD is private but can still be modified in unity
    [SerializeField] 
    private float height;
    public GameObject pipe;

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime)
        {
            GameObject newpipe = Instantiate(pipe);
            //vector 3 since object is on xyz
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newpipe, 10);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
