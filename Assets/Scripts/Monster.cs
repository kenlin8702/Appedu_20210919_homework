using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [Header("怪物設定")][Range(0,10)]
    public float speed = 3.5f;
    [Range(0,500)]
    public int atk = 100;
    [Range(0,5000)]
    public int health = 350;
    [Range(0,50)]
    public int trackrange = 30;
    public Vector3 delta_tr;
    
    [Header("掉落相關")]
    public GameObject dropitem;
    [Range(0,1)]
    public float droprate = 1f;
    [Header("音效")]
    public AudioClip dropitemsound;
    public AudioClip hurtsound;
    public AudioClip atksound;
    private AudioSource aus;
    private Rigidbody2D rd;
    private Animator ani;

    // Start is called before the first frame update
    void Start()
    {
        aus = GetComponent<AudioSource>();
        rd = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
