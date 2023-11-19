using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class REfOut : MonoBehaviour
{
    public SpriteRenderer SR;
    public Color tempColor;
    void Start()
    {

        ColorAndInt tempCI = new ColorAndInt();


        ChangeColor( tempCI.color);
        SR.color = tempCI.color;
    }

    void ChangeColor(Color color)
    {
        color = Color.red;
    }

    void ChangeColor(ref Color color)
    {
        color = Color.red;
    }

    public class ColorAndInt
    {
         public Color color;
        public int a;
        public ColorAndInt()
        {
            color = Color.green;
            a = 3;
        }
    }

    IEnumerator instance()
    {
        yield return null;
        yield return new WaitForSeconds(32f);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
