using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    [SerializeField] private GameObject platformPrefab;
    [SerializeField] private float initialTime;
    [SerializeField] private float minWidth;
    [SerializeField] private float maxWidth;
    [SerializeField] private float minlength;
    [SerializeField] private float maxlength;
    private float time;


    private void Start()
    {
        time = initialTime;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;

        if (time <= 0)
        {
            Instantiate(platformPrefab,
                        transform.position,
                        Quaternion.identity,
                        this.transform);

            this.transform.localScale = new Vector3(Random.Range(minlength, maxlength), 0.2f, Random.Range(minWidth, maxWidth));
            time = initialTime;
        }


    }
}
