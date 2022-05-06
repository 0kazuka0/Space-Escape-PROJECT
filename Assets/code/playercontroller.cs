using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playercontroller : MonoBehaviour
{
    public Transform player;
    public float speed = 5.0f;

    int bulletlayer;
    public Vector3 bulletposi = new Vector3(1.4f, -0.3f, 0);
    public GameObject bulletPrefab;

    

    public int hp = 1;
    public float freeperiod = 0;
    float freetime = 0;
    int correctlayer;

    public Text timertext;
    public int timeleft;
    IEnumerator Losttime()
    {
        while (timeleft > 0)
        {
            yield return new WaitForSeconds(1);
            timeleft--;
        }
    }
    private void Start()
    {
        bulletlayer = gameObject.layer;
        correctlayer = gameObject.layer;
        StartCoroutine("Losttime");
    }
    void OnTriggerEnter2D(Collider2D collision)
    {

        hp--;
        freetime = freeperiod;
        gameObject.layer = 11;

    }
    // Update is called once per frame
    void Update()
    {
        moveCharacter(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
        if (Input.GetKeyDown("space"))
        {
            shootBullet();
        }
        freetime -= Time.deltaTime;
        if (freetime <= 0)
        {
            gameObject.layer = correctlayer;
        }
        if (hp <= 0)
        {
            dead();
            SceneManager.LoadScene("menu");
        }
        timertext.text = "Time : " + timeleft;
        if (timeleft <= 0)
        {
            SceneManager.LoadScene("2");
        }
    }
    void dead()
    {
        Destroy(gameObject);
    }

    void moveCharacter(Vector2 direction)
    {
        player.Translate(direction * speed * Time.deltaTime);
    }
    public void shootBullet()
    {
        GameObject b = Instantiate(bulletPrefab,transform.position+bulletposi,transform.rotation) as GameObject;
      
    }
 
}
