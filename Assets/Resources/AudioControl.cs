using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test4 : MonoBehaviour
{
    [SerializeField] private AudioSource BGM;//AudioSource�^�̕ϐ�a��錾 �g�p����AudioSource�R���|�[�l���g���A�^�b�`�K�v

    [SerializeField] private AudioClip KokoniumiMainBGM;//AudioClip�^�̕ϐ�b1��錾 �g�p����AudioClip���A�^�b�`�K�v
    [SerializeField] private AudioClip WaveSound;//AudioClip�^�̕ϐ�b2��錾 �g�p����AudioClip���A�^�b�`�K�v 

    //����̊֐�1
    public void SE1()
    {
        BGM.PlayOneShot(KokoniumiMainBGM);
    }

    //����̊֐�2
    public void SE2()
    {
        BGM.PlayOneShot(WaveSound);
    }

    
}
