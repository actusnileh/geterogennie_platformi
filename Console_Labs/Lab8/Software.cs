
namespace SoftwareHierarchy
{
    public enum OSType
    {
        Free,
        Proprietary
    }

    public class Software
    {
        public string Name { get; set; }
        public string Version { get; set; }

        public virtual string Info()
        {
            return $"Название: {Name}, Версия: {Version}";
        }
    }

    public class OS : Software
    {
        public OSType Type { get; set; }

        public OS(string name, string version, OSType type)
        {
            Name = name;
            Version = version;
            Type = type;
        }

        public override string Info()
        {
            return $"{base.Info()}\nТип: {Type}";
        }
    }

    public class Application : Software
    {
        public Application(string name, string version)
        {
            Name = name;
            Version = version;
        }

        public override string Info()
        {
            return $"{base.Info()}";
        }
    }

}
