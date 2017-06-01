using System.ComponentModel.Composition;
using System.Windows.Forms;
using PluginContracts;

namespace MenuPlugin
{
    [Export(typeof(IPlugin))]
    public class Menu : IPlugin
    {
        #region IPlugin Members

        public string MenuName
        {
            get
            {
                return "Plugin Menu";
            }
        }

        public string MenuTitle
        {
            get
            {
                return "Ana Sayfa";
            }
        }

        public void Exit()
        {
            Application.Exit();
        }

        #endregion
    }
}
