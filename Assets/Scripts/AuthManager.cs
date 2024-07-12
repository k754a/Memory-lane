using UnityEngine;
using Firebase;
using Firebase.Auth;
using TMPro;
public class AuthManager: MonoBehaviour
{
    [Header("Firebase stuff")]
    public DependencyStatus dependencyStatus;
    public FirebaseAuth auth;
    public FirebaseUser User;

    [Header("Login stuffs")]
    public TMP_InputField emailLoginBox;
    public TMP_InputField passwordLoginBox;

    public TMP_Text warningLoginText;
    public TMP_Text confirmLoginText;



    //DONT HAVE THIS YET!
    [Header("Register stuffs")]

    public TMP_InputField usernameRegisterField;
    public TMP_InputField emailRegisterField;
    public TMP_InputField passwordRegisterField;
    public TMP_InputField passwordRegisterVerifyField;
    public TMP_Text warningRegisterText;





}
