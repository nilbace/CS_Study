using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intefffeacce : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // IInteractable 인터페이스 정의
    public interface IInteractable
    {
        string Name { get; }  // 상호작용 가능한 객체의 이름 속성
        event Action<int> OnInteract;  // 상호작용할 때 발생하는 이벤트

        void Interact();
    }

    // Player 클래스
    public class Player : MonoBehaviour
    {
        // 상호작용 가능한 객체를 저장할 변수
        private IInteractable currentInteractable;

        // 상호작용 가능한 객체와 상호작용하는 메서드
        public void InteractWithCurrent()
        {
            if (currentInteractable != null)
            {
                currentInteractable.Interact();
            }
        }
    }

    // 상호작용 가능한 객체인 Cube 클래스
    public class Cube :  IInteractable
    {
        public string Name { get; private set; } = "Cube";

        public event Action<int> OnInteract;

        public void Interact()
        {
            Debug.Log("Cube와 상호작용합니다.");
            OnInteract?.Invoke(42);  // 이벤트 호출
        }
    }



}
