using System.Runtime.InteropServices;

public class ShowAttDialog
{
#if UNITY_IOS
    [DllImport("__Internal")]
    private static extern int requestIDFA();
    
    //public static�ɂ��Ă����d�O���t�@�C���ŁuShowAttDialog.RequestIDFA()�v�Ƃ���ΌĂяo���܂�
    
    public static void RequestIDFA()
    {
        requestIDFA();
    }

#endif
}