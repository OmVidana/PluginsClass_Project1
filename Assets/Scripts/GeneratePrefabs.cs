using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class GenerateDemons : MonoBehaviour
{
    public float time;
    public Rigidbody prefab;
    private Rigidbody prefabs;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(createPrefabs());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator createPrefabs()
    {
        while (true)
        {
            prefabs = (Rigidbody)Instantiate(prefab, new Vector3(Random.Range(-1.5f, 1.5f), 1.5f, 15f), Quaternion.Euler(0f, 180f, 0f));
            prefabs.AddComponent<DemonPath>();
            yield return new WaitForSeconds(time);
        }
    }
}
