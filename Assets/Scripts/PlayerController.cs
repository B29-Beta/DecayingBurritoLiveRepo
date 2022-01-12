using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class PlayerController : MonoBehaviour

{

    public float speed;

    public float xRange;

    public float yRange;

    public GameObject Pickup;

    // Start is called before the first frame update 

    void Start()

    {



    }



    // Update is called once per frame 

    void Update()

    {

        float moveHorizontal = Input.GetAxisRaw("Horizontal");





        float moveVertical = Input.GetAxisRaw("Vertical");



        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        transform.Translate(movement * speed * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D other)

    {

        if (other.gameObject.CompareTag("Pickup"))

        {

            Destroy(other.gameObject);

        }

    }



}
