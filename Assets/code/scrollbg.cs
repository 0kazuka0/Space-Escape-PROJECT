using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollbg : MonoBehaviour
{
    public float bgspeed;
    public Renderer bgrend;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bgrend.material.mainTextureOffset += new Vector2(bgspeed * Time.deltaTime, 0f);
    }
}
