using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Player : MonoBehaviour
{
    public float duration;

    public NoteBook notebook;
    private GameObject g_notebook;

    private Rigidbody playerRigidBody;
    private Animator anim;

    private bool move;
    private Vector3 nextPos;
    private Vector3 direction;

    private List<Vector2> path;

    private ArrayList book;

    // Use this for initialization
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        move = false;

        book = new ArrayList();

        book.Add("Test - 1");
        book.Add("Test - 2");
        book.Add("Test - 3");
        book.Add("Test - 4");
        book.Add("Test - 5");
        book.Add("Test - 6");
        book.Add("Test - 7");
        book.Add("Test - 8");
        book.Add("Test - 9");
        book.Add("Test - 10");
        book.Add("Test - 11");
        book.Add("Test - 12");
        book.Add("Test - 13");
        book.Add("Test - 14");
        book.Add("Test - 15");

        g_notebook = GameObject.FindGameObjectWithTag("NoteBook");
        g_notebook.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //check if the flag for movement is true and the current gameobject position is not same as the clicked / tapped position
        if (move && !Mathf.Approximately(gameObject.transform.position.magnitude, nextPos.magnitude)) //&& !(V3Equal(transform.position, endPoint))){
        {
            //move the gameobject to the desired position
            //             transform.Rotate(nextPos);
            //             Vector3 rotate = ;
            //             transform.Rotate(new Vector3(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0));

            Vector3 relativePos = nextPos - transform.position;
            relativePos.y = 0;
            Quaternion rotation = Quaternion.LookRotation(relativePos);

            transform.rotation = rotation;

            anim.SetBool("IsWalking", true);
            gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, nextPos, 1 / (duration * (Vector3.Distance(gameObject.transform.position, nextPos))));
        }
        //set the movement indicator flag to false if the endPoint and current gameobject position are equal
        else if (move && Mathf.Approximately(gameObject.transform.position.magnitude, nextPos.magnitude))
        {
            move = false;
            anim.SetBool("IsWalking", false);

        }
    }

    public string getLine(int l)
    {
        return (string) book[l];
    }

    public void showBook()
    {
        g_notebook.SetActive(true);
        notebook.showPage();
        enabled = false;
    }

    public void hideBook()
    {
        notebook.ResetPage();
        g_notebook.SetActive(false);
        enabled = true;
    }

    public int getNumberOfPage()
    {
        return (book.Count / 7) + 1; 
    }

    public int getNumberLine()
    {
        return book.Count;
    }

    public void GoToPosition(Vector3 pos)
    {
        nextPos = pos;
        nextPos.z = 0;

        direction = pos;

        if(enabled)
            move = true;
    }
}
