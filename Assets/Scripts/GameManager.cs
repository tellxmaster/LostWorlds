using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject floor;
    public Renderer fondo;

    void Start()
    {
        for (int i = 0; i < 21; i++)
        {
            Instantiate(floor, new Vector2(-10 +i ,-3), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        fondo.material.mainTextureOffset = fondo.material.mainTextureOffset + new Vector2(0.02f, 0) * Time.deltaTime;
    }
}
