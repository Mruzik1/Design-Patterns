public interface IFileSystemComponent
{
    void DisplayInfo(); //implementovat v ulohe 2, podla potreby moze byt oznacena ako abstract
    void SetLevel(int level); //NEPOVINNE - na zjednodusenie prace, aby ste vedeli, na akej urovni sa nachadza
    string GetName();
    int GetSize();
}
