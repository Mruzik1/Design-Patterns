using System.Linq;


public class FileSystemComponent : IFileSystemComponent
{
    private int size;
    private string name;
    private int currentLevel;
    private OutputWriter writer;
    private IEnumerable<IFileSystemComponent> children;

    public FileSystemComponent(string name)
    {
        this.name = name;
        children = new List<IFileSystemComponent>();
        currentLevel = 0;
        writer = OutputWriter.GetInstance();
    }

    public void Add(IFileSystemComponent component)
    {
        component.SetLevel(currentLevel+1);
        children = children.Append(component);
    }

    public void Remove(IFileSystemComponent component)
    {
        children = children.Where(e => e != component);
    }

    public IEnumerable<IFileSystemComponent> GetChildNodes() => children;

    public void DisplayInfo()
    {
        string info = "";

        for (int i = 0; i < currentLevel; ++i)
            info += "   ";
        info += $"{GetName()} ({GetSize()}k)";

        writer.WriteLine(info);

        foreach (IFileSystemComponent child in GetChildNodes())
            child.DisplayInfo();
    }

    public void SetLevel(int level)
    {
        currentLevel = level;
    }

    public string GetName() => name;

    public int GetSize() => size;
}