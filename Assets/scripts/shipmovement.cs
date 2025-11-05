using UnityEngine;

public class shipmovement : MonoBehaviour
{
    Rigidbody2D m_Rigidbody;
    public float shippower = 0;
    public enum directionstomove { leftRight, upDown }
    public directionstomove shipdirection;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();

    }
    // Update is called once per frame

    private void Update()
    {



    }
    private void OnMouseDrag()
    {
        Vector2 directiontomove = Vector2.zero;
        if (shipdirection == directionstomove.upDown)
        {
            float ymovement = Input.mousePositionDelta.y;
            directiontomove = new Vector2(0, ymovement * shippower);
            m_Rigidbody.AddForce(directiontomove, ForceMode2D.Force);
           
        }

        if (shipdirection == directionstomove.leftRight)
        {
            directiontomove = Vector2.zero;
            float xmovement = Input.mousePositionDelta.x;
            directiontomove = new Vector2(xmovement * shippower, 0);
            m_Rigidbody.AddForce(directiontomove, ForceMode2D.Force);
        }
    }
}
