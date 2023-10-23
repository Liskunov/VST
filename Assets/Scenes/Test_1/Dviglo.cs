using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class Dviglo : MonoBehaviour
    {
        public float radius = 5f; // ������ ��������
        public float speed = 1f; // �������� ��������

        private float _angle; // ������� ����

        private void Update()
        {
            _angle += speed * Time.deltaTime; // ����������� ���� �� ������� � ��������

            // ��������� ����� ���������� ������� �� ���������� � ������� ������������������ �������
            float x = Mathf.Cos(_angle) * radius;
            float z = Mathf.Sin(_angle) * radius;

            transform.position = new Vector3(x, transform.position.y, z); // ��������� ������� �������
        }
    }
}
