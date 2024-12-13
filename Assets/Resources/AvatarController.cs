using Photon.Pun;
using UnityEngine;

public class AvatarController : MonoBehaviourPun, IPunObservable
{
    private Vector3 networkPosition;

    private void Update()
    {
        // ���g�����������I�u�W�F�N�g�̂ݓ�������
        if (photonView.IsMine)
        {
            // ���͂ɂ��ړ�
            var input = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);
            transform.Translate(6f * Time.deltaTime * input.normalized);
        }
        else
        {
            // ���v���C���[�̃I�u�W�F�N�g�͕�Ԃ��Ĉړ�������i�X���[�Y�ɓ����j
            transform.position = Vector3.Lerp(transform.position, networkPosition, Time.deltaTime * 10f);
        }
    }

    // �f�[�^�𑗎�M���邽�߂̃��\�b�h�iPhoton���R�[������j
    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.IsWriting)
        {
            // ���g�̈ʒu�𑗐M
            stream.SendNext(transform.position);
        }
        else
        {
            // ���v���C���[�̈ʒu����M
            networkPosition = (Vector3)stream.ReceiveNext();
        }
    }
}
