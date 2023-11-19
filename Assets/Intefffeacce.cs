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

    // IInteractable �������̽� ����
    public interface IInteractable
    {
        string Name { get; }  // ��ȣ�ۿ� ������ ��ü�� �̸� �Ӽ�
        event Action<int> OnInteract;  // ��ȣ�ۿ��� �� �߻��ϴ� �̺�Ʈ

        void Interact();
    }

    // Player Ŭ����
    public class Player : MonoBehaviour
    {
        // ��ȣ�ۿ� ������ ��ü�� ������ ����
        private IInteractable currentInteractable;

        // ��ȣ�ۿ� ������ ��ü�� ��ȣ�ۿ��ϴ� �޼���
        public void InteractWithCurrent()
        {
            if (currentInteractable != null)
            {
                currentInteractable.Interact();
            }
        }
    }

    // ��ȣ�ۿ� ������ ��ü�� Cube Ŭ����
    public class Cube :  IInteractable
    {
        public string Name { get; private set; } = "Cube";

        public event Action<int> OnInteract;

        public void Interact()
        {
            Debug.Log("Cube�� ��ȣ�ۿ��մϴ�.");
            OnInteract?.Invoke(42);  // �̺�Ʈ ȣ��
        }
    }



}
