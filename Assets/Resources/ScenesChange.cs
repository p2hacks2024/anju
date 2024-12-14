using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Unity�G���W���̃V�[���Ǘ��v���O�����𗘗p����

public class Change : MonoBehaviour // Change �Ƃ������O�ɂ��܂�
{
    // �C���X�y�N�^�[����ݒ�\�ȃt�B�[���h
    [SerializeField] private string nextSceneName; // ���ɑJ�ڂ���V�[����

    // �{�^������Ăяo����郁�\�b�h
    public void ChangeButton() // ChangeButton �Ƃ������O�ɂ��܂�
    {
        // �C���X�y�N�^�[�Ŏw�肳�ꂽ�V�[�������g���ĉ�ʑJ��
        if (!string.IsNullOrEmpty(nextSceneName))
        {
            SceneManager.LoadScene(nextSceneName);
        }
        else
        {
            Debug.LogWarning("���ɑJ�ڂ���V�[�������w�肳��Ă��܂���B");
        }
    }
}
