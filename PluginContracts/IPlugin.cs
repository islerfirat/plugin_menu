

namespace PluginContracts
{
    public interface IPlugin
    {
        string MenuName { get; }
        string MenuTitle { get; }
        void Exit();
    }
}
