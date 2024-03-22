namespace Database.Models;

/// <summary>
/// UserEntity는 해당 계정에 대한 정보를 저장한다.
/// 단순히 사용자에 Account 정보만을 가진다.
/// </summary>
public class UserModel {
    public string Email;
    public string Password;
    public string Nickname;
    public string Username;
}