using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corou : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("테스트 시작");
        var temp = TestEnumerator();
        Debug.Log($"현재 값 : {temp.Current}");
        temp.MoveNext();
        Debug.Log($"현재 값 : {temp.Current}");
        temp.MoveNext();
        Debug.Log($"현재 값 : {temp.Current}");
    }

    IEnumerator<int> TestEnumerator()
    {
        yield return 1;
        yield return 2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
