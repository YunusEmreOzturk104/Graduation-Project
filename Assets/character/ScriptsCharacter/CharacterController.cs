using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    Animator anim;
    [SerializeField]
    float characterSpeed;
    private float hp=100;
    private bool isLife;
    void Start()
    {
        anim = this.GetComponent<Animator>();
        isLife = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (hp<=0)
        {
            isLife = false;
            anim.SetBool("isLife", isLife);
        }
        if (isLife==true)
        {
            Movement();
        }
    }
    public bool getIsLife()
    {
        return isLife;
    }
    public void TakeDamage()
    {
        hp -= Random.Range(5, 10);
    }
    void Movement()
    {
        float horizontal = Input.GetAxis("Horizontal");//yatay
        float vertical = Input.GetAxis("Vertical");//dikey
        anim.SetFloat("Horizontal", horizontal);
        anim.SetFloat("Vertical", vertical);
        gameObject.transform.Translate(horizontal * characterSpeed * Time.deltaTime, 0, vertical * characterSpeed * Time.deltaTime);
    }
}
