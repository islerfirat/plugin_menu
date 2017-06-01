using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PluginContracts;

namespace WFA_Menu
{
    public partial class Form1 : Form
    {
        Dictionary<string, IPlugin> _Plugins;

        public Form1()
        {
            InitializeComponent();
            PluginLoader<IPlugin> loader = new PluginLoader<IPlugin>("Plugins");
            _Plugins = new Dictionary<string, IPlugin>();
            IEnumerable<IPlugin> plugins = loader.Plugins;
            foreach (var item in plugins)
            {
                _Plugins.Add("menu", item);
            }

            menuStrip1.ForeColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IPlugin plugin = _Plugins["menu"];
            plugin.Exit();
        }

        private void loadMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IPlugin plugin = _Plugins["menu"];
            ToolStripMenuItem menuler = new ToolStripMenuItem(plugin.MenuTitle);
            menuStrip1.Items.Add(menuler);
        }
    }
}
